// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeEventsResponseBody : TeaModel {
        [NameInMap("EventItems")]
        [Validation(Required=false)]
        public DescribeEventsResponseBodyEventItems EventItems { get; set; }
        public class DescribeEventsResponseBodyEventItems : TeaModel {
            [NameInMap("EventItems")]
            [Validation(Required=false)]
            public List<DescribeEventsResponseBodyEventItemsEventItems> EventItems { get; set; }
            public class DescribeEventsResponseBodyEventItemsEventItems : TeaModel {
                [NameInMap("CallerUid")]
                [Validation(Required=false)]
                public long? CallerUid { get; set; }

                [NameInMap("EventId")]
                [Validation(Required=false)]
                public int? EventId { get; set; }

                [NameInMap("EventName")]
                [Validation(Required=false)]
                public string EventName { get; set; }

                [NameInMap("EventPayload")]
                [Validation(Required=false)]
                public string EventPayload { get; set; }

                [NameInMap("EventReason")]
                [Validation(Required=false)]
                public string EventReason { get; set; }

                [NameInMap("EventRecordTime")]
                [Validation(Required=false)]
                public string EventRecordTime { get; set; }

                [NameInMap("EventTime")]
                [Validation(Required=false)]
                public string EventTime { get; set; }

                [NameInMap("EventType")]
                [Validation(Required=false)]
                public string EventType { get; set; }

                [NameInMap("EventUserType")]
                [Validation(Required=false)]
                public string EventUserType { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("ResourceName")]
                [Validation(Required=false)]
                public string ResourceName { get; set; }

                [NameInMap("ResourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number.</para>
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
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A103039D-B1B2-4C57-B989-7D7C0DA95426</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>40</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
