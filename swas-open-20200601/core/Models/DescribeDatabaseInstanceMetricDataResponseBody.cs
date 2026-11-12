// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SWAS_OPEN20200601.Models
{
    public class DescribeDatabaseInstanceMetricDataResponseBody : TeaModel {
        /// <summary>
        /// <para>The format of the metric data. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>cpuusage&amp;memusage</c></para>
        /// </description></item>
        /// <item><description><para><c>active_session&amp;total_session</c></para>
        /// </description></item>
        /// <item><description><para><c>ins_size&amp;data_size&amp;log_size&amp;tmp_size&amp;other_size</c></para>
        /// </description></item>
        /// <item><description><para><c>io</c></para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cpuusage&amp;memusage</para>
        /// </summary>
        [NameInMap("DataFormat")]
        [Validation(Required=false)]
        public string DataFormat { get; set; }

        /// <summary>
        /// <para>The metric data details.</para>
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
        /// <item><description><para><c>MySQL_MemCpuUsage</c>: The CPU utilization and memory usage of the instance, as a percentage of the total resources of the operating system.</para>
        /// </description></item>
        /// <item><description><para><c>MySQL_DetailedSpaceUsage</c>: The total, data, log, temporary, and system disk space usage of the instance.</para>
        /// </description></item>
        /// <item><description><para><c>MySQL_Sessions</c>: The number of active and total connections.</para>
        /// </description></item>
        /// <item><description><para><c>MySQL_IOPS</c>: The IOPS of the instance.</para>
        /// </description></item>
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
        /// <para>The unit of the metric data.</para>
        /// <list type="bullet">
        /// <item><description><para>%</para>
        /// </description></item>
        /// <item><description><para>int</para>
        /// </description></item>
        /// <item><description><para>MB</para>
        /// </description></item>
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
