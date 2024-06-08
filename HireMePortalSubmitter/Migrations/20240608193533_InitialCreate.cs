using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HireMePortalSubmitter.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CareerApply",
                columns: table => new
                {
                    CareerApplyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YearofExperinace = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CareerApply", x => x.CareerApplyId);
                });

            migrationBuilder.CreateTable(
                name: "Careers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    JobCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JobDetails = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExperienceRange = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Careers", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Careers",
                columns: new[] { "Id", "ExperienceRange", "JobCode", "JobDetails", "Location", "Name" },
                values: new object[,]
                {
                    { 1, "2-4 years", "DEV001", "Develop and maintain web applications.", "New York", "Developer" },
                    { 2, "3-5 years", "DES001", "Design user interfaces and graphics.", "Los Angeles", "Designer" },
                    { 3, "1-3 years", "TES001", "Test software applications for bugs.", "Chicago", "Tester" },
                    { 4, "5-7 years", "MAN001", "Manage project teams and deliverables.", "San Francisco", "Manager" },
                    { 5, "2-4 years", "SUP001", "Provide technical support to clients.", "Miami", "Support" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CareerApply");

            migrationBuilder.DropTable(
                name: "Careers");
        }
    }
}
