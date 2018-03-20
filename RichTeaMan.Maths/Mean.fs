namespace RichTeaMan.Maths

open System.Runtime.CompilerServices

[<Extension>]
type Mean = class

    /// <summary>
    /// Calculates average from the given set.
    /// </summary>
    [<Extension>]
    static member CalculateMean(set : seq<double>) =
        set |> Seq.average

    /// <summary>
    /// Calculates average from the given set.
    /// </summary>
    [<Extension>]
    static member CalculateMean(set : seq<int>) =
        set |> Seq.map(fun s -> double s) |> Seq.average

end