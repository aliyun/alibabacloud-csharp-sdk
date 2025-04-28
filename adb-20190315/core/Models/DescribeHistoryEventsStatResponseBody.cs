// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeHistoryEventsStatResponseBody : TeaModel {
        /// <summary>
        /// <para>The queried events.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeHistoryEventsStatResponseBodyItems> Items { get; set; }
        public class DescribeHistoryEventsStatResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The system event category. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Exception</description></item>
            /// <item><description>Optimize</description></item>
            /// <item><description>Notification</description></item>
            /// <item><description>Maintenance</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Exception</para>
            /// </summary>
            [NameInMap("EventCategory")]
            [Validation(Required=false)]
            public string EventCategory { get; set; }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BA0F6761-7A8C-59F8-9624-FB56788C0EDF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
