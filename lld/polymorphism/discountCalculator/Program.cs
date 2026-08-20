var processor = new OrderProcessor();

processor.ProcessOrder("Laptop", 999.99, new PercentageDiscount(20));
processor.ProcessOrder("Headphones", 49.99, new FlatDiscount(15));
processor.ProcessOrder("Keyboard", 79.98, new BuyOneGetOneFree());