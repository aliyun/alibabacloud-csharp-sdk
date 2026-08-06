// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GetCrawlerResponseBody : TeaModel {
        [NameInMap("Crawler")]
        [Validation(Required=false)]
        public GetCrawlerResponseBodyCrawler Crawler { get; set; }
        public class GetCrawlerResponseBodyCrawler : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1710239005403</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>12345</para>
            /// </summary>
            [NameInMap("DataSourceId")]
            [Validation(Required=false)]
            public long? DataSourceId { get; set; }

            [NameInMap("EnableAiComment")]
            [Validation(Required=false)]
            public bool? EnableAiComment { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Prod</para>
            /// </summary>
            [NameInMap("EnvType")]
            [Validation(Required=false)]
            public string EnvType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1234</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>SUCCESS</para>
            /// </summary>
            [NameInMap("LastRunStatus")]
            [Validation(Required=false)]
            public string LastRunStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1234</para>
            /// </summary>
            [NameInMap("LastRunTaskInstanceId")]
            [Validation(Required=false)]
            public long? LastRunTaskInstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>starrocks:example-instance</para>
            /// </summary>
            [NameInMap("MetaEntityId")]
            [Validation(Required=false)]
            public string MetaEntityId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1710239005403</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public long? ModifyTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>example_crawler</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Options")]
            [Validation(Required=false)]
            public Dictionary<string, string> Options { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Serverless_res_group_1234567890123456_1234567890</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            [NameInMap("ScheduleConfig")]
            [Validation(Required=false)]
            public GetCrawlerResponseBodyCrawlerScheduleConfig ScheduleConfig { get; set; }
            public class GetCrawlerResponseBodyCrawlerScheduleConfig : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>0 0 2 ? * *</para>
                /// </summary>
                [NameInMap("CronExpress")]
                [Validation(Required=false)]
                public string CronExpress { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>NORMAL</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("Scope")]
            [Validation(Required=false)]
            public GetCrawlerResponseBodyCrawlerScope Scope { get; set; }
            public class GetCrawlerResponseBodyCrawlerScope : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>^tmp_.*</para>
                /// </summary>
                [NameInMap("ExcludeRegex")]
                [Validation(Required=false)]
                public string ExcludeRegex { get; set; }

                [NameInMap("Items")]
                [Validation(Required=false)]
                public List<string> Items { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>DATABASE</para>
                /// </summary>
                [NameInMap("Unit")]
                [Validation(Required=false)]
                public string Unit { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>VALID</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1234</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public long? TaskId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>starrocks</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>9252F32F-D855-549E-8898-61CF5A733050</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
