namespace GeneratedADONET.TableGetters
open System
open System.Data
open Microsoft.Data.SqlClient
open System.Collections.Immutable

type ISqlConnection =
    abstract Connection: SqlConnection
    abstract Transaction: SqlTransaction option

type Document1(Id: int, Code: int, Serialization: byte[], RowVersion: byte[]) =
    member _.Id = Id
    member _.Code = Code
    member _.Serialization = Serialization
    member _.RowVersion = RowVersion
    static member Execute(conn: ISqlConnection) =
        task {
            use command = new SqlCommand("SELECT * FROM [dbo].[Document]", conn.Connection)
            conn.Transaction |> Option.iter(fun t -> command.Transaction <- t)
            use! reader = command.ExecuteReaderAsync()
            let b = ImmutableArray.CreateBuilder<Document1>()
            while reader.Read() do
                b.Add(Document1(reader.GetInt32(0), reader.GetInt32(1), reader.[2] :?> byte[], reader.[3] :?> byte[]))
            return b.ToImmutable()
        }

type Document2(Id: int, Code: int, Serialization: byte[], RowVersion: byte[]) =
    member _.Id = Id
    member _.Code = Code
    member _.Serialization = Serialization
    member _.RowVersion = RowVersion
    static member Execute(conn: ISqlConnection) =
        task {
            use command = new SqlCommand("SELECT * FROM [dbo].[Document]", conn.Connection)
            conn.Transaction |> Option.iter(fun t -> command.Transaction <- t)
            use! reader = command.ExecuteReaderAsync()
            let b = ImmutableArray.CreateBuilder<Document2>()
            while reader.Read() do
                b.Add(Document2(reader.GetInt32(0), reader.GetInt32(1), reader.[2] :?> byte[], reader.[3] :?> byte[]))
            return b.ToImmutable()
        }

type Document3(Id: int, Code: int, Serialization: byte[], RowVersion: byte[]) =
    member _.Id = Id
    member _.Code = Code
    member _.Serialization = Serialization
    member _.RowVersion = RowVersion
    static member Execute(conn: ISqlConnection) =
        task {
            use command = new SqlCommand("SELECT * FROM [dbo].[Document]", conn.Connection)
            conn.Transaction |> Option.iter(fun t -> command.Transaction <- t)
            use! reader = command.ExecuteReaderAsync()
            let b = ImmutableArray.CreateBuilder<Document3>()
            while reader.Read() do
                b.Add(Document3(reader.GetInt32(0), reader.GetInt32(1), reader.[2] :?> byte[], reader.[3] :?> byte[]))
            return b.ToImmutable()
        }

type Document4(Id: int, Code: int, Serialization: byte[], RowVersion: byte[]) =
    member _.Id = Id
    member _.Code = Code
    member _.Serialization = Serialization
    member _.RowVersion = RowVersion
    static member Execute(conn: ISqlConnection) =
        task {
            use command = new SqlCommand("SELECT * FROM [dbo].[Document]", conn.Connection)
            conn.Transaction |> Option.iter(fun t -> command.Transaction <- t)
            use! reader = command.ExecuteReaderAsync()
            let b = ImmutableArray.CreateBuilder<Document4>()
            while reader.Read() do
                b.Add(Document4(reader.GetInt32(0), reader.GetInt32(1), reader.[2] :?> byte[], reader.[3] :?> byte[]))
            return b.ToImmutable()
        }

type Document5(Id: int, Code: int, Serialization: byte[], RowVersion: byte[]) =
    member _.Id = Id
    member _.Code = Code
    member _.Serialization = Serialization
    member _.RowVersion = RowVersion
    static member Execute(conn: ISqlConnection) =
        task {
            use command = new SqlCommand("SELECT * FROM [dbo].[Document]", conn.Connection)
            conn.Transaction |> Option.iter(fun t -> command.Transaction <- t)
            use! reader = command.ExecuteReaderAsync()
            let b = ImmutableArray.CreateBuilder<Document5>()
            while reader.Read() do
                b.Add(Document5(reader.GetInt32(0), reader.GetInt32(1), reader.[2] :?> byte[], reader.[3] :?> byte[]))
            return b.ToImmutable()
        }

type Document6(Id: int, Code: int, Serialization: byte[], RowVersion: byte[]) =
    member _.Id = Id
    member _.Code = Code
    member _.Serialization = Serialization
    member _.RowVersion = RowVersion
    static member Execute(conn: ISqlConnection) =
        task {
            use command = new SqlCommand("SELECT * FROM [dbo].[Document]", conn.Connection)
            conn.Transaction |> Option.iter(fun t -> command.Transaction <- t)
            use! reader = command.ExecuteReaderAsync()
            let b = ImmutableArray.CreateBuilder<Document6>()
            while reader.Read() do
                b.Add(Document6(reader.GetInt32(0), reader.GetInt32(1), reader.[2] :?> byte[], reader.[3] :?> byte[]))
            return b.ToImmutable()
        }

