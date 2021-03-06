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

    public partial class PlantLayerSettingsPricklyPear : PlantLayerSettings
    {
        public PlantLayerSettingsPricklyPear() : base()
        {
            this.Name = "PricklyPear";
            this.DisplayName = Localizer.DoStr("Prickly Pear");
            this.InitMultiplier = 1;
            this.SyncToClient = false;
            this.Range = new Range(0f, 1f);
            this.OverrideRenderRange = new Range(0f, 0.333333f);
            this.MinColor = new Color(1f, 1f, 1f);
            this.MaxColor = new Color(0f, 1f, 0f);
            this.SumRelevant = true;
            this.Unit = "Prickly Pear";
            this.VoxelsPerEntry = 5;
            this.Category = WorldLayerCategory.Plant;
            this.ValueType = WorldLayerValueType.FillRate;
            this.AreaDescription = "";
            this.Subcategory = "PricklyPear".AddSpacesBetweenCapitals();
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
    public partial class PricklyPear : PlantEntity
    {
        public PricklyPear(WorldPosition3i mapPos, PlantPack plantPack) : base(species, mapPos, plantPack) { }
        public PricklyPear() { }
        static PlantSpecies species;

        [Ecopedia("Plants", "Plants", createAsSubPage: true, display: InPageTooltip.DynamicTooltip)]
        [Tag("Plants")]
        public partial class PricklyPearSpecies : PlantSpecies
        {
            public PricklyPearSpecies() : base()
            {
                species = this;
                this.InstanceType = typeof(PricklyPear);

                this.SetDefaultProperties();

                // Info
                this.Decorative = false;
                this.Name = "PricklyPear";
                this.DisplayName = Localizer.DoStr("Prickly Pear");
                this.IsConsideredNearbyFoodDuringSpawnCheck = true; 
                // Lifetime
               this.MaturityAgeDays = 1.8000002f;  
                // Generation
                this.Height = 1;
                // Food
                this.CalorieValue = 10;
                // Resources
                this.PostHarvestingGrowth = 0.5f;
                this.PickableAtPercent = 0.8f;
                this.ResourceList = new List<SpeciesResource>()
                {
                    new SpeciesResource(typeof(PricklyPearFruitItem), new Range(1, 2), 1),
                   new SpeciesResource(typeof(PricklyPearSeedItem), new Range(1, 2), 0.1f),
                };
                this.ResourceBonusAtGrowth = 0.9f;
                // Visuals
                this.BlockType = typeof(PricklyPearBlock);
                // Climate
                this.ReleasesCO2TonsPerDay = -0.0001f;
                // WorldLayers
               this.MaxGrowthRate = 0.02f;  
               this.MaxDeathRate = 0.01f;  
               this.SpreadRate = 9.999984E-4f;  
                this.ResourceConstraints.Add(new ResourceConstraint() { LayerName = "Nitrogen", HalfSpeedConcentration =  0.3f, MaxResourceContent =  0.5f });
                this.ResourceConstraints.Add(new ResourceConstraint() { LayerName = "Phosphorus", HalfSpeedConcentration =  0.1f, MaxResourceContent =  0.2f });
                this.ResourceConstraints.Add(new ResourceConstraint() { LayerName = "Potassium", HalfSpeedConcentration =  0.2f, MaxResourceContent =  0.3f });
                this.ResourceConstraints.Add(new ResourceConstraint() { LayerName = "SoilMoisture", HalfSpeedConcentration =  0.2f, MaxResourceContent =  0.1f }); 
                this.CapacityConstraints.Add(new CapacityConstraint() { CapacityLayerName = "FertileGround", ConsumedCapacityPerPop =  1 });
                this.CapacityConstraints.Add(new CapacityConstraint() { CapacityLayerName = "ShrubSpace", ConsumedCapacityPerPop =  4.5f }); 
                this.GenerationSpawnCountPerPoint = new Range(2, 5); 
                this.GenerationSpawnPointMultiplier = 0.02f; 
                this.BlanketSpawnPercent = 0.8f; 
                this.IdealTemperatureRange = new Range(0.72f,  0.95f);  
                this.IdealMoistureRange = new Range(0.05f,  0.3f);  
                this.IdealWaterRange = new Range(0, 0.1f);
                this.WaterExtremes = new Range(0, 0.2f);
                this.TemperatureExtremes = new Range(0.7f,  1);  
                this.MoistureExtremes = new Range(0,  0.35f);  
                this.MaxPollutionDensity = 0.7f;
                this.PollutionDensityTolerance = 0.1f;
                this.VoxelsPerEntry = 5;
            }

            partial void SetDefaultProperties();
        }
    }
    [Serialized]
    [Clearable]
    [MoveEfficiency(0.6f)] 
    public partial class PricklyPearBlock :
        InteractablePlantBlock { } 
}
