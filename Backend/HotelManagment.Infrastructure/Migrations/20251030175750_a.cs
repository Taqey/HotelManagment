using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelManagment.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class a : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    department_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    department_name = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Departme__C22324221AC68DC2", x => x.department_id);
                });

            migrationBuilder.CreateTable(
                name: "Facilities",
                columns: table => new
                {
                    facility_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    facility_name = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    description = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    price_per_hour = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    capacity = table.Column<int>(type: "int", nullable: true),
                    is_available = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Faciliti__B2E8EAAE8E3BBC33", x => x.facility_id);
                });

            migrationBuilder.CreateTable(
                name: "Guests",
                columns: table => new
                {
                    guest_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    full_name = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    phone = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    email = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    address = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    id_passport = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    religion = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    nationality = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    date_of_birth = table.Column<DateOnly>(type: "date", nullable: true),
                    gender = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Guests__19778E35E35BF3C4", x => x.guest_id);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    item_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    item_name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    item_type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    unit = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    description = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    barcode = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    cost_per_unit = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    supplier = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    minimum_quantity = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    is_active = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    created_date = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Items__52020FDDE335F51C", x => x.item_id);
                });

            migrationBuilder.CreateTable(
                name: "MenuItems",
                columns: table => new
                {
                    item_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    item_name = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    price = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    category = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    is_available = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__MenuItem__52020FDDC57B0273", x => x.item_id);
                });

            migrationBuilder.CreateTable(
                name: "RoomTypes",
                columns: table => new
                {
                    room_type_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    type_name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    price = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    capacity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__RoomType__42395E84EA59AAC0", x => x.room_type_id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    employee_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    full_name = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    job_title = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    department_id = table.Column<int>(type: "int", nullable: false),
                    salary = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    phone = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    hire_date = table.Column<DateOnly>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Employee__C52E0BA82BF8D87C", x => x.employee_id);
                    table.ForeignKey(
                        name: "FK__Employees__depar__7F2BE32F",
                        column: x => x.department_id,
                        principalTable: "Departments",
                        principalColumn: "department_id");
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    room_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    room_number = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    room_type_id = table.Column<int>(type: "int", nullable: false),
                    floor = table.Column<int>(type: "int", nullable: false),
                    status = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false, defaultValue: "Available"),
                    description = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Rooms__19675A8A3E387403", x => x.room_id);
                    table.ForeignKey(
                        name: "FK__Rooms__room_type__0C85DE4D",
                        column: x => x.room_type_id,
                        principalTable: "RoomTypes",
                        principalColumn: "room_type_id");
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    employee_id = table.Column<int>(type: "int", nullable: false),
                    is_active = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    created_date = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    last_login = table.Column<DateTime>(type: "datetime", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK__Users__employee___0F624AF8",
                        column: x => x.employee_id,
                        principalTable: "Employees",
                        principalColumn: "employee_id");
                });

            migrationBuilder.CreateTable(
                name: "EmployeeShifts",
                columns: table => new
                {
                    shift_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    employee_id = table.Column<int>(type: "int", nullable: false),
                    shift_date = table.Column<DateOnly>(type: "date", nullable: false),
                    start_time = table.Column<TimeOnly>(type: "time", nullable: false),
                    end_time = table.Column<TimeOnly>(type: "time", nullable: false),
                    status = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false, defaultValue: "Scheduled")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Employee__7B267220065940FC", x => x.shift_id);
                    table.ForeignKey(
                        name: "FK__EmployeeS__emplo__00200768",
                        column: x => x.employee_id,
                        principalTable: "Employees",
                        principalColumn: "employee_id");
                });

            migrationBuilder.CreateTable(
                name: "Warehouses",
                columns: table => new
                {
                    warehouse_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    warehouse_name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    location = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    description = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    capacity = table.Column<int>(type: "int", nullable: true),
                    manager_employee_id = table.Column<int>(type: "int", nullable: true),
                    is_active = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    created_date = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Warehous__734FE6BF80EEB599", x => x.warehouse_id);
                    table.ForeignKey(
                        name: "FK__Warehouse__manag__1332DBDC",
                        column: x => x.manager_employee_id,
                        principalTable: "Employees",
                        principalColumn: "employee_id");
                });

            migrationBuilder.CreateTable(
                name: "Bookings",
                columns: table => new
                {
                    booking_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    guest_id = table.Column<int>(type: "int", nullable: false),
                    room_id = table.Column<int>(type: "int", nullable: false),
                    check_in = table.Column<DateOnly>(type: "date", nullable: false),
                    check_out = table.Column<DateOnly>(type: "date", nullable: false),
                    status = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false, defaultValue: "Confirmed"),
                    total_amount = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    created_date = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Bookings__5DE3A5B1D4847D21", x => x.booking_id);
                    table.ForeignKey(
                        name: "FK__Bookings__guest___7D439ABD",
                        column: x => x.guest_id,
                        principalTable: "Guests",
                        principalColumn: "guest_id");
                    table.ForeignKey(
                        name: "FK__Bookings__room_i__7E37BEF6",
                        column: x => x.room_id,
                        principalTable: "Rooms",
                        principalColumn: "room_id");
                });

            migrationBuilder.CreateTable(
                name: "MaintenanceRequests",
                columns: table => new
                {
                    request_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    room_id = table.Column<int>(type: "int", nullable: false),
                    description = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    request_date = table.Column<DateOnly>(type: "date", nullable: false),
                    status = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false, defaultValue: "Open"),
                    assigned_employee_id = table.Column<int>(type: "int", nullable: true),
                    priority = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true, defaultValue: "Medium"),
                    completed_date = table.Column<DateOnly>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Maintena__18D3B90FCBD5B484", x => x.request_id);
                    table.ForeignKey(
                        name: "FK__Maintenan__assig__06CD04F7",
                        column: x => x.assigned_employee_id,
                        principalTable: "Employees",
                        principalColumn: "employee_id");
                    table.ForeignKey(
                        name: "FK__Maintenan__room___07C12930",
                        column: x => x.room_id,
                        principalTable: "Rooms",
                        principalColumn: "room_id");
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InventoryPerDepartment",
                columns: table => new
                {
                    inventory_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    department_id = table.Column<int>(type: "int", nullable: false),
                    warehouse_id = table.Column<int>(type: "int", nullable: false),
                    item_id = table.Column<int>(type: "int", nullable: false),
                    quantity = table.Column<int>(type: "int", nullable: false),
                    minimum_quantity = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    last_updated = table.Column<DateOnly>(type: "date", nullable: false, defaultValueSql: "(getdate())"),
                    notes = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Inventor__B59ACC49718CCABD", x => x.inventory_id);
                    table.ForeignKey(
                        name: "FK__Inventory__depar__03F0984C",
                        column: x => x.department_id,
                        principalTable: "Departments",
                        principalColumn: "department_id");
                    table.ForeignKey(
                        name: "FK__Inventory__item___04E4BC85",
                        column: x => x.item_id,
                        principalTable: "Items",
                        principalColumn: "item_id");
                    table.ForeignKey(
                        name: "FK__Inventory__wareh__05D8E0BE",
                        column: x => x.warehouse_id,
                        principalTable: "Warehouses",
                        principalColumn: "warehouse_id");
                });

            migrationBuilder.CreateTable(
                name: "WarehouseItems",
                columns: table => new
                {
                    warehouse_item_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    warehouse_id = table.Column<int>(type: "int", nullable: false),
                    item_id = table.Column<int>(type: "int", nullable: false),
                    quantity = table.Column<int>(type: "int", nullable: false),
                    minimum_quantity = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    maximum_quantity = table.Column<int>(type: "int", nullable: true),
                    last_updated = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    last_updated_by = table.Column<int>(type: "int", nullable: true),
                    location_in_warehouse = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    notes = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Warehous__13F05B7922BE9391", x => x.warehouse_item_id);
                    table.ForeignKey(
                        name: "FK__Warehouse__item___10566F31",
                        column: x => x.item_id,
                        principalTable: "Items",
                        principalColumn: "item_id");
                    table.ForeignKey(
                        name: "FK__Warehouse__last___114A936A",
                        column: x => x.last_updated_by,
                        principalTable: "Employees",
                        principalColumn: "employee_id");
                    table.ForeignKey(
                        name: "FK__Warehouse__wareh__123EB7A3",
                        column: x => x.warehouse_id,
                        principalTable: "Warehouses",
                        principalColumn: "warehouse_id");
                });

            migrationBuilder.CreateTable(
                name: "FacilityBookings",
                columns: table => new
                {
                    facility_booking_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    booking_id = table.Column<int>(type: "int", nullable: false),
                    facility_id = table.Column<int>(type: "int", nullable: false),
                    booking_date = table.Column<DateOnly>(type: "date", nullable: false),
                    start_time = table.Column<TimeOnly>(type: "time", nullable: false),
                    end_time = table.Column<TimeOnly>(type: "time", nullable: false),
                    hours = table.Column<int>(type: "int", nullable: false),
                    total_cost = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    status = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false, defaultValue: "Confirmed")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Facility__FC18257B425C7B32", x => x.facility_booking_id);
                    table.ForeignKey(
                        name: "FK__FacilityB__booki__01142BA1",
                        column: x => x.booking_id,
                        principalTable: "Bookings",
                        principalColumn: "booking_id");
                    table.ForeignKey(
                        name: "FK__FacilityB__facil__02084FDA",
                        column: x => x.facility_id,
                        principalTable: "Facilities",
                        principalColumn: "facility_id");
                });

            migrationBuilder.CreateTable(
                name: "GuestReviews",
                columns: table => new
                {
                    review_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    booking_id = table.Column<int>(type: "int", nullable: false),
                    rating = table.Column<int>(type: "int", nullable: false),
                    comment = table.Column<string>(type: "text", nullable: true),
                    review_date = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__GuestRev__60883D90951C7B0D", x => x.review_id);
                    table.ForeignKey(
                        name: "FK__GuestRevi__booki__02FC7413",
                        column: x => x.booking_id,
                        principalTable: "Bookings",
                        principalColumn: "booking_id");
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    order_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    booking_id = table.Column<int>(type: "int", nullable: false),
                    order_date = table.Column<DateTime>(type: "datetime", nullable: false),
                    total = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    status = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false, defaultValue: "Pending")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Orders__46596229C7732462", x => x.order_id);
                    table.ForeignKey(
                        name: "FK__Orders__booking___0A9D95DB",
                        column: x => x.booking_id,
                        principalTable: "Bookings",
                        principalColumn: "booking_id");
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    payment_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    booking_id = table.Column<int>(type: "int", nullable: false),
                    amount = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    payment_date = table.Column<DateOnly>(type: "date", nullable: false),
                    payment_method = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    transaction_reference = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    status = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false, defaultValue: "Completed")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Payments__ED1FC9EAEBC156CA", x => x.payment_id);
                    table.ForeignKey(
                        name: "FK__Payments__bookin__0B91BA14",
                        column: x => x.booking_id,
                        principalTable: "Bookings",
                        principalColumn: "booking_id");
                });

            migrationBuilder.CreateTable(
                name: "RoomServiceRequests",
                columns: table => new
                {
                    request_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    booking_id = table.Column<int>(type: "int", nullable: false),
                    request_type = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    description = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    request_time = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    status = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false, defaultValue: "Pending"),
                    assigned_employee_id = table.Column<int>(type: "int", nullable: true),
                    completed_time = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__RoomServ__18D3B90F3DEBDD96", x => x.request_id);
                    table.ForeignKey(
                        name: "FK__RoomServi__assig__0D7A0286",
                        column: x => x.assigned_employee_id,
                        principalTable: "Employees",
                        principalColumn: "employee_id");
                    table.ForeignKey(
                        name: "FK__RoomServi__booki__0E6E26BF",
                        column: x => x.booking_id,
                        principalTable: "Bookings",
                        principalColumn: "booking_id");
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    order_detail_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    order_id = table.Column<int>(type: "int", nullable: false),
                    item_id = table.Column<int>(type: "int", nullable: false),
                    quantity = table.Column<int>(type: "int", nullable: false, defaultValue: 1),
                    unit_price = table.Column<decimal>(type: "decimal(10,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__OrderDet__3C5A408022B4B559", x => x.order_detail_id);
                    table.ForeignKey(
                        name: "FK__OrderDeta__item___08B54D69",
                        column: x => x.item_id,
                        principalTable: "MenuItems",
                        principalColumn: "item_id");
                    table.ForeignKey(
                        name: "FK__OrderDeta__order__09A971A2",
                        column: x => x.order_id,
                        principalTable: "Orders",
                        principalColumn: "order_id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_employee_id",
                table: "AspNetUsers",
                column: "employee_id");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_guest_id",
                table: "Bookings",
                column: "guest_id");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_room_id",
                table: "Bookings",
                column: "room_id");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_department_id",
                table: "Employees",
                column: "department_id");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeShifts_employee_id",
                table: "EmployeeShifts",
                column: "employee_id");

            migrationBuilder.CreateIndex(
                name: "IX_FacilityBookings_booking_id",
                table: "FacilityBookings",
                column: "booking_id");

            migrationBuilder.CreateIndex(
                name: "IX_FacilityBookings_facility_id",
                table: "FacilityBookings",
                column: "facility_id");

            migrationBuilder.CreateIndex(
                name: "IX_GuestReviews_booking_id",
                table: "GuestReviews",
                column: "booking_id");

            migrationBuilder.CreateIndex(
                name: "IX_InventoryPerDepartment_item_id",
                table: "InventoryPerDepartment",
                column: "item_id");

            migrationBuilder.CreateIndex(
                name: "IX_InventoryPerDepartment_warehouse_id",
                table: "InventoryPerDepartment",
                column: "warehouse_id");

            migrationBuilder.CreateIndex(
                name: "UQ__Inventor__F945D847A14196D2",
                table: "InventoryPerDepartment",
                columns: new[] { "department_id", "warehouse_id", "item_id" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MaintenanceRequests_assigned_employee_id",
                table: "MaintenanceRequests",
                column: "assigned_employee_id");

            migrationBuilder.CreateIndex(
                name: "IX_MaintenanceRequests_room_id",
                table: "MaintenanceRequests",
                column: "room_id");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_item_id",
                table: "OrderDetails",
                column: "item_id");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_order_id",
                table: "OrderDetails",
                column: "order_id");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_booking_id",
                table: "Orders",
                column: "booking_id");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_booking_id",
                table: "Payments",
                column: "booking_id");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_room_type_id",
                table: "Rooms",
                column: "room_type_id");

            migrationBuilder.CreateIndex(
                name: "UQ__Rooms__FE22F61B2DDF5866",
                table: "Rooms",
                column: "room_number",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RoomServiceRequests_assigned_employee_id",
                table: "RoomServiceRequests",
                column: "assigned_employee_id");

            migrationBuilder.CreateIndex(
                name: "IX_RoomServiceRequests_booking_id",
                table: "RoomServiceRequests",
                column: "booking_id");

            migrationBuilder.CreateIndex(
                name: "IX_WarehouseItems_item_id",
                table: "WarehouseItems",
                column: "item_id");

            migrationBuilder.CreateIndex(
                name: "IX_WarehouseItems_last_updated_by",
                table: "WarehouseItems",
                column: "last_updated_by");

            migrationBuilder.CreateIndex(
                name: "UQ__Warehous__B66FC643FD5106DE",
                table: "WarehouseItems",
                columns: new[] { "warehouse_id", "item_id" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Warehouses_manager_employee_id",
                table: "Warehouses",
                column: "manager_employee_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "EmployeeShifts");

            migrationBuilder.DropTable(
                name: "FacilityBookings");

            migrationBuilder.DropTable(
                name: "GuestReviews");

            migrationBuilder.DropTable(
                name: "InventoryPerDepartment");

            migrationBuilder.DropTable(
                name: "MaintenanceRequests");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "RoomServiceRequests");

            migrationBuilder.DropTable(
                name: "WarehouseItems");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Facilities");

            migrationBuilder.DropTable(
                name: "MenuItems");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Warehouses");

            migrationBuilder.DropTable(
                name: "Bookings");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Guests");

            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "RoomTypes");
        }
    }
}