type Document7(Id: int, Code: int, Serialization: byte[], RowVersion: byte[]) =
    member _.Id = Id
    member _.Code = Code
    member _.Serialization = Serialization
    member _.RowVersion = RowVersion
    static member Execute(conn: ISqlConnection) =
        task {
            use command = new SqlCommand("SELECT * FROM [dbo].[Document]", conn.Connection)
            conn.Transaction |> Option.iter(fun t -> command.Transaction <- t)
            use! reader = command.ExecuteReaderAsync()
            let b = ImmutableArray.CreateBuilder<Document7>()
            while reader.Read() do
                b.Add(Document7(reader.GetInt32(0), reader.GetInt32(1), reader.[2] :?> byte[], reader.[3] :?> byte[]))
            return b.ToImmutable()
        }

type Document8(Id: int, Code: int, Serialization: byte[], RowVersion: byte[]) =
    member _.Id = Id
    member _.Code = Code
    member _.Serialization = Serialization
    member _.RowVersion = RowVersion
    static member Execute(conn: ISqlConnection) =
        task {
            use command = new SqlCommand("SELECT * FROM [dbo].[Document]", conn.Connection)
            conn.Transaction |> Option.iter(fun t -> command.Transaction <- t)
            use! reader = command.ExecuteReaderAsync()
            let b = ImmutableArray.CreateBuilder<Document8>()
            while reader.Read() do
                b.Add(Document8(reader.GetInt32(0), reader.GetInt32(1), reader.[2] :?> byte[], reader.[3] :?> byte[]))
            return b.ToImmutable()
        }

type Document9(Id: int, Code: int, Serialization: byte[], RowVersion: byte[]) =
    member _.Id = Id
    member _.Code = Code
    member _.Serialization = Serialization
    member _.RowVersion = RowVersion
    static member Execute(conn: ISqlConnection) =
        task {
            use command = new SqlCommand("SELECT * FROM [dbo].[Document]", conn.Connection)
            conn.Transaction |> Option.iter(fun t -> command.Transaction <- t)
            use! reader = command.ExecuteReaderAsync()
            let b = ImmutableArray.CreateBuilder<Document9>()
            while reader.Read() do
                b.Add(Document9(reader.GetInt32(0), reader.GetInt32(1), reader.[2] :?> byte[], reader.[3] :?> byte[]))
            return b.ToImmutable()
        }

type Document10(Id: int, Code: int, Serialization: byte[], RowVersion: byte[]) =
    member _.Id = Id
    member _.Code = Code
    member _.Serialization = Serialization
    member _.RowVersion = RowVersion
    static member Execute(conn: ISqlConnection) =
        task {
            use command = new SqlCommand("SELECT * FROM [dbo].[Document]", conn.Connection)
            conn.Transaction |> Option.iter(fun t -> command.Transaction <- t)
            use! reader = command.ExecuteReaderAsync()
            let b = ImmutableArray.CreateBuilder<Document10>()
            while reader.Read() do
                b.Add(Document10(reader.GetInt32(0), reader.GetInt32(1), reader.[2] :?> byte[], reader.[3] :?> byte[]))
            return b.ToImmutable()
        }

type Document11(Id: int, Code: int, Serialization: byte[], RowVersion: byte[]) =
    member _.Id = Id
    member _.Code = Code
    member _.Serialization = Serialization
    member _.RowVersion = RowVersion
    static member Execute(conn: ISqlConnection) =
        task {
            use command = new SqlCommand("SELECT * FROM [dbo].[Document]", conn.Connection)
            conn.Transaction |> Option.iter(fun t -> command.Transaction <- t)
            use! reader = command.ExecuteReaderAsync()
            let b = ImmutableArray.CreateBuilder<Document11>()
            while reader.Read() do
                b.Add(Document11(reader.GetInt32(0), reader.GetInt32(1), reader.[2] :?> byte[], reader.[3] :?> byte[]))
            return b.ToImmutable()
        }

type Document12(Id: int, Code: int, Serialization: byte[], RowVersion: byte[]) =
    member _.Id = Id
    member _.Code = Code
    member _.Serialization = Serialization
    member _.RowVersion = RowVersion
    static member Execute(conn: ISqlConnection) =
        task {
            use command = new SqlCommand("SELECT * FROM [dbo].[Document]", conn.Connection)
            conn.Transaction |> Option.iter(fun t -> command.Transaction <- t)
            use! reader = command.ExecuteReaderAsync()
            let b = ImmutableArray.CreateBuilder<Document12>()
            while reader.Read() do
                b.Add(Document12(reader.GetInt32(0), reader.GetInt32(1), reader.[2] :?> byte[], reader.[3] :?> byte[]))
            return b.ToImmutable()
        }

