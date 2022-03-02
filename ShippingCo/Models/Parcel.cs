using System.Collections.Generic;

namespace ShippingCo.Models {
  public class Parcel {
    public int Length { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }
    public int Weight { get; set; }


    public Parcel (int length, int width, int height, int weight) {
      Length = length;
      Width = width;
      Height = height; 
      Weight = weight;
    }
    public int GetVolume(int length, int width, int height) {
      // Parcel parcel = new Parcel(5, 6, 7, 8);
      // int volume = parcel.length * parcel.width * parcel.height;
      int volume = length * width * height;
      return volume;
    }
    public int GetCost(int weight) {
      int cost = 0;
      if (weight <= 5) {
        cost += 5;
      } else if (weight > 25) {
        cost += 25;
      } else {
        cost += 15;
      }
    return cost;
    }
  }
}