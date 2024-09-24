// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeDBClusterPerformanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the AnalyticDB for MySQL Data Lakehouse Edition (V3.0) cluster.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/454250.html">DescribeDBClusters</a> operation to query the IDs of all AnalyticDB for MySQL Data Lakehouse Edition (V3.0) clusters within a region.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>amv-bp1hx5n1o8f61****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The end time of the query. The time follows the ISO 8601 standard in the <em>yyyy-MM-ddTHH:mmZ</em> format. The time is displayed in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-03-11T15:01Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The queried performance metrics.</para>
        /// </summary>
        [NameInMap("Performances")]
        [Validation(Required=false)]
        public List<DescribeDBClusterPerformanceResponseBodyPerformances> Performances { get; set; }
        public class DescribeDBClusterPerformanceResponseBodyPerformances : TeaModel {
            /// <summary>
            /// <para>The name of the performance metric.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AnalyticDB_CPU_Usage_Percentage</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The queried performance metric data.</para>
            /// </summary>
            [NameInMap("Series")]
            [Validation(Required=false)]
            public List<DescribeDBClusterPerformanceResponseBodyPerformancesSeries> Series { get; set; }
            public class DescribeDBClusterPerformanceResponseBodyPerformancesSeries : TeaModel {
                /// <summary>
                /// <list type="bullet">
                /// <item><description><para>CPU</para>
                /// <list type="bullet">
                /// <item><description><para><b>AnalyticDB_CPU_Usage_Percentage</b>: the CPU utilization.</para>
                /// <list type="bullet">
                /// <item><description>AnalyticDB_Storage_CPU_Avg_Usage_Percentage: the average CPU utilization across storage nodes.</description></item>
                /// <item><description>AnalyticDB_Storage_CPU_Max_Usage_Percentage: the maximum CPU utilization across storage nodes.</description></item>
                /// <item><description>AnalyticDB_Compute_CPU_Max_Usage_Percentage: the average CPU utilization across compute nodes.</description></item>
                /// <item><description>AnalyticDB_Compute_CPU_Max_Usage_Percentage: the maximum CPU utilization across compute nodes.</description></item>
                /// <item><description>AnalyticDB_CS_CPU_Avg_Usage_Percentage: the average CPU utilization across access nodes.</description></item>
                /// <item><description>AnalyticDB_CS_CPU_Max_Usage_Percentage: the maximum CPU utilization across access nodes.</description></item>
                /// </list>
                /// </description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para>Connections</para>
                /// <list type="bullet">
                /// <item><description><para><b>AnalyticDB_Instance_Connection_Count</b>: the number of connections to the cluster.</para>
                /// <list type="bullet">
                /// <item><description>AnalyticDB_Instance_Connection_Count: the number of connections to the cluster.</description></item>
                /// </list>
                /// </description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para>Writes</para>
                /// <list type="bullet">
                /// <item><description><para><b>AnalyticDB_TPS</b>: the write TPS.</para>
                /// <list type="bullet">
                /// <item><description>tps: the sum of the insert_tps, update_tps, delete_tps, and load_tps values.</description></item>
                /// <item><description>insert_tps: the number of successful INSERT INTO VALUES operations per second.</description></item>
                /// <item><description>update_tps: the number of successful UPDATE operations per second.</description></item>
                /// <item><description>delete_tps: the number of successful DELETE operations per second.</description></item>
                /// <item><description>load_tps: the number of successful INSERT OVERWRITE operations per second.</description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para><b>AnalyticDB_InsertRT</b>: the write response time.</para>
                /// <list type="bullet">
                /// <item><description>AnalyticDB_Avg_InsertRT: the average amount of time consumed by writes.</description></item>
                /// <item><description>AnalyticDB_Max_InsertRT: the maximum amount of time consumed by a single write.</description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para><b>AnalyticDB_InsertBytes</b>: the write throughput.</para>
                /// <list type="bullet">
                /// <item><description>AnalyticDB_InsertBytes: the amount of written data.</description></item>
                /// </list>
                /// </description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para>Updates</para>
                /// <list type="bullet">
                /// <item><description><para><b>AnalyticDB_UpdateRT</b>: the update response time.</para>
                /// <list type="bullet">
                /// <item><description>updateinto_avg_rt: the average amount of time consumed by updates.</description></item>
                /// <item><description>updateinto_max_rt: the maximum amount of time consumed by a single update.</description></item>
                /// </list>
                /// </description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para>Deletes</para>
                /// <list type="bullet">
                /// <item><description><para><b>AnalyticDB_DeleteRT</b>: the delete response time.</para>
                /// <list type="bullet">
                /// <item><description>delete_avg_rt: the average amount of time consumed by deletes.</description></item>
                /// <item><description>delete_max_rt: the maximum amount of time consumed by a single delete.</description></item>
                /// </list>
                /// </description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para>Queries</para>
                /// <list type="bullet">
                /// <item><description><para><b>AnalyticDB_QPS</b>: the QPS.</para>
                /// <list type="bullet">
                /// <item><description>AnalyticDB_QPS: the number of SELECT operations completed per second.</description></item>
                /// <item><description>AnalyticDB_ETL_QPS: the number of INSERT OVERWRITE operations completed per second.</description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para><b>AnalyticDB_QueryRT</b>: the query response time.</para>
                /// <list type="bullet">
                /// <item><description>AnalyticDB_Avg_QueryRT: the average amount of time consumed by queries.</description></item>
                /// <item><description>AnalyticDB_Max_QueryRT: the maximum amount of time consumed by a single query.</description></item>
                /// <item><description>etl_avg_rt: the average amount of time consumed by extract, transform, load (ETL) operations.</description></item>
                /// <item><description>etl_max_rt: the maximum amount of time consumed by a single ETL operation.</description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para><b>AnalyticDB_QueryWaitTime</b>: the query wait time.</para>
                /// <list type="bullet">
                /// <item><description>AnalyticDB_Avg_QueryWaitTime: the average wait time for SELECT and ETL operations.</description></item>
                /// <item><description>AnalyticDB_Max_QueryWaitTime: the maximum wait time for SELECT and ETL operations.</description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para>AnalyticDB_QueryFailedRatio: the query failure rate.</para>
                /// <list type="bullet">
                /// <item><description>query_failed_ratio: the failure rate of SELECT and ETL operations.</description></item>
                /// </list>
                /// </description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para>Disks</para>
                /// <list type="bullet">
                /// <item><description><para><b>AnalyticDB_IO_Throughput</b>: the disk I/O throughput.</para>
                /// <list type="bullet">
                /// <item><description>AnalyticDB_Storage_Read_IO_Throughput: the average read throughput across storage nodes.</description></item>
                /// <item><description>AnalyticDB_Storage_Write_IO_Throughput: the average write throughput across storage nodes.</description></item>
                /// <item><description>AnalyticDB_Compute_Read_IO_Throughput: the average read throughput across compute nodes.</description></item>
                /// <item><description>AnalyticDB_Compute_Write_IO_Throughput: the average write throughput across compute nodes.</description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para><b>AnalyticDB_Disk_IO_Avg_Usage_Percentage</b>: the average I/O usage.</para>
                /// <list type="bullet">
                /// <item><description>AnalyticDB_Disk_IO_Avg_Usage_Percentage: the average I/O usage across storage nodes.</description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para><b>AnalyticDB_Disk_IO_Avg_Waiting_Time</b>: the average I/O wait time.</para>
                /// <list type="bullet">
                /// <item><description>AnalyticDB_Disk_IO_Avg_Waiting_Time: the average I/O wait time of storage nodes.</description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para><b>AnalyticDB_IOPS</b>: the disk IOPS.</para>
                /// <list type="bullet">
                /// <item><description>AnalyticDB_Storage_Read_IOPS: the average read IOPS of storage nodes.</description></item>
                /// <item><description>AnalyticDB_Storage_Write_IOPS: the average write IOPS of storage nodes.</description></item>
                /// <item><description>AnalyticDB_Compute_Read_IOPS: the average read IOPS of compute nodes.</description></item>
                /// <item><description>AnalyticDB_Compute_Write_IOPS: the average write IOPS of compute nodes.</description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para><b>AnalyticDB_DiskUsage</b>: the disk storage that is used.</para>
                /// <list type="bullet">
                /// <item><description>disk_used_ratio: the average disk usage across nodes.</description></item>
                /// <item><description>worker_max_node_disk_used_ratio: the maximum disk usage across nodes.</description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para><b>AnalyticDB_Hot_Data_Usage</b>: the disk storage that is used by hot data.</para>
                /// <list type="bullet">
                /// <item><description>AnalyticDB_Hot_Data_Usage: the disk storage that is used by hot data.</description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para><b>AnalyticDB_Cold_Data_Usage</b>: the disk storage that is used by cold data.</para>
                /// <list type="bullet">
                /// <item><description>AnalyticDB_Cold_Data_Usage: the disk storage that is used by cold data.</description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para>AnalyticDB_DiskUsedRatio: the node disk usage.</para>
                /// <list type="bullet">
                /// <item><description>disk_used_ratio: the average disk usage across nodes.</description></item>
                /// <item><description>worker_max_node_disk_used_ratio: the maximum disk usage across nodes.</description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para>AnalyticDB_DiskUsedSize: the total data size of the cluster.</para>
                /// <list type="bullet">
                /// <item><description>user_used_disk_max: the maximum hot data size across nodes.</description></item>
                /// <item><description>user_used_disk_avg: the average hot data size across nodes.</description></item>
                /// <item><description>hot_disk_used: the hot data size.</description></item>
                /// <item><description>cold_disk_used: the cold data size.</description></item>
                /// </list>
                /// </description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para>Other</para>
                /// <list type="bullet">
                /// <item><description><para><b>AnalyticDB_BuildTaskCount</b>: the number of BUILD jobs.</para>
                /// <list type="bullet">
                /// <item><description>max_build_task_count: the maximum number of running BUILD jobs across nodes.</description></item>
                /// <item><description>avg_build_task_count: the average number of running BUILD jobs across nodes.</description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para><b>AnalyticDB_ComputeMemoryUsedRatio</b>: the compute memory usage.</para>
                /// <list type="bullet">
                /// <item><description>max_worker_compute_memory_used_ratio: the maximum compute memory usage across storage nodes.</description></item>
                /// <item><description>avg_worker_compute_memory_used_ratio: the average compute memory usage across storage nodes.</description></item>
                /// <item><description>max_executor_compute_memory_used_ratio: the maximum compute memory usage across compute nodes.</description></item>
                /// <item><description>avg_executor_compute_memory_used_ratio: the average compute memory usage across compute nodes.</description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para>AnalyticDB_UnavailableNodeCount: the number of unavailable nodes.</para>
                /// <list type="bullet">
                /// <item><description>worker_unavailable_node_count: the number of unavailable storage nodes.</description></item>
                /// <item><description>executor_unavailable_node_count: the number of unavailable compute nodes.</description></item>
                /// </list>
                /// </description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para>WLM</para>
                /// <list type="bullet">
                /// <item><description><para>AnalyticDB_WLM_ResubmitQueries_Count: the number of resubmitted WLM queries.</para>
                /// <list type="bullet">
                /// <item><description>AnalyticDB_WLM_ResubmitQueries_Count: the number of resubmitted WLM queries.</description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para>AnalyticDB_WLM_SQA_AvgRt_MS: the average amount of time consumed by accelerated short WLM queries.</para>
                /// <list type="bullet">
                /// <item><description>AnalyticDB_WLM_SQA_AvgRt_MS: the average amount of time consumed by accelerated short WLM queries.</description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para>AnalyticDB_WLM_SQA_Queries_Count: the number of accelerated short WLM queries.</para>
                /// <list type="bullet">
                /// <item><description>AnalyticDB_WLM_SQA_Queries_Count: the number of accelerated short WLM queries.</description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para>AnalyticDB_WLM_TotalQueries_Count: the total number of WLM queries.</para>
                /// <list type="bullet">
                /// <item><description>AnalyticDB_WLM_TotalQueries_Count: the total number of WLM queries.</description></item>
                /// </list>
                /// </description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para>AnalyticDB Pipeline Service (APS)</para>
                /// <list type="bullet">
                /// <item><description><para>AnalyticDB_APS_BPS: the bytes per second (BPS) of APS provided by the AnalyticDB for MySQL Data Lakehouse Edition cluster.</para>
                /// <list type="bullet">
                /// <item><description>APS_Read_BPS: the read BPS of APS.</description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para>AnalyticDB_APS_CPU: the CPU utilization of APS provided by the AnalyticDB for MySQL Data Lakehouse Edition cluster.</para>
                /// <list type="bullet">
                /// <item><description>APS_CPU_Avg_Usage_Percentage: the average CPU utilization of APS.</description></item>
                /// <item><description>APS_CPU_Max_Usage_Percentage: the maximum CPU utilization of APS.</description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para>AnalyticDB_APS_Memory: the memory usage of APS provided by the AnalyticDB for MySQL Data Lakehouse Edition cluster.</para>
                /// <list type="bullet">
                /// <item><description>APS_Memory_Avg_Usage_Percentage: the average memory usage of APS.</description></item>
                /// <item><description>APS_Memory_Max_Usage_Percentage: the maximum memory usage of APS.</description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para>AnalyticDB_APS_RPS: the number of records per second of APS provided by the AnalyticDB for MySQL Data Lakehouse Edition cluster.</para>
                /// <list type="bullet">
                /// <item><description>APS_Read_RPS: the number of read records per second of APS.</description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para>AnalyticDB_APS_RT: the response time of APS provided by the AnalyticDB for MySQL Data Lakehouse Edition cluster.</para>
                /// <list type="bullet">
                /// <item><description>APS_Read_Avg_RT: the average response time of APS.</description></item>
                /// <item><description>APS_Read_Max_RT: the maximum response time of APS.</description></item>
                /// </list>
                /// </description></item>
                /// </list>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>AnalyticDB_Storage_CPU_Avg_Usage_Percentage</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The tags that are added to the cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{instance_name: &quot;am-***&quot;}</para>
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public string Tags { get; set; }

                /// <summary>
                /// <para>The values of the performance metric at different points in time.</para>
                /// </summary>
                [NameInMap("Values")]
                [Validation(Required=false)]
                public List<string> Values { get; set; }

            }

            /// <summary>
            /// <para>The unit of the performance metric.</para>
            /// 
            /// <b>Example:</b>
            /// <para>%</para>
            /// </summary>
            [NameInMap("Unit")]
            [Validation(Required=false)]
            public string Unit { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BD8C3096-8BC6-51DF-A4AB-BACD9DC10435</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The start time of the query. The time follows the ISO 8601 standard in the <em>yyyy-MM-ddTHH:mmZ</em> format. The time is displayed in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-03-10T23:56Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
