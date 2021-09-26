﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Trelo1.Data;

namespace Trelo1.Migrations
{
    [DbContext(typeof(TreloDbContext))]
    [Migration("20210926085408_FixUserTaskTable")]
    partial class FixUserTaskTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BoardUser", b =>
                {
                    b.Property<int>("BoardsId")
                        .HasColumnType("int");

                    b.Property<int>("UsersId")
                        .HasColumnType("int");

                    b.HasKey("BoardsId", "UsersId");

                    b.HasIndex("UsersId");

                    b.ToTable("BoardUser");
                });

            modelBuilder.Entity("Trelo1.Models.Board", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("OrganizationId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrganizationId");

                    b.ToTable("Boards");
                });

            modelBuilder.Entity("Trelo1.Models.Organization", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Organizations");
                });

            modelBuilder.Entity("Trelo1.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(17)
                        .HasColumnType("nvarchar(17)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Trelo1.Models.UserTask", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AssignedUserId")
                        .HasColumnType("int");

                    b.Property<int?>("BoardId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DueDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Priority")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AssignedUserId");

                    b.HasIndex("BoardId");

                    b.ToTable("Tasks");
                });

            modelBuilder.Entity("Trelo1.Models.UsersTasks", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("UserTaskId")
                        .HasColumnType("int");

                    b.HasIndex("UserId");

                    b.HasIndex("UserTaskId");

                    b.ToTable("UsersTasks");
                });

            modelBuilder.Entity("BoardUser", b =>
                {
                    b.HasOne("Trelo1.Models.Board", null)
                        .WithMany()
                        .HasForeignKey("BoardsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Trelo1.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Trelo1.Models.Board", b =>
                {
                    b.HasOne("Trelo1.Models.Organization", null)
                        .WithMany("Boards")
                        .HasForeignKey("OrganizationId");
                });

            modelBuilder.Entity("Trelo1.Models.UserTask", b =>
                {
                    b.HasOne("Trelo1.Models.User", "AssignedUser")
                        .WithMany("UserTasks")
                        .HasForeignKey("AssignedUserId");

                    b.HasOne("Trelo1.Models.Board", null)
                        .WithMany("UserTasks")
                        .HasForeignKey("BoardId");

                    b.Navigation("AssignedUser");
                });

            modelBuilder.Entity("Trelo1.Models.UsersTasks", b =>
                {
                    b.HasOne("Trelo1.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Trelo1.Models.UserTask", "UserTask")
                        .WithMany()
                        .HasForeignKey("UserTaskId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");

                    b.Navigation("UserTask");
                });

            modelBuilder.Entity("Trelo1.Models.Board", b =>
                {
                    b.Navigation("UserTasks");
                });

            modelBuilder.Entity("Trelo1.Models.Organization", b =>
                {
                    b.Navigation("Boards");
                });

            modelBuilder.Entity("Trelo1.Models.User", b =>
                {
                    b.Navigation("UserTasks");
                });
#pragma warning restore 612, 618
        }
    }
}
