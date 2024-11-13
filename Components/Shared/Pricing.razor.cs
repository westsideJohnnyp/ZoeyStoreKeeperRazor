namespace ZoeyStoreKeeperLandingPage.Components.Shared;

public partial class Pricing
{
    double basicPrice = 200;
    double standardPrice = 500;
    double premiumPrice = 1000;
    
    void daily()
    {
        basicPrice = 200;
        standardPrice = 500;
        premiumPrice = 1000;
    }

    void monthly()
    {
        basicPrice = 6200;
        standardPrice = 12400;
        premiumPrice = 18600;
    }

    void quaterly()
    {
        basicPrice = 18600;
        standardPrice = 37200;
        premiumPrice = 55800;
    }

    void yearly()
    {
        basicPrice = 73000;
        standardPrice = 146000;
        premiumPrice = 219000;
    }
}