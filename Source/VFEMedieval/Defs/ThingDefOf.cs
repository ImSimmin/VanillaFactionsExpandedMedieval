﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using Verse;
using RimWorld;

namespace VFEMedieval
{

    [DefOf]
    public static class ThingDefOf
    {

        public static ThingDef VFE_CobblestoneWall;
        public static ThingDef VFE_Must;
        public static ThingDef VFE_WineBarrel;
        public static ThingDef VFE_Wine;

        // Vanilla defs
        public static ThingDef MeleeWeapon_LongSword;

    }

    [StaticConstructorOnStartup]
    public static class ThingDefNamed
    {

        public static ThingDef VFES_ShortWall = DefDatabase<ThingDef>.GetNamedSilentFail("VFES_ShortWall");

    }

}