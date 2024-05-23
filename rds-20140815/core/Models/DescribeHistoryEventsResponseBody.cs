// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeHistoryEventsResponseBody : TeaModel {
        /// <summary>
        /// The events.
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeHistoryEventsResponseBodyItems> Items { get; set; }
        public class DescribeHistoryEventsResponseBodyItems : TeaModel {
            /// <summary>
            /// The details of the data.
            /// </summary>
            [NameInMap("Data")]
            [Validation(Required=false)]
            public DescribeHistoryEventsResponseBodyItemsData Data { get; set; }
            public class DescribeHistoryEventsResponseBodyItemsData : TeaModel {
                /// <summary>
                /// The cloud service type of the application group. Valid values: **web** and native. The value web indicates a web application. The value **native** indicates a local application.
                /// </summary>
                [NameInMap("CmsProduct")]
                [Validation(Required=false)]
                public string CmsProduct { get; set; }

                /// <summary>
                /// The database engine.
                /// </summary>
                [NameInMap("DbType")]
                [Validation(Required=false)]
                public string DbType { get; set; }

                /// <summary>
                /// The pagination parameter.
                /// </summary>
                [NameInMap("DetailImpact")]
                [Validation(Required=false)]
                public string DetailImpact { get; set; }

                /// <summary>
                /// The details of the instance operation.
                /// </summary>
                [NameInMap("DetailReason")]
                [Validation(Required=false)]
                public string DetailReason { get; set; }

                /// <summary>
                /// The time when the alert was closed. The time follows the ISO 8601 standard in the *yyyy-mm-dd*t*hh:mm*z format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// The system event category. For more information, see [View the event history of an ApsaraDB RDS instance](https://help.aliyun.com/document_detail/129759.html).
                /// </summary>
                [NameInMap("EventCategory")]
                [Validation(Required=false)]
                public string EventCategory { get; set; }

                /// <summary>
                /// The event code.
                /// </summary>
                [NameInMap("EventCode")]
                [Validation(Required=false)]
                public string EventCode { get; set; }

                /// <summary>
                /// The event details.
                /// </summary>
                [NameInMap("EventDetail")]
                [Validation(Required=false)]
                public string EventDetail { get; set; }

                /// <summary>
                /// The event ID.
                /// </summary>
                [NameInMap("EventId")]
                [Validation(Required=false)]
                public string EventId { get; set; }

                /// <summary>
                /// The event impact.
                /// </summary>
                [NameInMap("EventImpact")]
                [Validation(Required=false)]
                public string EventImpact { get; set; }

                /// <summary>
                /// The event level. For more information, see [View the event history of an ApsaraDB RDS instance](https://help.aliyun.com/document_detail/129759.html).
                /// </summary>
                [NameInMap("EventLevel")]
                [Validation(Required=false)]
                public string EventLevel { get; set; }

                /// <summary>
                /// The event source.
                /// </summary>
                [NameInMap("EventReason")]
                [Validation(Required=false)]
                public string EventReason { get; set; }

                /// <summary>
                /// The status of the alert event. Valid values:
                /// 
                /// *   **1**: pending
                /// *   **2**: ignored
                /// *   **4**: confirmed
                /// *   **8**: marked as false positive
                /// *   **16**: handling
                /// *   **32**: handled
                /// *   **64**: expired
                /// </summary>
                [NameInMap("EventStatus")]
                [Validation(Required=false)]
                public string EventStatus { get; set; }

                /// <summary>
                /// The event type. Valid values:
                /// </summary>
                [NameInMap("EventType")]
                [Validation(Required=false)]
                public string EventType { get; set; }

                /// <summary>
                /// The creation time. The time follows the ISO 8601 standard in the *yyyy-mm-dd*t*hh:mm*z format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("GmtCreated")]
                [Validation(Required=false)]
                public string GmtCreated { get; set; }

                /// <summary>
                /// The update time. The time follows the ISO 8601 standard in the *yyyy-mm-dd*t*hh:mm*z format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// The handling status.
                /// </summary>
                [NameInMap("HandleStatus")]
                [Validation(Required=false)]
                public string HandleStatus { get; set; }

                /// <summary>
                /// Indicates whether the event has a lifecycle.
                /// </summary>
                [NameInMap("HasLifeCycle")]
                [Validation(Required=false)]
                public int? HasLifeCycle { get; set; }

                /// <summary>
                /// The instance ID.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// The instance name.
                /// </summary>
                [NameInMap("InstanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

                /// <summary>
                /// Indicates whether the alert is closed. Valid values: **0**: closed. **1**: not closed.
                /// </summary>
                [NameInMap("IsClosed")]
                [Validation(Required=false)]
                public int? IsClosed { get; set; }

                /// <summary>
                /// The service name.
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
                /// The resource type. The value is fixed as **INSTANCE**.
                /// </summary>
                [NameInMap("ResourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

                /// <summary>
                /// The type of the source data.
                /// </summary>
                [NameInMap("SourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

                /// <summary>
                /// The start time. The time follows the ISO 8601 standard in the *yyyy-mm-dd*t*hh:mm*z format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// The ID of the resource owner.
                /// </summary>
                [NameInMap("Uid")]
                [Validation(Required=false)]
                public string Uid { get; set; }

            }

            /// <summary>
            /// The task ID
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// The region ID.
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// The event source.
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// The database engine version.
            /// </summary>
            [NameInMap("Specversion")]
            [Validation(Required=false)]
            public string Specversion { get; set; }

            /// <summary>
            /// The name of the pending event.
            /// </summary>
            [NameInMap("Subject")]
            [Validation(Required=false)]
            public string Subject { get; set; }

            /// <summary>
            /// The amount of time that has elapsed from the start time of the query. Unit: seconds.
            /// </summary>
            [NameInMap("Time")]
            [Validation(Required=false)]
            public string Time { get; set; }

            /// <summary>
            /// The event type. For more information, see [View the event history of an ApsaraDB RDS instance](https://help.aliyun.com/document_detail/129759.html).
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// The page number. Valid values: any non-zero positive integer. Default value: **1**.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page. Default value: 30.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
