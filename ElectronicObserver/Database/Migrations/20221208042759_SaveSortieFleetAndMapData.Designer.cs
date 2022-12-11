﻿// <auto-generated />
using System;
using ElectronicObserver.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ElectronicObserver.Database.Migrations
{
    [DbContext(typeof(ElectronicObserverContext))]
    [Migration("20221208042759_SaveSortieFleetAndMapData")]
    partial class SaveSortieFleetAndMapData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.4");

            modelBuilder.Entity("ElectronicObserver.Database.KancolleApi.ApiFile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ApiFileType")
                        .HasColumnType("INTEGER");

                    b.Property<byte[]>("Content")
                        .IsRequired()
                        .HasColumnType("BLOB");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("SortieRecordId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("TEXT");

                    b.Property<int>("Version")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("SortieRecordId");

                    b.ToTable("ApiFiles");
                });

            modelBuilder.Entity("ElectronicObserver.Database.MapData.CellModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CellId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CellType")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MapId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("WorldId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Cells");
                });

            modelBuilder.Entity("ElectronicObserver.Database.MapData.MapModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("MapId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("WorldId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Maps");
                });

            modelBuilder.Entity("ElectronicObserver.Database.MapData.WorldModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Worlds");
                });

            modelBuilder.Entity("ElectronicObserver.Database.Sortie.SortieRecord", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("FleetData")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Map")
                        .HasColumnType("INTEGER");

                    b.Property<string>("MapData")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("World")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Sorties");
                });

            modelBuilder.Entity("ElectronicObserver.Window.Tools.AutoRefresh.AutoRefreshModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsSingleMapMode")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Rules")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SingleMapModeMap")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("AutoRefresh");
                });

            modelBuilder.Entity("ElectronicObserver.Window.Tools.EquipmentUpgradePlanner.EquipmentUpgradePlanItemModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("DesiredUpgradeLevel")
                        .HasColumnType("INTEGER");

                    b.Property<int>("EquipmentId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("EquipmentMasterId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Finished")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Priority")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("EquipmentUpgradePlanItems");
                });

            modelBuilder.Entity("ElectronicObserver.Window.Tools.EventLockPlanner.EventLockPlannerModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Locks")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Phases")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ShipLocks")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("EventLockPlans");
                });

            modelBuilder.Entity("ElectronicObserver.Database.KancolleApi.ApiFile", b =>
                {
                    b.HasOne("ElectronicObserver.Database.Sortie.SortieRecord", null)
                        .WithMany("ApiFiles")
                        .HasForeignKey("SortieRecordId");
                });

            modelBuilder.Entity("ElectronicObserver.Database.Sortie.SortieRecord", b =>
                {
                    b.Navigation("ApiFiles");
                });
#pragma warning restore 612, 618
        }
    }
}
