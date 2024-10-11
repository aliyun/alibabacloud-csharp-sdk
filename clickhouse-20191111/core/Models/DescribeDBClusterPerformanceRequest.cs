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
        /// <para>The end of the time range to query. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mmZ format. The time must be in UTC.</para>
        /// <remarks>
        /// <para> The end time must be later than the start time. The interval cannot be more than 32 days.</para>
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
        /// <para>The performance metrics that you want to query. Separate multiple performance metrics with commas (,). You can query up to five performance metrics at a time. You can query the following performance metrics:</para>
        /// <remarks>
        /// <para> The <b>Key</b> parameter is required.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para><b>CPU</b>:</para>
        /// <list type="bullet">
        /// <item><description><b>CPU_USAGE</b>: the CPU utilization</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>Memory</b>:</para>
        /// <list type="bullet">
        /// <item><description><b>MEM_USAGE</b>: the memory usage</description></item>
        /// <item><description><b>MEM_USAGE_SIZE</b>: the used memory. Unit: MB</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>Disk</b>:</para>
        /// <list type="bullet">
        /// <item><description><b>DISK_USAGE</b>: the disk usage</description></item>
        /// <item><description><b>DISK_USAGE_SIZE</b>: the size of the used disks. Unit: MB</description></item>
        /// <item><description><b>IOPS</b>: the disk Input/Output Operations per Second (IOPS)</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>Connection</b>:</para>
        /// <list type="bullet">
        /// <item><description><b>CONN_USAGE</b>: the database connection usage</description></item>
        /// <item><description><b>CONN_USAGE_COUNT</b>: the number of database connections used</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>Write</b>:</para>
        /// <list type="bullet">
        /// <item><description><b>TPS</b>: the number of rows written per second</description></item>
        /// <item><description><b>INSERT_SIZE</b>: the amount of data written per second. Unit: MB</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>Query</b>:</para>
        /// <list type="bullet">
        /// <item><description><b>QPS</b>: the queries per second</description></item>
        /// <item><description><b>AVG_SEEK</b>: the average number of random seek calls</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>WAIT</b>:</para>
        /// <list type="bullet">
        /// <item><description><b>ZK_WAIT</b>: the average ZooKeeper wait time. Unit: ms</description></item>
        /// <item><description><b>IO_WAIT</b>: the average I/O wait time. Unit: ms</description></item>
        /// <item><description><b>CPU_WAIT</b>: the average CPU wait time. Unit: ms</description></item>
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
        /// <para>The beginning of the time range to query. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mmZ format. The time must be in Coordinated Universal Time (UTC).</para>
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
