using BenchmarkDotNet.Running;
using ConsoleApplication;

//BenchmarkRunner.Run<StringMethods>();
//StringMethods stringMethods = new StringMethods();


#region StartsWith
//stringMethods.StartsWithStringValue();
//stringMethods.StartsWithCharValue();
#endregion


//#region ToUpper/ToLower/Equals

//stringMethods.AreStringEqualForUpper();
//stringMethods.AreStringEqual();
//#endregion


BenchmarkRunner.Run<CollectionMethods>();
CollectionMethods collectionMethods = new CollectionMethods();
collectionMethods.HasSkodaForCount();
collectionMethods.HasSkodaForAny();