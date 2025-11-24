// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class DescribeVMsInServiceMeshResponseBody : TeaModel {
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
        /// <para>The VMs that are added to the ASM instance.</para>
        /// </summary>
        [NameInMap("VMs")]
        [Validation(Required=false)]
        public List<DescribeVMsInServiceMeshResponseBodyVMs> VMs { get; set; }
        public class DescribeVMsInServiceMeshResponseBodyVMs : TeaModel {
            /// <summary>
            /// <para>Indicates whether the ECS instance has labels.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("HasTag")]
            [Validation(Required=false)]
            public bool? HasTag { get; set; }

            /// <summary>
            /// <para>The host name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>iZ2ze45cgxkx4q12eh9l****</para>
            /// </summary>
            [NameInMap("HostName")]
            [Validation(Required=false)]
            public string HostName { get; set; }

            /// <summary>
            /// <para>The ID of the ECS instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-2ze45cgxkx4q12e****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The IP address of the ECS instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.0.<em>,</em>**</para>
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
