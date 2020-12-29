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
        public List<DescribeGtmRecoveryPlanAvailableConfigResponseBodyInstances> Instances { get; set; }
        public class DescribeGtmRecoveryPlanAvailableConfigResponseBodyInstances : TeaModel {
            [NameInMap("AddrPools")]
            [Validation(Required=false)]
            public List<DescribeGtmRecoveryPlanAvailableConfigResponseBodyInstancesAddrPools> AddrPools { get; set; }
            public class DescribeGtmRecoveryPlanAvailableConfigResponseBodyInstancesAddrPools : TeaModel {
                [NameInMap("AddrPoolId")]
                [Validation(Required=false)]
                public string AddrPoolId { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
