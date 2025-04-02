// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class GetJobMetricsRequest : TeaModel {
        /// <summary>
        /// <para>The end time of the time range to query monitoring data. The time is displayed in UTC. The default value is the current time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-11-09T16:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The type of the monitoring metrics. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>GpuCoreUsage: GPU utilization</description></item>
        /// <item><description>GpuMemoryUsage: GPU memory utilization</description></item>
        /// <item><description>CpuCoreUsage: CPU utilization</description></item>
        /// <item><description>MemoryUsage: memory utilization</description></item>
        /// <item><description>NetworkInputRate: the network write in rate.</description></item>
        /// <item><description>NetworkOutputRate: the network write out rate</description></item>
        /// <item><description>DiskReadRate: the disk read rate</description></item>
        /// <item><description>DiskWriteRate: the disk write rate</description></item>
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
        /// <para>The beginning of the time range to query monitoring data. The time is displayed in UTC. The default value is the time 1 hour before the current time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-11-08T16:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The interval at which monitoring data is returned. Default value: 5. Unit: minutes.</para>
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
