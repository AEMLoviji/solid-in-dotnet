using SOLID_NET.Ideas.D.Fixed;
using SOLID_NET.Ideas.I.Fixed;
using SOLID_NET.Ideas.S.Fixed;

// SRP example
Store store = new(
    reader: new ProductReader(),
    binder: new ProductBinder(),
    validator: new ProductValidator(),
    saver: new TextProductSaver()
);

store.AddNewProduct();

// ISP example
ICaller caller = new SmartPhone();

MyOldGoodFriend myOldGoodFriend = new();
myOldGoodFriend.Call(caller);

// DIP example
ITransport transport = new Car();
Product product = new(name: "iphone 12 pro", transport);
product.MoveTo("LA");


