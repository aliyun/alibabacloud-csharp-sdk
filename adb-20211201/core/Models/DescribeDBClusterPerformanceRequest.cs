// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeDBClusterPerformanceRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the AnalyticDB for MySQL Data Lakehouse Edition cluster.</para>
        /// <remarks>
        /// <para> You can call the <a href="~~~612397~~~">DescribeDBClusters</a> operation to query the IDs of all AnalyticDB for MySQL clusters within a region.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>amv-bp1hx5n1o8f61****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. Specify the time in the ISO 8601 standard in the <em>yyyy-MM-ddTHH:mmZ</em> format. The time must be in UTC.</para>
        /// <remarks>
        /// <para>The end time must be later than the start time. The maximum time range that can be specified is two days.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2022-03-11T15:01Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The performance metrics to be queried. Separate multiple values with commas (,). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>CPU</para>
        /// <list type="bullet">
        /// <item><description><b>AnalyticDB_CPU_Usage_Percentage</b>: the average CPU utilization.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Connections</para>
        /// <list type="bullet">
        /// <item><description><b>AnalyticDB_Instance_Connection_Count</b>: the number of database connections.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Writes</para>
        /// <list type="bullet">
        /// <item><description><b>AnalyticDB_TPS</b>: the write transactions per second (TPS).</description></item>
        /// <item><description><b>AnalyticDB_InsertRT</b>: the write response time.</description></item>
        /// <item><description><b>AnalyticDB_InsertBytes</b>: the write throughput.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Queries</para>
        /// <list type="bullet">
        /// <item><description><b>AnalyticDB_QPS</b>: the queries per second (QPS).</description></item>
        /// <item><description><b>AnalyticDB_QueryRT</b>: the query response time.</description></item>
        /// <item><description><b>AnalyticDB_QueryWaitTime</b>: the query wait time.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Disks</para>
        /// <list type="bullet">
        /// <item><description><b>AnalyticDB_Disk_IO_Avg_Usage_Percentage</b>: the average I/O utilization.</description></item>
        /// <item><description><b>AnalyticDB_Disk_IO_Avg_Waiting_Time</b>: the average I/O wait time.</description></item>
        /// <item><description><b>AnalyticDB_IO_Throughput</b>: the disk throughput.</description></item>
        /// <item><description><b>AnalyticDB_IOPS</b>: the disk IOPS.</description></item>
        /// <item><description><b>AnalyticDB_Disk_Usage</b>: the disk space that is used.</description></item>
        /// <item><description><b>AnalyticDB_Disk_Usage_Percentage</b>: the disk usage.</description></item>
        /// <item><description><b>AnalyticDB_Hot_Data_Usage</b>: the disk space that is used by hot data.</description></item>
        /// <item><description><b>AnalyticDB_Cold_Data_Usage</b>: the disk space that is used by code data.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter must be specified.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>AnalyticDB_CPU_Usage_Percentage</para>
        /// </summary>
        [NameInMap("Key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        /// <summary>
        /// <para>The region ID of the cluster.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/612393.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user_default</para>
        /// </summary>
        [NameInMap("ResourcePools")]
        [Validation(Required=false)]
        public string ResourcePools { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. Specify the time in the ISO 8601 standard in the <em>yyyy-MM-ddTHH:mmZ</em> format. The time must be in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-03-10T23:56Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
