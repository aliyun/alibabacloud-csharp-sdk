// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class ListMmsJobsResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public ListMmsJobsResponseBodyData Data { get; set; }
        public class ListMmsJobsResponseBodyData : TeaModel {
            [NameInMap("objectList")]
            [Validation(Required=false)]
            public List<ListMmsJobsResponseBodyDataObjectList> ObjectList { get; set; }
            public class ListMmsJobsResponseBodyDataObjectList : TeaModel {
                [NameInMap("config")]
                [Validation(Required=false)]
                public ListMmsJobsResponseBodyDataObjectListConfig Config { get; set; }
                public class ListMmsJobsResponseBodyDataObjectListConfig : TeaModel {
                    [NameInMap("columnMapping")]
                    [Validation(Required=false)]
                    public Dictionary<string, string> ColumnMapping { get; set; }

                    [NameInMap("enableVerification")]
                    [Validation(Required=false)]
                    public bool? EnableVerification { get; set; }

                    [NameInMap("increment")]
                    [Validation(Required=false)]
                    public bool? Increment { get; set; }

                    [NameInMap("others")]
                    [Validation(Required=false)]
                    public Dictionary<string, object> Others { get; set; }

                    [NameInMap("partitionFilters")]
                    [Validation(Required=false)]
                    public Dictionary<string, string> PartitionFilters { get; set; }

                    [NameInMap("partitions")]
                    [Validation(Required=false)]
                    public List<long?> Partitions { get; set; }

                    [NameInMap("schemaOnly")]
                    [Validation(Required=false)]
                    public bool? SchemaOnly { get; set; }

                    [NameInMap("tableBlackList")]
                    [Validation(Required=false)]
                    public List<string> TableBlackList { get; set; }

                    [NameInMap("tableMapping")]
                    [Validation(Required=false)]
                    public Dictionary<string, string> TableMapping { get; set; }

                    [NameInMap("tableWhiteList")]
                    [Validation(Required=false)]
                    public List<string> TableWhiteList { get; set; }

                    [NameInMap("tables")]
                    [Validation(Required=false)]
                    public List<string> Tables { get; set; }

                    [NameInMap("taskType")]
                    [Validation(Required=false)]
                    public string TaskType { get; set; }

                    [NameInMap("tunnelQuota")]
                    [Validation(Required=false)]
                    public string TunnelQuota { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2024-12-17 15:44:17</para>
                /// </summary>
                [NameInMap("createTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>196</para>
                /// </summary>
                [NameInMap("dbId")]
                [Validation(Required=false)]
                public long? DbId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>mms_test</para>
                /// </summary>
                [NameInMap("dstDbName")]
                [Validation(Required=false)]
                public string DstDbName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test_table_1</para>
                /// </summary>
                [NameInMap("dstSchemaName")]
                [Validation(Required=false)]
                public string DstSchemaName { get; set; }

                [NameInMap("eta")]
                [Validation(Required=false)]
                public string Eta { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>18</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>migrate_db_1</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2000015</para>
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
                /// <para>test_db_1</para>
                /// </summary>
                [NameInMap("srcDbName")]
                [Validation(Required=false)]
                public string SrcDbName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test_table_1</para>
                /// </summary>
                [NameInMap("srcSchemaName")]
                [Validation(Required=false)]
                public string SrcSchemaName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>DONE</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("stopped")]
                [Validation(Required=false)]
                public bool? Stopped { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("taskDone")]
                [Validation(Required=false)]
                public int? TaskDone { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("taskNum")]
                [Validation(Required=false)]
                public int? TaskNum { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Tables</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("pageNum")]
            [Validation(Required=false)]
            public int? PageNum { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("pageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1112E7C7-C65F-57A2-A7C7-3B178AA257B6</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
