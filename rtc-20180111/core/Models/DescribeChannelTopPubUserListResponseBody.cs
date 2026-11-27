// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class DescribeChannelTopPubUserListResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>231470C1-ACFB-4C9F-844F-4CFE1E3804C5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of details about top publishing users.</para>
        /// </summary>
        [NameInMap("TopPubUserDetailList")]
        [Validation(Required=false)]
        public List<DescribeChannelTopPubUserListResponseBodyTopPubUserDetailList> TopPubUserDetailList { get; set; }
        public class DescribeChannelTopPubUserListResponseBodyTopPubUserDetailList : TeaModel {
            /// <summary>
            /// <para>The time when the user first joined the channel. The value is a UNIX timestamp in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1615893327</para>
            /// </summary>
            [NameInMap("CreatedTs")]
            [Validation(Required=false)]
            public long? CreatedTs { get; set; }

            /// <summary>
            /// <para>The time when the user last left the channel. The value is a UNIX timestamp in seconds. The value is 0 if the call has not ended.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1615893442</para>
            /// </summary>
            [NameInMap("DestroyedTs")]
            [Validation(Required=false)]
            public long? DestroyedTs { get; set; }

            /// <summary>
            /// <para>The total duration in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>115</para>
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public long? Duration { get; set; }

            /// <summary>
            /// <para>The geographic location, such as Beijing-Beijing.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Zhejiang-Hangzhou</para>
            /// </summary>
            [NameInMap("Location")]
            [Validation(Required=false)]
            public string Location { get; set; }

            /// <summary>
            /// <para>The communication duration in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>115</para>
            /// </summary>
            [NameInMap("OnlineDuration")]
            [Validation(Required=false)]
            public long? OnlineDuration { get; set; }

            /// <summary>
            /// <para>The list of online periods for the user.</para>
            /// </summary>
            [NameInMap("OnlinePeriods")]
            [Validation(Required=false)]
            public List<DescribeChannelTopPubUserListResponseBodyTopPubUserDetailListOnlinePeriods> OnlinePeriods { get; set; }
            public class DescribeChannelTopPubUserListResponseBodyTopPubUserDetailListOnlinePeriods : TeaModel {
                /// <summary>
                /// <para>The time when the user joined the channel. The value is a UNIX timestamp in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1615893327</para>
                /// </summary>
                [NameInMap("JoinTs")]
                [Validation(Required=false)]
                public long? JoinTs { get; set; }

                /// <summary>
                /// <para>The time when the user left the channel. The value is a UNIX timestamp in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1615893442</para>
                /// </summary>
                [NameInMap("LeaveTs")]
                [Validation(Required=false)]
                public long? LeaveTs { get; set; }

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

    }

}
