// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeSpotAdviceRequest : TeaModel {
        /// <summary>
        /// <para>The number of vCPUs of the instance type. For more information, see <a href="https://help.aliyun.com/document_detail/25378.html">Instance families</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Cores")]
        [Validation(Required=false)]
        public int? Cores { get; set; }

        /// <summary>
        /// <para>The number of GPUs that a GPU-accelerated instance has. For information about the valid values, see <a href="https://help.aliyun.com/document_detail/108496.html">GPU-accelerated compute optimized instance types</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("GpuAmount")]
        [Validation(Required=false)]
        public int? GpuAmount { get; set; }

        /// <summary>
        /// <para>The GPU type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>NVIDIA P4</description></item>
        /// <item><description>NVIDIA T4</description></item>
        /// <item><description>NVIDIA P100</description></item>
        /// <item><description>NVIDIA V100</description></item>
        /// </list>
        /// <para>This parameter is left empty by default, which indicates that all GPU types are queried. For more information, see <a href="https://help.aliyun.com/document_detail/108496.html">GPU-accelerated compute-optimized and vGPU-accelerated instance families</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NVIDIA T4</para>
        /// </summary>
        [NameInMap("GpuSpec")]
        [Validation(Required=false)]
        public string GpuSpec { get; set; }

        /// <summary>
        /// <para>The level of the instance family. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>EntryLevel.</description></item>
        /// <item><description>EnterpriseLevel.</description></item>
        /// <item><description>CreditEntryLevel. For more information, see <a href="https://help.aliyun.com/document_detail/59977.html">Overview of burstable instances</a>.</description></item>
        /// </list>
        /// <para>This parameter is left empty by default, which indicates that instance families at all levels are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EntryLevel</para>
        /// </summary>
        [NameInMap("InstanceFamilyLevel")]
        [Validation(Required=false)]
        public string InstanceFamilyLevel { get; set; }

        /// <summary>
        /// <para>The instance family. For more information, see <a href="https://help.aliyun.com/document_detail/25378.html">Instance families</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs.c5</para>
        /// </summary>
        [NameInMap("InstanceTypeFamily")]
        [Validation(Required=false)]
        public string InstanceTypeFamily { get; set; }

        /// <summary>
        /// <para>The instance types. You can specify up to 10 instance types.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs.c5.large</para>
        /// </summary>
        [NameInMap("InstanceTypes")]
        [Validation(Required=false)]
        public List<string> InstanceTypes { get; set; }

        /// <summary>
        /// <para>The memory size of the instance type. Unit: GiB. For more information, see <a href="https://help.aliyun.com/document_detail/25378.html">Instance families</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8.0</para>
        /// </summary>
        [NameInMap("Memory")]
        [Validation(Required=false)]
        public float? Memory { get; set; }

        /// <summary>
        /// <para>The minimum number of vCPUs of the instance type. For more information, see <a href="https://help.aliyun.com/document_detail/25378.html">Instance families</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("MinCores")]
        [Validation(Required=false)]
        public int? MinCores { get; set; }

        /// <summary>
        /// <para>The minimum memory size of the instance type. For more information, see <a href="https://help.aliyun.com/document_detail/25378.html">Instance families</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8.0</para>
        /// </summary>
        [NameInMap("MinMemory")]
        [Validation(Required=false)]
        public float? MinMemory { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID. You can call the <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The zone ID.</para>
        /// <para>This parameter is left empty by default, which indicates that all zones in the specified region are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-i</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
