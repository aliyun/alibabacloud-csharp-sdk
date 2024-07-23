// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeEventsResponseBody : TeaModel {
        /// <summary>
        /// <para>The events.</para>
        /// </summary>
        [NameInMap("EventItems")]
        [Validation(Required=false)]
        public DescribeEventsResponseBodyEventItems EventItems { get; set; }
        public class DescribeEventsResponseBodyEventItems : TeaModel {
            [NameInMap("EventItems")]
            [Validation(Required=false)]
            public List<DescribeEventsResponseBodyEventItemsEventItems> EventItems { get; set; }
            public class DescribeEventsResponseBodyEventItemsEventItems : TeaModel {
                /// <summary>
                /// <para>The ID of the user who executed the event.</para>
                /// 
                /// <b>Example:</b>
                /// <para>22973492**********</para>
                /// </summary>
                [NameInMap("CallerUid")]
                [Validation(Required=false)]
                public long? CallerUid { get; set; }

                /// <summary>
                /// <para>The event ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>11000053</para>
                /// </summary>
                [NameInMap("EventId")]
                [Validation(Required=false)]
                public int? EventId { get; set; }

                /// <summary>
                /// <para>The event name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ModifySecurityIPList</para>
                /// </summary>
                [NameInMap("EventName")]
                [Validation(Required=false)]
                public string EventName { get; set; }

                /// <summary>
                /// <para>The request or context parameters of the event.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{\&quot;Domain\&quot;: \&quot;rds-inc-share.aliyuncs.com\&quot;, \&quot;Api\&quot;: \&quot;ReleaseInstancePublicConnection\&quot;}</para>
                /// </summary>
                [NameInMap("EventPayload")]
                [Validation(Required=false)]
                public string EventPayload { get; set; }

                /// <summary>
                /// <para>The source of the event.</para>
                /// 
                /// <b>Example:</b>
                /// <para>FROM_USER</para>
                /// </summary>
                [NameInMap("EventReason")]
                [Validation(Required=false)]
                public string EventReason { get; set; }

                /// <summary>
                /// <para>The time when the event was recorded. The time is slightly later than the time the event occurred.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-08-20T01:12:49Z</para>
                /// </summary>
                [NameInMap("EventRecordTime")]
                [Validation(Required=false)]
                public string EventRecordTime { get; set; }

                /// <summary>
                /// <para>The time when the event occurred.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-08-20T01:08:22Z</para>
                /// </summary>
                [NameInMap("EventTime")]
                [Validation(Required=false)]
                public string EventTime { get; set; }

                /// <summary>
                /// <para>The event type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>NetworkManagement</para>
                /// </summary>
                [NameInMap("EventType")]
                [Validation(Required=false)]
                public string EventType { get; set; }

                /// <summary>
                /// <para>The type of the user who executed the event.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SYSTEM</para>
                /// </summary>
                [NameInMap("EventUserType")]
                [Validation(Required=false)]
                public string EventUserType { get; set; }

                /// <summary>
                /// <para>The region ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The name of the resource associated with the event. Only instance IDs are supported for this parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rm-bp1z3065m9976ix8a</para>
                /// </summary>
                [NameInMap("ResourceName")]
                [Validation(Required=false)]
                public string ResourceName { get; set; }

                /// <summary>
                /// <para>The type of the resource associated with the event. Only instances are supported for this parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>instance</para>
                /// </summary>
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
