using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace DTL.MRA.Data.Migrations
{
    public partial class changeints : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "ReadingTime",
                table: "MeterReads",
                type: "int8",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<float>(
                name: "Reading",
                table: "MeterReads",
                type: "float4",
                nullable: false,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ReadingTime",
                table: "MeterReads",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "int8");

            migrationBuilder.AlterColumn<int>(
                name: "Reading",
                table: "MeterReads",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "float4");
        }
    }
}
