﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using QuizAPI.Data;

namespace QuizAPI.Migrations
{
    [DbContext(typeof(QuizContext))]
    partial class QuizContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("QuizAPI.Data.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<string>("QuestionText")
                        .HasColumnName("question_text");

                    b.Property<int?>("QuizId");

                    b.HasKey("Id");

                    b.HasIndex("QuizId");

                    b.ToTable("questions");
                });

            modelBuilder.Entity("QuizAPI.Data.Quiz", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<string>("Title")
                        .HasColumnName("title");

                    b.HasKey("Id");

                    b.ToTable("quizzes");
                });

            modelBuilder.Entity("QuizAPI.Data.Question", b =>
                {
                    b.HasOne("QuizAPI.Data.Quiz")
                        .WithMany("Questions")
                        .HasForeignKey("QuizId");
                });
#pragma warning restore 612, 618
        }
    }
}