type Document13(Id: int, Code: int, Serialization: byte[], RowVersion: byte[]) =
    member _.Id = Id
    member _.Code = Code
    member _.Serialization = Serialization
    member _.RowVersion = RowVersion
    static member Execute(conn: ISqlConnection) =
        task {
            use command = new SqlCommand("SELECT * FROM [dbo].[Document]", conn.Connection)
            conn.Transaction |> Option.iter(fun t -> command.Transaction <- t)
            use! reader = command.ExecuteReaderAsync()
            let b = ImmutableArray.CreateBuilder<Document13>()
            while reader.Read() do
                b.Add(Document13(reader.GetInt32(0), reader.GetInt32(1), reader.[2] :?> byte[], reader.[3] :?> byte[]))
            return b.ToImmutable()
        }

type Document14(Id: int, Code: int, Serialization: byte[], RowVersion: byte[]) =
    member _.Id = Id
    member _.Code = Code
    member _.Serialization = Serialization
    member _.RowVersion = RowVersion
    static member Execute(conn: ISqlConnection) =
        task {
            use command = new SqlCommand("SELECT * FROM [dbo].[Document]", conn.Connection)
            conn.Transaction |> Option.iter(fun t -> command.Transaction <- t)
            use! reader = command.ExecuteReaderAsync()
            let b = ImmutableArray.CreateBuilder<Document14>()
            while reader.Read() do
                b.Add(Document14(reader.GetInt32(0), reader.GetInt32(1), reader.[2] :?> byte[], reader.[3] :?> byte[]))
            return b.ToImmutable()
        }

type Document15(Id: int, Code: int, Serialization: byte[], RowVersion: byte[]) =
    member _.Id = Id
    member _.Code = Code
    member _.Serialization = Serialization
    member _.RowVersion = RowVersion
    static member Execute(conn: ISqlConnection) =
        task {
            use command = new SqlCommand("SELECT * FROM [dbo].[Document]", conn.Connection)
            conn.Transaction |> Option.iter(fun t -> command.Transaction <- t)
            use! reader = command.ExecuteReaderAsync()
            let b = ImmutableArray.CreateBuilder<Document15>()
            while reader.Read() do
                b.Add(Document15(reader.GetInt32(0), reader.GetInt32(1), reader.[2] :?> byte[], reader.[3] :?> byte[]))
            return b.ToImmutable()
        }

type Document16(Id: int, Code: int, Serialization: byte[], RowVersion: byte[]) =
    member _.Id = Id
    member _.Code = Code
    member _.Serialization = Serialization
    member _.RowVersion = RowVersion
    static member Execute(conn: ISqlConnection) =
        task {
            use command = new SqlCommand("SELECT * FROM [dbo].[Document]", conn.Connection)
            conn.Transaction |> Option.iter(fun t -> command.Transaction <- t)
            use! reader = command.ExecuteReaderAsync()
            let b = ImmutableArray.CreateBuilder<Document16>()
            while reader.Read() do
                b.Add(Document16(reader.GetInt32(0), reader.GetInt32(1), reader.[2] :?> byte[], reader.[3] :?> byte[]))
            return b.ToImmutable()
        }

type Document17(Id: int, Code: int, Serialization: byte[], RowVersion: byte[]) =
    member _.Id = Id
    member _.Code = Code
    member _.Serialization = Serialization
    member _.RowVersion = RowVersion
    static member Execute(conn: ISqlConnection) =
        task {
            use command = new SqlCommand("SELECT * FROM [dbo].[Document]", conn.Connection)
            conn.Transaction |> Option.iter(fun t -> command.Transaction <- t)
            use! reader = command.ExecuteReaderAsync()
            let b = ImmutableArray.CreateBuilder<Document17>()
            while reader.Read() do
                b.Add(Document17(reader.GetInt32(0), reader.GetInt32(1), reader.[2] :?> byte[], reader.[3] :?> byte[]))
            return b.ToImmutable()
        }

type Document18(Id: int, Code: int, Serialization: byte[], RowVersion: byte[]) =
    member _.Id = Id
    member _.Code = Code
    member _.Serialization = Serialization
    member _.RowVersion = RowVersion
    static member Execute(conn: ISqlConnection) =
        task {
            use command = new SqlCommand("SELECT * FROM [dbo].[Document]", conn.Connection)
            conn.Transaction |> Option.iter(fun t -> command.Transaction <- t)
            use! reader = command.ExecuteReaderAsync()
            let b = ImmutableArray.CreateBuilder<Document18>()
            while reader.Read() do
                b.Add(Document18(reader.GetInt32(0), reader.GetInt32(1), reader.[2] :?> byte[], reader.[3] :?> byte[]))
            return b.ToImmutable()
        }

type Document19(Id: int, Code: int, Serialization: byte[], RowVersion: byte[]) =
    member _.Id = Id
    member _.Code = Code
    member _.Serialization = Serialization
    member _.RowVersion = RowVersion
    static member Execute(conn: ISqlConnection) =
        task {
            use command = new SqlCommand("SELECT * FROM [dbo].[Document]", conn.Connection)
            conn.Transaction |> Option.iter(fun t -> command.Transaction <- t)
            use! reader = command.ExecuteReaderAsync()
            let b = ImmutableArray.CreateBuilder<Document19>()
            while reader.Read() do
                b.Add(Document19(reader.GetInt32(0), reader.GetInt32(1), reader.[2] :?> byte[], reader.[3] :?> byte[]))
            return b.ToImmutable()
        }

