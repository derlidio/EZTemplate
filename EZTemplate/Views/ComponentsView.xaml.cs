using EZAppMaker.Components;

namespace EZTemplate.Views;

public class Fruit
{
	public int Id { get; set; }
	public string Name { get; set; }
	public string Description { get; set; }
}

public partial class ComponentsView : EZContentView
{
    public List<Fruit> Fruits { get; set; } = new List<Fruit>()
	{
		new Fruit(){Id = 1, Name = "Apple", Description = "Don't take it from an old lady!"},
        new Fruit(){Id = 2, Name = "Banana", Description = "Minions will love it!"},
        new Fruit(){Id = 3, Name = "Pear", Description = "I don't know what to say about it!"},
        new Fruit(){Id = 4, Name = "Pineapple", Description = "Beware of the spikes!"},
        new Fruit(){Id = 5, Name = "Mango", Description = "Humm... juicy!"},
        new Fruit(){Id = 6, Name = "Strawberry", Description = "It tastes like strawberry!"},
        new Fruit(){Id = 7, Name = "Cramberry", Description = "Does it give you crams?"},
        new Fruit(){Id = 8, Name = "Lime", Description = "If life give you limes..."},
        new Fruit(){Id = 9, Name = "Tangerine", Description = "I don't know what to say about it!"}
    };

	public ComponentsView()
	{
		BindingContext = this;

		InitializeComponent();
	}
}