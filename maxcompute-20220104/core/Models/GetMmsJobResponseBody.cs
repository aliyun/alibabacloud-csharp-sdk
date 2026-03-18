// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class GetMmsJobResponseBody : TeaModel {
        /// <summary>
        /// <para>The migration job object.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetMmsJobResponseBodyData Data { get; set; }
        public class GetMmsJobResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The configuration of the migration job.</para>
            /// </summary>
            [NameInMap("config")]
            [Validation(Required=false)]
            public GetMmsJobResponseBodyDataConfig Config { get; set; }
            public class GetMmsJobResponseBodyDataConfig : TeaModel {
                /// <summary>
                /// <para>{Source column name: Destination column name}</para>
                /// </summary>
                [NameInMap("columnMapping")]
                [Validation(Required=false)]
                public Dictionary<string, string> ColumnMapping { get; set; }

                /// <summary>
                /// <para>Enables data verification. The current verification method is to execute a SELECT COUNT statement on the source and destination to compare the row counts.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("enableVerification")]
                [Validation(Required=false)]
                public bool? EnableVerification { get; set; }

                /// <summary>
                /// <para>Incremental migration. Only new or modified partitions are migrated. Note: Modified partitions are re-migrated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("increment")]
                [Validation(Required=false)]
                public bool? Increment { get; set; }

                /// <summary>
                /// <para>Other configuration information.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;spark.executor.mem&quot;: &quot;2g&quot;}</para>
                /// </summary>
                [NameInMap("others")]
                [Validation(Required=false)]
                public Dictionary<string, object> Others { get; set; }

                /// <summary>
                /// <para>The partition filter expression. This parameter specifies the partition filter expression for a specific table.</para>
                /// </summary>
                [NameInMap("partitionFilters")]
                [Validation(Required=false)]
                public Dictionary<string, string> PartitionFilters { get; set; }

                /// <summary>
                /// <para>If type is set to Partitions, this parameter specifies the list of partition IDs of the table to migrate.</para>
                /// </summary>
                [NameInMap("partitions")]
                [Validation(Required=false)]
                public List<long?> Partitions { get; set; }

                /// <summary>
                /// <para>Deprecated</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("schemaOnly")]
                [Validation(Required=false)]
                public bool? SchemaOnly { get; set; }

                /// <summary>
                /// <para>If type is set to Database, this parameter specifies the tables to exclude from the migration.</para>
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
                /// <para>If type is set to Database, this parameter specifies the list of tables to migrate. If you do not specify this parameter, all tables in the database are migrated.</para>
                /// </summary>
                [NameInMap("tableWhiteList")]
                [Validation(Required=false)]
                public List<string> TableWhiteList { get; set; }

                /// <summary>
                /// <para>If type is set to Tables, this parameter specifies the list of names of the tables to migrate.</para>
                /// </summary>
                [NameInMap("tables")]
                [Validation(Required=false)]
                public List<string> Tables { get; set; }

                /// <summary>
                /// <para>Deprecated. Valid values: MOCK, HIVE (a Hive user-defined table-valued function (UDTF) task), HIVE_DATAX (a Hive DataX task), COPY_TASK (an ODPS Copy Task), ODPS_INSERT_OVERWRITE (an ODPS simple insert overwrite task), MC2MC_VERIFY, OSS, HIVE_OSS, HIVE_SPARK, and BIGQUERY.</para>
                /// 
                /// <b>Example:</b>
                /// <para>BIGQUERY</para>
                /// </summary>
                [NameInMap("taskType")]
                [Validation(Required=false)]
                public string TaskType { get; set; }

                /// <summary>
                /// <para>Deprecated</para>
                /// 
                /// <b>Example:</b>
                /// <para>Depcreated</para>
                /// </summary>
                [NameInMap("tunnelQuota")]
                [Validation(Required=false)]
                public string TunnelQuota { get; set; }

            }

            /// <summary>
            /// <para>The time when the job was created.</para>
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
            /// <para>23</para>
            /// </summary>
            [NameInMap("dbId")]
            [Validation(Required=false)]
            public long? DbId { get; set; }

            /// <summary>
            /// <para>The destination MaxCompute project.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mms_target</para>
            /// </summary>
            [NameInMap("dstDbName")]
            [Validation(Required=false)]
            public string DstDbName { get; set; }

            /// <summary>
            /// <para>The destination MaxCompute schema.</para>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("dstSchemaName")]
            [Validation(Required=false)]
            public string DstSchemaName { get; set; }

            /// <summary>
            /// <para>The expected completion time of the migration. Note: A smaller eta value indicates a higher priority for the migration task.</para>
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
            /// <para>10</para>
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
            /// <para>2</para>
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
            /// <para>mms_test</para>
            /// </summary>
            [NameInMap("srcDbName")]
            [Validation(Required=false)]
            public string SrcDbName { get; set; }

            /// <summary>
            /// <para>The name of the source schema. This parameter specifies the schema in a Layer 3 namespace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("srcSchemaName")]
            [Validation(Required=false)]
            public string SrcSchemaName { get; set; }

            /// <summary>
            /// <para>The status of the migration task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DOING</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>Stopped.</para>
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
            /// <para>100</para>
            /// </summary>
            [NameInMap("taskDone")]
            [Validation(Required=false)]
            public int? TaskDone { get; set; }

            /// <summary>
            /// <para>The number of migration tasks included in the job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D9F872FD-5DDE-30A6-8C8A-1B8C6A81059F</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
