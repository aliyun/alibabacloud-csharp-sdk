// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SWAS_OPEN20200601.Models
{
    public class DescribeDatabaseInstanceMetricDataRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the lightweight database instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>db-38263fa955774501a2ae1bdaed6f****</para>
        /// </summary>
        [NameInMap("DatabaseInstanceId")]
        [Validation(Required=false)]
        public string DatabaseInstanceId { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. Specify the time in the <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a> standard in the <c>yyyy-MM-ddTHH:mmZ</c> format. The time must be in UTC.</para>
        /// <remarks>
        /// <para>The time in the console is displayed in UTC+8.</para>
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
        /// <item><description><para><c>MySQL_MemCpuUsage</c>: The CPU utilization and memory usage of the instance, as a percentage of the total resources of the operating system.</para>
        /// </description></item>
        /// <item><description><para><c>MySQL_DetailedSpaceUsage</c>: The total, data, log, temporary, and system disk space usage of the instance.</para>
        /// </description></item>
        /// <item><description><para><c>MySQL_Sessions</c>: The number of active and total connections.</para>
        /// </description></item>
        /// <item><description><para><c>MySQL_IOPS</c>: The IOPS of the instance.</para>
        /// </description></item>
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
        /// <para>The region ID of the lightweight database instance. You can call the <a href="https://help.aliyun.com/document_detail/189315.html">ListRegions</a> operation to get the latest list of Alibaba Cloud regions.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The start of the time range to query. Specify the time in the <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a> standard in the <c>yyyy-MM-ddTHH:mmZ</c> format. The time must be in UTC.</para>
        /// <remarks>
        /// <para>The time in the console is displayed in UTC+8.</para>
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
