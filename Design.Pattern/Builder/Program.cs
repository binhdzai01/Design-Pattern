//using Builder;

//// Builder Interitance
////var me = Person.New
////  .Called("Dmitri")
////  .WorksAsA("Quant")
////  .Born(DateTime.UtcNow)
////  .Build();
////Console.WriteLine(me);

////// Builder Stepwise
////var car = CarBuilder.Create()
////    .OfType(CarType.Crossover)
////    .WithWheels(15)
////    .Build();

//// Builder Faceted
//var pb = new PersonBuilder();
//Person person = pb
//  .Lives
//    .At("123 London Road")
//    .In("London")
//    .WithPostcode("SW12BC")
//  .Works
//    .At("Fabrikam")
//    .AsA("Engineer")
//    .Earning(123000);

//Console.WriteLine(person);