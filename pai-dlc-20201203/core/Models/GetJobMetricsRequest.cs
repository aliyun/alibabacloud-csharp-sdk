// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class GetJobMetricsRequest : TeaModel {
        /// <summary>
        /// <para>The end time (UTC) of the time range for querying monitoring data. Default value: the current time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-11-09T16:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The metric type of the monitoring data to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>GpuCoreUsage: GPU utilization.</para>
        /// </description></item>
        /// <item><description><para>GpuMemoryUsage: GPU memory usage.</para>
        /// </description></item>
        /// <item><description><para>CpuCoreUsage: CPU utilization.</para>
        /// </description></item>
        /// <item><description><para>MemoryUsage: memory usage.</para>
        /// </description></item>
        /// <item><description><para>NetworkInputRate: network input rate.</para>
        /// </description></item>
        /// <item><description><para>NetworkOutputRate: network output rate.</para>
        /// </description></item>
        /// <item><description><para>DiskReadRate: disk read rate.</para>
        /// </description></item>
        /// <item><description><para>DiskWriteRate: disk write rate.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>GpuMemoryUsage</para>
        /// </summary>
        [NameInMap("MetricType")]
        [Validation(Required=false)]
        public string MetricType { get; set; }

        /// <summary>
        /// <para>The start time (UTC) of the time range for querying monitoring data. Default value: one hour before the current time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-11-08T16:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The time interval at which monitoring data is returned. Default value: 5 minutes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5m</para>
        /// </summary>
        [NameInMap("TimeStep")]
        [Validation(Required=false)]
        public string TimeStep { get; set; }

        /// <summary>
        /// <para>The temporary token used for authentication.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eyXXXX-XXXX.XXXXX</para>
        /// </summary>
        [NameInMap("Token")]
        [Validation(Required=false)]
        public string Token { get; set; }

    }

}
