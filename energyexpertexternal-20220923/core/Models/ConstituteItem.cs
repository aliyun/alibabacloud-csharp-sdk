// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923.Models
{
    public class ConstituteItem : TeaModel {
        [NameInMap("carbonEmissionData")]
        [Validation(Required=false)]
        public double? CarbonEmissionData { get; set; }

        [NameInMap("dataUnit")]
        [Validation(Required=false)]
        public string DataUnit { get; set; }

        [NameInMap("emissionSource")]
        [Validation(Required=false)]
        public string EmissionSource { get; set; }

        [NameInMap("emissionSourceKey")]
        [Validation(Required=false)]
        public string EmissionSourceKey { get; set; }

        [NameInMap("enterpriseName")]
        [Validation(Required=false)]
        public string EnterpriseName { get; set; }

        [NameInMap("envGasEmissions")]
        [Validation(Required=false)]
        public List<ConstituteItemEnvGasEmissions> EnvGasEmissions { get; set; }
        public class ConstituteItemEnvGasEmissions : TeaModel {
            [NameInMap("carbonEmissionData")]
            [Validation(Required=false)]
            public double? CarbonEmissionData { get; set; }

            [NameInMap("gasEmissionData")]
            [Validation(Required=false)]
            public double? GasEmissionData { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("nameKey")]
        [Validation(Required=false)]
        public string NameKey { get; set; }

        [NameInMap("ratio")]
        [Validation(Required=false)]
        public double? Ratio { get; set; }

        [NameInMap("rawData")]
        [Validation(Required=false)]
        public double? RawData { get; set; }

        [NameInMap("subConstituteItems")]
        [Validation(Required=false)]
        public List<ConstituteItem> SubConstituteItems { get; set; }

    }

}
