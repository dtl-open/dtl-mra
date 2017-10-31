using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace DTL.MRA.Data.Migrations
{
    public partial class changefloattodouble : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Reading",
                table: "MeterReads",
                type: "float8",
                nullable: false,
                oldClrType: typeof(float));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "Reading",
                table: "MeterReads",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float8");
        }
    }
}
