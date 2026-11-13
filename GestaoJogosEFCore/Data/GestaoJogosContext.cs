using System;
using System.Collections.Generic;
using GestaoJogosEFCore.Models;
using Microsoft.EntityFrameworkCore;

namespace GestaoJogosEFCore.Data;

public partial class GestaoJogosContext : DbContext
{
    public GestaoJogosContext(DbContextOptions<GestaoJogosContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Desenvolvedora> Desenvolvedora { get; set; }

    public virtual DbSet<Jogador> Jogador { get; set; }

    public virtual DbSet<JogadorJogo> JogadorJogo { get; set; }

    public virtual DbSet<Jogo> Jogo { get; set; }

    public virtual DbSet<PerfilJogador> PerfilJogador { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Desenvolvedora>(entity =>
        {
            entity.HasKey(e => e.IdDesenvolvedora).HasName("PK__Desenvol__C26F4F6791226421");

            entity.Property(e => e.Nome)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Pais)
                .HasMaxLength(80)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Jogador>(entity =>
        {
            entity.HasKey(e => e.IdJogador).HasName("PK__Jogador__94A4447CA94D8FFB");

            entity.HasIndex(e => e.Email, "UQ__Jogador__A9D10534E23CD72A").IsUnique();

            entity.Property(e => e.Email)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Nome)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<JogadorJogo>(entity =>
        {
            entity.HasKey(e => e.IdJogadorJogo).HasName("PK__JogadorJ__E1F1771E40196D1E");

            entity.HasIndex(e => new { e.IdJogador, e.IdJogo }, "UQ_JogadorJogo").IsUnique();

            entity.Property(e => e.DataAquisicao).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.HorasJogadas).HasColumnType("decimal(8, 2)");
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("Na biblioteca");

            entity.HasOne(d => d.IdJogadorNavigation).WithMany(p => p.JogadorJogo)
                .HasForeignKey(d => d.IdJogador)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_JogadorJogo_Jogador");

            entity.HasOne(d => d.IdJogoNavigation).WithMany(p => p.JogadorJogo)
                .HasForeignKey(d => d.IdJogo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_JogadorJogo_Jogo");
        });

        modelBuilder.Entity<Jogo>(entity =>
        {
            entity.HasKey(e => e.IdJogo).HasName("PK__Jogo__69E08513BCAD3D6D");

            entity.Property(e => e.Genero)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Nome)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Preco).HasColumnType("decimal(10, 2)");

            entity.HasOne(d => d.IdDesenvolvedoraNavigation).WithMany(p => p.Jogo)
                .HasForeignKey(d => d.IdDesenvolvedora)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Jogo_Desenvolvedora");
        });

        modelBuilder.Entity<PerfilJogador>(entity =>
        {
            entity.HasKey(e => e.IdPerfil).HasName("PK__PerfilJo__C7BD5CC1795E3159");

            entity.HasIndex(e => e.IdJogador, "UQ__PerfilJo__94A4447D189A20D4").IsUnique();

            entity.HasIndex(e => e.Nickname, "UQ__PerfilJo__CC6CD17E038A2B1A").IsUnique();

            entity.Property(e => e.Biografia)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.Nickname)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Plataforma)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.IdJogadorNavigation).WithOne(p => p.PerfilJogador)
                .HasForeignKey<PerfilJogador>(d => d.IdJogador)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PerfilJogador_Jogador");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
