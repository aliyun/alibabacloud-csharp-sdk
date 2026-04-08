// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class GetMmsTimerResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetMmsTimerResponseBodyData Data { get; set; }
        public class GetMmsTimerResponseBodyData : TeaModel {
            [NameInMap("config")]
            [Validation(Required=false)]
            public GetMmsTimerResponseBodyDataConfig Config { get; set; }
            public class GetMmsTimerResponseBodyDataConfig : TeaModel {
                [NameInMap("columnMapping")]
                [Validation(Required=false)]
                public Dictionary<string, string> ColumnMapping { get; set; }

                [NameInMap("enableDataMigration")]
                [Validation(Required=false)]
                public bool? EnableDataMigration { get; set; }

                [NameInMap("enableSchemaMigration")]
                [Validation(Required=false)]
                public bool? EnableSchemaMigration { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("enableVerification")]
                [Validation(Required=false)]
                public bool? EnableVerification { get; set; }

                [NameInMap("others")]
                [Validation(Required=false)]
                public Dictionary<string, object> Others { get; set; }

                [NameInMap("partitionFilters")]
                [Validation(Required=false)]
                public Dictionary<string, string> PartitionFilters { get; set; }

                [NameInMap("partitions")]
                [Validation(Required=false)]
                public List<long?> Partitions { get; set; }

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

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1730946421757</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>23</para>
            /// </summary>
            [NameInMap("dbId")]
            [Validation(Required=false)]
            public long? DbId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2523</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>sale_detail</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Daily</para>
            /// </summary>
            [NameInMap("scheduleType")]
            [Validation(Required=false)]
            public string ScheduleType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2000017</para>
            /// </summary>
            [NameInMap("sourceId")]
            [Validation(Required=false)]
            public long? SourceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>mms_test</para>
            /// </summary>
            [NameInMap("srcDbName")]
            [Validation(Required=false)]
            public string SrcDbName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("stopped")]
            [Validation(Required=false)]
            public bool? Stopped { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Daily, Hourly</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2026-04-01T02:18:01Z</para>
            /// </summary>
            [NameInMap("updateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>p1=1/p2=abc</para>
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0a06dfe716674588654372173ec0da</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
