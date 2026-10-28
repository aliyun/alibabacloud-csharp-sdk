// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class ListTrainingJobInstanceMetricsRequest : TeaModel {
        /// <summary>
        /// <para>The end UTC time in ISO 8601 format. If left empty, the current time is used.</para>
        /// <para>Use the UTC time format: yyyy-MM-ddTHH:mmZ</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-11-08T16:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>trains930928remn-master-0</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The metric type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>GpuCoreUsage: POD GPU utilization.</description></item>
        /// <item><description>GpuMemoryUsage: POD GPU memory utilization.</description></item>
        /// <item><description>CpuCoreUsage: POD CPU utilization.</description></item>
        /// <item><description>MemoryUsage: POD memory utilization.</description></item>
        /// <item><description>NetworkInputRate: POD network write rate (TCP/IP) (MB/s).</description></item>
        /// <item><description>NetworkOutputRate: POD network read rate (TCP/IP) (MB/s).</description></item>
        /// <item><description>DiskReadRate: POD disk read rate (MB/s).</description></item>
        /// <item><description>DiskWriteRate: POD disk write rate (MB/s).</description></item>
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
        /// <para>The start UTC time in ISO 8601 format. If left empty, the job start time is used.</para>
        /// <para>Use the UTC time format: yyyy-MM-ddTHH:mmZ</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-11-08T16:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The metric collection interval. Valid values: 1h, 30m, 5m, and 10s. h indicates hours, m indicates minutes, and s indicates seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10s</para>
        /// </summary>
        [NameInMap("TimeStep")]
        [Validation(Required=false)]
        public string TimeStep { get; set; }

    }

}
