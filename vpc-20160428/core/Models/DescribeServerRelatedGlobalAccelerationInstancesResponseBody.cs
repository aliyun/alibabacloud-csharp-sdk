// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeServerRelatedGlobalAccelerationInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of GA instances.</para>
        /// </summary>
        [NameInMap("GlobalAccelerationInstances")]
        [Validation(Required=false)]
        public DescribeServerRelatedGlobalAccelerationInstancesResponseBodyGlobalAccelerationInstances GlobalAccelerationInstances { get; set; }
        public class DescribeServerRelatedGlobalAccelerationInstancesResponseBodyGlobalAccelerationInstances : TeaModel {
            [NameInMap("GlobalAccelerationInstance")]
            [Validation(Required=false)]
            public List<DescribeServerRelatedGlobalAccelerationInstancesResponseBodyGlobalAccelerationInstancesGlobalAccelerationInstance> GlobalAccelerationInstance { get; set; }
            public class DescribeServerRelatedGlobalAccelerationInstancesResponseBodyGlobalAccelerationInstancesGlobalAccelerationInstance : TeaModel {
                /// <summary>
                /// <para>The ID of the GA instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ga-t4nku6vv9****</para>
                /// </summary>
                [NameInMap("GlobalAccelerationInstanceId")]
                [Validation(Required=false)]
                public string GlobalAccelerationInstanceId { get; set; }

                /// <summary>
                /// <para>The public IP address of the GA instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12.34.56.78</para>
                /// </summary>
                [NameInMap("IpAddress")]
                [Validation(Required=false)]
                public string IpAddress { get; set; }

                /// <summary>
                /// <para>The region ID of the GA instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ap-southeast-1</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The IP address of the backend service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>172.24.52.234</para>
                /// </summary>
                [NameInMap("ServerIpAddress")]
                [Validation(Required=false)]
                public string ServerIpAddress { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A8252014-D8DE-4D85-AF35-AFEXXXXXXX</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
