// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ListEcsNotInClusterResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The information about ECS instances.</para>
        /// </summary>
        [NameInMap("EcsEntityList")]
        [Validation(Required=false)]
        public ListEcsNotInClusterResponseBodyEcsEntityList EcsEntityList { get; set; }
        public class ListEcsNotInClusterResponseBodyEcsEntityList : TeaModel {
            [NameInMap("EcsEntity")]
            [Validation(Required=false)]
            public List<ListEcsNotInClusterResponseBodyEcsEntityListEcsEntity> EcsEntity { get; set; }
            public class ListEcsNotInClusterResponseBodyEcsEntityListEcsEntity : TeaModel {
                /// <summary>
                /// <para>The number of CPU cores.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Cpu")]
                [Validation(Required=false)]
                public int? Cpu { get; set; }

                /// <summary>
                /// <para>The elastic IP address (EIP) associated with the ECS instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>139.30.xxx.xx</para>
                /// </summary>
                [NameInMap("Eip")]
                [Validation(Required=false)]
                public string Eip { get; set; }

                /// <summary>
                /// <para>Indicates whether the ECS instance has expired. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>: The ECS instance has expired.</description></item>
                /// <item><description><b>false</b>: The ECS instance has not expired.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Expired")]
                [Validation(Required=false)]
                public bool? Expired { get; set; }

                /// <summary>
                /// <para>The private IP address of the ECS instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>192.168.20.113</para>
                /// </summary>
                [NameInMap("InnerIp")]
                [Validation(Required=false)]
                public string InnerIp { get; set; }

                /// <summary>
                /// <para>The ID of the ECS instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>i-2ze7s2v0b***********</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The name of the ECS instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>worker-k8s-for-cs-c9dfa009a5e7c4faab2010b87cae4****</para>
                /// </summary>
                [NameInMap("InstanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

                /// <summary>
                /// <para>The size of memory. Unit: bytes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4096</para>
                /// </summary>
                [NameInMap("Mem")]
                [Validation(Required=false)]
                public int? Mem { get; set; }

                /// <summary>
                /// <para>The private IP address of the ECS instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>192.168.<em>.</em>*</para>
                /// </summary>
                [NameInMap("PrivateIp")]
                [Validation(Required=false)]
                public string PrivateIp { get; set; }

                /// <summary>
                /// <para>The public IP address of the ECS instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>131.30.xxx.xx</para>
                /// </summary>
                [NameInMap("PublicIp")]
                [Validation(Required=false)]
                public string PublicIp { get; set; }

                /// <summary>
                /// <para>The ID of the region where the ECS instance is located.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-beijing</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The status of the ECS instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Pending</b>: The ECS instance is being created.</description></item>
                /// <item><description><b>Running</b>: The ECS instance is running.</description></item>
                /// <item><description><b>Starting</b>: The ECS instance is being started.</description></item>
                /// <item><description><b>Stopping</b>: The ECS instance is being stopped.</description></item>
                /// <item><description><b>Stopped</b>: The ECS instance is stopped.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Running</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The ID of the VPC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-2zef6ob8mrlzv8x3q****</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                /// <summary>
                /// <para>The name of the VPC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("VpcName")]
                [Validation(Required=false)]
                public string VpcName { get; set; }

            }

        }

        /// <summary>
        /// <para>The message that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b197-40ab-9155-****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
