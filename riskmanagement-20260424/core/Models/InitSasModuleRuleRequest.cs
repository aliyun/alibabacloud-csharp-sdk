// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RiskManagement20260424.Models
{
    public class InitSasModuleRuleRequest : TeaModel {
        [NameInMap("AutoBind")]
        [Validation(Required=false)]
        public int? AutoBind { get; set; }

        [NameInMap("Instances")]
        [Validation(Required=false)]
        public List<InitSasModuleRuleRequestInstances> Instances { get; set; }
        public class InitSasModuleRuleRequestInstances : TeaModel {
            [NameInMap("Cores")]
            [Validation(Required=false)]
            public string Cores { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

        [NameInMap("IsTrial")]
        [Validation(Required=false)]
        public bool? IsTrial { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
