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
        /// The returned data.
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
                /// The estimated daily storage usage increment in the last seven days.
                /// 
                /// >  Unit: bytes.
                /// </summary>
                [NameInMap("DailyIncrement")]
                [Validation(Required=false)]
                public long? DailyIncrement { get; set; }

                /// <summary>
                /// The estimated number of days before the remaining storage runs out.
                /// </summary>
                [NameInMap("EstimateAvailableDays")]
                [Validation(Required=false)]
                public long? EstimateAvailableDays { get; set; }

                /// <summary>
                /// The list of items to be optimized.
                /// </summary>
                [NameInMap("NeedOptimizeItemList")]
                [Validation(Required=false)]
                public List<GetStorageAnalysisResultResponseBodyDataStorageAnalysisResultNeedOptimizeItemList> NeedOptimizeItemList { get; set; }
                public class GetStorageAnalysisResultResponseBodyDataStorageAnalysisResultNeedOptimizeItemList : TeaModel {
                    /// <summary>
                    /// The data associated with items to be optimized.
                    /// </summary>
                    [NameInMap("AssociatedData")]
                    [Validation(Required=false)]
                    public string AssociatedData { get; set; }

                    /// <summary>
                    /// The database name.
                    /// </summary>
                    [NameInMap("DbName")]
                    [Validation(Required=false)]
                    public string DbName { get; set; }

                    /// <summary>
                    /// The optimization suggestion. Valid values:
                    /// 
                    /// *   **NEED_ANALYZE_TABLE**: You can execute the ANALYZE TABLE statement on the related table during off-peak hours.
                    /// *   **NEED_OPTIMIZE_TABLE**: You can reclaim fragments during off-peak hours.
                    /// </summary>
                    [NameInMap("OptimizeAdvice")]
                    [Validation(Required=false)]
                    public string OptimizeAdvice { get; set; }

                    /// <summary>
                    /// The item to be optimized. Valid values:
                    /// 
                    /// *   **NEED_ANALYZE_TABLE**: The statistical data in information_schema.tables differs greatly from the physical file size.
                    /// *   **NEED_OPTIMIZE_TABLE**: The fragmentation degree of the table is high.
                    /// </summary>
                    [NameInMap("OptimizeItemName")]
                    [Validation(Required=false)]
                    public string OptimizeItemName { get; set; }

                    /// <summary>
                    /// The table name.
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
                    /// The average row length.
                    /// 
                    /// >  Unit: bytes.
                    /// </summary>
                    [NameInMap("AvgRowLength")]
                    [Validation(Required=false)]
                    public long? AvgRowLength { get; set; }

                    /// <summary>
                    /// The size of storage occupied by fragments.
                    /// 
                    /// >  Unit: bytes.
                    /// </summary>
                    [NameInMap("DataFree")]
                    [Validation(Required=false)]
                    public long? DataFree { get; set; }

                    /// <summary>
                    /// The size of storage occupied by the table data.
                    /// 
                    /// >  Unit: bytes.
                    /// </summary>
                    [NameInMap("DataSize")]
                    [Validation(Required=false)]
                    public long? DataSize { get; set; }

                    /// <summary>
                    /// The database name.
                    /// </summary>
                    [NameInMap("DbName")]
                    [Validation(Required=false)]
                    public string DbName { get; set; }

                    /// <summary>
                    /// The type of the engine used by the table.
                    /// </summary>
                    [NameInMap("Engine")]
                    [Validation(Required=false)]
                    public string Engine { get; set; }

                    [NameInMap("FragmentSize")]
                    [Validation(Required=false)]
                    public long? FragmentSize { get; set; }

                    /// <summary>
                    /// The size of storage occupied by indexes.
                    /// 
                    /// >  Unit: bytes.
                    /// </summary>
                    [NameInMap("IndexSize")]
                    [Validation(Required=false)]
                    public long? IndexSize { get; set; }

                    /// <summary>
                    /// The size of the table storage.
                    /// 
                    /// >  Unit: byte. The value of the parameter is the sum of DataSize, IndexSize, and DataFree.
                    /// </summary>
                    [NameInMap("PhyTotalSize")]
                    [Validation(Required=false)]
                    public long? PhyTotalSize { get; set; }

                    /// <summary>
                    /// The physical file size of the table.
                    /// 
                    /// >  Unit: byte. You may fail to obtain the physical file size because of the deployment mode of the database instance.
                    /// </summary>
                    [NameInMap("PhysicalFileSize")]
                    [Validation(Required=false)]
                    public long? PhysicalFileSize { get; set; }

                    /// <summary>
                    /// The table name.
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
                    /// The table type.
                    /// </summary>
                    [NameInMap("TableType")]
                    [Validation(Required=false)]
                    public string TableType { get; set; }

                    /// <summary>
                    /// The size of storage occupied by table data and indexes.
                    /// 
                    /// >  Unit: byte. The value of the parameter is the sum of DataSize and IndexSize.
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
