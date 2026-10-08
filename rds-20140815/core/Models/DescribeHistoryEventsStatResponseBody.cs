// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeHistoryEventsStatResponseBody : TeaModel {
        /// <summary>
        /// <para>The event list.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeHistoryEventsStatResponseBodyItems> Items { get; set; }
        public class DescribeHistoryEventsStatResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The system event categorization. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Exception</b>: abnormal event.</description></item>
            /// <item><description><b>Optimize</b>: optimization events.</description></item>
            /// <item><description><b>Notification</b>: notification event.</description></item>
            /// <item><description><b>Maintenance</b>: scheduled maintenance event.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Exception</para>
            /// </summary>
            [NameInMap("EventCategory")]
            [Validation(Required=false)]
            public string EventCategory { get; set; }

            /// <summary>
            /// <para>The total number of records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>31</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E52666CC-330E-418A-8E5B-A19E3FB42D13</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
