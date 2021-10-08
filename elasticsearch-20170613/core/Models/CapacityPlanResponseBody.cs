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
                public string ConfigType { get; set; }
                public long? Disk { get; set; }
                public string DiskType { get; set; }
            }
            [NameInMap("InstanceCategory")]
            [Validation(Required=false)]
            public string InstanceCategory { get; set; }
            [NameInMap("NodeConfigurations")]
            [Validation(Required=false)]
            public List<CapacityPlanResponseBodyResultNodeConfigurations> NodeConfigurations { get; set; }
            public class CapacityPlanResponseBodyResultNodeConfigurations : TeaModel {
                public long? Amount { get; set; }
                public long? Cpu { get; set; }
                public long? Disk { get; set; }
                public string DiskType { get; set; }
                public long? Memory { get; set; }
                public string NodeType { get; set; }
            }
            [NameInMap("OversizedCluster")]
            [Validation(Required=false)]
            public bool? OversizedCluster { get; set; }
        };

    }

}
