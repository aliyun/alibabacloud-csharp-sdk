// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListCrawlersResponseBody : TeaModel {
        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("PagingInfo")]
        [Validation(Required=false)]
        public ListCrawlersResponseBodyPagingInfo PagingInfo { get; set; }
        public class ListCrawlersResponseBodyPagingInfo : TeaModel {
            /// <summary>
            /// <para>The list of metadata crawlers.</para>
            /// </summary>
            [NameInMap("Crawlers")]
            [Validation(Required=false)]
            public List<ListCrawlersResponseBodyPagingInfoCrawlers> Crawlers { get; set; }
            public class ListCrawlersResponseBodyPagingInfoCrawlers : TeaModel {
                /// <summary>
                /// <para>The creation time, expressed as a millisecond-precision UNIX timestamp.</para>
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
                /// <para>The DataWorks environment type. Valid values: Dev, Prod.</para>
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
                /// <para>The most recent run status. Valid values: WAITING, RUNNING, SUCCESS, ERROR, SHUTDOWN. This field may be empty if the crawler has not run yet.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SUCCESS</para>
                /// </summary>
                [NameInMap("LastRunStatus")]
                [Validation(Required=false)]
                public string LastRunStatus { get; set; }

                /// <summary>
                /// <para>The meta entity ID associated with the crawler. You can use this ID to connect to metadata query APIs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>starrocks:example-instance</para>
                /// </summary>
                [NameInMap("MetaEntityId")]
                [Validation(Required=false)]
                public string MetaEntityId { get; set; }

                /// <summary>
                /// <para>The modification time, expressed as a millisecond-precision UNIX timestamp.</para>
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
                /// <para>The schedule configuration.</para>
                /// </summary>
                [NameInMap("ScheduleConfig")]
                [Validation(Required=false)]
                public ListCrawlersResponseBodyPagingInfoCrawlersScheduleConfig ScheduleConfig { get; set; }
                public class ListCrawlersResponseBodyPagingInfoCrawlersScheduleConfig : TeaModel {
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
                    /// <para>The schedule type. Valid values: MANUAL, NORMAL.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>NORMAL</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <para>The crawler status. The value is VALID when the crawler configuration is valid and the associated data source exists. Otherwise, the value is INVALID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>VALID</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The DataWorks scheduling node ID associated with the crawler. You can use this ID to call GetTask to query the node definition.</para>
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
            /// <para>The current page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of records that match the query conditions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID. Used to locate logs and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9252F32F-D855-549E-8898-61CF5A733050</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request succeeded.</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
