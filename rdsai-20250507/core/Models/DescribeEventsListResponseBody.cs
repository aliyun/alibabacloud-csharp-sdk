// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class DescribeEventsListResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OtherException:3,MysqlIOException:1</para>
        /// </summary>
        [NameInMap("EventCodeCounts")]
        [Validation(Required=false)]
        public string EventCodeCounts { get; set; }

        [NameInMap("Events")]
        [Validation(Required=false)]
        public List<DescribeEventsListResponseBodyEvents> Events { get; set; }
        public class DescribeEventsListResponseBodyEvents : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>ExceptionEvent</para>
            /// </summary>
            [NameInMap("EventCode")]
            [Validation(Required=false)]
            public string EventCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>None</para>
            /// </summary>
            [NameInMap("EventStatus")]
            [Validation(Required=false)]
            public string EventStatus { get; set; }

            [NameInMap("EventTimeList")]
            [Validation(Required=false)]
            public List<string> EventTimeList { get; set; }

            [NameInMap("InstanceDescription")]
            [Validation(Required=false)]
            public string InstanceDescription { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>rm-2zecnb327gp36e7lh</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-07-23T02:11:07Z</para>
            /// </summary>
            [NameInMap("RecoveryTime")]
            [Validation(Required=false)]
            public string RecoveryTime { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageCount")]
        [Validation(Required=false)]
        public long? PageCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>FE9C65D7-930F-57A5-A207-8C396329241C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalPages")]
        [Validation(Required=false)]
        public long? TotalPages { get; set; }

    }

}