type Document20(Id: int, Code: int, Serialization: byte[], RowVersion: byte[]) =
    member _.Id = Id
    member _.Code = Code
    member _.Serialization = Serialization
    member _.RowVersion = RowVersion
    static member Execute(conn: ISqlConnection) =
        task {
            use command = new SqlCommand("SELECT * FROM [dbo].[Document]", conn.Connection)
            conn.Transaction |> Option.iter(fun t -> command.Transaction <- t)
            use! reader = command.ExecuteReaderAsync()
            let b = ImmutableArray.CreateBuilder<Document20>()
            while reader.Read() do
                b.Add(Document20(reader.GetInt32(0), reader.GetInt32(1), reader.[2] :?> byte[], reader.[3] :?> byte[]))
            return b.ToImmutable()
        }

type Document21(Id: int, Code: int, Serialization: byte[], RowVersion: byte[]) =
    member _.Id = Id
    member _.Code = Code
    member _.Serialization = Serialization
    member _.RowVersion = RowVersion
    static member Execute(conn: ISqlConnection) =
        task {
            use command = new SqlCommand("SELECT * FROM [dbo].[Document]", conn.Connection)
            conn.Transaction |> Option.iter(fun t -> command.Transaction <- t)
            use! reader = command.ExecuteReaderAsync()
            let b = ImmutableArray.CreateBuilder<Document21>()
            while reader.Read() do
                b.Add(Document21(reader.GetInt32(0), reader.GetInt32(1), reader.[2] :?> byte[], reader.[3] :?> byte[]))
            return b.ToImmutable()
        }

type Document22(Id: int, Code: int, Serialization: byte[], RowVersion: byte[]) =
    member _.Id = Id
    member _.Code = Code
    member _.Serialization = Serialization
    member _.RowVersion = RowVersion
    static member Execute(conn: ISqlConnection) =
        task {
            use command = new SqlCommand("SELECT * FROM [dbo].[Document]", conn.Connection)
            conn.Transaction |> Option.iter(fun t -> command.Transaction <- t)
            use! reader = command.ExecuteReaderAsync()
            let b = ImmutableArray.CreateBuilder<Document22>()
            while reader.Read() do
                b.Add(Document22(reader.GetInt32(0), reader.GetInt32(1), reader.[2] :?> byte[], reader.[3] :?> byte[]))
            return b.ToImmutable()
        }

type Document23(Id: int, Code: int, Serialization: byte[], RowVersion: byte[]) =
    member _.Id = Id
    member _.Code = Code
    member _.Serialization = Serialization
    member _.RowVersion = RowVersion
    static member Execute(conn: ISqlConnection) =
        task {
            use command = new SqlCommand("SELECT * FROM [dbo].[Document]", conn.Connection)
            conn.Transaction |> Option.iter(fun t -> command.Transaction <- t)
            use! reader = command.ExecuteReaderAsync()
            let b = ImmutableArray.CreateBuilder<Document23>()
            while reader.Read() do
                b.Add(Document23(reader.GetInt32(0), reader.GetInt32(1), reader.[2] :?> byte[], reader.[3] :?> byte[]))
            return b.ToImmutable()
        }

type Document24(Id: int, Code: int, Serialization: byte[], RowVersion: byte[]) =
    member _.Id = Id
    member _.Code = Code
    member _.Serialization = Serialization
    member _.RowVersion = RowVersion
    static member Execute(conn: ISqlConnection) =
        task {
            use command = new SqlCommand("SELECT * FROM [dbo].[Document]", conn.Connection)
            conn.Transaction |> Option.iter(fun t -> command.Transaction <- t)
            use! reader = command.ExecuteReaderAsync()
            let b = ImmutableArray.CreateBuilder<Document24>()
            while reader.Read() do
                b.Add(Document24(reader.GetInt32(0), reader.GetInt32(1), reader.[2] :?> byte[], reader.[3] :?> byte[]))
            return b.ToImmutable()
        }

type Document25(Id: int, Code: int, Serialization: byte[], RowVersion: byte[]) =
    member _.Id = Id
    member _.Code = Code
    member _.Serialization = Serialization
    member _.RowVersion = RowVersion
    static member Execute(conn: ISqlConnection) =
        task {
            use command = new SqlCommand("SELECT * FROM [dbo].[Document]", conn.Connection)
            conn.Transaction |> Option.iter(fun t -> command.Transaction <- t)
            use! reader = command.ExecuteReaderAsync()
            let b = ImmutableArray.CreateBuilder<Document25>()
            while reader.Read() do
                b.Add(Document25(reader.GetInt32(0), reader.GetInt32(1), reader.[2] :?> byte[], reader.[3] :?> byte[]))
            return b.ToImmutable()
        }

