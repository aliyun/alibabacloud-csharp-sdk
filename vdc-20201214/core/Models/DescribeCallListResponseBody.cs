// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vdc20201214.Models
{
    public class DescribeCallListResponseBody : TeaModel {
        /// <summary>
        /// 页码。
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// 每页数量。
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// 总数量。
        /// </summary>
        [NameInMap("TotalCnt")]
        [Validation(Required=false)]
        public int? TotalCnt { get; set; }

        /// <summary>
        /// 通信列表。
        /// </summary>
        [NameInMap("CallList")]
        [Validation(Required=false)]
        public List<DescribeCallListResponseBodyCallList> CallList { get; set; }
        public class DescribeCallListResponseBodyCallList : TeaModel {
            /// <summary>
            /// App ID。
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// 频道ID。
            /// </summary>
            [NameInMap("ChannelId")]
            [Validation(Required=false)]
            public string ChannelId { get; set; }

            /// <summary>
            /// 通信状态，IN：进行中，OUT：已结束
            /// </summary>
            [NameInMap("CallStatus")]
            [Validation(Required=false)]
            public string CallStatus { get; set; }

            /// <summary>
            /// 通信的创建时间戳，使用UNIX时间戳表示，单位：秒。
            /// </summary>
            [NameInMap("CreatedTs")]
            [Validation(Required=false)]
            public long? CreatedTs { get; set; }

            /// <summary>
            /// 通信的释放时间戳，使用UNIX时间戳表示，单位：秒。
            /// </summary>
            [NameInMap("DestroyedTs")]
            [Validation(Required=false)]
            public long? DestroyedTs { get; set; }

            /// <summary>
            /// 通信持续时长，单位：秒。
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public long? Duration { get; set; }

            /// <summary>
            /// 通信用户数。
            /// </summary>
            [NameInMap("UserCnt")]
            [Validation(Required=false)]
            public int? UserCnt { get; set; }

            /// <summary>
            /// 通信体验差的用户数。
            /// </summary>
            [NameInMap("BadExpUserCnt")]
            [Validation(Required=false)]
            public int? BadExpUserCnt { get; set; }

        }

        /// <summary>
        /// 请求ID。
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
