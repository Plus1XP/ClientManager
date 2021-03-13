using Microsoft.EntityFrameworkCore.Migrations;

namespace ClientAPI.Data.Migrations
{
    public partial class m1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    ClientId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumberOfUsers = table.Column<int>(type: "int", nullable: false),
                    support = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.ClientId);
                });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "ClientId", "Address", "Name", "NumberOfUsers", "support" },
                values: new object[] { "1d087ba0-f736-4b62-bd74-655cec99867a", "Manstead House, york Way, W1 6XT", "TechMedia", 14, null });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "ClientId", "Address", "Name", "NumberOfUsers", "support" },
                values: new object[] { "74718d9d-4525-41c8-9490-dcd6ec05437f", "14 Runway Drive, Pudding Lane, E1 1TT", "DataSolutions", 8, null });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "ClientId", "Address", "Name", "NumberOfUsers", "support" },
                values: new object[] { "bd9fc68a-9e55-4068-9338-267f1f819a79", "1-4 Nobal Street, Berks, BK1 8QS", "Infranology", 4, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clients");
        }
    }
}
