﻿using Hearthstone_Deck_Tracker.Hearthstone.EffectSystem.Enums;

namespace Hearthstone_Deck_Tracker.Hearthstone.EffectSystem.Effects.Priest;

public class RazaTheResealedEnchantment : EntityBasedEffect
{
	public override string CardId => HearthDb.CardIds.NonCollectible.Priest.RazatheResealed_RazaResealedEnchantEnchantment;
	protected override string CardIdToShowInUI => HearthDb.CardIds.Collectible.Priest.RazaTheResealed;

	public RazaTheResealedEnchantment(int entityId, bool isControlledByPlayer) : base(entityId, isControlledByPlayer)
	{
	}

	public override EffectDuration EffectDuration => EffectDuration.Permanent;
	public override EffectTag EffectTag => EffectTag.HeroModification;
}