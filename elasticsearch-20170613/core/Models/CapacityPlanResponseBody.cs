// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class CapacityPlanResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public CapacityPlanResponseBodyResult Result { get; set; }
        public class CapacityPlanResponseBodyResult : TeaModel {
            [NameInMap("ExtendConfigs")]
            [Validation(Required=false)]
            public List<CapacityPlanResponseBodyResultExtendConfigs> ExtendConfigs { get; set; }
            public class CapacityPlanResponseBodyResultExtendConfigs : TeaModel {
                [NameInMap("ConfigType")]
                [Validation(Required=false)]
                public string ConfigType { get; set; }

                [NameInMap("Disk")]
                [Validation(Required=false)]
                public long? Disk { get; set; }

                [NameInMap("DiskType")]
                [Validation(Required=false)]
                public string DiskType { get; set; }

            }

            [NameInMap("InstanceCategory")]
            [Validation(Required=false)]
            public string InstanceCategory { get; set; }

            [NameInMap("NodeConfigurations")]
            [Validation(Required=false)]
            public List<CapacityPlanResponseBodyResultNodeConfigurations> NodeConfigurations { get; set; }
            public class CapacityPlanResponseBodyResultNodeConfigurations : TeaModel {
                [NameInMap("Amount")]
                [Validation(Required=false)]
                public long? Amount { get; set; }

                [NameInMap("Cpu")]
                [Validation(Required=false)]
                public long? Cpu { get; set; }

                [NameInMap("Disk")]
                [Validation(Required=false)]
                public long? Disk { get; set; }

                [NameInMap("DiskType")]
                [Validation(Required=false)]
                public string DiskType { get; set; }

                [NameInMap("Memory")]
                [Validation(Required=false)]
                public long? Memory { get; set; }

                [NameInMap("NodeType")]
                [Validation(Required=false)]
                public string NodeType { get; set; }

            }

            [NameInMap("OversizedCluster")]
            [Validation(Required=false)]
            public bool? OversizedCluster { get; set; }

        }

    }

}
