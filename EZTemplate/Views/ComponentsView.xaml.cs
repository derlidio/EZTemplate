using EZAppMaker.Components;

namespace EZTemplate.Views;

public class Fruit
{
	public int Id { get; set; }
    public string Type { get; set; }
	public string Name { get; set; }
	public string Description { get; set; }
}

public partial class ComponentsView : EZContentView
{
    public List<Fruit> Fruits { get; set; } = new List<Fruit>()
	{
		new Fruit(){Id = 1, Type= "Juicy", Name = "Apple", Description = "Don't take it from an old lady!"},
        new Fruit(){Id = 3, Type= "Juicy", Name = "Pear", Description = "I don't know what to say about it!"},
        new Fruit(){Id = 5, Type= "Juicy", Name = "Mango", Description = "Humm... Yammy!"},
        new Fruit(){Id = 8, Type= "Juicy", Name = "Lime", Description = "If life give you limes..."},
        new Fruit(){Id = 9, Type= "Juicy", Name = "Tangerine", Description = "I don't know what to say about it!"},
        new Fruit(){Id = 4, Type= "Yammy", Name = "Pineapple", Description = "Beware of the spikes!"},
        new Fruit(){Id = 6, Type= "Yammy", Name = "Strawberry", Description = "It tastes like strawberry!"},
        new Fruit(){Id = 7, Type= "Yammy", Name = "Cramberry", Description = "Does it give you crams?"},
        new Fruit(){Id = 2, Type= "Yammy", Name = "Banana", Description = "Minions will love it!"}
    };

	public ComponentsView()
	{
		BindingContext = this;

		InitializeComponent();
	}
}