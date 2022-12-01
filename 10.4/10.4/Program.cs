//Порушено принцип розділення інтерфейсу
using System.Runtime.CompilerServices;

interface IItem
{  
    void SetPrice(double price);
}

interface IDiscount
{
    void ApplyDiscount(String discount);
}

interface IPromocode
{
    void ApplyPromocode(String promocode);
}

interface IClothing
{
    void SetColor(byte color);
    void SetSize(byte size);
}

class Book: IItem, IDiscount
{
    public void SetPrice(double price)
    {

    }
    public void ApplyDiscount(String discount)
    {

    }

}

class Clothing : IItem, IClothing, IDiscount
{
    public void SetPrice(double price)
    {

    }

    public void ApplyDiscount(String discount)
    {

    }

    public void SetColor(byte color)
    {

    }
    public void SetSize(byte size)
    {

    }
}
