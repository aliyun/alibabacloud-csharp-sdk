// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class DescribeEventsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of events on the current page, returned in descending order of the event log time.</para>
        /// </summary>
        [NameInMap("EventList")]
        [Validation(Required=false)]
        public List<DescribeEventsResponseBodyEventList> EventList { get; set; }
        public class DescribeEventsResponseBodyEventList : TeaModel {
            /// <summary>
            /// <para>The ID of the delivery group associated with the event. This field may be empty if the event is not associated with a delivery group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aig-9ciijz60n4xsv****</para>
            /// </summary>
            [NameInMap("AppInstanceGroupId")]
            [Validation(Required=false)]
            public string AppInstanceGroupId { get; set; }

            /// <summary>
            /// <para>The name of the delivery group associated with the event. This field may be empty if the event is not associated with a delivery group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>R&amp;D workstation group</para>
            /// </summary>
            [NameInMap("AppInstanceGroupName")]
            [Validation(Required=false)]
            public string AppInstanceGroupName { get; set; }

            /// <summary>
            /// <para>The event detail text. The content varies based on the <c>EventType</c> and may be empty. For example, a session release event may return a JSON text that describes the release cause.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;Reason&quot;:&quot;ByUser&quot;}</para>
            /// </summary>
            [NameInMap("DetailInfo")]
            [Validation(Required=false)]
            public string DetailInfo { get; set; }

            /// <summary>
            /// <para>The unique identifier of the event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>evt-9ciijz60n4xsv****</para>
            /// </summary>
            [NameInMap("EventId")]
            [Validation(Required=false)]
            public string EventId { get; set; }

            /// <summary>
            /// <para>The event type identifier. Different products may return different values. You can use this value for subsequent exact filtering.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SessionDisconnected</para>
            /// </summary>
            [NameInMap("EventType")]
            [Validation(Required=false)]
            public string EventType { get; set; }

            /// <summary>
            /// <para>The private IP address of the member ENI of the cloud resource associated with the event. This field may be empty if it is not applicable.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.1.10</para>
            /// </summary>
            [NameInMap("MemberEniIp")]
            [Validation(Required=false)]
            public string MemberEniIp { get; set; }

            /// <summary>
            /// <para>The time when the event occurred. Format: <c>yyyy-MM-dd HH:mm:ss</c>. Time zone: UTC+8 (Asia/Shanghai).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-09-29 14:17:33</para>
            /// </summary>
            [NameInMap("OccurredTime")]
            [Validation(Required=false)]
            public string OccurredTime { get; set; }

            /// <summary>
            /// <para>The ID of the office network associated with the event. This field may be empty if it is not applicable.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shanghai+dir-123456****</para>
            /// </summary>
            [NameInMap("OfficeSiteId")]
            [Validation(Required=false)]
            public string OfficeSiteId { get; set; }

            /// <summary>
            /// <para>The product type to which the event belongs. This field is an open string and may be extended as supported event sources expand. Callers should not restrict the value to the products currently listed in the <c>ProductType</c> request parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CloudApp</para>
            /// </summary>
            [NameInMap("ProductType")]
            [Validation(Required=false)]
            public string ProductType { get; set; }

            /// <summary>
            /// <para>The ID of the end user who generated the event. This field may be empty if the event is not associated with an end user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user01</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// <para>A compatibility field. The current version does not set this field. Do not rely on its value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>A compatibility field. The current version does not generate a next page token. Do not use this field for pagination.</para>
        /// 
        /// <b>Example:</b>
        /// <para>unused</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The page number corresponding to the current response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of events per page used in the current response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The unique identifier of the request, which can be used to troubleshoot request issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of events that meet all filter conditions within the 30-day retrievable window. Unit: entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>36</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
