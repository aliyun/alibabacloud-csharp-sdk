// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeServerRelatedGlobalAccelerationInstancesResponseBody : TeaModel {
        [NameInMap("GlobalAccelerationInstances")]
        [Validation(Required=false)]
        public DescribeServerRelatedGlobalAccelerationInstancesResponseBodyGlobalAccelerationInstances GlobalAccelerationInstances { get; set; }
        public class DescribeServerRelatedGlobalAccelerationInstancesResponseBodyGlobalAccelerationInstances : TeaModel {
            [NameInMap("GlobalAccelerationInstance")]
            [Validation(Required=false)]
            public List<DescribeServerRelatedGlobalAccelerationInstancesResponseBodyGlobalAccelerationInstancesGlobalAccelerationInstance> GlobalAccelerationInstance { get; set; }
            public class DescribeServerRelatedGlobalAccelerationInstancesResponseBodyGlobalAccelerationInstancesGlobalAccelerationInstance : TeaModel {
                [NameInMap("GlobalAccelerationInstanceId")]
                [Validation(Required=false)]
                public string GlobalAccelerationInstanceId { get; set; }

                [NameInMap("IpAddress")]
                [Validation(Required=false)]
                public string IpAddress { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("ServerIpAddress")]
                [Validation(Required=false)]
                public string ServerIpAddress { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
