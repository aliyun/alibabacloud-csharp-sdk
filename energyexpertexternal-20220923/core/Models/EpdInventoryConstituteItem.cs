// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923.Models
{
    public class EpdInventoryConstituteItem : TeaModel {
        [NameInMap("carbonEmission")]
        [Validation(Required=false)]
        public double? CarbonEmission { get; set; }

        [NameInMap("factor")]
        [Validation(Required=false)]
        public string Factor { get; set; }

        [NameInMap("factorDataset")]
        [Validation(Required=false)]
        public string FactorDataset { get; set; }

        [NameInMap("factorId")]
        [Validation(Required=false)]
        public string FactorId { get; set; }

        [NameInMap("factorType")]
        [Validation(Required=false)]
        public int? FactorType { get; set; }

        [NameInMap("factorUnit")]
        [Validation(Required=false)]
        public string FactorUnit { get; set; }

        [NameInMap("inventoryId")]
        [Validation(Required=false)]
        public long? InventoryId { get; set; }

        [NameInMap("inventoryUnit")]
        [Validation(Required=false)]
        public string InventoryUnit { get; set; }

        [NameInMap("inventoryValue")]
        [Validation(Required=false)]
        public double? InventoryValue { get; set; }

        [NameInMap("inventoryValuePerProduct")]
        [Validation(Required=false)]
        public double? InventoryValuePerProduct { get; set; }

        [NameInMap("inventoryValuePerProductUnit")]
        [Validation(Required=false)]
        public string InventoryValuePerProductUnit { get; set; }

        [NameInMap("items")]
        [Validation(Required=false)]
        public List<EpdInventoryConstituteItem> Items { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("num")]
        [Validation(Required=false)]
        public long? Num { get; set; }

        [NameInMap("percent")]
        [Validation(Required=false)]
        public double? Percent { get; set; }

        [NameInMap("quantity")]
        [Validation(Required=false)]
        public double? Quantity { get; set; }

        [NameInMap("resourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        [NameInMap("state")]
        [Validation(Required=false)]
        public int? State { get; set; }

        [NameInMap("unit")]
        [Validation(Required=false)]
        public string Unit { get; set; }

    }

}
