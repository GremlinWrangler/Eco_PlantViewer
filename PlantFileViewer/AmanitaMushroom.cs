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

    public partial class PlantLayerSettingsAmanitaMushroom : PlantLayerSettings
    {
        public PlantLayerSettingsAmanitaMushroom() : base()
        {
            this.Name = "AmanitaMushroom";
            this.DisplayName = Localizer.DoStr("Amanita Mushroom");
            this.InitMultiplier = 1;
            this.SyncToClient = false;
            this.Range = new Range(0f, 1f);
            this.OverrideRenderRange = new Range(0f, 0.333333f);
            this.MinColor = new Color(1f, 1f, 1f);
            this.MaxColor = new Color(0f, 1f, 0f);
            this.SumRelevant = true;
            this.Unit = "Amanita Mushroom";
            this.VoxelsPerEntry = 5;
            this.Category = WorldLayerCategory.Plant;
            this.ValueType = WorldLayerValueType.FillRate;
            this.AreaDescription = "";
            this.Subcategory = "AmanitaMushroom".AddSpacesBetweenCapitals();
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
    public partial class AmanitaMushroom : PlantEntity
    {
        public AmanitaMushroom(WorldPosition3i mapPos, PlantPack plantPack) : base(species, mapPos, plantPack) { }
        public AmanitaMushroom() { }
        static PlantSpecies species;

        [Ecopedia("Plants", "Fungi", createAsSubPage: true, display: InPageTooltip.DynamicTooltip)]
        [Tag("Plants")]
        public partial class AmanitaMushroomSpecies : PlantSpecies
        {
            public AmanitaMushroomSpecies() : base()
            {
                species = this;
                this.InstanceType = typeof(AmanitaMushroom);

                this.SetDefaultProperties();

                // Info
                this.Decorative = false;
                this.Name = "AmanitaMushroom";
                this.DisplayName = Localizer.DoStr("Amanita Mushroom");
                // Lifetime
                this.MaturityAgeDays = 0.8f;
                // Generation
                this.Height = 1;
                // Food
                this.CalorieValue = 1;
                // Resources
                this.PostHarvestingGrowth = 0;
                this.PickableAtPercent = 0;
                this.ResourceList = new List<SpeciesResource>()
                {
                    new SpeciesResource(typeof(AmanitaMushroomsItem), new Range(1, 2), 1),
                   new SpeciesResource(typeof(AmanitaMushroomSporesItem), new Range(1, 2), 0.2f),
                };
                this.ResourceBonusAtGrowth = 0.9f;
                // Visuals
                this.BlockType = typeof(AmanitaMushroomBlock);
                // Climate
                this.ReleasesCO2TonsPerDay = -0.0001f;
                // WorldLayers
                this.MaxGrowthRate = 0.02f;
                this.MaxDeathRate = 0.01f;
                this.SpreadRate = 0.001f;
                this.ResourceConstraints.Add(new ResourceConstraint() { LayerName = "Phosphorus", HalfSpeedConcentration =  0.1f, MaxResourceContent =  0.2f });
                this.ResourceConstraints.Add(new ResourceConstraint() { LayerName = "SoilMoisture", HalfSpeedConcentration =  0.1f, MaxResourceContent =  0.05f }); 
                this.CapacityConstraints.Add(new CapacityConstraint() { CapacityLayerName = "FertileGround", ConsumedCapacityPerPop =  2 });
                this.CapacityConstraints.Add(new CapacityConstraint() { CapacityLayerName = "ShrubSpace", ConsumedCapacityPerPop =  2 }); 
                this.BlanketSpawnPercent = 0.8f; 
                this.IdealTemperatureRange = new Range(0.45f, 0.55f);
                this.IdealMoistureRange = new Range(0.55f, 0.75f);
                this.IdealWaterRange = new Range(0, 0.1f);
                this.WaterExtremes = new Range(0, 0.2f);
                this.TemperatureExtremes = new Range(0.4f, 0.6f);
                this.MoistureExtremes = new Range(0.5f, 0.8f);
                this.MaxPollutionDensity = 0.7f;
                this.PollutionDensityTolerance = 0.1f;
                this.VoxelsPerEntry = 5;
            }

            partial void SetDefaultProperties();
        }
    }
    [Serialized]
    [Clearable]
    public partial class AmanitaMushroomBlock :
        InteractablePlantBlock { } 
}