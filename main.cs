using System;
using System.Collections.Generic;

class OrderDetail {
  public int id; 
  public double amount; 
  public double quantity;
  public OrderDetail(int id, double amount, double quantity) {
    this.id = id; 
    this.amount = amount; 
    this.quantity = quantity; 
  }
}
class Order { 
  public int id; 
  public double total; 
  public List<OrderDetail> detail; 

}
class MainClass {
 

  public static void Main (string[] args) {
    var Orders = new List<Order>() {
        new Order() {
          id = 1,
          total = 0.0,
          detail = new List<OrderDetail>() {
            new OrderDetail(1, 100, 15),
            new OrderDetail(2, 150, 105),
            new OrderDetail(3, 300, 10)
          }
        },
        new Order() {
          id = 1,
          total = 0.0,
          detail = new List<OrderDetail>() {
            new OrderDetail(4, 1000, 5),
            new OrderDetail(5, 300, 30),
            new OrderDetail(6, 1500, 1)
          }
        },
        new Order() {
          id = 1,
          total = 0.0,
          detail = new List<OrderDetail>() {
            new OrderDetail(7, 450, 15),
            new OrderDetail(8, 800, 15),
            new OrderDetail(9, 300, 15)
          }
        },
        new Order() {
          id = 1,
          total = 0.0,
          detail = new List<OrderDetail>() {
            new OrderDetail(10, 1000, 12),
            new OrderDetail(11, 10, 11),
            new OrderDetail(12, 15, 100)
          }
        },
        new Order() {
          id = 1,
          total = 0.0,
          detail = new List<OrderDetail>() {
            new OrderDetail(13, 200, 9),
            new OrderDetail(14, 100, 15),
            new OrderDetail(15, 100, 15)
          }
        }

    };

var cantordenes =  Orders.Count;
Console.WriteLine("Count: {0}",cantordenes);

if(cantordenes > 0){
foreach(Order sorder in Orders){
 int sorderid = sorder.id;
 double sordertotal = sorder.total;

foreach(OrderDetail od in sorder.detail){
int idod= od.id;
double amountod= od.amount;
double quantityod = od.quantity;

double totalod= amountod*quantityod;

Console.WriteLine("El id de su orden es: "+idod+" El total de su orden es: "+totalod);
}

}

//    foreach(OrderDetail OD in sorder
// Console.WriteLine(OD.amount);
}

  }
}