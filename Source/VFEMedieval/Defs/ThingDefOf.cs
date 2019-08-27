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

        public static ThingDef VFEM_CobblestoneWall;
        public static ThingDef VFEM_Must;
        public static ThingDef VFEM_WineBarrel;
        public static ThingDef VFEM_Wine;

        // Vanilla defs
        public static ThingDef MeleeWeapon_LongSword;

    }

    [StaticConstructorOnStartup]
    public static class ThingDefNamed
    {

        public static ThingDef VFES_ShortWall = DefDatabase<ThingDef>.GetNamedSilentFail("VFES_ShortWall");

    }

}
