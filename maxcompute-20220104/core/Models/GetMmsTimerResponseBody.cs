// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class GetMmsTimerResponseBody : TeaModel {
        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetMmsTimerResponseBodyData Data { get; set; }
        public class GetMmsTimerResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The configuration of the migration job.</para>
            /// </summary>
            [NameInMap("config")]
            [Validation(Required=false)]
            public GetMmsTimerResponseBodyDataConfig Config { get; set; }
            public class GetMmsTimerResponseBodyDataConfig : TeaModel {
                /// <summary>
                /// <para>A map of source column names to destination column names.</para>
                /// </summary>
                [NameInMap("columnMapping")]
                [Validation(Required=false)]
                public Dictionary<string, string> ColumnMapping { get; set; }

                /// <summary>
                /// <para>Whether to migrate table data.</para>
                /// </summary>
                [NameInMap("enableDataMigration")]
                [Validation(Required=false)]
                public bool? EnableDataMigration { get; set; }

                /// <summary>
                /// <para>Whether to migrate the table schema.</para>
                /// </summary>
                [NameInMap("enableSchemaMigration")]
                [Validation(Required=false)]
                public bool? EnableSchemaMigration { get; set; }

                /// <summary>
                /// <para>Whether to enable verification. The system performs verification by running a <c>SELECT COUNT(*)</c> query on both the source and destination to compare the row count.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("enableVerification")]
                [Validation(Required=false)]
                public bool? EnableVerification { get; set; }

                /// <summary>
                /// <para>Other configurations.</para>
                /// </summary>
                [NameInMap("others")]
                [Validation(Required=false)]
                public Dictionary<string, object> Others { get; set; }

                /// <summary>
                /// <para>A map of table names to their corresponding partition filter expressions.</para>
                /// </summary>
                [NameInMap("partitionFilters")]
                [Validation(Required=false)]
                public Dictionary<string, string> PartitionFilters { get; set; }

                /// <summary>
                /// <para>If <c>type</c> is set to <c>Partitions</c>, this parameter specifies a list of partition IDs to migrate.</para>
                /// </summary>
                [NameInMap("partitions")]
                [Validation(Required=false)]
                public List<long?> Partitions { get; set; }

                /// <summary>
                /// <para>If <c>type</c> is set to <c>Database</c>, this parameter specifies a table deny list. Tables on this list are excluded from the migration.</para>
                /// </summary>
                [NameInMap("tableBlackList")]
                [Validation(Required=false)]
                public List<string> TableBlackList { get; set; }

                /// <summary>
                /// <para>A map of source table names to destination table names.</para>
                /// </summary>
                [NameInMap("tableMapping")]
                [Validation(Required=false)]
                public Dictionary<string, string> TableMapping { get; set; }

                /// <summary>
                /// <para>If <c>type</c> is set to <c>Database</c>, this parameter specifies a table allowlist. If this parameter is not specified, all tables in the database are migrated.</para>
                /// </summary>
                [NameInMap("tableWhiteList")]
                [Validation(Required=false)]
                public List<string> TableWhiteList { get; set; }

                /// <summary>
                /// <para>If <c>type</c> is set to <c>Tables</c>, this parameter specifies a list of table names to migrate.</para>
                /// </summary>
                [NameInMap("tables")]
                [Validation(Required=false)]
                public List<string> Tables { get; set; }

            }

            /// <summary>
            /// <para>The creation time of the scheduled task. This is a Unix timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1730946421757</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The ID of the source database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>23</para>
            /// </summary>
            [NameInMap("dbId")]
            [Validation(Required=false)]
            public long? DbId { get; set; }

            /// <summary>
            /// <para>The ID of the scheduled task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2523</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The name of the scheduled task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sale_detail</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The scheduling type of the scheduled task. Valid values: <c>Daily</c> and <c>Hourly</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Daily</para>
            /// </summary>
            [NameInMap("scheduleType")]
            [Validation(Required=false)]
            public string ScheduleType { get; set; }

            /// <summary>
            /// <para>The ID of the data source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2000017</para>
            /// </summary>
            [NameInMap("sourceId")]
            [Validation(Required=false)]
            public long? SourceId { get; set; }

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
            /// <para>Indicates whether the scheduled task is stopped.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("stopped")]
            [Validation(Required=false)]
            public bool? Stopped { get; set; }

            /// <summary>
            /// <para>The type of the scheduled task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Daily, Hourly</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The last update time of the scheduled task, in ISO 8601 format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-04-01T02:18:01Z</para>
            /// </summary>
            [NameInMap("updateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            /// <summary>
            /// <para>The scheduling time. If <c>scheduleType</c> is <c>Daily</c>, the value is in the <c>HH:MM</c> format. If <c>scheduleType</c> is <c>Hourly</c>, the value is in the <c>MM</c> format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>p1=1/p2=abc</para>
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0a06dfe716674588654372173ec0da</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
