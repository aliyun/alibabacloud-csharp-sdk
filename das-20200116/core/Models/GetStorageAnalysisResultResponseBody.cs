// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class GetStorageAnalysisResultResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code returned.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        /// <summary>
        /// The data returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetStorageAnalysisResultResponseBodyData Data { get; set; }
        public class GetStorageAnalysisResultResponseBodyData : TeaModel {
            /// <summary>
            /// The number of databases that have been analyzed.
            /// </summary>
            [NameInMap("AnalyzedDbCount")]
            [Validation(Required=false)]
            public long? AnalyzedDbCount { get; set; }

            /// <summary>
            /// The details of storage analysis.
            /// </summary>
            [NameInMap("StorageAnalysisResult")]
            [Validation(Required=false)]
            public GetStorageAnalysisResultResponseBodyDataStorageAnalysisResult StorageAnalysisResult { get; set; }
            public class GetStorageAnalysisResultResponseBodyDataStorageAnalysisResult : TeaModel {
                /// <summary>
                /// The reason why the analysis on the database and table fails.
                /// 
                /// *   **DB_OR_TABLE_NOT_EXIST**: The specified database or table does not exist.
                /// *   **DB_NOT_EXIST**: The specified database does not exist.
                /// </summary>
                [NameInMap("AnalysisErrorType")]
                [Validation(Required=false)]
                public string AnalysisErrorType { get; set; }

                /// <summary>
                /// Indicates whether the analysis on the database and table is successful.
                /// </summary>
                [NameInMap("AnalysisSuccess")]
                [Validation(Required=false)]
                public bool? AnalysisSuccess { get; set; }

                /// <summary>
                /// The estimated average daily growth of the used storage space in the previous seven days. Unit: bytes.
                /// </summary>
                [NameInMap("DailyIncrement")]
                [Validation(Required=false)]
                public long? DailyIncrement { get; set; }

                /// <summary>
                /// The estimated number of days for which the remaining storage space is available.
                /// </summary>
                [NameInMap("EstimateAvailableDays")]
                [Validation(Required=false)]
                public long? EstimateAvailableDays { get; set; }

                /// <summary>
                /// The items to be optimized, which are generated based on DAS default rules. You can ignore these items based on your business requirements, and create custom rules to generate items to be optimized based on other basic data that is returned.
                /// </summary>
                [NameInMap("NeedOptimizeItemList")]
                [Validation(Required=false)]
                public List<GetStorageAnalysisResultResponseBodyDataStorageAnalysisResultNeedOptimizeItemList> NeedOptimizeItemList { get; set; }
                public class GetStorageAnalysisResultResponseBodyDataStorageAnalysisResultNeedOptimizeItemList : TeaModel {
                    /// <summary>
                    /// The data associated with the items to be optimized, which is in the JSON format.
                    /// </summary>
                    [NameInMap("AssociatedData")]
                    [Validation(Required=false)]
                    public string AssociatedData { get; set; }

                    /// <summary>
                    /// The name of the database.
                    /// </summary>
                    [NameInMap("DbName")]
                    [Validation(Required=false)]
                    public string DbName { get; set; }

                    /// <summary>
                    /// The optimization suggestion. Valid values:
                    /// 
                    /// *   **NEED_ANALYZE_TABLE**: You can execute the `ANALYZE TABLE` statement on the table during off-peak hours. This is applicable only to ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters.
                    /// *   **NEED_OPTIMIZE_TABLE**: You can reclaim fragments during off-peak hours.
                    /// *   **CHANGE_TABLE_ENGINE_IF_NECESSARY**: Change the storage engine type of a table after risk assessment. This is applicable only to ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters.
                    /// *   **AUTO_INCREMENT_ID_BE_TO_RUN_OUT**: Pay attention to the usage of auto-increment IDs. This is applicable only to ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters.
                    /// *   **DUPLICATE_INDEX**: Optimize indexes of tables. This is applicable only to ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters.
                    /// *   **TABLE_SIZE**: Pay attention to the table size. This is applicable only to ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters.
                    /// *   **TABLE_ROWS_AND_AVG_ROW_LENGTH**: Pay attention to the number of rows in a table and the average row length. This is applicable only to ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters.
                    /// *   **STORAGE_USED_PERCENT**: Pay attention to the space usage to prevent the instance from being locked if the instance is full.
                    /// </summary>
                    [NameInMap("OptimizeAdvice")]
                    [Validation(Required=false)]
                    public string OptimizeAdvice { get; set; }

                    /// <summary>
                    /// The item to be optimized. Valid values:
                    /// 
                    /// *   **NEED_ANALYZE_TABLE**: tables whose storage statistics obtained from `information_schema.tables` are 50 GB larger or smaller than the physical file sizes. This is applicable only to ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters.
                    /// 
                    /// *   **NEED_OPTIMIZE_TABLE**: tables whose space fragments are larger than 6 GB and whose fragmentation rates are greater than 30%. The fragmentation rate of a table is generally calculated based on the following formulas:
                    /// 
                    ///     *   ApsaraDB RDS for MySQL and PolarDB for MySQL: `Fragmentation rate = DataFree/(DataSize + IndexSize + DataFree)`. In this topic, PhyTotalSize = DataSize + IndexSize + DataFree. Thus, the fragmentation rate can be calculated based on the following formula: `Fragmentation rate = DataFree/PhyTotalSize`.
                    ///     *   ApsaraDB for MongoDB: `Fragmentation rate = FragmentSize/PhyTotalSize`.
                    /// 
                    /// *   **TABLE_ENGINE**: tables whose storage engines are not InnoDB or XEngine. This is applicable only to ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters.
                    /// 
                    /// *   **AUTO_INCREMENT_ID_BE_TO_RUN_OUT**: tables whose usages of auto-increment IDs exceed 80%. This is applicable only to ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters.
                    /// 
                    /// *   **DUPLICATE_INDEX**: tables whose indexes are redundant or duplicate. This is applicable only to ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters.
                    /// 
                    /// *   **TABLE_SIZE**: single tables whose sizes are larger than 50 GB. This is applicable only to ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters.
                    /// 
                    /// *   **TABLE_ROWS_AND_AVG_ROW_LENGTH**: single tables that contain more than 5 million rows and whose average row lengths exceed 10 KB. This is applicable only to ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters.
                    /// 
                    /// *   **TOTAL_DATA_FREE**: instances whose reclaimable space is larger than 60 GB and whose total fragmentation rate is larger than 5%.
                    /// 
                    /// *   **STORAGE_USED_PERCENT**: instances whose space usage is larger than 90%.
                    /// </summary>
                    [NameInMap("OptimizeItemName")]
                    [Validation(Required=false)]
                    public string OptimizeItemName { get; set; }

                    /// <summary>
                    /// The name of the table.
                    /// </summary>
                    [NameInMap("TableName")]
                    [Validation(Required=false)]
                    public string TableName { get; set; }

                }

                /// <summary>
                /// The information about the table.
                /// </summary>
                [NameInMap("TableStats")]
                [Validation(Required=false)]
                public List<GetStorageAnalysisResultResponseBodyDataStorageAnalysisResultTableStats> TableStats { get; set; }
                public class GetStorageAnalysisResultResponseBodyDataStorageAnalysisResultTableStats : TeaModel {
                    /// <summary>
                    /// The average length of rows. Unit: bytes.
                    /// </summary>
                    [NameInMap("AvgRowLength")]
                    [Validation(Required=false)]
                    public long? AvgRowLength { get; set; }

                    /// <summary>
                    /// The size of space fragments. Unit: bytes.
                    /// 
                    /// >  This parameter is applicable only to ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters. The fragmentation rate of a table is generally calculated based on the following formula: `Fragmentation rate = DataFree/(DataSize + IndexSize + DataFree)`. In this topic, `Fragmentation rate = DataFree/PhyTotalSize`.
                    /// </summary>
                    [NameInMap("DataFree")]
                    [Validation(Required=false)]
                    public long? DataFree { get; set; }

                    /// <summary>
                    /// *   For ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters, this parameter indicates the amount of space occupied by data. Unit: bytes.
                    /// *   For ApsaraDB for MongoDB instances, this parameter indicates the size of uncompressed data, that is, the amount of data. Unit: bytes.
                    /// </summary>
                    [NameInMap("DataSize")]
                    [Validation(Required=false)]
                    public long? DataSize { get; set; }

                    /// <summary>
                    /// The name of the database.
                    /// </summary>
                    [NameInMap("DbName")]
                    [Validation(Required=false)]
                    public string DbName { get; set; }

                    /// <summary>
                    /// The type of the storage engine used by the table.
                    /// 
                    /// >  This parameter is applicable only to ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters.
                    /// </summary>
                    [NameInMap("Engine")]
                    [Validation(Required=false)]
                    public string Engine { get; set; }

                    /// <summary>
                    /// The size of space that can be reclaimed. Unit: bytes.
                    /// 
                    /// >  This parameter is applicable only to ApsaraDB for MongoDB instances. `Fragmentation rate = FragmentSize/PhyTotalSize`.
                    /// </summary>
                    [NameInMap("FragmentSize")]
                    [Validation(Required=false)]
                    public long? FragmentSize { get; set; }

                    /// <summary>
                    /// The storage space occupied by indexes. Unit: bytes.
                    /// </summary>
                    [NameInMap("IndexSize")]
                    [Validation(Required=false)]
                    public long? IndexSize { get; set; }

                    /// <summary>
                    /// The storage space of the table. Unit: bytes.
                    /// 
                    /// >  For ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters, the value of the parameter is the sum of **DataSize**, **IndexSize**, and **DataFree**. For ApsaraDB for MongoDB instances, the value of this parameter is the sum of **DataSize** and **IndexSize**.
                    /// </summary>
                    [NameInMap("PhyTotalSize")]
                    [Validation(Required=false)]
                    public long? PhyTotalSize { get; set; }

                    /// <summary>
                    /// The physical file size of the table. Unit: bytes.
                    /// 
                    /// >  This parameter is applicable only to ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters. Data of specific database instances cannot be obtained due to deployment mode.
                    /// </summary>
                    [NameInMap("PhysicalFileSize")]
                    [Validation(Required=false)]
                    public long? PhysicalFileSize { get; set; }

                    /// <summary>
                    /// The name of the table.
                    /// </summary>
                    [NameInMap("TableName")]
                    [Validation(Required=false)]
                    public string TableName { get; set; }

                    /// <summary>
                    /// The number of rows in the table.
                    /// </summary>
                    [NameInMap("TableRows")]
                    [Validation(Required=false)]
                    public long? TableRows { get; set; }

                    /// <summary>
                    /// The type of the table.
                    /// 
                    /// >  This parameter is applicable only to ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters.
                    /// </summary>
                    [NameInMap("TableType")]
                    [Validation(Required=false)]
                    public string TableType { get; set; }

                    /// <summary>
                    /// *   For ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters, this parameter indicates the amount of space occupied by table data and indexes. Unit: bytes. The value is the sum of **DataSize** and **IndexSize**.
                    /// *   For ApsaraDB for MongoDB instances, this parameter indicates the actual size of space allocated by Block Manager. Unit: Bytes. The compression ratio of an ApsaraDB for MongoDB instance is calculated based on the following formula: `Compression ratio = TotalSize/DataSize`.
                    /// </summary>
                    [NameInMap("TotalSize")]
                    [Validation(Required=false)]
                    public long? TotalSize { get; set; }

                }

                /// <summary>
                /// The size of remaining storage.
                /// 
                /// >  Unit: bytes.
                /// </summary>
                [NameInMap("TotalFreeStorageSize")]
                [Validation(Required=false)]
                public long? TotalFreeStorageSize { get; set; }

                /// <summary>
                /// The total size of instance storage.
                /// 
                /// >  Unit: bytes.
                /// </summary>
                [NameInMap("TotalStorageSize")]
                [Validation(Required=false)]
                public long? TotalStorageSize { get; set; }

                /// <summary>
                /// The size of used storage.
                /// 
                /// >  Unit: bytes.
                /// </summary>
                [NameInMap("TotalUsedStorageSize")]
                [Validation(Required=false)]
                public long? TotalUsedStorageSize { get; set; }

            }

            /// <summary>
            /// Indicates whether the task is complete.
            /// </summary>
            [NameInMap("TaskFinish")]
            [Validation(Required=false)]
            public bool? TaskFinish { get; set; }

            /// <summary>
            /// The task ID.
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// The task progress.
            /// 
            /// >  Valid values are integers that range from 0 to 100.
            /// </summary>
            [NameInMap("TaskProgress")]
            [Validation(Required=false)]
            public long? TaskProgress { get; set; }

            /// <summary>
            /// The status of the storage analysis task. Valid values:
            /// 
            /// *   **INIT**: The task is being initialized.
            /// *   **PENDING**: The task is being queued for execution.
            /// *   **RECEIVED**: The task is received for execution.
            /// *   **RUNNING**: The task is being executed.
            /// *   **RETRY**: The task is being retried.
            /// *   **SUCCESS**: The task succeeds.
            /// *   **FAILURE**: The task fails.
            /// </summary>
            [NameInMap("TaskState")]
            [Validation(Required=false)]
            public string TaskState { get; set; }

            /// <summary>
            /// Indicates whether the task is successful.
            /// </summary>
            [NameInMap("TaskSuccess")]
            [Validation(Required=false)]
            public bool? TaskSuccess { get; set; }

            /// <summary>
            /// The number of databases that need to be analyzed in the storage analysis task.
            /// </summary>
            [NameInMap("TotalDbCount")]
            [Validation(Required=false)]
            public long? TotalDbCount { get; set; }

        }

        /// <summary>
        /// The returned message.
        /// 
        /// >  If the request is successful, **Successful** is returned. Otherwise, an error message such as an error code is returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request is successful. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
