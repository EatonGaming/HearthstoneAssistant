﻿using HearthstoneDeckTracker.Enums;

namespace HearthstoneDeckTracker.Model
{
	public class Player
	{
		public string Name { get; set; }
		public Class Class { get; set; }
		public bool Coin { get; set; } = false;
		public bool Win { get; set; }
		public int Health { get; set; }
		public Deck Deck { get; set; }

		public bool HasName => Name == null;
	}
}