type Document26(Id: int, Code: int, Serialization: byte[], RowVersion: byte[]) =
    member _.Id = Id
    member _.Code = Code
    member _.Serialization = Serialization
    member _.RowVersion = RowVersion
    static member Execute(conn: ISqlConnection) =
        task {
            use command = new SqlCommand("SELECT * FROM [dbo].[Document]", conn.Connection)
            conn.Transaction |> Option.iter(fun t -> command.Transaction <- t)
            use! reader = command.ExecuteReaderAsync()
            let b = ImmutableArray.CreateBuilder<Document26>()
            while reader.Read() do
                b.Add(Document26(reader.GetInt32(0), reader.GetInt32(1), reader.[2] :?> byte[], reader.[3] :?> byte[]))
            return b.ToImmutable()
        }

type Document27(Id: int, Code: int, Serialization: byte[], RowVersion: byte[]) =
    member _.Id = Id
    member _.Code = Code
    member _.Serialization = Serialization
    member _.RowVersion = RowVersion
    static member Execute(conn: ISqlConnection) =
        task {
            use command = new SqlCommand("SELECT * FROM [dbo].[Document]", conn.Connection)
            conn.Transaction |> Option.iter(fun t -> command.Transaction <- t)
            use! reader = command.ExecuteReaderAsync()
            let b = ImmutableArray.CreateBuilder<Document27>()
            while reader.Read() do
                b.Add(Document27(reader.GetInt32(0), reader.GetInt32(1), reader.[2] :?> byte[], reader.[3] :?> byte[]))
            return b.ToImmutable()
        }

type Document28(Id: int, Code: int, Serialization: byte[], RowVersion: byte[]) =
    member _.Id = Id
    member _.Code = Code
    member _.Serialization = Serialization
    member _.RowVersion = RowVersion
    static member Execute(conn: ISqlConnection) =
        task {
            use command = new SqlCommand("SELECT * FROM [dbo].[Document]", conn.Connection)
            conn.Transaction |> Option.iter(fun t -> command.Transaction <- t)
            use! reader = command.ExecuteReaderAsync()
            let b = ImmutableArray.CreateBuilder<Document28>()
            while reader.Read() do
                b.Add(Document28(reader.GetInt32(0), reader.GetInt32(1), reader.[2] :?> byte[], reader.[3] :?> byte[]))
            return b.ToImmutable()
        }

type Document29(Id: int, Code: int, Serialization: byte[], RowVersion: byte[]) =
    member _.Id = Id
    member _.Code = Code
    member _.Serialization = Serialization
    member _.RowVersion = RowVersion
    static member Execute(conn: ISqlConnection) =
        task {
            use command = new SqlCommand("SELECT * FROM [dbo].[Document]", conn.Connection)
            conn.Transaction |> Option.iter(fun t -> command.Transaction <- t)
            use! reader = command.ExecuteReaderAsync()
            let b = ImmutableArray.CreateBuilder<Document29>()
            while reader.Read() do
                b.Add(Document29(reader.GetInt32(0), reader.GetInt32(1), reader.[2] :?> byte[], reader.[3] :?> byte[]))
            return b.ToImmutable()
        }

type Document30(Id: int, Code: int, Serialization: byte[], RowVersion: byte[]) =
    member _.Id = Id
    member _.Code = Code
    member _.Serialization = Serialization
    member _.RowVersion = RowVersion
    static member Execute(conn: ISqlConnection) =
        task {
            use command = new SqlCommand("SELECT * FROM [dbo].[Document]", conn.Connection)
            conn.Transaction |> Option.iter(fun t -> command.Transaction <- t)
            use! reader = command.ExecuteReaderAsync()
            let b = ImmutableArray.CreateBuilder<Document30>()
            while reader.Read() do
                b.Add(Document30(reader.GetInt32(0), reader.GetInt32(1), reader.[2] :?> byte[], reader.[3] :?> byte[]))
            return b.ToImmutable()
        }

type Document31(Id: int, Code: int, Serialization: byte[], RowVersion: byte[]) =
    member _.Id = Id
    member _.Code = Code
    member _.Serialization = Serialization
    member _.RowVersion = RowVersion
    static member Execute(conn: ISqlConnection) =
        task {
            use command = new SqlCommand("SELECT * FROM [dbo].[Document]", conn.Connection)
            conn.Transaction |> Option.iter(fun t -> command.Transaction <- t)
            use! reader = command.ExecuteReaderAsync()
            let b = ImmutableArray.CreateBuilder<Document31>()
            while reader.Read() do
                b.Add(Document31(reader.GetInt32(0), reader.GetInt32(1), reader.[2] :?> byte[], reader.[3] :?> byte[]))
            return b.ToImmutable()
        }

