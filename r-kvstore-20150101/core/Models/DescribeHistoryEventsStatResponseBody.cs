// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
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
            /// <item><description><b>Exception</b>: Exception event.</description></item>
            /// <item><description><b>Optimize</b>: Optimization events.</description></item>
            /// <item><description><b>Notification</b>: Notification event.</description></item>
            /// <item><description><b>Maintenance</b>: Scheduled maintenance event.</description></item>
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
            /// <para>21</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B32A350C-3A8E-5FF1-A56F-51C3769D****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
