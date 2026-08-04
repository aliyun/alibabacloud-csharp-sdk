// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class ListTrainingJobInstanceMetricsRequest : TeaModel {
        /// <summary>
        /// <para>End time in UTC, in ISO 8601 format. If empty, use the current time.</para>
        /// <para>Use the UTC time format: yyyy-MM-ddTHH:mmZ</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-11-08T16:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>Instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>trains930928remn-master-0</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Metric type:</para>
        /// <list type="bullet">
        /// <item><description><para>GpuCoreUsage: POD GPU usage</para>
        /// </description></item>
        /// <item><description><para>GpuMemoryUsage: POD GPU memory usage</para>
        /// </description></item>
        /// <item><description><para>CpuCoreUsage: POD CPU usage</para>
        /// </description></item>
        /// <item><description><para>MemoryUsage: POD memory usage</para>
        /// </description></item>
        /// <item><description><para>NetworkInputRate: POD network input rate (TCP/IP) (MB/s)</para>
        /// </description></item>
        /// <item><description><para>NetworkOutputRate: POD network output rate (TCP/IP) (MB/s)</para>
        /// </description></item>
        /// <item><description><para>DiskReadRate: POD disk read rate (MB/s)</para>
        /// </description></item>
        /// <item><description><para>DiskWriteRate: POD disk write rate (MB/s)</para>
        /// </description></item>
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
        /// <para>Start time in UTC, in ISO 8601 format. If empty, use the job start time.</para>
        /// <para>Use the UTC time format: yyyy-MM-ddTHH:mmZ</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-11-08T16:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>Time interval. Valid values: 1h, 30m, 5m, 10s.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10s</para>
        /// </summary>
        [NameInMap("TimeStep")]
        [Validation(Required=false)]
        public string TimeStep { get; set; }

    }

}
