﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PsiOffice.TreatmentAPI.Model.Context;

#nullable disable

namespace PsiOffice.TreatmentAPI.Migrations
{
    [DbContext(typeof(MySQLContext))]
    partial class MySQLContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("PsiOffice.TreatmentAPI.Model.Treatment", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("AdditionalFilds")
                        .HasColumnType("json")
                        .HasColumnName("additional_fields");

                    b.Property<DateTime>("DtCreation")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("dt_creation");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("end_date");

                    b.Property<long>("IdPacient")
                        .HasColumnType("bigint")
                        .HasColumnName("id_pacient");

                    b.Property<long>("IdTreatmentType")
                        .HasColumnType("bigint")
                        .HasColumnName("id_treatment_type");

                    b.Property<string>("InitialDemend")
                        .HasColumnType("longtext")
                        .HasColumnName("initial_demend");

                    b.Property<string>("Observation")
                        .HasColumnType("longtext")
                        .HasColumnName("observation");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("start_date");

                    b.HasKey("Id");

                    b.ToTable("treatment");
                });
#pragma warning restore 612, 618
        }
    }
}
