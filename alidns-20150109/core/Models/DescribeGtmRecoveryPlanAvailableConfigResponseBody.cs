// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeGtmRecoveryPlanAvailableConfigResponseBody : TeaModel {
        [NameInMap("Instances")]
        [Validation(Required=false)]
        public DescribeGtmRecoveryPlanAvailableConfigResponseBodyInstances Instances { get; set; }
        public class DescribeGtmRecoveryPlanAvailableConfigResponseBodyInstances : TeaModel {
            [NameInMap("Instance")]
            [Validation(Required=false)]
            public List<DescribeGtmRecoveryPlanAvailableConfigResponseBodyInstancesInstance> Instance { get; set; }
            public class DescribeGtmRecoveryPlanAvailableConfigResponseBodyInstancesInstance : TeaModel {
                [NameInMap("AddrPool")]
                [Validation(Required=false)]
                public List<DescribeGtmRecoveryPlanAvailableConfigResponseBodyInstancesInstanceAddrPool> AddrPool { get; set; }
                public class DescribeGtmRecoveryPlanAvailableConfigResponseBodyInstancesInstanceAddrPool : TeaModel {
                    [NameInMap("AddrPoolId")]
                    [Validation(Required=false)]
                    public string AddrPoolId { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
