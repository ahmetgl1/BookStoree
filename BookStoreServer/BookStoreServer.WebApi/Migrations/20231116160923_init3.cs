using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookStoreServer.WebApi.Migrations
{
    /// <inheritdoc />
    public partial class init3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "CoverImageUrl", "CreateAt", "ISBN", "IsActive", "IsDelete", "Price", "Quantity", "Summary", "Title", "UpdateAt" },
                values: new object[,]
                {
                    { 1, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3252), "782-454-961-41", true, false, 10m, 10, "Summary1", "Kitap1", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3271) },
                    { 2, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3276), "782-454-961-42", true, false, 20m, 10, "Summary2", "Kitap2", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3277) },
                    { 3, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3279), "782-454-961-43", true, false, 30m, 10, "Summary3", "Kitap3", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3281) },
                    { 4, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3283), "782-454-961-44", true, false, 40m, 10, "Summary4", "Kitap4", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3284) },
                    { 5, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3286), "782-454-961-45", true, false, 50m, 10, "Summary5", "Kitap5", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3287) },
                    { 6, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3290), "782-454-961-46", true, false, 60m, 10, "Summary6", "Kitap6", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3292) },
                    { 7, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3294), "782-454-961-47", true, false, 70m, 10, "Summary7", "Kitap7", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3295) },
                    { 8, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3297), "782-454-961-48", true, false, 80m, 10, "Summary8", "Kitap8", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3298) },
                    { 9, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3300), "782-454-961-49", true, false, 90m, 10, "Summary9", "Kitap9", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3301) },
                    { 10, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3306), "782-454-961-410", true, false, 100m, 10, "Summary10", "Kitap10", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3308) },
                    { 11, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3310), "782-454-961-411", true, false, 110m, 10, "Summary11", "Kitap11", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3311) },
                    { 12, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3313), "782-454-961-412", true, false, 120m, 10, "Summary12", "Kitap12", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3314) },
                    { 13, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3316), "782-454-961-413", true, false, 130m, 10, "Summary13", "Kitap13", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3317) },
                    { 14, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3318), "782-454-961-414", true, false, 140m, 10, "Summary14", "Kitap14", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3320) },
                    { 15, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3322), "782-454-961-415", true, false, 150m, 10, "Summary15", "Kitap15", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3323) },
                    { 16, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3324), "782-454-961-416", true, false, 160m, 10, "Summary16", "Kitap16", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3326) },
                    { 17, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3341), "782-454-961-417", true, false, 170m, 10, "Summary17", "Kitap17", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3342) },
                    { 18, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3346), "782-454-961-418", true, false, 180m, 10, "Summary18", "Kitap18", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3347) },
                    { 19, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3349), "782-454-961-419", true, false, 190m, 10, "Summary19", "Kitap19", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3351) },
                    { 20, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3352), "782-454-961-420", true, false, 200m, 10, "Summary20", "Kitap20", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3354) },
                    { 21, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3355), "782-454-961-421", true, false, 210m, 10, "Summary21", "Kitap21", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3357) },
                    { 22, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3358), "782-454-961-422", true, false, 220m, 10, "Summary22", "Kitap22", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3359) },
                    { 23, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3361), "782-454-961-423", true, false, 230m, 10, "Summary23", "Kitap23", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3362) },
                    { 24, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3364), "782-454-961-424", true, false, 240m, 10, "Summary24", "Kitap24", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3365) },
                    { 25, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3366), "782-454-961-425", true, false, 250m, 10, "Summary25", "Kitap25", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3368) },
                    { 26, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3369), "782-454-961-426", true, false, 260m, 10, "Summary26", "Kitap26", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3371) },
                    { 27, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3372), "782-454-961-427", true, false, 270m, 10, "Summary27", "Kitap27", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3373) },
                    { 28, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3375), "782-454-961-428", true, false, 280m, 10, "Summary28", "Kitap28", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3376) },
                    { 29, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3378), "782-454-961-429", true, false, 290m, 10, "Summary29", "Kitap29", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3379) },
                    { 30, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3381), "782-454-961-430", true, false, 300m, 10, "Summary30", "Kitap30", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3382) },
                    { 31, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3383), "782-454-961-431", true, false, 310m, 10, "Summary31", "Kitap31", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3385) },
                    { 32, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3386), "782-454-961-432", true, false, 320m, 10, "Summary32", "Kitap32", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3388) },
                    { 33, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3389), "782-454-961-433", true, false, 330m, 10, "Summary33", "Kitap33", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3390) },
                    { 34, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3394), "782-454-961-434", true, false, 340m, 10, "Summary34", "Kitap34", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3395) },
                    { 35, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3397), "782-454-961-435", true, false, 350m, 10, "Summary35", "Kitap35", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3398) },
                    { 36, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3400), "782-454-961-436", true, false, 360m, 10, "Summary36", "Kitap36", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3401) },
                    { 37, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3403), "782-454-961-437", true, false, 370m, 10, "Summary37", "Kitap37", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3404) },
                    { 38, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3405), "782-454-961-438", true, false, 380m, 10, "Summary38", "Kitap38", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3407) },
                    { 39, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3416), "782-454-961-439", true, false, 390m, 10, "Summary39", "Kitap39", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3418) },
                    { 40, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3419), "782-454-961-440", true, false, 400m, 10, "Summary40", "Kitap40", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3421) },
                    { 41, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3422), "782-454-961-441", true, false, 410m, 10, "Summary41", "Kitap41", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3423) },
                    { 42, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3425), "782-454-961-442", true, false, 420m, 10, "Summary42", "Kitap42", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3426) },
                    { 43, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3428), "782-454-961-443", true, false, 430m, 10, "Summary43", "Kitap43", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3429) },
                    { 44, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3431), "782-454-961-444", true, false, 440m, 10, "Summary44", "Kitap44", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3432) },
                    { 45, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3433), "782-454-961-445", true, false, 450m, 10, "Summary45", "Kitap45", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3435) },
                    { 46, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3436), "782-454-961-446", true, false, 460m, 10, "Summary46", "Kitap46", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3437) },
                    { 47, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3439), "782-454-961-447", true, false, 470m, 10, "Summary47", "Kitap47", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3440) },
                    { 48, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3442), "782-454-961-448", true, false, 480m, 10, "Summary48", "Kitap48", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3443) },
                    { 49, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3445), "782-454-961-449", true, false, 490m, 10, "Summary49", "Kitap49", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3446) },
                    { 50, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3447), "782-454-961-450", true, false, 500m, 10, "Summary50", "Kitap50", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3449) },
                    { 51, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3450), "782-454-961-451", true, false, 510m, 10, "Summary51", "Kitap51", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3452) },
                    { 52, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3453), "782-454-961-452", true, false, 520m, 10, "Summary52", "Kitap52", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3454) },
                    { 53, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3456), "782-454-961-453", true, false, 530m, 10, "Summary53", "Kitap53", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3457) },
                    { 54, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3459), "782-454-961-454", true, false, 540m, 10, "Summary54", "Kitap54", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3460) },
                    { 55, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3461), "782-454-961-455", true, false, 550m, 10, "Summary55", "Kitap55", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3463) },
                    { 56, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3464), "782-454-961-456", true, false, 560m, 10, "Summary56", "Kitap56", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3466) },
                    { 57, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3467), "782-454-961-457", true, false, 570m, 10, "Summary57", "Kitap57", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3468) },
                    { 58, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3470), "782-454-961-458", true, false, 580m, 10, "Summary58", "Kitap58", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3471) },
                    { 59, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3473), "782-454-961-459", true, false, 590m, 10, "Summary59", "Kitap59", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3474) },
                    { 60, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3476), "782-454-961-460", true, false, 600m, 10, "Summary60", "Kitap60", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3477) },
                    { 61, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3479), "782-454-961-461", true, false, 610m, 10, "Summary61", "Kitap61", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3480) },
                    { 62, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3481), "782-454-961-462", true, false, 620m, 10, "Summary62", "Kitap62", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3483) },
                    { 63, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3497), "782-454-961-463", true, false, 630m, 10, "Summary63", "Kitap63", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3498) },
                    { 64, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3500), "782-454-961-464", true, false, 640m, 10, "Summary64", "Kitap64", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3502) },
                    { 65, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3503), "782-454-961-465", true, false, 650m, 10, "Summary65", "Kitap65", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3505) },
                    { 66, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3508), "782-454-961-466", true, false, 660m, 10, "Summary66", "Kitap66", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3510) },
                    { 67, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3511), "782-454-961-467", true, false, 670m, 10, "Summary67", "Kitap67", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3513) },
                    { 68, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3514), "782-454-961-468", true, false, 680m, 10, "Summary68", "Kitap68", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3515) },
                    { 69, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3517), "782-454-961-469", true, false, 690m, 10, "Summary69", "Kitap69", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3518) },
                    { 70, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3520), "782-454-961-470", true, false, 700m, 10, "Summary70", "Kitap70", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3521) },
                    { 71, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3522), "782-454-961-471", true, false, 710m, 10, "Summary71", "Kitap71", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3524) },
                    { 72, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3525), "782-454-961-472", true, false, 720m, 10, "Summary72", "Kitap72", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3527) },
                    { 73, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3528), "782-454-961-473", true, false, 730m, 10, "Summary73", "Kitap73", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3530) },
                    { 74, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3531), "782-454-961-474", true, false, 740m, 10, "Summary74", "Kitap74", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3532) },
                    { 75, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3534), "782-454-961-475", true, false, 750m, 10, "Summary75", "Kitap75", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3535) },
                    { 76, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3537), "782-454-961-476", true, false, 760m, 10, "Summary76", "Kitap76", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3538) },
                    { 77, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3540), "782-454-961-477", true, false, 770m, 10, "Summary77", "Kitap77", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3541) },
                    { 78, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3542), "782-454-961-478", true, false, 780m, 10, "Summary78", "Kitap78", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3544) },
                    { 79, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3545), "782-454-961-479", true, false, 790m, 10, "Summary79", "Kitap79", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3547) },
                    { 80, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3548), "782-454-961-480", true, false, 800m, 10, "Summary80", "Kitap80", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3549) },
                    { 81, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3551), "782-454-961-481", true, false, 810m, 10, "Summary81", "Kitap81", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3552) },
                    { 82, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3553), "782-454-961-482", true, false, 820m, 10, "Summary82", "Kitap82", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3555) },
                    { 83, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3556), "782-454-961-483", true, false, 830m, 10, "Summary83", "Kitap83", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3558) },
                    { 84, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3568), "782-454-961-484", true, false, 840m, 10, "Summary84", "Kitap84", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3569) },
                    { 85, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3572), "782-454-961-485", true, false, 850m, 10, "Summary85", "Kitap85", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3573) },
                    { 86, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3575), "782-454-961-486", true, false, 860m, 10, "Summary86", "Kitap86", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3576) },
                    { 87, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3577), "782-454-961-487", true, false, 870m, 10, "Summary87", "Kitap87", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3579) },
                    { 88, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3580), "782-454-961-488", true, false, 880m, 10, "Summary88", "Kitap88", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3581) },
                    { 89, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3583), "782-454-961-489", true, false, 890m, 10, "Summary89", "Kitap89", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3584) },
                    { 90, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3586), "782-454-961-490", true, false, 900m, 10, "Summary90", "Kitap90", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3587) },
                    { 91, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3589), "782-454-961-491", true, false, 910m, 10, "Summary91", "Kitap91", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3590) },
                    { 92, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3591), "782-454-961-492", true, false, 920m, 10, "Summary92", "Kitap92", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3593) },
                    { 93, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3594), "782-454-961-493", true, false, 930m, 10, "Summary93", "Kitap93", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3596) },
                    { 94, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3597), "782-454-961-494", true, false, 940m, 10, "Summary94", "Kitap94", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3598) },
                    { 95, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3600), "782-454-961-495", true, false, 950m, 10, "Summary95", "Kitap95", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3601) },
                    { 96, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3603), "782-454-961-496", true, false, 960m, 10, "Summary96", "Kitap96", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3604) },
                    { 97, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3605), "782-454-961-497", true, false, 970m, 10, "Summary97", "Kitap97", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3607) },
                    { 98, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3608), "782-454-961-498", true, false, 980m, 10, "Summary98", "Kitap98", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3609) },
                    { 99, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3611), "782-454-961-499", true, false, 990m, 10, "Summary99", "Kitap99", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3613) },
                    { 100, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3615), "782-454-961-4100", true, false, 1000m, 10, "Summary100", "Kitap100", new DateTime(2023, 11, 16, 19, 9, 23, 699, DateTimeKind.Local).AddTicks(3617) }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "IsActive", "IsDelete", "Name" },
                values: new object[,]
                {
                    { 1, true, false, "Kategori1" },
                    { 2, true, false, "Kategori2" },
                    { 3, true, false, "Kategori3" },
                    { 4, true, false, "Kategori4" },
                    { 5, true, false, "Kategori5" },
                    { 6, true, false, "Kategori6" },
                    { 7, true, false, "Kategori7" },
                    { 8, true, false, "Kategori8" },
                    { 9, true, false, "Kategori9" },
                    { 10, true, false, "Kategori10" }
                });

            migrationBuilder.InsertData(
                table: "BookCategories",
                columns: new[] { "BookId", "CategoryId" },
                values: new object[,]
                {
                    { 1, 7 },
                    { 2, 1 },
                    { 3, 5 },
                    { 4, 2 },
                    { 5, 6 },
                    { 6, 7 },
                    { 7, 5 },
                    { 8, 1 },
                    { 9, 2 },
                    { 10, 7 },
                    { 11, 4 },
                    { 12, 8 },
                    { 13, 3 },
                    { 14, 1 },
                    { 15, 1 },
                    { 16, 6 },
                    { 17, 1 },
                    { 18, 4 },
                    { 19, 10 },
                    { 20, 8 },
                    { 21, 8 },
                    { 22, 10 },
                    { 23, 5 },
                    { 24, 1 },
                    { 25, 3 },
                    { 26, 7 },
                    { 27, 10 },
                    { 28, 5 },
                    { 29, 9 },
                    { 30, 1 },
                    { 31, 7 },
                    { 32, 4 },
                    { 33, 6 },
                    { 34, 5 },
                    { 35, 3 },
                    { 36, 10 },
                    { 37, 3 },
                    { 38, 4 },
                    { 39, 3 },
                    { 40, 9 },
                    { 41, 6 },
                    { 42, 2 },
                    { 43, 3 },
                    { 44, 4 },
                    { 45, 3 },
                    { 46, 10 },
                    { 47, 2 },
                    { 48, 1 },
                    { 49, 4 },
                    { 50, 10 },
                    { 51, 5 },
                    { 52, 7 },
                    { 53, 3 },
                    { 54, 3 },
                    { 55, 1 },
                    { 56, 6 },
                    { 57, 6 },
                    { 58, 6 },
                    { 59, 1 },
                    { 60, 7 },
                    { 61, 10 },
                    { 62, 5 },
                    { 63, 3 },
                    { 64, 6 },
                    { 65, 1 },
                    { 66, 5 },
                    { 67, 9 },
                    { 68, 1 },
                    { 69, 2 },
                    { 70, 2 },
                    { 71, 3 },
                    { 72, 8 },
                    { 73, 3 },
                    { 74, 7 },
                    { 75, 9 },
                    { 76, 7 },
                    { 77, 6 },
                    { 78, 3 },
                    { 79, 8 },
                    { 80, 7 },
                    { 81, 10 },
                    { 82, 10 },
                    { 83, 8 },
                    { 84, 1 },
                    { 85, 4 },
                    { 86, 7 },
                    { 87, 9 },
                    { 88, 2 },
                    { 89, 9 },
                    { 90, 3 },
                    { 91, 1 },
                    { 92, 3 },
                    { 93, 6 },
                    { 94, 5 },
                    { 95, 3 },
                    { 96, 6 },
                    { 97, 1 },
                    { 98, 4 },
                    { 99, 6 },
                    { 100, 9 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 1, 7 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 3, 5 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 5, 6 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 6, 7 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 7, 5 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 8, 1 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 9, 2 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 10, 7 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 11, 4 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 12, 8 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 13, 3 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 14, 1 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 15, 1 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 16, 6 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 17, 1 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 18, 4 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 19, 10 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 20, 8 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 21, 8 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 22, 10 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 23, 5 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 24, 1 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 25, 3 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 26, 7 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 27, 10 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 28, 5 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 29, 9 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 30, 1 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 31, 7 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 32, 4 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 33, 6 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 34, 5 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 35, 3 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 36, 10 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 37, 3 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 38, 4 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 39, 3 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 40, 9 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 41, 6 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 42, 2 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 43, 3 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 44, 4 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 45, 3 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 46, 10 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 47, 2 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 48, 1 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 49, 4 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 50, 10 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 51, 5 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 52, 7 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 53, 3 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 54, 3 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 55, 1 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 56, 6 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 57, 6 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 58, 6 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 59, 1 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 60, 7 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 61, 10 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 62, 5 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 63, 3 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 64, 6 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 65, 1 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 66, 5 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 67, 9 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 68, 1 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 69, 2 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 70, 2 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 71, 3 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 72, 8 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 73, 3 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 74, 7 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 75, 9 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 76, 7 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 77, 6 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 78, 3 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 79, 8 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 80, 7 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 81, 10 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 82, 10 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 83, 8 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 84, 1 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 85, 4 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 86, 7 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 87, 9 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 88, 2 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 89, 9 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 90, 3 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 91, 1 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 92, 3 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 93, 6 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 94, 5 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 95, 3 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 96, 6 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 97, 1 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 98, 4 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 99, 6 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 100, 9 });

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
