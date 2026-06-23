// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20191111.Models
{
    public class DescribeDBClusterPerformanceRequest : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cc-bp125e3uu94wo****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. Specify the time in UTC using the <c>yyyy-MM-ddTHH:mmZ</c> format.</para>
        /// <remarks>
        /// <para>The end time must be later than the start time. The maximum time range cannot exceed 32 days.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-11-27T16:38Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The performance metrics that you want to query. Separate multiple metric names with a comma (,). You can query up to five performance metrics at a time. The following performance metrics are supported:</para>
        /// <remarks>
        /// <para><b>Key</b> is required.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para><b>CPU</b>:</para>
        /// <list type="bullet">
        /// <item><description><b>CPU_USAGE</b>: The CPU utilization.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>Memory</b>:</para>
        /// <list type="bullet">
        /// <item><description><para><b>MEM_USAGE</b>: The memory utilization.</para>
        /// </description></item>
        /// <item><description><para><b>MEM_USAGE_SIZE</b>: The memory usage in MB.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>Disk</b>:</para>
        /// <list type="bullet">
        /// <item><description><para><b>DISK_USAGE</b>: The disk utilization.</para>
        /// </description></item>
        /// <item><description><para><b>DISK_USAGE_SIZE</b>: The disk usage in MB.</para>
        /// </description></item>
        /// <item><description><para><b>IOPS</b>: The disk input/output operations per second (IOPS).</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>Connection</b>:</para>
        /// <list type="bullet">
        /// <item><description><para><b>CONN_USAGE</b>: The database connection utilization.</para>
        /// </description></item>
        /// <item><description><para><b>CONN_USAGE_COUNT</b>: The number of database connections.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>Write</b>:</para>
        /// <list type="bullet">
        /// <item><description><para><b>TPS</b>: The number of rows written per second (TPS).</para>
        /// </description></item>
        /// <item><description><para><b>INSERT_SIZE</b>: The write size per second in MB.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>Query</b>:</para>
        /// <list type="bullet">
        /// <item><description><para><b>QPS</b>: The queries per second (QPS).</para>
        /// </description></item>
        /// <item><description><para><b>AVG_SEEK</b>: The number of random SEEK calls.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>WAIT</b>:</para>
        /// <list type="bullet">
        /// <item><description><para><b>ZK_WAIT</b>: The average wait time of ZooKeeper (ZK) in ms.</para>
        /// </description></item>
        /// <item><description><para><b>IO_WAIT</b>: The average I/O wait time in ms.</para>
        /// </description></item>
        /// <item><description><para><b>CPU_WAIT</b>: The average CPU wait time in ms.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>MEM_USAGE</para>
        /// </summary>
        [NameInMap("Key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. Specify the time in UTC using the <c>yyyy-MM-ddTHH:mmZ</c> format.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-11-27T16:37Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
