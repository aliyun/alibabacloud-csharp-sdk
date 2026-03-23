// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeHistoryEventsResponseBody : TeaModel {
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeHistoryEventsResponseBodyItems> Items { get; set; }
        public class DescribeHistoryEventsResponseBodyItems : TeaModel {
            [NameInMap("Data")]
            [Validation(Required=false)]
            public DescribeHistoryEventsResponseBodyItemsData Data { get; set; }
            public class DescribeHistoryEventsResponseBodyItemsData : TeaModel {
                [NameInMap("CmsProduct")]
                [Validation(Required=false)]
                public string CmsProduct { get; set; }

                [NameInMap("DbType")]
                [Validation(Required=false)]
                public string DbType { get; set; }

                [NameInMap("DetailImpact")]
                [Validation(Required=false)]
                public string DetailImpact { get; set; }

                [NameInMap("DetailReason")]
                [Validation(Required=false)]
                public string DetailReason { get; set; }

                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                [NameInMap("EventCategory")]
                [Validation(Required=false)]
                public string EventCategory { get; set; }

                [NameInMap("EventCode")]
                [Validation(Required=false)]
                public string EventCode { get; set; }

                [NameInMap("EventDetail")]
                [Validation(Required=false)]
                public string EventDetail { get; set; }

                [NameInMap("EventId")]
                [Validation(Required=false)]
                public string EventId { get; set; }

                [NameInMap("EventImpact")]
                [Validation(Required=false)]
                public string EventImpact { get; set; }

                [NameInMap("EventLevel")]
                [Validation(Required=false)]
                public string EventLevel { get; set; }

                [NameInMap("EventReason")]
                [Validation(Required=false)]
                public string EventReason { get; set; }

                [NameInMap("EventStatus")]
                [Validation(Required=false)]
                public string EventStatus { get; set; }

                [NameInMap("EventType")]
                [Validation(Required=false)]
                public string EventType { get; set; }

                [NameInMap("GmtCreated")]
                [Validation(Required=false)]
                public string GmtCreated { get; set; }

                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                [NameInMap("HandleStatus")]
                [Validation(Required=false)]
                public string HandleStatus { get; set; }

                [NameInMap("HasLifeCycle")]
                [Validation(Required=false)]
                public int? HasLifeCycle { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("InstanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

                [NameInMap("IsClosed")]
                [Validation(Required=false)]
                public int? IsClosed { get; set; }

                [NameInMap("Product")]
                [Validation(Required=false)]
                public string Product { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("ResourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

                [NameInMap("SourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                [NameInMap("Uid")]
                [Validation(Required=false)]
                public string Uid { get; set; }

            }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            [NameInMap("Specversion")]
            [Validation(Required=false)]
            public string Specversion { get; set; }

            [NameInMap("Subject")]
            [Validation(Required=false)]
            public string Subject { get; set; }

            [NameInMap("Time")]
            [Validation(Required=false)]
            public string Time { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
