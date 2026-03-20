// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class Resource : TeaModel {
        /// <summary>
        /// <para>The information about the clusters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The total number of CPU cores.</para>
        /// 
        /// <b>Example:</b>
        /// <para>64</para>
        /// </summary>
        [NameInMap("CpuCount")]
        [Validation(Required=false)]
        public int? CpuCount { get; set; }

        [NameInMap("CpuUsed")]
        [Validation(Required=false)]
        public int? CpuUsed { get; set; }

        /// <summary>
        /// <para>The time when the instance was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-02-26T17:52:49Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The additional information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("ExtraData")]
        [Validation(Required=false)]
        public Dictionary<string, object> ExtraData { get; set; }

        [NameInMap("Features")]
        [Validation(Required=false)]
        public List<string> Features { get; set; }

        /// <summary>
        /// <para>The total number of GPUs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("GpuCount")]
        [Validation(Required=false)]
        public int? GpuCount { get; set; }

        [NameInMap("GpuUsed")]
        [Validation(Required=false)]
        public float? GpuUsed { get; set; }

        /// <summary>
        /// <para>The total number of instances. It is equal to the number of subscription instances plus the number of pay-as-you-go instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("InstanceCount")]
        [Validation(Required=false)]
        public int? InstanceCount { get; set; }

        [NameInMap("InstanceMaxAllocatableCPU")]
        [Validation(Required=false)]
        public int? InstanceMaxAllocatableCPU { get; set; }

        [NameInMap("InstanceMaxAllocatableGPU")]
        [Validation(Required=false)]
        public float? InstanceMaxAllocatableGPU { get; set; }

        [NameInMap("InstanceMaxAllocatableMemory")]
        [Validation(Required=false)]
        public int? InstanceMaxAllocatableMemory { get; set; }

        [NameInMap("Memory")]
        [Validation(Required=false)]
        public int? Memory { get; set; }

        [NameInMap("MemoryUsed")]
        [Validation(Required=false)]
        public int? MemoryUsed { get; set; }

        /// <summary>
        /// <para>The latest message about the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Resource is ready</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The number of pay-as-you-go instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("PostPaidInstanceCount")]
        [Validation(Required=false)]
        public int? PostPaidInstanceCount { get; set; }

        /// <summary>
        /// <para>The number of subscription instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("PrePaidInstanceCount")]
        [Validation(Required=false)]
        public int? PrePaidInstanceCount { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
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
        /// <para>The status of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ResouceReady</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The time when the instance was last updated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-02-26T19:52:49Z</para>
        /// </summary>
        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

        /// <summary>
        /// <para>The vendor of the resource group instances.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ECS</description></item>
        /// <item><description>BareMetal</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ECS</para>
        /// </summary>
        [NameInMap("Vendor")]
        [Validation(Required=false)]
        public string Vendor { get; set; }

    }

}
