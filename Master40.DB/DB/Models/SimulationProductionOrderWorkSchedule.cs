﻿using Master40.DB.DB.Interfaces;
using Master40.DB.Models;

namespace Master40.DB.DB.Models
{
    public class SimulationProductionOrderWorkSchedule : BaseEntity, ISimulationProductionOrderWorkSchedule
    {
        public int HierarchyNumber { get; set; }
        public int Start { get; set; }
        public int End { get; set; }
        public int ProductionOrderId { get; set; }
        public ProductionOrder ProductionOrder { get; set; }
        public int SimulatedStart { get; set; }
        public int SimulatedEnd { get; set; }
        public int SimulatedDuration { get; set; }
    }
}
