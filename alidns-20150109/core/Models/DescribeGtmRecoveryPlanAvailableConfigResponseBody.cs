// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeGtmRecoveryPlanAvailableConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The instances.</para>
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
                /// <para>The address pools.</para>
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
                        /// <para>The address pool ID.</para>
                        /// </summary>
                        [NameInMap("AddrPoolId")]
                        [Validation(Required=false)]
                        public string AddrPoolId { get; set; }

                        /// <summary>
                        /// <para>The name of the address pool.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>hra0i9</para>
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                    }

                }

                /// <summary>
                /// <para>The instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>instance-example</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The instance name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>instance-name-example</para>
                /// </summary>
                [NameInMap("InstanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F8F8EF50-8B7F-4702-B294-97170A423403</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
