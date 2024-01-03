namespace ConsoleApplication
{
    public class StringMethods
    {
        //#region StartsWith
        //[Benchmark(Baseline = true)]
        ///// <summary>
        ///// Doğru Kullanım
        ///// </summary>
        ///// <returns></returns>
        //public bool StartsWithCharValue()
        //{
        //    string text = "Emre Can Ayar";
        //    return text.StartsWith('E');
        //}

        //[Benchmark]
        ///// <summary>
        ///// Yanlış Kullanım
        ///// </summary>
        ///// <returns></returns>
        //public bool StartsWithStringValue()
        //{
        //    string text = "Emre Can Ayar";
        //    return text.StartsWith("E");
        //}
        //#endregion

        //#region ToUpper/ToLower/Equals

        //[Benchmark]
        ///// <summary>
        ///// Yanlış Kullanım
        ///// </summary>
        ///// <returns></returns>
        //public bool AreStringEqualForUpper()
        //{
        //    string first = "Emre Can Ayar";
        //    string second = "Emre Can Ayar";
        //    return first.ToUpper() == second.ToUpper();
        //}

        //[Benchmark(Baseline = true)]
        ///// <summary>
        ///// Doğru Kullanım
        ///// </summary>
        ///// <returns></returns>
        //public bool AreStringEqual()
        //{
        //    string first = "Emre Can Ayar";
        //    string second = "Emre Can Ayar";
        //    return string.Equals(first, second, StringComparison.OrdinalIgnoreCase);
        //}
        //#endregion
    }
}
