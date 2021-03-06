// <auto-generated />
using ClientAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ClientAPI.Data.Migrations
{
    [DbContext(typeof(ClientDbContext))]
    [Migration("20210313161359_m1")]
    partial class m1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ClientLibrary.Models.Client", b =>
                {
                    b.Property<string>("ClientId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumberOfUsers")
                        .HasColumnType("int");

                    b.Property<string>("support")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ClientId");

                    b.ToTable("Clients");

                    b.HasData(
                        new
                        {
                            ClientId = "1d087ba0-f736-4b62-bd74-655cec99867a",
                            Address = "Manstead House, york Way, W1 6XT",
                            Name = "TechMedia",
                            NumberOfUsers = 14
                        },
                        new
                        {
                            ClientId = "74718d9d-4525-41c8-9490-dcd6ec05437f",
                            Address = "14 Runway Drive, Pudding Lane, E1 1TT",
                            Name = "DataSolutions",
                            NumberOfUsers = 8
                        },
                        new
                        {
                            ClientId = "bd9fc68a-9e55-4068-9338-267f1f819a79",
                            Address = "1-4 Nobal Street, Berks, BK1 8QS",
                            Name = "Infranology",
                            NumberOfUsers = 4
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