type Document32(Id: int, Code: int, Serialization: byte[], RowVersion: byte[]) =
    member _.Id = Id
    member _.Code = Code
    member _.Serialization = Serialization
    member _.RowVersion = RowVersion
    static member Execute(conn: ISqlConnection) =
        task {
            use command = new SqlCommand("SELECT * FROM [dbo].[Document]", conn.Connection)
            conn.Transaction |> Option.iter(fun t -> command.Transaction <- t)
            use! reader = command.ExecuteReaderAsync()
            let b = ImmutableArray.CreateBuilder<Document32>()
            while reader.Read() do
                b.Add(Document32(reader.GetInt32(0), reader.GetInt32(1), reader.[2] :?> byte[], reader.[3] :?> byte[]))
            return b.ToImmutable()
        }

type Document33(Id: int, Code: int, Serialization: byte[], RowVersion: byte[]) =
    member _.Id = Id
    member _.Code = Code
    member _.Serialization = Serialization
    member _.RowVersion = RowVersion
    static member Execute(conn: ISqlConnection) =
        task {
            use command = new SqlCommand("SELECT * FROM [dbo].[Document]", conn.Connection)
            conn.Transaction |> Option.iter(fun t -> command.Transaction <- t)
            use! reader = command.ExecuteReaderAsync()
            let b = ImmutableArray.CreateBuilder<Document33>()
            while reader.Read() do
                b.Add(Document33(reader.GetInt32(0), reader.GetInt32(1), reader.[2] :?> byte[], reader.[3] :?> byte[]))
            return b.ToImmutable()
        }

type Document34(Id: int, Code: int, Serialization: byte[], RowVersion: byte[]) =
    member _.Id = Id
    member _.Code = Code
    member _.Serialization = Serialization
    member _.RowVersion = RowVersion
    static member Execute(conn: ISqlConnection) =
        task {
            use command = new SqlCommand("SELECT * FROM [dbo].[Document]", conn.Connection)
            conn.Transaction |> Option.iter(fun t -> command.Transaction <- t)
            use! reader = command.ExecuteReaderAsync()
            let b = ImmutableArray.CreateBuilder<Document34>()
            while reader.Read() do
                b.Add(Document34(reader.GetInt32(0), reader.GetInt32(1), reader.[2] :?> byte[], reader.[3] :?> byte[]))
            return b.ToImmutable()
        }

type Document35(Id: int, Code: int, Serialization: byte[], RowVersion: byte[]) =
    member _.Id = Id
    member _.Code = Code
    member _.Serialization = Serialization
    member _.RowVersion = RowVersion
    static member Execute(conn: ISqlConnection) =
        task {
            use command = new SqlCommand("SELECT * FROM [dbo].[Document]", conn.Connection)
            conn.Transaction |> Option.iter(fun t -> command.Transaction <- t)
            use! reader = command.ExecuteReaderAsync()
            let b = ImmutableArray.CreateBuilder<Document35>()
            while reader.Read() do
                b.Add(Document35(reader.GetInt32(0), reader.GetInt32(1), reader.[2] :?> byte[], reader.[3] :?> byte[]))
            return b.ToImmutable()
        }

type Document36(Id: int, Code: int, Serialization: byte[], RowVersion: byte[]) =
    member _.Id = Id
    member _.Code = Code
    member _.Serialization = Serialization
    member _.RowVersion = RowVersion
    static member Execute(conn: ISqlConnection) =
        task {
            use command = new SqlCommand("SELECT * FROM [dbo].[Document]", conn.Connection)
            conn.Transaction |> Option.iter(fun t -> command.Transaction <- t)
            use! reader = command.ExecuteReaderAsync()
            let b = ImmutableArray.CreateBuilder<Document36>()
            while reader.Read() do
                b.Add(Document36(reader.GetInt32(0), reader.GetInt32(1), reader.[2] :?> byte[], reader.[3] :?> byte[]))
            return b.ToImmutable()
        }

type Document37(Id: int, Code: int, Serialization: byte[], RowVersion: byte[]) =
    member _.Id = Id
    member _.Code = Code
    member _.Serialization = Serialization
    member _.RowVersion = RowVersion
    static member Execute(conn: ISqlConnection) =
        task {
            use command = new SqlCommand("SELECT * FROM [dbo].[Document]", conn.Connection)
            conn.Transaction |> Option.iter(fun t -> command.Transaction <- t)
            use! reader = command.ExecuteReaderAsync()
            let b = ImmutableArray.CreateBuilder<Document37>()
            while reader.Read() do
                b.Add(Document37(reader.GetInt32(0), reader.GetInt32(1), reader.[2] :?> byte[], reader.[3] :?> byte[]))
            return b.ToImmutable()
        }

