// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class DescribeEndPointEventListResponseBody : TeaModel {
        [NameInMap("Nodes")]
        [Validation(Required=false)]
        public List<DescribeEndPointEventListResponseBodyNodes> Nodes { get; set; }
        public class DescribeEndPointEventListResponseBodyNodes : TeaModel {
            [NameInMap("EventDataItems")]
            [Validation(Required=false)]
            public List<DescribeEndPointEventListResponseBodyNodesEventDataItems> EventDataItems { get; set; }
            public class DescribeEndPointEventListResponseBodyNodesEventDataItems : TeaModel {
                [NameInMap("EventList")]
                [Validation(Required=false)]
                public List<DescribeEndPointEventListResponseBodyNodesEventDataItemsEventList> EventList { get; set; }
                public class DescribeEndPointEventListResponseBodyNodesEventDataItemsEventList : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>开始发布</para>
                    /// </summary>
                    [NameInMap("EventName")]
                    [Validation(Required=false)]
                    public string EventName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>USER</para>
                    /// </summary>
                    [NameInMap("EventType")]
                    [Validation(Required=false)]
                    public string EventType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1614936817</para>
                    /// </summary>
                    [NameInMap("Ts")]
                    [Validation(Required=false)]
                    public long? Ts { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1614936817123</para>
                    /// </summary>
                    [NameInMap("TsInMs")]
                    [Validation(Required=false)]
                    public string TsInMs { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1614936817</para>
                /// </summary>
                [NameInMap("Ts")]
                [Validation(Required=false)]
                public long? Ts { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>testuserid</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>231470C1-ACFB-4C9F-844F-4CFE1E3804C5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
