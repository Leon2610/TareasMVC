using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TareasMVC.Migrations
{
    /// <inheritdoc />
    public partial class AdminRol : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"IF NOT EXISTS(SELECT Id FROM AspNetRoles WHERE Id = 'dc2c0431-73e9-4573-af1a-f5dfac034166')
                                BEGIN
	                                INSERT AspNetRoles (Id, [Name], [NormalizedName])
	                                VALUES ('dc2c0431-73e9-4573-af1a-f5dfac034166','admin', 'ADMIN')
                                END");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"DELETE AspNetRoles WHERE Id = 'dc2c0431-73e9-4573-af1a-f5dfac034166'");
        }
    }
}
