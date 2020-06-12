﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using main.Core.Database;

namespace main.Core.Database.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("main.Core.Domain.Models.Bans", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("bigint(20)");

                    b.Property<DateTimeOffset>("BannedOn")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("banned_on")
                        .HasColumnType("timestamp")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<string>("ByName")
                        .HasColumnName("by_name")
                        .HasColumnType("varchar(256)")
                        .HasMaxLength(256)
                        .IsUnicode(false);

                    b.Property<long>("ByUserid")
                        .HasColumnName("by_userid")
                        .HasColumnType("bigint(20)");

                    b.Property<DateTime?>("ExpiresOn")
                        .HasColumnName("expires_on")
                        .HasColumnType("datetime");

                    b.Property<byte>("Lifted")
                        .HasColumnName("lifted")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .HasColumnName("name")
                        .HasColumnType("varchar(256)")
                        .HasMaxLength(256)
                        .IsUnicode(false);

                    b.Property<string>("Reason")
                        .HasColumnName("reason")
                        .HasColumnType("varchar(256)")
                        .HasMaxLength(256)
                        .IsUnicode(false);

                    b.Property<long>("Userid")
                        .HasColumnName("userid")
                        .HasColumnType("bigint(20)");

                    b.HasKey("Id");

                    b.HasIndex("Userid")
                        .HasName("uid");

                    b.ToTable("bans");
                });

            modelBuilder.Entity("main.Core.Domain.Models.Verifications", b =>
                {
                    b.Property<long>("Userid")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("userid")
                        .HasColumnType("bigint(20)");

                    b.Property<DateTimeOffset?>("DeletedOn")
                        .HasColumnName("deleted_on")
                        .HasColumnType("timestamp");

                    b.Property<int?>("ForumId")
                        .HasColumnName("forum_id")
                        .HasColumnType("int(11)");

                    b.Property<string>("ForumName")
                        .HasColumnName("forum_name")
                        .HasColumnType("varchar(128)")
                        .HasMaxLength(128)
                        .IsUnicode(false);

                    b.Property<string>("VerifiedBy")
                        .HasColumnName("verified_by")
                        .HasColumnType("varchar(256)")
                        .HasMaxLength(256)
                        .IsUnicode(false);

                    b.Property<DateTime>("VerifiedOn")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("verified_on")
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.HasKey("Userid")
                        .HasName("PRIMARY");

                    b.ToTable("verifications");
                });
#pragma warning restore 612, 618
        }
    }
}