using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace P01_SalesDatabase.Migrations
{
    /// <inheritdoc />
    public partial class SalesAddDateDefault : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Date",
                table: "Sale",
                type: "int",
                nullable: true,
                defaultValueSql: "20 - 11 - 2023",
                oldClrType: typeof(int),
                oldType: "int");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Date",
                table: "Sale",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldDefaultValueSql: "20 - 11 - 2023");
        }
    }
}
