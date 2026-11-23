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
        /// <para>The end time of the query. Format: yyyy-MM-ddTHH:mmZ (UTC time).</para>
        /// <remarks>
        /// <para>The end time must be later than the start time, and the time interval between the start time and the end time cannot exceed 32 days.</para>
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
        /// <para>The names of the performance metrics to query. Separate multiple values with commas (,). You can query up to 5 performance metrics at a time. The following performance metrics are supported:</para>
        /// <remarks>
        /// <para><b>Key</b> is required.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><b>CPU</b>:<list type="bullet">
        /// <item><description><b>CPU_USAGE</b>: CPU utilization.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><b>Memory</b>:<list type="bullet">
        /// <item><description><b>MEM_USAGE</b>: Memory utilization.</description></item>
        /// <item><description><b>MEM_USAGE_SIZE</b>: Memory usage (unit: MB).</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><b>Disk</b>:<list type="bullet">
        /// <item><description><b>DISK_USAGE</b>: Disk utilization. </description></item>
        /// <item><description><b>DISK_USAGE_SIZE</b>: Disk usage (unit: MB).</description></item>
        /// <item><description><b>IOPS</b>: Disk IOPS.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><b>Connections</b>:<list type="bullet">
        /// <item><description><b>CONN_USAGE</b>: Database connection utilization.</description></item>
        /// <item><description><b>CONN_USAGE_COUNT</b>: Number of database connections in use.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><b>Writes</b>: <list type="bullet">
        /// <item><description><b>TPS</b>: Number of rows written per second.</description></item>
        /// <item><description><b>INSERT_SIZE</b>: Size of data written per second (unit: MB).</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><b>Queries</b>: <list type="bullet">
        /// <item><description><b>QPS</b>: Queries per second (QPS).</description></item>
        /// <item><description><b>AVG_SEEK</b>: Number of random SEEK calls.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><b>WAIT</b>: <list type="bullet">
        /// <item><description><b>ZK_WAIT</b>: Average wait time for ZooKeeper (unit: ms).</description></item>
        /// <item><description><b>IO_WAIT</b>: Average wait time for IO_WAIT (unit: ms).</description></item>
        /// <item><description><b>CPU_WAIT</b>: Average wait time for CPU_WAIT (unit: ms).</description></item>
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
        /// <para>The start time of the query. Format: yyyy-MM-ddTHH:mmZ (UTC time).</para>
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
