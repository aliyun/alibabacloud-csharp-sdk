// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class DescribeChannelTopPubUserListResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>231470C1-ACFB-4C9F-844F-4CFE1E3804C5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TopPubUserDetailList")]
        [Validation(Required=false)]
        public List<DescribeChannelTopPubUserListResponseBodyTopPubUserDetailList> TopPubUserDetailList { get; set; }
        public class DescribeChannelTopPubUserListResponseBodyTopPubUserDetailList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1615893327</para>
            /// </summary>
            [NameInMap("CreatedTs")]
            [Validation(Required=false)]
            public long? CreatedTs { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1615893442</para>
            /// </summary>
            [NameInMap("DestroyedTs")]
            [Validation(Required=false)]
            public long? DestroyedTs { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public long? Duration { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>浙江省-杭州市</para>
            /// </summary>
            [NameInMap("Location")]
            [Validation(Required=false)]
            public string Location { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("OnlineDuration")]
            [Validation(Required=false)]
            public long? OnlineDuration { get; set; }

            [NameInMap("OnlinePeriods")]
            [Validation(Required=false)]
            public List<DescribeChannelTopPubUserListResponseBodyTopPubUserDetailListOnlinePeriods> OnlinePeriods { get; set; }
            public class DescribeChannelTopPubUserListResponseBodyTopPubUserDetailListOnlinePeriods : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1615893327</para>
                /// </summary>
                [NameInMap("JoinTs")]
                [Validation(Required=false)]
                public long? JoinTs { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1615893442</para>
                /// </summary>
                [NameInMap("LeaveTs")]
                [Validation(Required=false)]
                public long? LeaveTs { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>testuserid</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
