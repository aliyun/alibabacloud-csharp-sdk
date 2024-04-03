// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923.Models
{
    public class GwpInventoryConstitute : TeaModel {
        [NameInMap("byResourceType")]
        [Validation(Required=false)]
        public List<GwpResourceConstitute> ByResourceType { get; set; }

        [NameInMap("carbonEmission")]
        [Validation(Required=false)]
        public double? CarbonEmission { get; set; }

        [NameInMap("items")]
        [Validation(Required=false)]
        public List<GwpInventoryConstitute> Items { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("percent")]
        [Validation(Required=false)]
        public double? Percent { get; set; }

        [NameInMap("resourceType")]
        [Validation(Required=false)]
        public int? ResourceType { get; set; }

        [NameInMap("unit")]
        [Validation(Required=false)]
        public string Unit { get; set; }

    }

}
