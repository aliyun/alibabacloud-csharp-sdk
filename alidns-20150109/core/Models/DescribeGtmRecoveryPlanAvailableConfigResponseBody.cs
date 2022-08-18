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
                public DescribeGtmRecoveryPlanAvailableConfigResponseBodyInstancesInstanceAddrPools AddrPools { get; set; }
                public class DescribeGtmRecoveryPlanAvailableConfigResponseBodyInstancesInstanceAddrPools : TeaModel {
                    [NameInMap("AddrPool")]
                    [Validation(Required=false)]
                    public List<DescribeGtmRecoveryPlanAvailableConfigResponseBodyInstancesInstanceAddrPoolsAddrPool> AddrPool { get; set; }
                    public class DescribeGtmRecoveryPlanAvailableConfigResponseBodyInstancesInstanceAddrPoolsAddrPool : TeaModel {
                        [NameInMap("AddrPoolId")]
                        [Validation(Required=false)]
                        public string AddrPoolId { get; set; }

                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                    }

                }
                public string InstanceId { get; set; }
                public string InstanceName { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
