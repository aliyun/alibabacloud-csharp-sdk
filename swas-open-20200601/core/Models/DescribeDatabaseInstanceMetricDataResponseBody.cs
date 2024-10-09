// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SWAS_OPEN20200601.Models
{
    public class DescribeDatabaseInstanceMetricDataResponseBody : TeaModel {
        /// <summary>
        /// <para>The data format. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>cpuusage\&amp;memusage</description></item>
        /// <item><description>active_session\&amp;total_session</description></item>
        /// <item><description>ins_size\&amp;data_size\&amp;log_size\&amp;tmp_size\&amp;other_size</description></item>
        /// <item><description>io</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cpuusage&amp;memusage</para>
        /// </summary>
        [NameInMap("DataFormat")]
        [Validation(Required=false)]
        public string DataFormat { get; set; }

        /// <summary>
        /// <para>The monitoring data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[  {     \&quot;date&quot;\: &quot; 2022-09-06T04:04:00Z&quot;,\&quot;value\&quot;:\&quot;0.77&amp;3.69\&quot;  } ]</para>
        /// </summary>
        [NameInMap("MetricData")]
        [Validation(Required=false)]
        public string MetricData { get; set; }

        /// <summary>
        /// <para>The name of the metric. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>MySQL_MemCpuUsage: The CPU utilization and memory usage of the instance within the entire operating system.</description></item>
        /// <item><description>MySQL_DetailedSpaceUsage: The total space usage, data space, log space, temporary space, and system space of the instance.</description></item>
        /// <item><description>MySQL_Sessions : The total number of active connections.</description></item>
        /// <item><description>MySQL_IOPS: The IOPS of the instance.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>MySQL_MemCpuUsage</para>
        /// </summary>
        [NameInMap("MetricName")]
        [Validation(Required=false)]
        public string MetricName { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30637AD6-D977-4833-A54C-CC89483E****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The unit of the monitoring metric.</para>
        /// <list type="bullet">
        /// <item><description>%</description></item>
        /// <item><description>int</description></item>
        /// <item><description>MB</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>%</para>
        /// </summary>
        [NameInMap("Unit")]
        [Validation(Required=false)]
        public string Unit { get; set; }

    }

}
