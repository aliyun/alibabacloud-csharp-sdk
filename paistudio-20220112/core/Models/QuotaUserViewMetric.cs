// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class QuotaUserViewMetric : TeaModel {
        /// <summary>
        /// <para>The number of CPU nodes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("CPUNodeNumber")]
        [Validation(Required=false)]
        public int? CPUNodeNumber { get; set; }

        /// <summary>
        /// <para>The CPU utilization.</para>
        /// 
        /// <b>Example:</b>
        /// <para>59</para>
        /// </summary>
        [NameInMap("CPUUsageRate")]
        [Validation(Required=false)]
        public string CPUUsageRate { get; set; }

        /// <summary>
        /// <para>The CPU jobs.</para>
        /// </summary>
        [NameInMap("CpuJobNames")]
        [Validation(Required=false)]
        public List<string> CpuJobNames { get; set; }

        /// <summary>
        /// <para>The CPU node list.</para>
        /// </summary>
        [NameInMap("CpuNodeNames")]
        [Validation(Required=false)]
        public List<string> CpuNodeNames { get; set; }

        /// <summary>
        /// <para>The disk read rate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>22</para>
        /// </summary>
        [NameInMap("DiskReadRate")]
        [Validation(Required=false)]
        public string DiskReadRate { get; set; }

        /// <summary>
        /// <para>The disk write rate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>22</para>
        /// </summary>
        [NameInMap("DiskWriteRate")]
        [Validation(Required=false)]
        public string DiskWriteRate { get; set; }

        /// <summary>
        /// <para>The number of GPU nodes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("GPUNodeNumber")]
        [Validation(Required=false)]
        public int? GPUNodeNumber { get; set; }

        /// <summary>
        /// <para>The GPU utilization.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("GPUUsageRate")]
        [Validation(Required=false)]
        public string GPUUsageRate { get; set; }

        /// <summary>
        /// <para>The GPU jobs.</para>
        /// </summary>
        [NameInMap("GpuJobNames")]
        [Validation(Required=false)]
        public List<string> GpuJobNames { get; set; }

        /// <summary>
        /// <para>The GPU node list.</para>
        /// </summary>
        [NameInMap("GpuNodeNames")]
        [Validation(Required=false)]
        public List<string> GpuNodeNames { get; set; }

        /// <summary>
        /// <para>The job type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PyTorch</para>
        /// </summary>
        [NameInMap("JobType")]
        [Validation(Required=false)]
        public string JobType { get; set; }

        /// <summary>
        /// <para>The memory utilization.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MemoryUsageRate")]
        [Validation(Required=false)]
        public string MemoryUsageRate { get; set; }

        /// <summary>
        /// <para>The network input rate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("NetworkInputRate")]
        [Validation(Required=false)]
        public string NetworkInputRate { get; set; }

        /// <summary>
        /// <para>The network output rate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("NetworkOutputRate")]
        [Validation(Required=false)]
        public string NetworkOutputRate { get; set; }

        /// <summary>
        /// <para>The node list.</para>
        /// </summary>
        [NameInMap("NodeNames")]
        [Validation(Required=false)]
        public List<string> NodeNames { get; set; }

        /// <summary>
        /// <para>The number of requested CPU cores.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("RequestCPU")]
        [Validation(Required=false)]
        public int? RequestCPU { get; set; }

        /// <summary>
        /// <para>The number of requested GPU cores.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("RequestGPU")]
        [Validation(Required=false)]
        public int? RequestGPU { get; set; }

        /// <summary>
        /// <para>The requested memory in KB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>102400000</para>
        /// </summary>
        [NameInMap("RequestMemory")]
        [Validation(Required=false)]
        public long? RequestMemory { get; set; }

        /// <summary>
        /// <para>The total number of CPU cores.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("TotalCPU")]
        [Validation(Required=false)]
        public int? TotalCPU { get; set; }

        /// <summary>
        /// <para>The total number of GPUs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalGPU")]
        [Validation(Required=false)]
        public int? TotalGPU { get; set; }

        /// <summary>
        /// <para>The total memory in KB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10240</para>
        /// </summary>
        [NameInMap("TotalMemory")]
        [Validation(Required=false)]
        public long? TotalMemory { get; set; }

        /// <summary>
        /// <para>The user ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456789</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
