// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class JobViewMetric : TeaModel {
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
        /// <para>The GPU utilization.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("GPUUsageRate")]
        [Validation(Required=false)]
        public string GPUUsageRate { get; set; }

        /// <summary>
        /// <para>The job ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dsw-12580</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// <para>The job type, such as DLC or DSW.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TFJob</para>
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
        /// <para>The network inbound rate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("NetworkInputRate")]
        [Validation(Required=false)]
        public string NetworkInputRate { get; set; }

        /// <summary>
        /// <para>The network outbound rate.</para>
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
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg17tmvwiokhzaxg</para>
        /// </summary>
        [NameInMap("ResourceGroupID")]
        [Validation(Required=false)]
        public string ResourceGroupID { get; set; }

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
        /// <para>The total number of GPU cards.</para>
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
