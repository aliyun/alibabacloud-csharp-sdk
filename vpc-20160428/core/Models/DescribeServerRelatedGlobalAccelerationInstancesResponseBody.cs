// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeServerRelatedGlobalAccelerationInstancesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("GlobalAccelerationInstances")]
        [Validation(Required=false)]
        public DescribeServerRelatedGlobalAccelerationInstancesResponseBodyGlobalAccelerationInstances GlobalAccelerationInstances { get; set; }
        public class DescribeServerRelatedGlobalAccelerationInstancesResponseBodyGlobalAccelerationInstances : TeaModel {
            [NameInMap("GlobalAccelerationInstance")]
            [Validation(Required=false)]
            public List<DescribeServerRelatedGlobalAccelerationInstancesResponseBodyGlobalAccelerationInstancesGlobalAccelerationInstance> GlobalAccelerationInstance { get; set; }
            public class DescribeServerRelatedGlobalAccelerationInstancesResponseBodyGlobalAccelerationInstancesGlobalAccelerationInstance : TeaModel {
                public string ServerIpAddress { get; set; }
                public string IpAddress { get; set; }
                public string GlobalAccelerationInstanceId { get; set; }
                public string RegionId { get; set; }
            }
        };

    }

}
