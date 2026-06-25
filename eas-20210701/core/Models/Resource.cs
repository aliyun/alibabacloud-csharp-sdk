// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class Resource : TeaModel {
        /// <summary>
        /// <para>The ID of the cluster where the resource group is located.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The total number of CPU cores in the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>64</para>
        /// </summary>
        [NameInMap("CpuCount")]
        [Validation(Required=false)]
        public int? CpuCount { get; set; }

        /// <summary>
        /// <para>The number of used CPU cores in the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("CpuUsed")]
        [Validation(Required=false)]
        public int? CpuUsed { get; set; }

        /// <summary>
        /// <para>The time the resource group was created, in ISO 8601 format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-02-26T17:52:49Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>Additional information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("ExtraData")]
        [Validation(Required=false)]
        public Dictionary<string, object> ExtraData { get; set; }

        /// <summary>
        /// <para>The features supported by the resource group.</para>
        /// </summary>
        [NameInMap("Features")]
        [Validation(Required=false)]
        public List<string> Features { get; set; }

        /// <summary>
        /// <para>The total number of GPUs in the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("GpuCount")]
        [Validation(Required=false)]
        public int? GpuCount { get; set; }

        /// <summary>
        /// <para>The number of used GPUs in the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("GpuUsed")]
        [Validation(Required=false)]
        public float? GpuUsed { get; set; }

        /// <summary>
        /// <para>The total number of instances (prepaid and postpaid) in the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("InstanceCount")]
        [Validation(Required=false)]
        public int? InstanceCount { get; set; }

        /// <summary>
        /// <para>The maximum number of allocatable CPU cores per node.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16</para>
        /// </summary>
        [NameInMap("InstanceMaxAllocatableCPU")]
        [Validation(Required=false)]
        public int? InstanceMaxAllocatableCPU { get; set; }

        /// <summary>
        /// <para>The maximum number of allocatable GPUs per node.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("InstanceMaxAllocatableGPU")]
        [Validation(Required=false)]
        public float? InstanceMaxAllocatableGPU { get; set; }

        /// <summary>
        /// <para>The maximum allocatable memory per node in the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2048</para>
        /// </summary>
        [NameInMap("InstanceMaxAllocatableMemory")]
        [Validation(Required=false)]
        public int? InstanceMaxAllocatableMemory { get; set; }

        /// <summary>
        /// <para>The total memory of the resource group, in MB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8192</para>
        /// </summary>
        [NameInMap("Memory")]
        [Validation(Required=false)]
        public int? Memory { get; set; }

        /// <summary>
        /// <para>The amount of used memory in the resource group, in MB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2048</para>
        /// </summary>
        [NameInMap("MemoryUsed")]
        [Validation(Required=false)]
        public int? MemoryUsed { get; set; }

        /// <summary>
        /// <para>The latest status message for the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Resource is ready</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The number of postpaid instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("PostPaidInstanceCount")]
        [Validation(Required=false)]
        public int? PostPaidInstanceCount { get; set; }

        /// <summary>
        /// <para>The number of prepaid instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("PrePaidInstanceCount")]
        [Validation(Required=false)]
        public int? PrePaidInstanceCount { get; set; }

        /// <summary>
        /// <para>The unique identifier of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eas-r-asdasdasd</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        /// <summary>
        /// <para>The name of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>iot</para>
        /// </summary>
        [NameInMap("ResourceName")]
        [Validation(Required=false)]
        public string ResourceName { get; set; }

        /// <summary>
        /// <para>The type of the resource group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>Dedicated</c>: A dedicated resource group.</para>
        /// </description></item>
        /// <item><description><para><c>SelfManaged</c>: A self-managed resource group.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Dedicated</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The number of services deployed in the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ServiceCount")]
        [Validation(Required=false)]
        public int? ServiceCount { get; set; }

        /// <summary>
        /// <para>The status of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ResourceReady</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The time the resource group was last updated, in ISO 8601 format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-02-26T19:52:49Z</para>
        /// </summary>
        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

        /// <summary>
        /// <para>The usage mode of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>inference</para>
        /// </summary>
        [NameInMap("UsageMode")]
        [Validation(Required=false)]
        public string UsageMode { get; set; }

        /// <summary>
        /// <para>The provider of the compute instances in the resource group, such as ECS.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ECS</para>
        /// </summary>
        [NameInMap("Vendor")]
        [Validation(Required=false)]
        public string Vendor { get; set; }

    }

}