type Document38(Id: int, Code: int, Serialization: byte[], RowVersion: byte[]) =
    member _.Id = Id
    member _.Code = Code
    member _.Serialization = Serialization
    member _.RowVersion = RowVersion
    static member Execute(conn: ISqlConnection) =
        task {
            use command = new SqlCommand("SELECT * FROM [dbo].[Document]", conn.Connection)
            conn.Transaction |> Option.iter(fun t -> command.Transaction <- t)
            use! reader = command.ExecuteReaderAsync()
            let b = ImmutableArray.CreateBuilder<Document38>()
            while reader.Read() do
                b.Add(Document38(reader.GetInt32(0), reader.GetInt32(1), reader.[2] :?> byte[], reader.[3] :?> byte[]))
            return b.ToImmutable()
        }

type Document39(Id: int, Code: int, Serialization: byte[], RowVersion: byte[]) =
    member _.Id = Id
    member _.Code = Code
    member _.Serialization = Serialization
    member _.RowVersion = RowVersion
    static member Execute(conn: ISqlConnection) =
        task {
            use command = new SqlCommand("SELECT * FROM [dbo].[Document]", conn.Connection)
            conn.Transaction |> Option.iter(fun t -> command.Transaction <- t)
            use! reader = command.ExecuteReaderAsync()
            let b = ImmutableArray.CreateBuilder<Document39>()
            while reader.Read() do
                b.Add(Document39(reader.GetInt32(0), reader.GetInt32(1), reader.[2] :?> byte[], reader.[3] :?> byte[]))
            return b.ToImmutable()
        }

type Document40(Id: int, Code: int, Serialization: byte[], RowVersion: byte[]) =
    member _.Id = Id
    member _.Code = Code
    member _.Serialization = Serialization
    member _.RowVersion = RowVersion
    static member Execute(conn: ISqlConnection) =
        task {
            use command = new SqlCommand("SELECT * FROM [dbo].[Document]", conn.Connection)
            conn.Transaction |> Option.iter(fun t -> command.Transaction <- t)
            use! reader = command.ExecuteReaderAsync()
            let b = ImmutableArray.CreateBuilder<Document40>()
            while reader.Read() do
                b.Add(Document40(reader.GetInt32(0), reader.GetInt32(1), reader.[2] :?> byte[], reader.[3] :?> byte[]))
            return b.ToImmutable()
        }

type Document41(Id: int, Code: int, Serialization: byte[], RowVersion: byte[]) =
    member _.Id = Id
    member _.Code = Code
    member _.Serialization = Serialization
    member _.RowVersion = RowVersion
    static member Execute(conn: ISqlConnection) =
        task {
            use command = new SqlCommand("SELECT * FROM [dbo].[Document]", conn.Connection)
            conn.Transaction |> Option.iter(fun t -> command.Transaction <- t)
            use! reader = command.ExecuteReaderAsync()
            let b = ImmutableArray.CreateBuilder<Document41>()
            while reader.Read() do
                b.Add(Document41(reader.GetInt32(0), reader.GetInt32(1), reader.[2] :?> byte[], reader.[3] :?> byte[]))
            return b.ToImmutable()
        }

type Document42(Id: int, Code: int, Serialization: byte[], RowVersion: byte[]) =
    member _.Id = Id
    member _.Code = Code
    member _.Serialization = Serialization
    member _.RowVersion = RowVersion
    static member Execute(conn: ISqlConnection) =
        task {
            use command = new SqlCommand("SELECT * FROM [dbo].[Document]", conn.Connection)
            conn.Transaction |> Option.iter(fun t -> command.Transaction <- t)
            use! reader = command.ExecuteReaderAsync()
            let b = ImmutableArray.CreateBuilder<Document42>()
            while reader.Read() do
                b.Add(Document42(reader.GetInt32(0), reader.GetInt32(1), reader.[2] :?> byte[], reader.[3] :?> byte[]))
            return b.ToImmutable()
        }

type Document43(Id: int, Code: int, Serialization: byte[], RowVersion: byte[]) =
    member _.Id = Id
    member _.Code = Code
    member _.Serialization = Serialization
    member _.RowVersion = RowVersion
    static member Execute(conn: ISqlConnection) =
        task {
            use command = new SqlCommand("SELECT * FROM [dbo].[Document]", conn.Connection)
            conn.Transaction |> Option.iter(fun t -> command.Transaction <- t)
            use! reader = command.ExecuteReaderAsync()
            let b = ImmutableArray.CreateBuilder<Document43>()
            while reader.Read() do
                b.Add(Document43(reader.GetInt32(0), reader.GetInt32(1), reader.[2] :?> byte[], reader.[3] :?> byte[]))
            return b.ToImmutable()
        }

type Document44(Id: int, Code: int, Serialization: byte[], RowVersion: byte[]) =
    member _.Id = Id
    member _.Code = Code
    member _.Serialization = Serialization
    member _.RowVersion = RowVersion
    static member Execute(conn: ISqlConnection) =
        task {
            use command = new SqlCommand("SELECT * FROM [dbo].[Document]", conn.Connection)
            conn.Transaction |> Option.iter(fun t -> command.Transaction <- t)
            use! reader = command.ExecuteReaderAsync()
            let b = ImmutableArray.CreateBuilder<Document44>()
            while reader.Read() do
                b.Add(Document44(reader.GetInt32(0), reader.GetInt32(1), reader.[2] :?> byte[], reader.[3] :?> byte[]))
            return b.ToImmutable()
        }

