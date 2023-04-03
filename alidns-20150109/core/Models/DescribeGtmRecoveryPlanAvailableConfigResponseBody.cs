// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeGtmRecoveryPlanAvailableConfigResponseBody : TeaModel {
        /// <summary>
        /// The list of GTM instances involved in the disaster recovery plan.
        /// </summary>
        [NameInMap("Instances")]
        [Validation(Required=false)]
        public DescribeGtmRecoveryPlanAvailableConfigResponseBodyInstances Instances { get; set; }
        public class DescribeGtmRecoveryPlanAvailableConfigResponseBodyInstances : TeaModel {
            [NameInMap("Instance")]
            [Validation(Required=false)]
            public List<DescribeGtmRecoveryPlanAvailableConfigResponseBodyInstancesInstance> Instance { get; set; }
            public class DescribeGtmRecoveryPlanAvailableConfigResponseBodyInstancesInstance : TeaModel {
                /// <summary>
                /// The list of address pools for the GTM instance.
                /// </summary>
                [NameInMap("AddrPools")]
                [Validation(Required=false)]
                public DescribeGtmRecoveryPlanAvailableConfigResponseBodyInstancesInstanceAddrPools AddrPools { get; set; }
                public class DescribeGtmRecoveryPlanAvailableConfigResponseBodyInstancesInstanceAddrPools : TeaModel {
                    [NameInMap("AddrPool")]
                    [Validation(Required=false)]
                    public List<DescribeGtmRecoveryPlanAvailableConfigResponseBodyInstancesInstanceAddrPoolsAddrPool> AddrPool { get; set; }
                    public class DescribeGtmRecoveryPlanAvailableConfigResponseBodyInstancesInstanceAddrPoolsAddrPool : TeaModel {
                        /// <summary>
                        /// The ID of the address pool.
                        /// </summary>
                        [NameInMap("AddrPoolId")]
                        [Validation(Required=false)]
                        public string AddrPoolId { get; set; }

                        /// <summary>
                        /// The name of the address pool.
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                    }

                }

                /// <summary>
                /// The ID of the GTM instance.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// The name of the GTM instance.
                /// </summary>
                [NameInMap("InstanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
