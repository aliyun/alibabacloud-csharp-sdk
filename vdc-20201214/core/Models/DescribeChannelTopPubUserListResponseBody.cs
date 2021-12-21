// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vdc20201214.Models
{
    public class DescribeChannelTopPubUserListResponseBody : TeaModel {
        /// <summary>
        /// 请求ID。
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Top发布用户详情列表
        /// </summary>
        [NameInMap("TopPubUserDetailList")]
        [Validation(Required=false)]
        public List<DescribeChannelTopPubUserListResponseBodyTopPubUserDetailList> TopPubUserDetailList { get; set; }
        public class DescribeChannelTopPubUserListResponseBodyTopPubUserDetailList : TeaModel {
            /// <summary>
            /// 第一次加入通话的时间，使用UNIX时间戳表示，单位：秒。
            /// </summary>
            [NameInMap("CreatedTs")]
            [Validation(Required=false)]
            public long? CreatedTs { get; set; }

            /// <summary>
            /// 最后一次离开通话的时间，使用UNIX时间戳表示，单位：秒。通话未结束时值为0。
            /// </summary>
            [NameInMap("DestroyedTs")]
            [Validation(Required=false)]
            public long? DestroyedTs { get; set; }

            /// <summary>
            /// 总时长，单位：秒。
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public long? Duration { get; set; }

            /// <summary>
            /// 地域位置，例如：北京市-北京市
            /// </summary>
            [NameInMap("Location")]
            [Validation(Required=false)]
            public string Location { get; set; }

            /// <summary>
            /// 通信时长，单位：秒。
            /// </summary>
            [NameInMap("OnlineDuration")]
            [Validation(Required=false)]
            public long? OnlineDuration { get; set; }

            /// <summary>
            /// 在线期间用户列表。
            /// </summary>
            [NameInMap("OnlinePeriods")]
            [Validation(Required=false)]
            public List<DescribeChannelTopPubUserListResponseBodyTopPubUserDetailListOnlinePeriods> OnlinePeriods { get; set; }
            public class DescribeChannelTopPubUserListResponseBodyTopPubUserDetailListOnlinePeriods : TeaModel {
                /// <summary>
                /// 加入通话时间，使用UNIX时间戳表示，单位：秒。
                /// </summary>
                [NameInMap("JoinTs")]
                [Validation(Required=false)]
                public long? JoinTs { get; set; }

                /// <summary>
                /// 离开通话时间，使用UNIX时间戳表示，单位：秒。
                /// </summary>
                [NameInMap("LeaveTs")]
                [Validation(Required=false)]
                public long? LeaveTs { get; set; }

            }

            /// <summary>
            /// 用户ID。
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
