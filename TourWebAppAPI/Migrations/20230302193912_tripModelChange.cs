using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TourWebAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class tripModelChange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Trips_TripsId",
                table: "Bookings");

            migrationBuilder.DropIndex(
                name: "IX_Bookings_TripsId",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "TotalTripsCompleted",
                table: "Trips");

            migrationBuilder.DropColumn(
                name: "TripsId",
                table: "Bookings");

            migrationBuilder.RenameColumn(
                name: "TotalTripsPending",
                table: "Trips",
                newName: "BookingId");

            migrationBuilder.RenameColumn(
                name: "TotalMoneySpent",
                table: "Trips",
                newName: "Cost");

            migrationBuilder.AddColumn<bool>(
                name: "Completed",
                table: "Trips",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCompleted",
                table: "Trips",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateIndex(
                name: "IX_Trips_BookingId",
                table: "Trips",
                column: "BookingId");

            migrationBuilder.AddForeignKey(
                name: "FK_Trips_Bookings_BookingId",
                table: "Trips",
                column: "BookingId",
                principalTable: "Bookings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Trips_Bookings_BookingId",
                table: "Trips");

            migrationBuilder.DropIndex(
                name: "IX_Trips_BookingId",
                table: "Trips");

            migrationBuilder.DropColumn(
                name: "Completed",
                table: "Trips");

            migrationBuilder.DropColumn(
                name: "DateCompleted",
                table: "Trips");

            migrationBuilder.RenameColumn(
                name: "Cost",
                table: "Trips",
                newName: "TotalMoneySpent");

            migrationBuilder.RenameColumn(
                name: "BookingId",
                table: "Trips",
                newName: "TotalTripsPending");

            migrationBuilder.AddColumn<int>(
                name: "TotalTripsCompleted",
                table: "Trips",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TripsId",
                table: "Bookings",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_TripsId",
                table: "Bookings",
                column: "TripsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Trips_TripsId",
                table: "Bookings",
                column: "TripsId",
                principalTable: "Trips",
                principalColumn: "Id");
        }
    }
}
