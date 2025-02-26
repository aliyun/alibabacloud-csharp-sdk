// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class DescribeResourceResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the cluster to which the resource group belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The total number of CPU cores.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16</para>
        /// </summary>
        [NameInMap("CpuCount")]
        [Validation(Required=false)]
        public int? CpuCount { get; set; }

        /// <summary>
        /// <para>The number of vCPUs that is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("CpuUsed")]
        [Validation(Required=false)]
        public int? CpuUsed { get; set; }

        /// <summary>
        /// <para>The time when the resource group was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-05-19T14:19:42Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The additional information, such as the connection status of a virtual private cloud (VPC) and the log status of Log Service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;vswitch_id&quot;:&quot;vsw-bp17uo6xebcusy****&quot;,&quot;gpu_share&quot;:true,&quot;aux_vswitch_id_list&quot;:[&quot;vsw-bp13b3pvjap3vxn****&quot;,&quot;vsw-bp1nls8o5hk8mt8*****&quot;],&quot;security_group_id&quot;:&quot;sg-bp1j1z7297hcink*****&quot;,&quot;vpc_id&quot;:&quot;vpc-bp1kjr3rfyhx01*****&quot;,&quot;destination_cidr&quot;:&quot;172.16.0.12/28&quot;,&quot;role_arn&quot;:&quot;acs:ram::1157703270*****:role/AliyunServiceRoleForPaiEas&quot;,&quot;sls_project&quot;:&quot;&quot;,&quot;sls_logstore&quot;:&quot;&quot;,&quot;sls_status&quot;:&quot;ResourceReady&quot;,&quot;sls_message&quot;:&quot;&quot;,&quot;update_time&quot;:&quot;&quot;}</para>
        /// </summary>
        [NameInMap("ExtraData")]
        [Validation(Required=false)]
        public string ExtraData { get; set; }

        /// <summary>
        /// <para>The total number of GPUs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("GpuCount")]
        [Validation(Required=false)]
        public int? GpuCount { get; set; }

        /// <summary>
        /// <para>The number of GPUs that is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("GpuUsed")]
        [Validation(Required=false)]
        public float? GpuUsed { get; set; }

        /// <summary>
        /// <para>The total number of instances in the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("InstanceCount")]
        [Validation(Required=false)]
        public int? InstanceCount { get; set; }

        /// <summary>
        /// <para>The total memory size. Unit: MB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8192</para>
        /// </summary>
        [NameInMap("Memory")]
        [Validation(Required=false)]
        public int? Memory { get; set; }

        /// <summary>
        /// <para>The size of memory that is used. Unit: MB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2048</para>
        /// </summary>
        [NameInMap("MemoryUsed")]
        [Validation(Required=false)]
        public int? MemoryUsed { get; set; }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Resource is ready</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the resource group owner.</para>
        /// 
        /// <b>Example:</b>
        /// <para>14401087478****</para>
        /// </summary>
        [NameInMap("OwnerUid")]
        [Validation(Required=false)]
        public string OwnerUid { get; set; }

        /// <summary>
        /// <para>The total number of pay-as-you-go instances in the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("PostPaidInstanceCount")]
        [Validation(Required=false)]
        public int? PostPaidInstanceCount { get; set; }

        /// <summary>
        /// <para>The total number of subscription instances in the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PrePaidInstanceCount")]
        [Validation(Required=false)]
        public int? PrePaidInstanceCount { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>902976F2-6FAF-5404-8A4D-6CC223***</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the Elastic Algorithm Service (EAS) resource.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eas-r-glkfpsxuw57x1h*****</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        /// <summary>
        /// <para>The name of the EAS resource.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-resouce****</para>
        /// </summary>
        [NameInMap("ResourceName")]
        [Validation(Required=false)]
        public string ResourceName { get; set; }

        /// <summary>
        /// <para>The type of the resource group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Dedicated: the dedicated resource group.</description></item>
        /// <item><description>SelfManaged: the self-managed resource group.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Dedicated</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The state of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ResourceReady</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The time when the resource group was last updated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-02-24T11:52:17Z</para>
        /// </summary>
        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

    }

}
