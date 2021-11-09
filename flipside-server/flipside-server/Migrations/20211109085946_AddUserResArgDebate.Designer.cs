﻿// <auto-generated />
using System;
using Flipside_Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Flipside_Server.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20211109085946_AddUserResArgDebate")]
    partial class AddUserResArgDebate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("Flipside_Server.GraphQL.Argument", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("AuthorId")
                        .HasColumnType("integer")
                        .HasColumnName("author_id");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("created_at");

                    b.Property<int>("DebateId")
                        .HasColumnType("integer")
                        .HasColumnName("debate_id");

                    b.Property<string>("TextContent")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("text_content");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("title");

                    b.HasKey("Id")
                        .HasName("pk_arguments");

                    b.HasIndex("AuthorId")
                        .HasDatabaseName("ix_arguments_author_id");

                    b.HasIndex("DebateId")
                        .HasDatabaseName("ix_arguments_debate_id");

                    b.ToTable("arguments");
                });

            modelBuilder.Entity("Flipside_Server.GraphQL.Debate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("created_at");

                    b.Property<int?>("CreatorId")
                        .HasColumnType("integer")
                        .HasColumnName("creator_id");

                    b.HasKey("Id")
                        .HasName("pk_debates");

                    b.HasIndex("CreatorId")
                        .HasDatabaseName("ix_debates_creator_id");

                    b.ToTable("debates");
                });

            modelBuilder.Entity("Flipside_Server.GraphQL.Resolution", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("created_at");

                    b.Property<int?>("DebateId")
                        .HasColumnType("integer")
                        .HasColumnName("debate_id");

                    b.Property<string>("SpiritOfTheResolution")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("spirit_of_the_resolution");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("text");

                    b.HasKey("Id")
                        .HasName("pk_resolutions");

                    b.HasIndex("DebateId")
                        .HasDatabaseName("ix_resolutions_debate_id");

                    b.ToTable("resolutions");
                });

            modelBuilder.Entity("Flipside_Server.GraphQL.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("created_at");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("email");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.HasKey("Id")
                        .HasName("pk_users");

                    b.ToTable("users");
                });

            modelBuilder.Entity("Flipside_Server.GraphQL.Argument", b =>
                {
                    b.HasOne("Flipside_Server.GraphQL.User", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorId")
                        .HasConstraintName("fk_arguments_users_author_id");

                    b.HasOne("Flipside_Server.GraphQL.Debate", "Debate")
                        .WithMany("Arguments")
                        .HasForeignKey("DebateId")
                        .HasConstraintName("fk_arguments_debates_debate_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Debate");
                });

            modelBuilder.Entity("Flipside_Server.GraphQL.Debate", b =>
                {
                    b.HasOne("Flipside_Server.GraphQL.User", "Creator")
                        .WithMany()
                        .HasForeignKey("CreatorId")
                        .HasConstraintName("fk_debates_users_creator_id");

                    b.Navigation("Creator");
                });

            modelBuilder.Entity("Flipside_Server.GraphQL.Resolution", b =>
                {
                    b.HasOne("Flipside_Server.GraphQL.Debate", "Debate")
                        .WithMany()
                        .HasForeignKey("DebateId")
                        .HasConstraintName("fk_resolutions_debates_debate_id");

                    b.Navigation("Debate");
                });

            modelBuilder.Entity("Flipside_Server.GraphQL.Debate", b =>
                {
                    b.Navigation("Arguments");
                });
#pragma warning restore 612, 618
        }
    }
}
