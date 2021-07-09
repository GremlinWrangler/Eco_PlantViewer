﻿// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// <auto-generated />

namespace Eco.Mods.TechTree
{
    }
// WORLD LAYER INFO
namespace Eco.Mods.WorldLayers
{
    using Eco.Shared.Localization;
    using Eco.Shared.Math;
    using Eco.Shared.Utils;
    using Eco.Simulation.WorldLayers.Layers;

    public partial class PlantLayerSettingsBirch : PlantLayerSettings
    {
        public PlantLayerSettingsBirch() : base()
        {
            this.Name = "Birch";
            this.DisplayName = Localizer.DoStr("Birch");
            this.InitMultiplier = 1;
            this.SyncToClient = false;
            this.Range = new Range(0f, 1f);
            this.OverrideRenderRange = new Range(0f, 0.05f);
            this.MinColor = new Color(1f, 1f, 1f);
            this.MaxColor = new Color(0f, 1f, 0f);
            this.SumRelevant = true;
            this.Unit = "Birch";
            this.VoxelsPerEntry = 20;
            this.Category = WorldLayerCategory.Plant;
            this.ValueType = WorldLayerValueType.FillRate;
            this.AreaDescription = "";
            this.Subcategory = "Birch".AddSpacesBetweenCapitals();
        }
    }
}

namespace Eco.Mods.Organisms
{
    using System.Collections.Generic;
    using Eco.Core.Items;
    using Eco.Gameplay.Plants;
    using Eco.Mods.TechTree;
    using Eco.Shared.Localization;
    using Eco.Shared.Math;
    using Eco.Shared.Serialization;
    using Eco.Simulation;
    using Eco.Simulation.Types;
    using Eco.World.Blocks;

    [Serialized]
    public partial class Birch : TreeEntity
    {
        public Birch(WorldPosition3i mapPos, PlantPack plantPack) : base(species, mapPos, plantPack) { }
        public Birch() { }
        static TreeSpecies species;

        [Ecopedia("Plants", "Trees", createAsSubPage: true, display: InPageTooltip.DynamicTooltip)]
        [Tag("Plants")]
        public partial class BirchSpecies : TreeSpecies
        {
            public BirchSpecies() : base()
            {
                species = this;
                this.InstanceType = typeof(Birch);

                this.SetDefaultProperties();

                // Info
                this.Decorative = false;
                this.Name = "Birch";
                this.DisplayName = Localizer.DoStr("Birch");
                // Lifetime
               this.MaturityAgeDays = 4.9999995f;  
                // Generation
                this.Height = 1;
                // Food
                this.CalorieValue = 15;
                // Resources
                this.PostHarvestingGrowth = 0;
                this.ScythingKills = false; 
                this.PickableAtPercent = 0;
                this.ResourceList = new List<SpeciesResource>()
                {
                    new SpeciesResource(typeof(BirchLogItem), new Range(0, 50), 1),
                };
                this.ResourceBonusAtGrowth = 0.9f;
                // Visuals
                // Climate
                this.ReleasesCO2TonsPerDay = -0.075f;
                // WorldLayers
               this.MaxGrowthRate = 0.02f;  
               this.MaxDeathRate = 0.01f;  
               this.SpreadRate = 1.0E-4f;  
                this.ResourceConstraints.Add(new ResourceConstraint() { LayerName = "SoilMoisture", HalfSpeedConcentration =  0.1f, MaxResourceContent =  0.1f }); 
                this.CapacityConstraints.Add(new CapacityConstraint() { CapacityLayerName = "FertileGround", ConsumedCapacityPerPop =  10 });
                this.CapacityConstraints.Add(new CapacityConstraint() { CapacityLayerName = "CanopySpace", ConsumedCapacityPerPop =  30 }); 
                this.BlanketSpawnPercent = 0.5f; 
                this.IdealTemperatureRange = new Range(0.55f,  0.75f);  
                this.IdealMoistureRange = new Range(0.52f,  0.58f);  
                this.IdealWaterRange = new Range(0, 0.1f);
                this.WaterExtremes = new Range(0, 0.2f);
                this.TemperatureExtremes = new Range(0.5f,  0.8f);  
                this.MoistureExtremes = new Range(0.5f,  0.6f);  
                this.MaxPollutionDensity = 0.7f;
                this.PollutionDensityTolerance = 0.1f;
                this.VoxelsPerEntry = 20;
            }

            partial void SetDefaultProperties();
        }
    }
}