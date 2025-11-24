// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class DescribeServiceMeshVMsResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4b2c0fe0-6705-4614-8521-6b9d289163c8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ECS instances that reside in the same VPC as the ASM instance.</para>
        /// </summary>
        [NameInMap("VMs")]
        [Validation(Required=false)]
        public List<DescribeServiceMeshVMsResponseBodyVMs> VMs { get; set; }
        public class DescribeServiceMeshVMsResponseBodyVMs : TeaModel {
            /// <summary>
            /// <para>Indicates whether the ECS instance has labels.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("HasTag")]
            [Validation(Required=false)]
            public bool? HasTag { get; set; }

            /// <summary>
            /// <para>The host name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>iZ2ze45cgxkx4q12eh****</para>
            /// </summary>
            [NameInMap("HostName")]
            [Validation(Required=false)]
            public string HostName { get; set; }

            /// <summary>
            /// <para>The ID of the ECS instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-2ze0kub9scdguom****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The IP address of the ECS instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.2.241</para>
            /// </summary>
            [NameInMap("IpAddress")]
            [Validation(Required=false)]
            public string IpAddress { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing</para>
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// <para>The security group to which the ECS instance belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sg-2zeaqy08amco9osl****</para>
            /// </summary>
            [NameInMap("SecurityGroupIds")]
            [Validation(Required=false)]
            public string SecurityGroupIds { get; set; }

            /// <summary>
            /// <para>The ASM instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ccb37ff104caf419fbf48fb38e6f3****</para>
            /// </summary>
            [NameInMap("ServiceMeshId")]
            [Validation(Required=false)]
            public string ServiceMeshId { get; set; }

            /// <summary>
            /// <para>The state of the ECS instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

    }

}
