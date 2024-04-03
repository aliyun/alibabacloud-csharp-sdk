// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923.Models
{
    public class GwpResourceConstitute : TeaModel {
        [NameInMap("carbonEmission")]
        [Validation(Required=false)]
        public double? CarbonEmission { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("percent")]
        [Validation(Required=false)]
        public string Percent { get; set; }

        [NameInMap("resourceType")]
        [Validation(Required=false)]
        public int? ResourceType { get; set; }

        [NameInMap("unit")]
        [Validation(Required=false)]
        public string Unit { get; set; }

    }

}
