// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923.Models
{
    public class OrgEmission : TeaModel {
        [NameInMap("carbonEmissionData")]
        [Validation(Required=false)]
        public double? CarbonEmissionData { get; set; }

        [NameInMap("moduleEmissionList")]
        [Validation(Required=false)]
        public List<OrgEmissionModuleEmissionList> ModuleEmissionList { get; set; }
        public class OrgEmissionModuleEmissionList : TeaModel {
            [NameInMap("carbonEmissionData")]
            [Validation(Required=false)]
            public double? CarbonEmissionData { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("nameKey")]
            [Validation(Required=false)]
            public string NameKey { get; set; }

            [NameInMap("ratio")]
            [Validation(Required=false)]
            public double? Ratio { get; set; }

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

        [NameInMap("subEmissionItems")]
        [Validation(Required=false)]
        public List<OrgEmission> SubEmissionItems { get; set; }

        [NameInMap("weightingCarbonEmissionData")]
        [Validation(Required=false)]
        public double? WeightingCarbonEmissionData { get; set; }

        [NameInMap("weightingProportion")]
        [Validation(Required=false)]
        public double? WeightingProportion { get; set; }

        [NameInMap("weightingRatio")]
        [Validation(Required=false)]
        public double? WeightingRatio { get; set; }

    }

}
