// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class ListMmsJobsResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the returned data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public ListMmsJobsResponseBodyData Data { get; set; }
        public class ListMmsJobsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of migration jobs.</para>
            /// </summary>
            [NameInMap("objectList")]
            [Validation(Required=false)]
            public List<ListMmsJobsResponseBodyDataObjectList> ObjectList { get; set; }
            public class ListMmsJobsResponseBodyDataObjectList : TeaModel {
                /// <summary>
                /// <para>The configuration of the migration job.</para>
                /// </summary>
                [NameInMap("config")]
                [Validation(Required=false)]
                public ListMmsJobsResponseBodyDataObjectListConfig Config { get; set; }
                public class ListMmsJobsResponseBodyDataObjectListConfig : TeaModel {
                    /// <summary>
                    /// <para>The mapping from source column names to destination column names.</para>
                    /// </summary>
                    [NameInMap("columnMapping")]
                    [Validation(Required=false)]
                    public Dictionary<string, string> ColumnMapping { get; set; }

                    /// <summary>
                    /// <para>Enable verification. The current method runs SELECT COUNT on both the source and destination and compares the row counts.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("enableVerification")]
                    [Validation(Required=false)]
                    public bool? EnableVerification { get; set; }

                    /// <summary>
                    /// <para>Enable incremental migration. Only new or modified partitions are migrated. Modified partitions are re-migrated.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("increment")]
                    [Validation(Required=false)]
                    public bool? Increment { get; set; }

                    /// <summary>
                    /// <para>Other configuration settings.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{&quot;spark.executor.mem&quot;: &quot;2g&quot;}</para>
                    /// </summary>
                    [NameInMap("others")]
                    [Validation(Required=false)]
                    public Dictionary<string, object> Others { get; set; }

                    /// <summary>
                    /// <para>The partition filter expression. Specify the partition filter expression for each table.</para>
                    /// </summary>
                    [NameInMap("partitionFilters")]
                    [Validation(Required=false)]
                    public Dictionary<string, string> PartitionFilters { get; set; }

                    /// <summary>
                    /// <para>When type is set to Partitions, specify the partition IDs of the tables to migrate.</para>
                    /// </summary>
                    [NameInMap("partitions")]
                    [Validation(Required=false)]
                    public List<long?> Partitions { get; set; }

                    /// <summary>
                    /// <para>Deprecated.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("schemaOnly")]
                    [Validation(Required=false)]
                    public bool? SchemaOnly { get; set; }

                    /// <summary>
                    /// <para>When type is set to Database, specify the tables to exclude from migration.</para>
                    /// </summary>
                    [NameInMap("tableBlackList")]
                    [Validation(Required=false)]
                    public List<string> TableBlackList { get; set; }

                    /// <summary>
                    /// <para>The mapping from source table names to destination table names.</para>
                    /// </summary>
                    [NameInMap("tableMapping")]
                    [Validation(Required=false)]
                    public Dictionary<string, string> TableMapping { get; set; }

                    /// <summary>
                    /// <para>When type is set to Database, specify the tables to migrate. If you do not specify tableWhiteList, all tables in the specified database are migrated.</para>
                    /// </summary>
                    [NameInMap("tableWhiteList")]
                    [Validation(Required=false)]
                    public List<string> TableWhiteList { get; set; }

                    /// <summary>
                    /// <para>When type is set to Tables, specify the names of the tables to migrate.</para>
                    /// </summary>
                    [NameInMap("tables")]
                    [Validation(Required=false)]
                    public List<string> Tables { get; set; }

                    /// <summary>
                    /// <para>Deprecated. Valid values: MOCK, HIVE (hive udtf task), HIVE_DATAX (hive datax task), COPY_TASK (ODPS Copy Task), ODPS_INSERT_OVERWRITE (ODPS simple insert overwrite task), MC2MC_VERIFY, OSS, HIVE_OSS, HIVE_SPARK, and BIGQUERY.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>BIGQUERY</para>
                    /// </summary>
                    [NameInMap("taskType")]
                    [Validation(Required=false)]
                    public string TaskType { get; set; }

                    /// <summary>
                    /// <para>Deprecated.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Depcreated</para>
                    /// </summary>
                    [NameInMap("tunnelQuota")]
                    [Validation(Required=false)]
                    public string TunnelQuota { get; set; }

                }

                /// <summary>
                /// <para>Indicates whether the migration job is stopped.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-12-17 15:44:17</para>
                /// </summary>
                [NameInMap("createTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The source database ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>196</para>
                /// </summary>
                [NameInMap("dbId")]
                [Validation(Required=false)]
                public long? DbId { get; set; }

                /// <summary>
                /// <para>The destination MaxCompute project.</para>
                /// 
                /// <b>Example:</b>
                /// <para>mms_test</para>
                /// </summary>
                [NameInMap("dstDbName")]
                [Validation(Required=false)]
                public string DstDbName { get; set; }

                /// <summary>
                /// <para>The destination MaxCompute schema.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test_table_1</para>
                /// </summary>
                [NameInMap("dstSchemaName")]
                [Validation(Required=false)]
                public string DstSchemaName { get; set; }

                /// <summary>
                /// <para>The estimated completion time of the migration. A smaller eta value increases the priority of the migration job.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-05-06</para>
                /// </summary>
                [NameInMap("eta")]
                [Validation(Required=false)]
                public string Eta { get; set; }

                /// <summary>
                /// <para>The migration job ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>18</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The name of the migration job.</para>
                /// 
                /// <b>Example:</b>
                /// <para>migrate_db_1</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The data source ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2000015</para>
                /// </summary>
                [NameInMap("sourceId")]
                [Validation(Required=false)]
                public long? SourceId { get; set; }

                /// <summary>
                /// <para>The name of the data source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>demo</para>
                /// </summary>
                [NameInMap("sourceName")]
                [Validation(Required=false)]
                public string SourceName { get; set; }

                /// <summary>
                /// <para>The name of the source database.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test_db_1</para>
                /// </summary>
                [NameInMap("srcDbName")]
                [Validation(Required=false)]
                public string SrcDbName { get; set; }

                /// <summary>
                /// <para>The source schema name. This is the schema in a Layer 3 namespace.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test_table_1</para>
                /// </summary>
                [NameInMap("srcSchemaName")]
                [Validation(Required=false)]
                public string SrcSchemaName { get; set; }

                /// <summary>
                /// <para>The status of the migration job.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DONE</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>Indicates whether the migration job is stopped.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("stopped")]
                [Validation(Required=false)]
                public bool? Stopped { get; set; }

                /// <summary>
                /// <para>The number of completed migration tasks.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("taskDone")]
                [Validation(Required=false)]
                public int? TaskDone { get; set; }

                /// <summary>
                /// <para>The number of migration tasks in the job.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("taskNum")]
                [Validation(Required=false)]
                public int? TaskNum { get; set; }

                /// <summary>
                /// <para>The migration scope. Valid values: Database, Tables, and Partitions.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Tables</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("pageNum")]
            [Validation(Required=false)]
            public int? PageNum { get; set; }

            /// <summary>
            /// <para>The number of entries returned on each page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("pageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1112E7C7-C65F-57A2-A7C7-3B178AA257B6</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
