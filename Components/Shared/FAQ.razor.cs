
namespace ZoeyStoreKeeperLandingPage.Components.Shared;

public partial class FAQ
{
    FAQData[] faqs = new FAQData[]
    {
        new FAQData
        {
            Title = "What's ZoeyStorekeer? ",
            Description =@"ZoeyStorekeer is management solution that is built to serve every
                                organization, big
                                or small. This soolution offers both POS and storekeeper services, with POS
                                you can sell your product at a fix price on storekeeper, see transaction details,
                                print
                                receipt
                                and the total sale income
                                of the day, week or month instantly.... "
        },
        new FAQData
        {
            Title = "What if I have problem on my zoey Point of Sale system?",
            Description =@"Our highly trained support team is available via phone or email. You can also learn from
                            our
                            Seller
                            Community, or visit the Support Center 24/7 to find useful tips, articles, and thorough
                            video
                            walkthroughs."

                            
        },
         new FAQData
        {
            Title = " Do You Offers Training?",
            Description =@"Yes, we offer short duration training."
        },

         new FAQData
        {
            Title = "Are My Data Backup In The Cloud ",
            Description =@" Definatly yes!."
        },
      
};
}

class FAQData
{
    public string Title { get; set; }
    public string Description { get; set; }
    public bool Opened { get; set; }
    public void Toggle()
    {
        Opened = !Opened;
        
    }
}