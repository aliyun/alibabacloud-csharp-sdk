// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ListConvertableEcuResponseBody : TeaModel {
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
        /// <para>The ECS instances that can be imported to the cluster.</para>
        /// </summary>
        [NameInMap("InstanceList")]
        [Validation(Required=false)]
        public ListConvertableEcuResponseBodyInstanceList InstanceList { get; set; }
        public class ListConvertableEcuResponseBodyInstanceList : TeaModel {
            [NameInMap("Instance")]
            [Validation(Required=false)]
            public List<ListConvertableEcuResponseBodyInstanceListInstance> Instance { get; set; }
            public class ListConvertableEcuResponseBodyInstanceListInstance : TeaModel {
                /// <summary>
                /// <para>The number of CPU cores of the ECS instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Cpu")]
                [Validation(Required=false)]
                public int? Cpu { get; set; }

                /// <summary>
                /// <para>The ID of the elastic compute units (ECU).</para>
                /// 
                /// <b>Example:</b>
                /// <para>b197-40ab-9155-7ca7</para>
                /// </summary>
                [NameInMap("EcuId")]
                [Validation(Required=false)]
                public string EcuId { get; set; }

                /// <summary>
                /// <para>The elastic IP address (EIP) associated with the ECS instance. The EIP can be changed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>13.xx.xxx.xx</para>
                /// </summary>
                [NameInMap("Eip")]
                [Validation(Required=false)]
                public string Eip { get; set; }

                /// <summary>
                /// <para>Indicates whether the ECS instance has expired.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Expired")]
                [Validation(Required=false)]
                public bool? Expired { get; set; }

                /// <summary>
                /// <para>The private IP address of the ECS instance. This parameter is valid only when the ECS instance is deployed in a VPC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>192.168.13.xx</para>
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
                /// <para>worker-k8s</para>
                /// </summary>
                [NameInMap("InstanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

                /// <summary>
                /// <para>The size of memory for the ECS instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4096</para>
                /// </summary>
                [NameInMap("Mem")]
                [Validation(Required=false)]
                public int? Mem { get; set; }

                /// <summary>
                /// <para>The private IP address of the ECS instance. This parameter is valid only when the ECS instance is deployed in a VPC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>192.XX.XX.123</para>
                /// </summary>
                [NameInMap("PrivateIp")]
                [Validation(Required=false)]
                public string PrivateIp { get; set; }

                /// <summary>
                /// <para>The public IP address of the ECS instance. This IP address can be used only by the ECS instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>13.xx.xx.xxx</para>
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
                /// <para>The state of the instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Pending: The instance is being created.</description></item>
                /// <item><description>Running: The instance is running.</description></item>
                /// <item><description>Starting: The instance is being started.</description></item>
                /// <item><description>Stopping: The instance is being stopped.</description></item>
                /// <item><description>Stopped: The instance is stopped.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Running</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The ID of the virtual private cloud (VPC).</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-2zef6ob8m************</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                /// <summary>
                /// <para>The name of the VPC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>jianwei-test</para>
                /// </summary>
                [NameInMap("VpcName")]
                [Validation(Required=false)]
                public string VpcName { get; set; }

            }

        }

        /// <summary>
        /// <para>The additional information that is returned.</para>
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
        /// <para>b197-40ab-9155-7ca7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
