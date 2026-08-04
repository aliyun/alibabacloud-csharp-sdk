// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class UserViewMetric : TeaModel {
        /// <summary>
        /// <para>Number of CPU nodes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("CPUNodeNumber")]
        [Validation(Required=false)]
        public int? CPUNodeNumber { get; set; }

        /// <summary>
        /// <para>CPU usage rate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>59</para>
        /// </summary>
        [NameInMap("CPUUsageRate")]
        [Validation(Required=false)]
        public string CPUUsageRate { get; set; }

        /// <summary>
        /// <para>CPU jobs.</para>
        /// </summary>
        [NameInMap("CpuJobNames")]
        [Validation(Required=false)]
        public List<string> CpuJobNames { get; set; }

        /// <summary>
        /// <para>List of CPU nodes.</para>
        /// </summary>
        [NameInMap("CpuNodeNames")]
        [Validation(Required=false)]
        public List<string> CpuNodeNames { get; set; }

        /// <summary>
        /// <para>Disk read rate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>22</para>
        /// </summary>
        [NameInMap("DiskReadRate")]
        [Validation(Required=false)]
        public string DiskReadRate { get; set; }

        /// <summary>
        /// <para>Disk write rate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>22</para>
        /// </summary>
        [NameInMap("DiskWriteRate")]
        [Validation(Required=false)]
        public string DiskWriteRate { get; set; }

        /// <summary>
        /// <para>Number of GPU nodes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("GPUNodeNumber")]
        [Validation(Required=false)]
        public int? GPUNodeNumber { get; set; }

        /// <summary>
        /// <para>GPU usage rate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("GPUUsageRate")]
        [Validation(Required=false)]
        public string GPUUsageRate { get; set; }

        /// <summary>
        /// <para>GPU jobs.</para>
        /// </summary>
        [NameInMap("GpuJobNames")]
        [Validation(Required=false)]
        public List<string> GpuJobNames { get; set; }

        /// <summary>
        /// <para>List of GPU nodes.</para>
        /// </summary>
        [NameInMap("GpuNodeNames")]
        [Validation(Required=false)]
        public List<string> GpuNodeNames { get; set; }

        /// <summary>
        /// <para>Job type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PyTorch</para>
        /// </summary>
        [NameInMap("JobType")]
        [Validation(Required=false)]
        public string JobType { get; set; }

        /// <summary>
        /// <para>Memory usage rate.</para>
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
        /// <para>Network output rate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("NetworkOutputRate")]
        [Validation(Required=false)]
        public string NetworkOutputRate { get; set; }

        /// <summary>
        /// <para>List of nodes.</para>
        /// </summary>
        [NameInMap("NodeNames")]
        [Validation(Required=false)]
        public List<string> NodeNames { get; set; }

        /// <summary>
        /// <para>Number of CPU cores allocated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("RequestCPU")]
        [Validation(Required=false)]
        public int? RequestCPU { get; set; }

        /// <summary>
        /// <para>Number of GPU cores allocated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("RequestGPU")]
        [Validation(Required=false)]
        public int? RequestGPU { get; set; }

        /// <summary>
        /// <para>Allocated memory, in KB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>102400000</para>
        /// </summary>
        [NameInMap("RequestMemory")]
        [Validation(Required=false)]
        public long? RequestMemory { get; set; }

        /// <summary>
        /// <para>Resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg17tmvwiokh****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>Total number of CPU cores.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("TotalCPU")]
        [Validation(Required=false)]
        public int? TotalCPU { get; set; }

        /// <summary>
        /// <para>Total number of GPU cards.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalGPU")]
        [Validation(Required=false)]
        public int? TotalGPU { get; set; }

        /// <summary>
        /// <para>Total memory, in KB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10240</para>
        /// </summary>
        [NameInMap("TotalMemory")]
        [Validation(Required=false)]
        public long? TotalMemory { get; set; }

        /// <summary>
        /// <para>User ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16111111****</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
