// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GetCrawlerResponseBody : TeaModel {
        /// <summary>
        /// <para>The metadata crawler details.</para>
        /// </summary>
        [NameInMap("Crawler")]
        [Validation(Required=false)]
        public GetCrawlerResponseBodyCrawler Crawler { get; set; }
        public class GetCrawlerResponseBodyCrawler : TeaModel {
            /// <summary>
            /// <para>The creation time. The value is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1710239005403</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The data source ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12345</para>
            /// </summary>
            [NameInMap("DataSourceId")]
            [Validation(Required=false)]
            public long? DataSourceId { get; set; }

            /// <summary>
            /// <para>Indicates whether AI metadata descriptions are enabled.</para>
            /// </summary>
            [NameInMap("EnableAiComment")]
            [Validation(Required=false)]
            public bool? EnableAiComment { get; set; }

            /// <summary>
            /// <para>The DataWorks environment type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Dev</description></item>
            /// <item><description>Prod</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Prod</para>
            /// </summary>
            [NameInMap("EnvType")]
            [Validation(Required=false)]
            public string EnvType { get; set; }

            /// <summary>
            /// <para>The crawler ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The latest run status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>WAITING</description></item>
            /// <item><description>RUNNING</description></item>
            /// <item><description>SUCCESS</description></item>
            /// <item><description>ERROR</description></item>
            /// <item><description>SHUTDOWN
            /// This parameter may be empty if the crawler has not been run.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SUCCESS</para>
            /// </summary>
            [NameInMap("LastRunStatus")]
            [Validation(Required=false)]
            public string LastRunStatus { get; set; }

            /// <summary>
            /// <para>The DataWorks task instance ID associated with the latest run. This parameter may be empty if the crawler has not been run.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234</para>
            /// </summary>
            [NameInMap("LastRunTaskInstanceId")]
            [Validation(Required=false)]
            public long? LastRunTaskInstanceId { get; set; }

            /// <summary>
            /// <para>The ID of the meta-entity associated with the crawler. You can use this ID in metadata query APIs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>starrocks:example-instance</para>
            /// </summary>
            [NameInMap("MetaEntityId")]
            [Validation(Required=false)]
            public string MetaEntityId { get; set; }

            /// <summary>
            /// <para>The modification time. The value is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1710239005403</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public long? ModifyTime { get; set; }

            /// <summary>
            /// <para>The crawler name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example_crawler</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The extension configuration for the crawler type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;CollectRecyclebin&quot;:&quot;false&quot;}</para>
            /// </summary>
            [NameInMap("Options")]
            [Validation(Required=false)]
            public Dictionary<string, string> Options { get; set; }

            /// <summary>
            /// <para>The DataWorks user ID of the crawler owner.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            /// <summary>
            /// <para>The DataWorks workspace ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

            /// <summary>
            /// <para>The ID of the Serverless 2.0 resource group used to run the crawl task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Serverless_res_group_1234567890123456_1234567890</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The schedule settings.</para>
            /// </summary>
            [NameInMap("ScheduleConfig")]
            [Validation(Required=false)]
            public GetCrawlerResponseBodyCrawlerScheduleConfig ScheduleConfig { get; set; }
            public class GetCrawlerResponseBodyCrawlerScheduleConfig : TeaModel {
                /// <summary>
                /// <para>The cron expression.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0 0 2 ? * *</para>
                /// </summary>
                [NameInMap("CronExpress")]
                [Validation(Required=false)]
                public string CronExpress { get; set; }

                /// <summary>
                /// <para>The scheduling type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>MANUAL</description></item>
                /// <item><description>NORMAL</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>NORMAL</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The crawl scope configuration.</para>
            /// </summary>
            [NameInMap("Scope")]
            [Validation(Required=false)]
            public GetCrawlerResponseBodyCrawlerScope Scope { get; set; }
            public class GetCrawlerResponseBodyCrawlerScope : TeaModel {
                /// <summary>
                /// <para>The regular expression used to exclude items from the crawl scope.</para>
                /// 
                /// <b>Example:</b>
                /// <para>^tmp_.*</para>
                /// </summary>
                [NameInMap("ExcludeRegex")]
                [Validation(Required=false)]
                public string ExcludeRegex { get; set; }

                /// <summary>
                /// <para>The crawl scope items.</para>
                /// </summary>
                [NameInMap("Items")]
                [Validation(Required=false)]
                public List<string> Items { get; set; }

                /// <summary>
                /// <para>The crawl scope granularity. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>PROJECT</description></item>
                /// <item><description>DATABASE</description></item>
                /// <item><description>INSTANCE</description></item>
                /// <item><description>CATALOG</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>DATABASE</para>
                /// </summary>
                [NameInMap("Unit")]
                [Validation(Required=false)]
                public string Unit { get; set; }

            }

            /// <summary>
            /// <para>The crawler status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>VALID: The crawler configuration is valid and the associated data source exists.</description></item>
            /// <item><description>INVALID: The crawler configuration is invalid or the associated data source does not exist.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>VALID</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The DataWorks scheduled task ID associated with the crawler. You can call GetTask to query the task definition.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public long? TaskId { get; set; }

            /// <summary>
            /// <para>The crawler type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>starrocks</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The request ID. You can use the ID to locate logs and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9252F32F-D855-549E-8898-61CF5A733050</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
