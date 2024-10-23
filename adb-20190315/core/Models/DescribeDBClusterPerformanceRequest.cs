// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeDBClusterPerformanceRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the AnalyticDB for MySQL cluster.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/129857.html">DescribeDBClusters</a> operation to query the IDs of all AnalyticDB for MySQL clusters within a region.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>am-************</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The end time of the query. Specify the time in the ISO 8601 standard in the <em>yyyy-MM-ddTHH:mmZ</em> format. The time must be in UTC.</para>
        /// <remarks>
        /// <para>The end time must be later than the start time. The maximum time range that can be specified is two days.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2021-05-03T15:01Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The performance metrics to be queried. Separate multiple values with commas (,). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>CPU</para>
        /// <list type="bullet">
        /// <item><description><b>AnalyticDB_CPU</b>: the average CPU utilization.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Connections</para>
        /// <list type="bullet">
        /// <item><description><b>AnalyticDB_Connections</b>: the number of connections of the cluster.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Writes</para>
        /// <list type="bullet">
        /// <item><description><b>AnalyticDB_TPS</b>: the write transactions per second (TPS).</description></item>
        /// <item><description><b>AnalyticDB_InsertRT</b>: the write response time.</description></item>
        /// <item><description><b>AnalyticDB_InsertBytes</b>: the write throughput.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Updates</para>
        /// <list type="bullet">
        /// <item><description><b>AnalyticDB_UpdateRT</b>: the update response time.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Deletes</para>
        /// <list type="bullet">
        /// <item><description><b>AnalyticDB_DeleteRT</b>: the delete response time.</description></item>
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
        /// <item><description><b>AnalyticDB_IO</b>: the disk I/O throughput.</description></item>
        /// <item><description><b>AnalyticDB_IO_UTIL</b>: the disk I/O usage.</description></item>
        /// <item><description><b>AnalyticDB_IO_WAIT</b>: the disk I/O wait time.</description></item>
        /// <item><description><b>AnalyticDB_IOPS</b>: the disk IOPS.</description></item>
        /// <item><description><b>AnalyticDB_DiskUsage</b>: the disk space that is used.</description></item>
        /// <item><description><b>AnalyticDB_HotDataDiskUsage</b>: the disk space that is used by hot data.</description></item>
        /// <item><description><b>AnalyticDB_ColdDataDiskUsage</b>: the disk space that is used by cold data.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Other</para>
        /// <list type="bullet">
        /// <item><description><b>AnalyticDB_BuildTaskCount</b>: the number of BUILD jobs.</description></item>
        /// <item><description><b>AnalyticDB_ComputeMemoryUsedRatio</b>: the compute memory usage.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para> If you leave this parameter empty, the values of all the preceding performance metrics are returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>AnalyticDB_CPU</para>
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

        /// <summary>
        /// <para>The region ID of the cluster.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The name of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("ResourcePools")]
        [Validation(Required=false)]
        public string ResourcePools { get; set; }

        /// <summary>
        /// <para>The start time of the query. Specify the time in the ISO 8601 standard in the <em>yyyy-MM-ddTHH:mmZ</em> format. The time must be in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-05-03T15:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
