// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SWAS_OPEN20200601.Models
{
    public class DescribeDatabaseInstanceMetricDataRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the Simple Database Service instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>db-38263fa955774501a2ae1bdaed6f****</para>
        /// </summary>
        [NameInMap("DatabaseInstanceId")]
        [Validation(Required=false)]
        public string DatabaseInstanceId { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. Specify the time in the <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a> standard in the yyyy-MM-ddTHH:mmZ format. The time must be in UTC.</para>
        /// <remarks>
        /// <para>The time displayed in the Simple Application Server console is in the format of UTC+8.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-09-07T04:04Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The name of the metric. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>MySQL_MemCpuUsage: The CPU utilization and memory usage of the instance within the entire operating system.</description></item>
        /// <item><description>MySQL_DetailedSpaceUsage: The total space usage, data space, log space, temporary space, and system space of the instance.</description></item>
        /// <item><description>MySQL_Sessions : The total number of active connections.</description></item>
        /// <item><description>MySQL_IOPS: The IOPS of the instance.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MySQL_MemCpuUsage</para>
        /// </summary>
        [NameInMap("MetricName")]
        [Validation(Required=false)]
        public string MetricName { get; set; }

        /// <summary>
        /// <para>The region ID of the Simple Database Service instance. You can call the <a href="https://help.aliyun.com/document_detail/189315.html">ListRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. Specify the time in the <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a> standard in the yyyy-MM-ddTHH:mmZ format. The time must be in UTC.</para>
        /// <remarks>
        /// <para>The time displayed in the Simple Application Server console is in the format of UTC+8.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-09-06T04:04Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
