// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class GetStorageAnalysisResultResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetStorageAnalysisResultResponseBodyData Data { get; set; }
        public class GetStorageAnalysisResultResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The number of databases that have been analyzed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("AnalyzedDbCount")]
            [Validation(Required=false)]
            public long? AnalyzedDbCount { get; set; }

            /// <summary>
            /// <para>The details of storage analysis.</para>
            /// </summary>
            [NameInMap("StorageAnalysisResult")]
            [Validation(Required=false)]
            public GetStorageAnalysisResultResponseBodyDataStorageAnalysisResult StorageAnalysisResult { get; set; }
            public class GetStorageAnalysisResultResponseBodyDataStorageAnalysisResult : TeaModel {
                /// <summary>
                /// <para>The reason why the analysis on the database and table fails.</para>
                /// <list type="bullet">
                /// <item><description><b>DB_OR_TABLE_NOT_EXIST</b>: The specified database or table does not exist.</description></item>
                /// <item><description><b>DB_NOT_EXIST</b>: The specified database does not exist.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>DB_NOT_EXIST</para>
                /// </summary>
                [NameInMap("AnalysisErrorType")]
                [Validation(Required=false)]
                public string AnalysisErrorType { get; set; }

                /// <summary>
                /// <para>Indicates whether the analysis on the database and table is successful.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("AnalysisSuccess")]
                [Validation(Required=false)]
                public bool? AnalysisSuccess { get; set; }

                /// <summary>
                /// <para>The estimated average daily growth of the used storage space in the previous seven days. Unit: bytes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("DailyIncrement")]
                [Validation(Required=false)]
                public long? DailyIncrement { get; set; }

                /// <summary>
                /// <para>The estimated number of days for which the remaining storage space is available.</para>
                /// 
                /// <b>Example:</b>
                /// <para>99</para>
                /// </summary>
                [NameInMap("EstimateAvailableDays")]
                [Validation(Required=false)]
                public long? EstimateAvailableDays { get; set; }

                /// <summary>
                /// <para>The items to be optimized, which are generated based on DAS default rules. You can ignore these items based on your business requirements, and create custom rules to generate items to be optimized based on other basic data that is returned.</para>
                /// </summary>
                [NameInMap("NeedOptimizeItemList")]
                [Validation(Required=false)]
                public List<GetStorageAnalysisResultResponseBodyDataStorageAnalysisResultNeedOptimizeItemList> NeedOptimizeItemList { get; set; }
                public class GetStorageAnalysisResultResponseBodyDataStorageAnalysisResultNeedOptimizeItemList : TeaModel {
                    /// <summary>
                    /// <para>The data associated with the items to be optimized, which is in the JSON format.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{
                    ///     &quot;autoIncrementCurrentValue&quot;: 2147483647,
                    ///     &quot;autoIncrementRatio&quot;: 1,
                    ///     &quot;dbName&quot;: &quot;testdb01&quot;,
                    ///     &quot;maximumValue&quot;: 2147483647,
                    ///     &quot;columnName&quot;: &quot;id&quot;,
                    ///     &quot;tableName&quot;: &quot;test_table&quot;
                    /// }</para>
                    /// </summary>
                    [NameInMap("AssociatedData")]
                    [Validation(Required=false)]
                    public string AssociatedData { get; set; }

                    /// <summary>
                    /// <para>The name of the database.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>testdb01</para>
                    /// </summary>
                    [NameInMap("DbName")]
                    [Validation(Required=false)]
                    public string DbName { get; set; }

                    /// <summary>
                    /// <para>The optimization suggestion. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>NEED_ANALYZE_TABLE</b>: You can execute the <c>ANALYZE TABLE</c> statement on the table during off-peak hours. This is applicable only to ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters.</description></item>
                    /// <item><description><b>NEED_OPTIMIZE_TABLE</b>: You can reclaim fragments during off-peak hours.</description></item>
                    /// <item><description><b>CHANGE_TABLE_ENGINE_IF_NECESSARY</b>: Change the storage engine type of a table after risk assessment. This is applicable only to ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters.</description></item>
                    /// <item><description><b>AUTO_INCREMENT_ID_BE_TO_RUN_OUT</b>: Pay attention to the usage of auto-increment IDs. This is applicable only to ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters.</description></item>
                    /// <item><description><b>DUPLICATE_INDEX</b>: Optimize indexes of tables. This is applicable only to ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters.</description></item>
                    /// <item><description><b>TABLE_SIZE</b>: Pay attention to the table size. This is applicable only to ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters.</description></item>
                    /// <item><description><b>TABLE_ROWS_AND_AVG_ROW_LENGTH</b>: Pay attention to the number of rows in a table and the average row length. This is applicable only to ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters.</description></item>
                    /// <item><description><b>STORAGE_USED_PERCENT</b>: Pay attention to the space usage to prevent the instance from being locked if the instance is full.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>NEED_OPTIMIZE_TABLE</para>
                    /// </summary>
                    [NameInMap("OptimizeAdvice")]
                    [Validation(Required=false)]
                    public string OptimizeAdvice { get; set; }

                    /// <summary>
                    /// <para>The item to be optimized. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><b>NEED_ANALYZE_TABLE</b>: tables whose storage statistics obtained from <c>information_schema.tables</c> are 50 GB larger or smaller than the physical file sizes. This is applicable only to ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters.</para>
                    /// </description></item>
                    /// <item><description><para><b>NEED_OPTIMIZE_TABLE</b>: tables whose space fragments are larger than 6 GB and whose fragmentation rates are greater than 30%. The fragmentation rate of a table is generally calculated based on the following formulas:</para>
                    /// <list type="bullet">
                    /// <item><description>ApsaraDB RDS for MySQL and PolarDB for MySQL: <c>Fragmentation rate = DataFree/(DataSize + IndexSize + DataFree)</c>. In this topic, PhyTotalSize = DataSize + IndexSize + DataFree. Thus, the fragmentation rate can be calculated based on the following formula: <c>Fragmentation rate = DataFree/PhyTotalSize</c>.</description></item>
                    /// <item><description>ApsaraDB for MongoDB: <c>Fragmentation rate = FragmentSize/PhyTotalSize</c>.</description></item>
                    /// </list>
                    /// </description></item>
                    /// <item><description><para><b>TABLE_ENGINE</b>: tables whose storage engines are not InnoDB or XEngine. This is applicable only to ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters.</para>
                    /// </description></item>
                    /// <item><description><para><b>AUTO_INCREMENT_ID_BE_TO_RUN_OUT</b>: tables whose usages of auto-increment IDs exceed 80%. This is applicable only to ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters.</para>
                    /// </description></item>
                    /// <item><description><para><b>DUPLICATE_INDEX</b>: tables whose indexes are redundant or duplicate. This is applicable only to ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters.</para>
                    /// </description></item>
                    /// <item><description><para><b>TABLE_SIZE</b>: single tables whose sizes are larger than 50 GB. This is applicable only to ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters.</para>
                    /// </description></item>
                    /// <item><description><para><b>TABLE_ROWS_AND_AVG_ROW_LENGTH</b>: single tables that contain more than 5 million rows and whose average row lengths exceed 10 KB. This is applicable only to ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters.</para>
                    /// </description></item>
                    /// <item><description><para><b>TOTAL_DATA_FREE</b>: instances whose reclaimable space is larger than 60 GB and whose total fragmentation rate is larger than 5%.</para>
                    /// </description></item>
                    /// <item><description><para><b>STORAGE_USED_PERCENT</b>: instances whose space usage is larger than 90%.</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>NEED_OPTIMIZE_TABLE</para>
                    /// </summary>
                    [NameInMap("OptimizeItemName")]
                    [Validation(Required=false)]
                    public string OptimizeItemName { get; set; }

                    /// <summary>
                    /// <para>The name of the table.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test_table</para>
                    /// </summary>
                    [NameInMap("TableName")]
                    [Validation(Required=false)]
                    public string TableName { get; set; }

                }

                /// <summary>
                /// <para>The information about the table.</para>
                /// </summary>
                [NameInMap("TableStats")]
                [Validation(Required=false)]
                public List<GetStorageAnalysisResultResponseBodyDataStorageAnalysisResultTableStats> TableStats { get; set; }
                public class GetStorageAnalysisResultResponseBodyDataStorageAnalysisResultTableStats : TeaModel {
                    /// <summary>
                    /// <para>The average length of rows. Unit: bytes.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>154</para>
                    /// </summary>
                    [NameInMap("AvgRowLength")]
                    [Validation(Required=false)]
                    public long? AvgRowLength { get; set; }

                    /// <summary>
                    /// <para>The size of space fragments. Unit: bytes.</para>
                    /// <remarks>
                    /// <para> This parameter is applicable only to ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters. The fragmentation rate of a table is generally calculated based on the following formula: <c>Fragmentation rate = DataFree/(DataSize + IndexSize + DataFree)</c>. In this topic, <c>Fragmentation rate = DataFree/PhyTotalSize</c>.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>7340032</para>
                    /// </summary>
                    [NameInMap("DataFree")]
                    [Validation(Required=false)]
                    public long? DataFree { get; set; }

                    /// <summary>
                    /// <list type="bullet">
                    /// <item><description>For ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters, this parameter indicates the amount of space occupied by data. Unit: bytes.</description></item>
                    /// <item><description>For ApsaraDB for MongoDB instances, this parameter indicates the size of uncompressed data, that is, the amount of data. Unit: bytes.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1982857216</para>
                    /// </summary>
                    [NameInMap("DataSize")]
                    [Validation(Required=false)]
                    public long? DataSize { get; set; }

                    /// <summary>
                    /// <para>The name of the database.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>testdb01</para>
                    /// </summary>
                    [NameInMap("DbName")]
                    [Validation(Required=false)]
                    public string DbName { get; set; }

                    /// <summary>
                    /// <para>The type of the storage engine used by the table.</para>
                    /// <remarks>
                    /// <para> This parameter is applicable only to ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>InnoDB</para>
                    /// </summary>
                    [NameInMap("Engine")]
                    [Validation(Required=false)]
                    public string Engine { get; set; }

                    /// <summary>
                    /// <para>The size of space that can be reclaimed. Unit: bytes.</para>
                    /// <remarks>
                    /// <para> This parameter is applicable only to ApsaraDB for MongoDB instances. <c>Fragmentation rate = FragmentSize/PhyTotalSize</c>.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>362221568</para>
                    /// </summary>
                    [NameInMap("FragmentSize")]
                    [Validation(Required=false)]
                    public long? FragmentSize { get; set; }

                    /// <summary>
                    /// <para>The storage space occupied by indexes. Unit: bytes.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1022296064</para>
                    /// </summary>
                    [NameInMap("IndexSize")]
                    [Validation(Required=false)]
                    public long? IndexSize { get; set; }

                    /// <summary>
                    /// <para>The storage space of the table. Unit: bytes.</para>
                    /// <remarks>
                    /// <para> For ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters, the value of the parameter is the sum of <b>DataSize</b>, <b>IndexSize</b>, and <b>DataFree</b>. For ApsaraDB for MongoDB instances, the value of this parameter is the sum of <b>DataSize</b> and <b>IndexSize</b>.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3012493312</para>
                    /// </summary>
                    [NameInMap("PhyTotalSize")]
                    [Validation(Required=false)]
                    public long? PhyTotalSize { get; set; }

                    /// <summary>
                    /// <para>The physical file size of the table. Unit: bytes.</para>
                    /// <remarks>
                    /// <para> This parameter is applicable only to ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters. Data of specific database instances cannot be obtained due to deployment mode.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3057655808</para>
                    /// </summary>
                    [NameInMap("PhysicalFileSize")]
                    [Validation(Required=false)]
                    public long? PhysicalFileSize { get; set; }

                    /// <summary>
                    /// <para>The name of the table.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test_table</para>
                    /// </summary>
                    [NameInMap("TableName")]
                    [Validation(Required=false)]
                    public string TableName { get; set; }

                    /// <summary>
                    /// <para>The number of rows in the table.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>12794732</para>
                    /// </summary>
                    [NameInMap("TableRows")]
                    [Validation(Required=false)]
                    public long? TableRows { get; set; }

                    /// <summary>
                    /// <para>The type of the table.</para>
                    /// <remarks>
                    /// <para> This parameter is applicable only to ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>BASE TABLE</para>
                    /// </summary>
                    [NameInMap("TableType")]
                    [Validation(Required=false)]
                    public string TableType { get; set; }

                    /// <summary>
                    /// <list type="bullet">
                    /// <item><description>For ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters, this parameter indicates the amount of space occupied by table data and indexes. Unit: bytes. The value is the sum of <b>DataSize</b> and <b>IndexSize</b>.</description></item>
                    /// <item><description>For ApsaraDB for MongoDB instances, this parameter indicates the actual size of space allocated by Block Manager. Unit: Bytes. The compression ratio of an ApsaraDB for MongoDB instance is calculated based on the following formula: <c>Compression ratio = TotalSize/DataSize</c>.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3005153280</para>
                    /// </summary>
                    [NameInMap("TotalSize")]
                    [Validation(Required=false)]
                    public long? TotalSize { get; set; }

                }

                /// <summary>
                /// <para>The size of remaining storage.</para>
                /// <remarks>
                /// <para> Unit: bytes.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>146403229696</para>
                /// </summary>
                [NameInMap("TotalFreeStorageSize")]
                [Validation(Required=false)]
                public long? TotalFreeStorageSize { get; set; }

                /// <summary>
                /// <para>The total size of instance storage.</para>
                /// <remarks>
                /// <para> Unit: bytes.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>214748364800</para>
                /// </summary>
                [NameInMap("TotalStorageSize")]
                [Validation(Required=false)]
                public long? TotalStorageSize { get; set; }

                /// <summary>
                /// <para>The size of used storage.</para>
                /// <remarks>
                /// <para> Unit: bytes.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>68345135104</para>
                /// </summary>
                [NameInMap("TotalUsedStorageSize")]
                [Validation(Required=false)]
                public long? TotalUsedStorageSize { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether the task is complete.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("TaskFinish")]
            [Validation(Required=false)]
            public bool? TaskFinish { get; set; }

            /// <summary>
            /// <para>The task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>910f83f4b96df0524ddc5749f615****</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>The task progress.</para>
            /// <remarks>
            /// <para> Valid values are integers that range from 0 to 100.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("TaskProgress")]
            [Validation(Required=false)]
            public long? TaskProgress { get; set; }

            /// <summary>
            /// <para>The status of the storage analysis task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>INIT</b>: The task is being initialized.</description></item>
            /// <item><description><b>PENDING</b>: The task is being queued for execution.</description></item>
            /// <item><description><b>RECEIVED</b>: The task is received for execution.</description></item>
            /// <item><description><b>RUNNING</b>: The task is being executed.</description></item>
            /// <item><description><b>RETRY</b>: The task is being retried.</description></item>
            /// <item><description><b>SUCCESS</b>: The task succeeds.</description></item>
            /// <item><description><b>FAILURE</b>: The task fails.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>RUNNING</para>
            /// </summary>
            [NameInMap("TaskState")]
            [Validation(Required=false)]
            public string TaskState { get; set; }

            /// <summary>
            /// <para>Indicates whether the task is successful.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("TaskSuccess")]
            [Validation(Required=false)]
            public bool? TaskSuccess { get; set; }

            /// <summary>
            /// <para>The number of databases that need to be analyzed in the storage analysis task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>32</para>
            /// </summary>
            [NameInMap("TotalDbCount")]
            [Validation(Required=false)]
            public long? TotalDbCount { get; set; }

        }

        /// <summary>
        /// <para>The returned message.</para>
        /// <remarks>
        /// <para> If the request is successful, <b>Successful</b> is returned. Otherwise, an error message such as an error code is returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B6D17591-B48B-4D31-9CD6-9B9796B2****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
