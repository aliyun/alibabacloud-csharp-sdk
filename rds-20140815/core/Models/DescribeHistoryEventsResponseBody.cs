// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeHistoryEventsResponseBody : TeaModel {
        /// <summary>
        /// The details of the task execution.
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeHistoryEventsResponseBodyItems> Items { get; set; }
        public class DescribeHistoryEventsResponseBodyItems : TeaModel {
            /// <summary>
            /// The data returned.
            /// </summary>
            [NameInMap("Data")]
            [Validation(Required=false)]
            public DescribeHistoryEventsResponseBodyItemsData Data { get; set; }
            public class DescribeHistoryEventsResponseBodyItemsData : TeaModel {
                /// <summary>
                /// product.
                /// </summary>
                [NameInMap("CmsProduct")]
                [Validation(Required=false)]
                public string CmsProduct { get; set; }

                /// <summary>
                /// The type of the database engine.
                /// </summary>
                [NameInMap("DbType")]
                [Validation(Required=false)]
                public string DbType { get; set; }

                /// <summary>
                /// Detail impact.
                /// </summary>
                [NameInMap("DetailImpact")]
                [Validation(Required=false)]
                public string DetailImpact { get; set; }

                /// <summary>
                /// Detail reason.
                /// </summary>
                [NameInMap("DetailReason")]
                [Validation(Required=false)]
                public string DetailReason { get; set; }

                /// <summary>
                /// The end date of the query.
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// Event category.
                /// </summary>
                [NameInMap("EventCategory")]
                [Validation(Required=false)]
                public string EventCategory { get; set; }

                /// <summary>
                /// The code of the extension point event.
                /// </summary>
                [NameInMap("EventCode")]
                [Validation(Required=false)]
                public string EventCode { get; set; }

                /// <summary>
                /// The output names of the current file.
                /// 
                /// This parameter is equivalent to the Output Name parameter under Output in the Dependencies section of the Properties panel in the [DataWorks console](https://workbench.data.aliyun.com/console).
                /// </summary>
                [NameInMap("EventDetail")]
                [Validation(Required=false)]
                public string EventDetail { get; set; }

                /// <summary>
                /// The ID of the custom event.
                /// </summary>
                [NameInMap("EventId")]
                [Validation(Required=false)]
                public string EventId { get; set; }

                /// <summary>
                /// Event impact.
                /// </summary>
                [NameInMap("EventImpact")]
                [Validation(Required=false)]
                public string EventImpact { get; set; }

                /// <summary>
                /// Event level.
                /// </summary>
                [NameInMap("EventLevel")]
                [Validation(Required=false)]
                public string EventLevel { get; set; }

                /// <summary>
                /// The cause of the event.
                /// </summary>
                [NameInMap("EventReason")]
                [Validation(Required=false)]
                public string EventReason { get; set; }

                /// <summary>
                /// The status of the exception. Valid values:
                /// 
                /// *   **1**: pending handling
                /// *   **2**: ignored
                /// *   **4**: confirmed
                /// *   **8**: marked as a false positive
                /// *   **16**: handling
                /// *   **32**: handled
                /// *   **64**: expired
                /// </summary>
                [NameInMap("EventStatus")]
                [Validation(Required=false)]
                public string EventStatus { get; set; }

                /// <summary>
                /// The alert type.
                /// 
                /// *   Set the value to **sensitiveFile**.
                /// </summary>
                [NameInMap("EventType")]
                [Validation(Required=false)]
                public string EventType { get; set; }

                /// <summary>
                /// The time when the instance is created. The time is in the yyyy-MM-dd HH:mm:ss format.
                /// </summary>
                [NameInMap("GmtCreated")]
                [Validation(Required=false)]
                public string GmtCreated { get; set; }

                /// <summary>
                /// The time when the export task was modified.
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// Processing status.
                /// </summary>
                [NameInMap("HandleStatus")]
                [Validation(Required=false)]
                public string HandleStatus { get; set; }

                /// <summary>
                /// Is there a lifecycle.
                /// </summary>
                [NameInMap("HasLifeCycle")]
                [Validation(Required=false)]
                public int? HasLifeCycle { get; set; }

                /// <summary>
                /// The instance ID. Separate multiple instance IDs with commas (,). You can specify up to 30 instance IDs. This parameter is empty by default, which indicates that you can specify an unlimited number of instance IDs.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// The name of the instance.
                /// </summary>
                [NameInMap("InstanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

                /// <summary>
                /// Whether to close.
                /// </summary>
                [NameInMap("IsClosed")]
                [Validation(Required=false)]
                public int? IsClosed { get; set; }

                /// <summary>
                /// The name of the cloud service in which the system event occurred.
                /// 
                /// You can call the DescribeSystemEventMetaList operation to obtain the value of the response parameter `Product`. The value of the Product parameter indicates the names of all cloud services in which the system events of your Alibaba Cloud account occurred. For more information, see [DescribeSystemEventMetaList](~~114972~~).
                /// </summary>
                [NameInMap("Product")]
                [Validation(Required=false)]
                public string Product { get; set; }

                /// <summary>
                /// The region ID. You can call the DescribeRegions operation to query the most recent region list.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The type of resource. Set the value to INSTANCE.
                /// </summary>
                [NameInMap("ResourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

                /// <summary>
                /// The type of the source resource.
                /// </summary>
                [NameInMap("SourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

                /// <summary>
                /// The beginning of the time range to query. Specify the time in the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm*Z format. The time must be in UTC.
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// The account ID. You can view the ID of the **logon account** by moving the pointer over the profile in the Alibaba Cloud console.
                /// </summary>
                [NameInMap("Uid")]
                [Validation(Required=false)]
                public string Uid { get; set; }

            }

            /// <summary>
            /// The ID of the task.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// The region of the instance.
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// The instance username.
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// Specversion.
            /// </summary>
            [NameInMap("Specversion")]
            [Validation(Required=false)]
            public string Specversion { get; set; }

            /// <summary>
            /// The subject of the certificate, which is in the DN format.
            /// </summary>
            [NameInMap("Subject")]
            [Validation(Required=false)]
            public string Subject { get; set; }

            /// <summary>
            /// The time when the log was generated. The time is displayed in UTC.
            /// </summary>
            [NameInMap("Time")]
            [Validation(Required=false)]
            public string Time { get; set; }

            /// <summary>
            /// The notification type.
            /// 
            /// Valid values:
            /// 
            /// *   Sell
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   Operation
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   Promotion
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// The number of the page to return. Valid values: any non-zero positive integer.
        /// 
        /// Default value: **1**.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of tasks that meet these constraints without taking pagination into account.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
