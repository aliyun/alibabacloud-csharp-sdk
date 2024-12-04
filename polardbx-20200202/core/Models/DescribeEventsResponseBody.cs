// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class DescribeEventsResponseBody : TeaModel {
        [NameInMap("EventItems")]
        [Validation(Required=false)]
        public List<DescribeEventsResponseBodyEventItems> EventItems { get; set; }
        public class DescribeEventsResponseBodyEventItems : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>50421290</para>
            /// </summary>
            [NameInMap("EventId")]
            [Validation(Required=false)]
            public long? EventId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ModifySecurityIps</para>
            /// </summary>
            [NameInMap("EventName")]
            [Validation(Required=false)]
            public string EventName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{\&quot;Domain\&quot;: \&quot;rds-cn-hangzhou.aliyuncs.com\&quot;}</para>
            /// </summary>
            [NameInMap("EventPayload")]
            [Validation(Required=false)]
            public string EventPayload { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>FROM_USER</para>
            /// </summary>
            [NameInMap("EventReason")]
            [Validation(Required=false)]
            public string EventReason { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2021-10-15T06:39:49Z</para>
            /// </summary>
            [NameInMap("EventRecordTime")]
            [Validation(Required=false)]
            public string EventRecordTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2021-10-15T06:35:00Z</para>
            /// </summary>
            [NameInMap("EventTime")]
            [Validation(Required=false)]
            public string EventTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>SecurityManagement</para>
            /// </summary>
            [NameInMap("EventType")]
            [Validation(Required=false)]
            public string EventType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>USRE</para>
            /// </summary>
            [NameInMap("EventUserType")]
            [Validation(Required=false)]
            public string EventUserType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>px-bp1v8udesc89g156g</para>
            /// </summary>
            [NameInMap("ResourceName")]
            [Validation(Required=false)]
            public string ResourceName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>instance</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4748127A-6D50-432C-B635-433467074C27</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public long? TotalRecordCount { get; set; }

    }

}
