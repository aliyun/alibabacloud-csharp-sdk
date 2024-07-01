// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeDBClusterPerformanceResponseBody : TeaModel {
        /// <summary>
        /// The ID of the AnalyticDB for MySQL Data Lakehouse Edition (V3.0) cluster.
        /// 
        /// > You can call the [DescribeDBClusters](https://help.aliyun.com/document_detail/454250.html) operation to query the IDs of all AnalyticDB for MySQL Data Lakehouse Edition (V3.0) clusters within a region.
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// The end time of the query. The time follows the ISO 8601 standard in the *yyyy-MM-ddTHH:mmZ* format. The time is displayed in UTC.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The queried performance metrics.
        /// </summary>
        [NameInMap("Performances")]
        [Validation(Required=false)]
        public List<DescribeDBClusterPerformanceResponseBodyPerformances> Performances { get; set; }
        public class DescribeDBClusterPerformanceResponseBodyPerformances : TeaModel {
            /// <summary>
            /// The name of the performance metric.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The queried performance metric data.
            /// </summary>
            [NameInMap("Series")]
            [Validation(Required=false)]
            public List<DescribeDBClusterPerformanceResponseBodyPerformancesSeries> Series { get; set; }
            public class DescribeDBClusterPerformanceResponseBodyPerformancesSeries : TeaModel {
                /// <summary>
                /// *   CPU
                /// 
                ///     *   **AnalyticDB_CPU_Usage_Percentage**: the CPU utilization.
                /// 
                ///         *   AnalyticDB_Storage_CPU_Avg_Usage_Percentage: the average CPU utilization across storage nodes.
                ///         *   AnalyticDB_Storage_CPU_Max_Usage_Percentage: the maximum CPU utilization across storage nodes.
                ///         *   AnalyticDB_Compute_CPU_Max_Usage_Percentage: the average CPU utilization across compute nodes.
                ///         *   AnalyticDB_Compute_CPU_Max_Usage_Percentage: the maximum CPU utilization across compute nodes.
                ///         *   AnalyticDB_CS_CPU_Avg_Usage_Percentage: the average CPU utilization across access nodes.
                ///         *   AnalyticDB_CS_CPU_Max_Usage_Percentage: the maximum CPU utilization across access nodes.
                /// 
                /// *   Connections
                /// 
                ///     *   **AnalyticDB_Instance_Connection_Count**: the number of connections to the cluster.
                /// 
                ///         *   AnalyticDB_Instance_Connection_Count: the number of connections to the cluster.
                /// 
                /// *   Writes
                /// 
                ///     *   **AnalyticDB_TPS**: the write TPS.
                /// 
                ///         *   tps: the sum of the insert_tps, update_tps, delete_tps, and load_tps values.
                ///         *   insert_tps: the number of successful INSERT INTO VALUES operations per second.
                ///         *   update_tps: the number of successful UPDATE operations per second.
                ///         *   delete_tps: the number of successful DELETE operations per second.
                ///         *   load_tps: the number of successful INSERT OVERWRITE operations per second.
                /// 
                ///     *   **AnalyticDB_InsertRT**: the write response time.
                /// 
                ///         *   AnalyticDB_Avg_InsertRT: the average amount of time consumed by writes.
                ///         *   AnalyticDB_Max_InsertRT: the maximum amount of time consumed by a single write.
                /// 
                ///     *   **AnalyticDB_InsertBytes**: the write throughput.
                /// 
                ///         *   AnalyticDB_InsertBytes: the amount of written data.
                /// 
                /// *   Updates
                /// 
                ///     *   **AnalyticDB_UpdateRT**: the update response time.
                /// 
                ///         *   updateinto_avg_rt: the average amount of time consumed by updates.
                ///         *   updateinto_max_rt: the maximum amount of time consumed by a single update.
                /// 
                /// *   Deletes
                /// 
                ///     *   **AnalyticDB_DeleteRT**: the delete response time.
                /// 
                ///         *   delete_avg_rt: the average amount of time consumed by deletes.
                ///         *   delete_max_rt: the maximum amount of time consumed by a single delete.
                /// 
                /// *   Queries
                /// 
                ///     *   **AnalyticDB_QPS**: the QPS.
                /// 
                ///         *   AnalyticDB_QPS: the number of SELECT operations completed per second.
                ///         *   AnalyticDB_ETL_QPS: the number of INSERT OVERWRITE operations completed per second.
                /// 
                ///     *   **AnalyticDB_QueryRT**: the query response time.
                /// 
                ///         *   AnalyticDB_Avg_QueryRT: the average amount of time consumed by queries.
                ///         *   AnalyticDB_Max_QueryRT: the maximum amount of time consumed by a single query.
                ///         *   etl_avg_rt: the average amount of time consumed by extract-transform-load (ETL) operations.
                ///         *   etl_max_rt: the maximum amount of time consumed by a single ETL operation.
                /// 
                ///     *   **AnalyticDB_QueryWaitTime**: the query wait time.
                /// 
                ///         *   AnalyticDB_Avg_QueryWaitTime: the average wait time for SELECT and ETL operations.
                ///         *   AnalyticDB_Max_QueryWaitTime: the maximum wait time for SELECT and ETL operations.
                /// 
                ///     *   AnalyticDB_QueryFailedRatio: the query failure rate.
                /// 
                ///         *   query_failed_ratio: the failure rate of SELECT and ETL operations.
                /// 
                /// *   Disks
                /// 
                ///     *   **AnalyticDB_IO_Throughput**: the disk I/O throughput.
                /// 
                ///         *   AnalyticDB_Storage_Read_IO_Throughput: the average read throughput across storage nodes.
                ///         *   AnalyticDB_Storage_Write_IO_Throughput: the average write throughput across storage nodes.
                ///         *   AnalyticDB_Compute_Read_IO_Throughput: the average read throughput across compute nodes.
                ///         *   AnalyticDB_Compute_Write_IO_Throughput: the average write throughput across compute nodes.
                /// 
                ///     *   **AnalyticDB_Disk_IO_Avg_Usage_Percentage**: the average I/O usage.
                /// 
                ///         *   AnalyticDB_Disk_IO_Avg_Usage_Percentage: the average I/O usage across storage nodes.
                /// 
                ///     *   **AnalyticDB_Disk_IO_Avg_Waiting_Time**: the average I/O wait time.
                /// 
                ///         *   AnalyticDB_Disk_IO_Avg_Waiting_Time: the average I/O wait time of storage nodes.
                /// 
                ///     *   **AnalyticDB_IOPS**: the disk IOPS.
                /// 
                ///         *   AnalyticDB_Storage_Read_IOPS: the average read IOPS of storage nodes.
                ///         *   AnalyticDB_Storage_Write_IOPS: the average write IOPS of storage nodes.
                ///         *   AnalyticDB_Compute_Read_IOPS: the average read IOPS of compute nodes.
                ///         *   AnalyticDB_Compute_Write_IOPS: the average write IOPS of compute nodes.
                /// 
                ///     *   **AnalyticDB_DiskUsage**: the disk storage that is used.
                /// 
                ///         *   disk_used_ratio: the average disk usage across nodes.
                ///         *   worker_max_node_disk_used_ratio: the maximum disk usage across nodes.
                /// 
                ///     *   **AnalyticDB_Hot_Data_Usage**: the disk storage that is used by hot data.
                /// 
                ///         *   AnalyticDB_Hot_Data_Usage: the disk storage that is used by hot data.
                /// 
                ///     *   **AnalyticDB_Cold_Data_Usage**: the disk storage that is used by cold data.
                /// 
                ///         *   AnalyticDB_Cold_Data_Usage: the disk storage that is used by cold data.
                /// 
                ///     *   AnalyticDB_DiskUsedRatio: the node disk usage.
                /// 
                ///         *   disk_used_ratio: the average disk usage across nodes.
                ///         *   worker_max_node_disk_used_ratio: the maximum disk usage across nodes.
                /// 
                ///     *   AnalyticDB_DiskUsedSize: the total data size of the cluster.
                /// 
                ///         *   user_used_disk_max: the maximum hot data size across nodes.
                ///         *   user_used_disk_avg: the average hot data size across nodes.
                ///         *   hot_disk_used: the hot data size.
                ///         *   cold_disk_used: the cold data size.
                /// 
                /// *   Other
                /// 
                ///     *   **AnalyticDB_BuildTaskCount**: the number of BUILD jobs.
                /// 
                ///         *   max_build_task_count: the maximum number of running BUILD jobs across nodes.
                ///         *   avg_build_task_count: the average number of running BUILD jobs across nodes.
                /// 
                ///     *   **AnalyticDB_ComputeMemoryUsedRatio**: the compute memory usage.
                /// 
                ///         *   max_worker_compute_memory_used_ratio: the maximum compute memory usage across storage nodes.
                ///         *   avg_worker_compute_memory_used_ratio: the average compute memory usage across storage nodes.
                ///         *   max_executor_compute_memory_used_ratio: the maximum compute memory usage across compute nodes.
                ///         *   avg_executor_compute_memory_used_ratio: the average compute memory usage across compute nodes.
                /// 
                ///     *   AnalyticDB_UnavailableNodeCount: the number of unavailable nodes.
                /// 
                ///         *   worker_unavailable_node_count: the number of unavailable storage nodes.
                ///         *   executor_unavailable_node_count: the number of unavailable compute nodes.
                /// 
                /// *   WLM
                /// 
                ///     *   AnalyticDB_WLM_ResubmitQueries_Count: the number of resubmitted WLM queries.
                /// 
                ///         *   AnalyticDB_WLM_ResubmitQueries_Count: the number of resubmitted WLM queries.
                /// 
                ///     *   AnalyticDB_WLM_SQA_AvgRt_MS: the average amount of time consumed by accelerated short WLM queries.
                /// 
                ///         *   AnalyticDB_WLM_SQA_AvgRt_MS: the average amount of time consumed by accelerated short WLM queries.
                /// 
                ///     *   AnalyticDB_WLM_SQA_Queries_Count: the number of accelerated short WLM queries.
                /// 
                ///         *   AnalyticDB_WLM_SQA_Queries_Count: the number of accelerated short WLM queries.
                /// 
                ///     *   AnalyticDB_WLM_TotalQueries_Count: the total number of WLM queries.
                /// 
                ///         *   AnalyticDB_WLM_TotalQueries_Count: the total number of WLM queries.
                /// 
                /// *   APS
                /// 
                ///     *   AnalyticDB_APS_BPS: the bytes per second (BPS) of APS provided by the AnalyticDB for MySQL Data Lakehouse Edition (V3.0) cluster.
                /// 
                ///         *   APS_Read_BPS: the read BPS of APS.
                /// 
                ///     *   AnalyticDB_APS_CPU: the CPU utilization of APS provided by the AnalyticDB for MySQL Data Lakehouse Edition (V3.0) cluster.
                /// 
                ///         *   APS_CPU_Avg_Usage_Percentage: the average CPU utilization of APS.
                ///         *   APS_CPU_Max_Usage_Percentage: the maximum CPU utilization of APS.
                /// 
                ///     *   AnalyticDB_APS_Memory: the memory usage of APS provided by the AnalyticDB for MySQL Data Lakehouse Edition (V3.0) cluster.
                /// 
                ///         *   APS_Memory_Avg_Usage_Percentage: the average memory usage of APS.
                ///         *   APS_Memory_Max_Usage_Percentage: the maximum memory usage of APS.
                /// 
                ///     *   AnalyticDB_APS_RPS: the number of records per second of APS provided by the AnalyticDB for MySQL Data Lakehouse Edition (V3.0) cluster.
                /// 
                ///         *   APS_Read_RPS: the number of read records per second of APS.
                /// 
                ///     *   AnalyticDB_APS_RT: the response time of APS provided by the AnalyticDB for MySQL Data Lakehouse Edition (V3.0) cluster.
                /// 
                ///         *   APS_Read_Avg_RT: the average response time of APS.
                ///         *   APS_Read_Max_RT: the maximum response time of APS.
                /// 
                /// *   *   *
                ///     *   *
                ///     *   *
                ///     *   *
                ///     *   *
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The tags that are added to the cluster.
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public string Tags { get; set; }

                /// <summary>
                /// The values of the performance metric at different points in time.
                /// </summary>
                [NameInMap("Values")]
                [Validation(Required=false)]
                public List<string> Values { get; set; }

            }

            /// <summary>
            /// The unit of the performance metric.
            /// </summary>
            [NameInMap("Unit")]
            [Validation(Required=false)]
            public string Unit { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The start time of the query. The time follows the ISO 8601 standard in the *yyyy-MM-ddTHH:mmZ* format. The time is displayed in UTC.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
