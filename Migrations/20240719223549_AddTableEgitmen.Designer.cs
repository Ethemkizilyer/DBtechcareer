﻿// <auto-generated />
using System;
using DBtechcareer.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DBtechcareer.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240719223549_AddTableEgitmen")]
    partial class AddTableEgitmen
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.7");

            modelBuilder.Entity("DBtechcareer.Data.Bootcamp", b =>
                {
                    b.Property<int>("BootcampId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Baslik")
                        .HasColumnType("TEXT");

                    b.Property<int?>("EgitmenId")
                        .HasColumnType("INTEGER");

                    b.HasKey("BootcampId");

                    b.HasIndex("EgitmenId");

                    b.ToTable("Bootcamps");
                });

            modelBuilder.Entity("DBtechcareer.Data.BootcampKayit", b =>
                {
                    b.Property<int>("KayitId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("BootcampId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("KayitTarihi")
                        .HasColumnType("TEXT");

                    b.Property<int>("OgrenciId")
                        .HasColumnType("INTEGER");

                    b.HasKey("KayitId");

                    b.HasIndex("BootcampId");

                    b.HasIndex("OgrenciId");

                    b.ToTable("KursKayitlari");
                });

            modelBuilder.Entity("DBtechcareer.Data.Egitmen", b =>
                {
                    b.Property<int>("EgitmenId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Ad")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("BaslamaTarihi")
                        .HasColumnType("TEXT");

                    b.Property<string>("Eposta")
                        .HasColumnType("TEXT");

                    b.Property<string>("Soyad")
                        .HasColumnType("TEXT");

                    b.Property<string>("Telefon")
                        .HasColumnType("TEXT");

                    b.HasKey("EgitmenId");

                    b.ToTable("Egitmenler");
                });

            modelBuilder.Entity("DBtechcareer.Data.Ogrenci", b =>
                {
                    b.Property<int>("OgrenciId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Eposta")
                        .HasColumnType("TEXT");

                    b.Property<string>("OgrenciAd")
                        .HasColumnType("TEXT");

                    b.Property<string>("OgrenciSoyad")
                        .HasColumnType("TEXT");

                    b.Property<string>("Telefon")
                        .HasColumnType("TEXT");

                    b.HasKey("OgrenciId");

                    b.ToTable("Ogrenciler");
                });

            modelBuilder.Entity("DBtechcareer.Data.Bootcamp", b =>
                {
                    b.HasOne("DBtechcareer.Data.Egitmen", "Egitmen")
                        .WithMany("Bootcamp")
                        .HasForeignKey("EgitmenId");

                    b.Navigation("Egitmen");
                });

            modelBuilder.Entity("DBtechcareer.Data.BootcampKayit", b =>
                {
                    b.HasOne("DBtechcareer.Data.Bootcamp", "Bootcamp")
                        .WithMany("KursKayit")
                        .HasForeignKey("BootcampId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DBtechcareer.Data.Ogrenci", "Ogrenci")
                        .WithMany("KursKayit")
                        .HasForeignKey("OgrenciId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bootcamp");

                    b.Navigation("Ogrenci");
                });

            modelBuilder.Entity("DBtechcareer.Data.Bootcamp", b =>
                {
                    b.Navigation("KursKayit");
                });

            modelBuilder.Entity("DBtechcareer.Data.Egitmen", b =>
                {
                    b.Navigation("Bootcamp");
                });

            modelBuilder.Entity("DBtechcareer.Data.Ogrenci", b =>
                {
                    b.Navigation("KursKayit");
                });
#pragma warning restore 612, 618
        }
    }
}
