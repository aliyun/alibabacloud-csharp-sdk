// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class GetMmsTableResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetMmsTableResponseBodyData Data { get; set; }
        public class GetMmsTableResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("dbId")]
            [Validation(Required=false)]
            public long? DbId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>mms_test</para>
            /// </summary>
            [NameInMap("dbName")]
            [Validation(Required=false)]
            public string DbName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("dstName")]
            [Validation(Required=false)]
            public string DstName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>mms_test</para>
            /// </summary>
            [NameInMap("dstProjectName")]
            [Validation(Required=false)]
            public string DstProjectName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("dstSchemaName")]
            [Validation(Required=false)]
            public string DstSchemaName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;mapkey.delim&quot;:&quot;:&quot;,&quot;collection.delim&quot;:&quot;,&quot;,&quot;serialization.format&quot;:&quot;|&quot;,&quot;field.delim&quot;:&quot;|&quot;}</para>
            /// </summary>
            [NameInMap("extra")]
            [Validation(Required=false)]
            public string Extra { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("hasPartitions")]
            [Validation(Required=false)]
            public bool? HasPartitions { get; set; }

            /// <summary>
            /// <para>table ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>22</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>inputFormat</para>
            /// 
            /// <b>Example:</b>
            /// <para>org.apache.hadoop.hive.ql.io.parquet.MapredParquetInputFormat</para>
            /// </summary>
            [NameInMap("inputFormat")]
            [Validation(Required=false)]
            public string InputFormat { get; set; }

            /// <summary>
            /// <para>lastDdlTime</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-12-17 15:44:42</para>
            /// </summary>
            [NameInMap("lastDdlTime")]
            [Validation(Required=false)]
            public string LastDdlTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>| hdfs://master-1-1.c-c127cd184bb029ea.cn-zhangjiakou.emr.aliyuncs.com:9000/user/hive/warehouse/demo</para>
            /// </summary>
            [NameInMap("location")]
            [Validation(Required=false)]
            public string Location { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>233232</para>
            /// </summary>
            [NameInMap("numRows")]
            [Validation(Required=false)]
            public long? NumRows { get; set; }

            /// <summary>
            /// <para>outputFormat</para>
            /// 
            /// <b>Example:</b>
            /// <para>org.apache.hadoop.hive.ql.io.parquet.MapredParquetOutputFormat</para>
            /// </summary>
            [NameInMap("outputFormat")]
            [Validation(Required=false)]
            public string OutputFormat { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Hive</para>
            /// </summary>
            [NameInMap("owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("partitions")]
            [Validation(Required=false)]
            public int? Partitions { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("partitionsDoing")]
            [Validation(Required=false)]
            public int? PartitionsDoing { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("partitionsDone")]
            [Validation(Required=false)]
            public int? PartitionsDone { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("partitionsFailed")]
            [Validation(Required=false)]
            public int? PartitionsFailed { get; set; }

            [NameInMap("schema")]
            [Validation(Required=false)]
            public GetMmsTableResponseBodyDataSchema Schema { get; set; }
            public class GetMmsTableResponseBodyDataSchema : TeaModel {
                [NameInMap("columns")]
                [Validation(Required=false)]
                public List<GetMmsTableResponseBodyDataSchemaColumns> Columns { get; set; }
                public class GetMmsTableResponseBodyDataSchemaColumns : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>user id</para>
                    /// </summary>
                    [NameInMap("comment")]
                    [Validation(Required=false)]
                    public string Comment { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("defaultValue")]
                    [Validation(Required=false)]
                    public string DefaultValue { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>user_id</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("nullable")]
                    [Validation(Required=false)]
                    public bool? Nullable { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>bigint</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>for mms test</para>
                /// </summary>
                [NameInMap("comment")]
                [Validation(Required=false)]
                public string Comment { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("partitions")]
                [Validation(Required=false)]
                public List<GetMmsTableResponseBodyDataSchemaPartitions> Partitions { get; set; }
                public class GetMmsTableResponseBodyDataSchemaPartitions : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>first partition level</para>
                    /// </summary>
                    [NameInMap("comment")]
                    [Validation(Required=false)]
                    public string Comment { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>abc</para>
                    /// </summary>
                    [NameInMap("defaultValue")]
                    [Validation(Required=false)]
                    public string DefaultValue { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>p1</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("nullable")]
                    [Validation(Required=false)]
                    public bool? Nullable { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>string</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

            }

            /// <summary>
            /// <para>serde</para>
            /// 
            /// <b>Example:</b>
            /// <para>org.apache.hadoop.hive.ql.io.parquet.serde.ParquetHiveSerDe</para>
            /// </summary>
            [NameInMap("serde")]
            [Validation(Required=false)]
            public string Serde { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>23232</para>
            /// </summary>
            [NameInMap("size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2000028</para>
            /// </summary>
            [NameInMap("sourceId")]
            [Validation(Required=false)]
            public long? SourceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>demo</para>
            /// </summary>
            [NameInMap("sourceName")]
            [Validation(Required=false)]
            public string SourceName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>DONE</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>MANAGED_TABLED</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("updated")]
            [Validation(Required=false)]
            public bool? Updated { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>E7FB14F1-4ACD-5C73-A755-B302D70AB9AD</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
