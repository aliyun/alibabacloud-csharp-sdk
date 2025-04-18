// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dsw20220101.Models
{
    public class GetInstanceMetricsRequest : TeaModel {
        /// <summary>
        /// <para>The end of the time range to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-11-08T15:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The metric type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>GpuCoreUsage: the GPU utilization.</description></item>
        /// <item><description>GpuMemoryUsage: the GPU memory utilization.</description></item>
        /// <item><description>CpuCoreUsage: the CPU utilization.</description></item>
        /// <item><description>MemoryUsage: the memory utilization.</description></item>
        /// <item><description>NetworkInputRate: the network ingress rate.</description></item>
        /// <item><description>NetworkOutputRate: the network egress rate.</description></item>
        /// <item><description>DiskReadRate: the disk read rate.</description></item>
        /// <item><description>DiskWriteRate: the disk write rate.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>GpuCoreUsage</para>
        /// </summary>
        [NameInMap("MetricType")]
        [Validation(Required=false)]
        public string MetricType { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-11-08T15:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The interval at which metrics are returned. Unit: minutes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15m</para>
        /// </summary>
        [NameInMap("TimeStep")]
        [Validation(Required=false)]
        public string TimeStep { get; set; }

    }

}
