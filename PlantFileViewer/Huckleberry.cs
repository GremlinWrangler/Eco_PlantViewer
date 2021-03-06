// Copyright (c) Strange Loop Games. All rights reserved.
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

    public partial class PlantLayerSettingsHuckleberry : PlantLayerSettings
    {
        public PlantLayerSettingsHuckleberry() : base()
        {
            this.Name = "Huckleberry";
            this.DisplayName = Localizer.DoStr("Huckleberry");
            this.InitMultiplier = 1;
            this.SyncToClient = false;
            this.Range = new Range(0f, 1f);
            this.OverrideRenderRange = new Range(0f, 0.333333f);
            this.MinColor = new Color(1f, 1f, 1f);
            this.MaxColor = new Color(0f, 1f, 0f);
            this.SumRelevant = true;
            this.Unit = "Huckleberry";
            this.VoxelsPerEntry = 5;
            this.Category = WorldLayerCategory.Plant;
            this.ValueType = WorldLayerValueType.FillRate;
            this.AreaDescription = "";
            this.Subcategory = "Huckleberry".AddSpacesBetweenCapitals();
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
    public partial class Huckleberry : PlantEntity
    {
        public Huckleberry(WorldPosition3i mapPos, PlantPack plantPack) : base(species, mapPos, plantPack) { }
        public Huckleberry() { }
        static PlantSpecies species;

        [Ecopedia("Plants", "Plants", createAsSubPage: true, display: InPageTooltip.DynamicTooltip)]
        [Tag("Plants")]
        public partial class HuckleberrySpecies : PlantSpecies
        {
            public HuckleberrySpecies() : base()
            {
                species = this;
                this.InstanceType = typeof(Huckleberry);

                this.SetDefaultProperties();

                // Info
                this.Decorative = false;
                this.Name = "Huckleberry";
                this.DisplayName = Localizer.DoStr("Huckleberry");
                this.IsConsideredNearbyFoodDuringSpawnCheck = true; 
                // Lifetime
               this.MaturityAgeDays = 2.0000002f;  
                // Generation
                this.Height = 1;
                // Food
                this.CalorieValue = 8;
                // Resources
                this.PostHarvestingGrowth = 0.5f;
                this.PickableAtPercent = 0.8f;
                this.ResourceList = new List<SpeciesResource>()
                {
                    new SpeciesResource(typeof(HuckleberriesItem), new Range(1, 4), 1),
                   new SpeciesResource(typeof(HuckleberrySeedItem), new Range(1, 2), 0.1f),
                };
                this.ResourceBonusAtGrowth = 0.9f;
                // Visuals
                this.BlockType = typeof(HuckleberryBlock);
                // Climate
                this.ReleasesCO2TonsPerDay = -0.0002f;
                // WorldLayers
               this.MaxGrowthRate = 0.02f;  
               this.MaxDeathRate = 0.01f;  
               this.SpreadRate = 0.001f;  
                this.ResourceConstraints.Add(new ResourceConstraint() { LayerName = "Nitrogen", HalfSpeedConcentration =  0.1f, MaxResourceContent =  0.1f });
                this.ResourceConstraints.Add(new ResourceConstraint() { LayerName = "Phosphorus", HalfSpeedConcentration =  0.1f, MaxResourceContent =  0.15f });
                this.ResourceConstraints.Add(new ResourceConstraint() { LayerName = "Potassium", HalfSpeedConcentration =  0.2f, MaxResourceContent =  0.2f });
                this.ResourceConstraints.Add(new ResourceConstraint() { LayerName = "SoilMoisture", HalfSpeedConcentration =  0.2f, MaxResourceContent =  0.05f }); 
                this.CapacityConstraints.Add(new CapacityConstraint() { CapacityLayerName = "FertileGround", ConsumedCapacityPerPop =  5 });
                this.CapacityConstraints.Add(new CapacityConstraint() { CapacityLayerName = "ShrubSpace", ConsumedCapacityPerPop =  5 }); 
                this.BlanketSpawnPercent = 0.5f; 
                this.IdealTemperatureRange = new Range(0.25f,  0.2999999f);  
                this.IdealMoistureRange = new Range(0.52f,  0.58f);  
                this.IdealWaterRange = new Range(0, 0.1f);
                this.WaterExtremes = new Range(0, 0.2f);
                this.TemperatureExtremes = new Range(0.2f,  0.75f);  
                this.MoistureExtremes = new Range(0.45f,  0.6f);  
                this.MaxPollutionDensity = 0.7f;
                this.PollutionDensityTolerance = 0.1f;
                this.VoxelsPerEntry = 5;
            }

            partial void SetDefaultProperties();
        }
    }
    [Serialized]
    [Clearable]
    [MoveEfficiency(0.75f)] 
    public partial class HuckleberryBlock :
        InteractablePlantBlock { } 
}
