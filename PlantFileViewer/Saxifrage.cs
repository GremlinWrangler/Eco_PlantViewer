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

    public partial class PlantLayerSettingsSaxifrage : PlantLayerSettings
    {
        public PlantLayerSettingsSaxifrage() : base()
        {
            this.Name = "Saxifrage";
            this.DisplayName = Localizer.DoStr("Saxifrage");
            this.InitMultiplier = 1;
            this.SyncToClient = false;
            this.Range = new Range(0f, 1f);
            this.OverrideRenderRange = new Range(0f, 0.333333f);
            this.MinColor = new Color(1f, 1f, 1f);
            this.MaxColor = new Color(0f, 1f, 0f);
            this.SumRelevant = true;
            this.Unit = "Saxifrage";
            this.VoxelsPerEntry = 5;
            this.Category = WorldLayerCategory.Plant;
            this.ValueType = WorldLayerValueType.FillRate;
            this.AreaDescription = "";
            this.Subcategory = "Saxifrage".AddSpacesBetweenCapitals();
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
    public partial class Saxifrage : PlantEntity
    {
        public Saxifrage(WorldPosition3i mapPos, PlantPack plantPack) : base(species, mapPos, plantPack) { }
        public Saxifrage() { }
        static PlantSpecies species;

        [Ecopedia("Plants", "Plants", createAsSubPage: true, display: InPageTooltip.DynamicTooltip)]
        [Tag("Plants")]
        public partial class SaxifrageSpecies : PlantSpecies
        {
            public SaxifrageSpecies() : base()
            {
                species = this;
                this.InstanceType = typeof(Saxifrage);

                this.SetDefaultProperties();

                // Info
                this.Decorative = false;
                this.Name = "Saxifrage";
                this.DisplayName = Localizer.DoStr("Saxifrage");
                // Lifetime
               this.MaturityAgeDays = 0.8f;  
                // Generation
                this.Height = 1;
                // Food
                this.CalorieValue = 3;
                // Resources
                this.PostHarvestingGrowth = 0;
                this.PickableAtPercent = 0;
                this.ResourceList = new List<SpeciesResource>()
                {
                    new SpeciesResource(typeof(PlantFibersItem), new Range(1, 3), 1),
                   new SpeciesResource(typeof(SaxifrageSeedItem), new Range(1, 2), 0.1f),
                };
                this.ResourceBonusAtGrowth = 0.9f;
                // Visuals
                this.BlockType = typeof(SaxifrageBlock);
                // Climate
                this.ReleasesCO2TonsPerDay = -0.0001f;
                // WorldLayers
               this.MaxGrowthRate = 0.02f;  
               this.MaxDeathRate = 0.01f;  
               this.SpreadRate = 0.001f;  
                this.ResourceConstraints.Add(new ResourceConstraint() { LayerName = "Nitrogen", HalfSpeedConcentration =  0.1f, MaxResourceContent =  0.1f });
                this.ResourceConstraints.Add(new ResourceConstraint() { LayerName = "SoilMoisture", HalfSpeedConcentration =  0.2f, MaxResourceContent =  0.2f }); 
                this.CapacityConstraints.Add(new CapacityConstraint() { CapacityLayerName = "FertileGround", ConsumedCapacityPerPop =  2 });
                this.CapacityConstraints.Add(new CapacityConstraint() { CapacityLayerName = "ShrubSpace", ConsumedCapacityPerPop =  2 }); 
                this.BlanketSpawnPercent = 0.6f; 
                this.IdealTemperatureRange = new Range(0.12f,  0.28f);  
                this.IdealMoistureRange = new Range(0.12f,  0.48f);  
                this.IdealWaterRange = new Range(0, 0.1f);
                this.WaterExtremes = new Range(0, 0.2f);
                this.TemperatureExtremes = new Range(0.1f,  0.3f);  
                this.MoistureExtremes = new Range(0.1f,  0.5f);  
                this.MaxPollutionDensity = 0.7f;
                this.PollutionDensityTolerance = 0.1f;
                this.VoxelsPerEntry = 5;
            }

            partial void SetDefaultProperties();
        }
    }
    [Serialized]
    [Reapable] 
    [Clearable]
    [MoveEfficiency(0.8f)] 
    public partial class SaxifrageBlock :
        PlantBlock { } 
}