type Document45(Id: int, Code: int, Serialization: byte[], RowVersion: byte[]) =
    member _.Id = Id
    member _.Code = Code
    member _.Serialization = Serialization
    member _.RowVersion = RowVersion
    static member Execute(conn: ISqlConnection) =
        task {
            use command = new SqlCommand("SELECT * FROM [dbo].[Document]", conn.Connection)
            conn.Transaction |> Option.iter(fun t -> command.Transaction <- t)
            use! reader = command.ExecuteReaderAsync()
            let b = ImmutableArray.CreateBuilder<Document45>()
            while reader.Read() do
                b.Add(Document45(reader.GetInt32(0), reader.GetInt32(1), reader.[2] :?> byte[], reader.[3] :?> byte[]))
            return b.ToImmutable()
        }

type Document46(Id: int, Code: int, Serialization: byte[], RowVersion: byte[]) =
    member _.Id = Id
    member _.Code = Code
    member _.Serialization = Serialization
    member _.RowVersion = RowVersion
    static member Execute(conn: ISqlConnection) =
        task {
            use command = new SqlCommand("SELECT * FROM [dbo].[Document]", conn.Connection)
            conn.Transaction |> Option.iter(fun t -> command.Transaction <- t)
            use! reader = command.ExecuteReaderAsync()
            let b = ImmutableArray.CreateBuilder<Document46>()
            while reader.Read() do
                b.Add(Document46(reader.GetInt32(0), reader.GetInt32(1), reader.[2] :?> byte[], reader.[3] :?> byte[]))
            return b.ToImmutable()
        }

type Document47(Id: int, Code: int, Serialization: byte[], RowVersion: byte[]) =
    member _.Id = Id
    member _.Code = Code
    member _.Serialization = Serialization
    member _.RowVersion = RowVersion
    static member Execute(conn: ISqlConnection) =
        task {
            use command = new SqlCommand("SELECT * FROM [dbo].[Document]", conn.Connection)
            conn.Transaction |> Option.iter(fun t -> command.Transaction <- t)
            use! reader = command.ExecuteReaderAsync()
            let b = ImmutableArray.CreateBuilder<Document47>()
            while reader.Read() do
                b.Add(Document47(reader.GetInt32(0), reader.GetInt32(1), reader.[2] :?> byte[], reader.[3] :?> byte[]))
            return b.ToImmutable()
        }

type Document48(Id: int, Code: int, Serialization: byte[], RowVersion: byte[]) =
    member _.Id = Id
    member _.Code = Code
    member _.Serialization = Serialization
    member _.RowVersion = RowVersion
    static member Execute(conn: ISqlConnection) =
        task {
            use command = new SqlCommand("SELECT * FROM [dbo].[Document]", conn.Connection)
            conn.Transaction |> Option.iter(fun t -> command.Transaction <- t)
            use! reader = command.ExecuteReaderAsync()
            let b = ImmutableArray.CreateBuilder<Document48>()
            while reader.Read() do
                b.Add(Document48(reader.GetInt32(0), reader.GetInt32(1), reader.[2] :?> byte[], reader.[3] :?> byte[]))
            return b.ToImmutable()
        }

type Document49(Id: int, Code: int, Serialization: byte[], RowVersion: byte[]) =
    member _.Id = Id
    member _.Code = Code
    member _.Serialization = Serialization
    member _.RowVersion = RowVersion
    static member Execute(conn: ISqlConnection) =
        task {
            use command = new SqlCommand("SELECT * FROM [dbo].[Document]", conn.Connection)
            conn.Transaction |> Option.iter(fun t -> command.Transaction <- t)
            use! reader = command.ExecuteReaderAsync()
            let b = ImmutableArray.CreateBuilder<Document49>()
            while reader.Read() do
                b.Add(Document49(reader.GetInt32(0), reader.GetInt32(1), reader.[2] :?> byte[], reader.[3] :?> byte[]))
            return b.ToImmutable()
        }

type Document50(Id: int, Code: int, Serialization: byte[], RowVersion: byte[]) =
    member _.Id = Id
    member _.Code = Code
    member _.Serialization = Serialization
    member _.RowVersion = RowVersion
    static member Execute(conn: ISqlConnection) =
        task {
            use command = new SqlCommand("SELECT * FROM [dbo].[Document]", conn.Connection)
            conn.Transaction |> Option.iter(fun t -> command.Transaction <- t)
            use! reader = command.ExecuteReaderAsync()
            let b = ImmutableArray.CreateBuilder<Document50>()
            while reader.Read() do
                b.Add(Document50(reader.GetInt32(0), reader.GetInt32(1), reader.[2] :?> byte[], reader.[3] :?> byte[]))
            return b.ToImmutable()
        }