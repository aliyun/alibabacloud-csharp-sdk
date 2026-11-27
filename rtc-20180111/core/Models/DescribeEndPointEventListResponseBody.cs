// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class DescribeEndPointEventListResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of basic user information.</para>
        /// </summary>
        [NameInMap("Nodes")]
        [Validation(Required=false)]
        public List<DescribeEndPointEventListResponseBodyNodes> Nodes { get; set; }
        public class DescribeEndPointEventListResponseBodyNodes : TeaModel {
            /// <summary>
            /// <para>The list of event data.</para>
            /// </summary>
            [NameInMap("EventDataItems")]
            [Validation(Required=false)]
            public List<DescribeEndPointEventListResponseBodyNodesEventDataItems> EventDataItems { get; set; }
            public class DescribeEndPointEventListResponseBodyNodesEventDataItems : TeaModel {
                /// <summary>
                /// <para>The list of events.</para>
                /// </summary>
                [NameInMap("EventList")]
                [Validation(Required=false)]
                public List<DescribeEndPointEventListResponseBodyNodesEventDataItemsEventList> EventList { get; set; }
                public class DescribeEndPointEventListResponseBodyNodesEventDataItemsEventList : TeaModel {
                    /// <summary>
                    /// <para>The event name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Start publishing</para>
                    /// </summary>
                    [NameInMap("EventName")]
                    [Validation(Required=false)]
                    public string EventName { get; set; }

                    /// <summary>
                    /// <para>The event type. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>USER</b>: user event</description></item>
                    /// <item><description><b>SYSTEM</b>: system event</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>USER</para>
                    /// </summary>
                    [NameInMap("EventType")]
                    [Validation(Required=false)]
                    public string EventType { get; set; }

                    /// <summary>
                    /// <para>The time when the event occurred. The time is a UNIX timestamp in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1614936817</para>
                    /// </summary>
                    [NameInMap("Ts")]
                    [Validation(Required=false)]
                    public long? Ts { get; set; }

                    /// <summary>
                    /// <para>The time when the event occurred. The time is a UNIX timestamp in milliseconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1614936817123</para>
                    /// </summary>
                    [NameInMap("TsInMs")]
                    [Validation(Required=false)]
                    public string TsInMs { get; set; }

                }

                /// <summary>
                /// <para>The time when the first event occurred. The time is a UNIX timestamp in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1614936817</para>
                /// </summary>
                [NameInMap("Ts")]
                [Validation(Required=false)]
                public long? Ts { get; set; }

            }

            /// <summary>
            /// <para>The user ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testuserid</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>231470C1-ACFB-4C9F-844F-4CFE1E3804C5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
