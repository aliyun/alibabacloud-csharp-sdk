// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vdc20201214.Models
{
    public class DescribeFaultDiagnosisUserListResponseBody : TeaModel {
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
        /// 请求ID。
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 总数量。
        /// </summary>
        [NameInMap("TotalCnt")]
        [Validation(Required=false)]
        public int? TotalCnt { get; set; }

        /// <summary>
        /// 异常用户明细列表。
        /// </summary>
        [NameInMap("UserList")]
        [Validation(Required=false)]
        public List<DescribeFaultDiagnosisUserListResponseBodyUserList> UserList { get; set; }
        public class DescribeFaultDiagnosisUserListResponseBodyUserList : TeaModel {
            /// <summary>
            /// 通信的创建时间戳，使用UNIX时间戳表示，单位：秒。
            /// </summary>
            [NameInMap("ChannelCreatedTs")]
            [Validation(Required=false)]
            public long? ChannelCreatedTs { get; set; }

            /// <summary>
            /// 频道ID。
            /// </summary>
            [NameInMap("ChannelId")]
            [Validation(Required=false)]
            public string ChannelId { get; set; }

            /// <summary>
            /// 用户首次进入通话时间，使用UNIX时间戳表示，单位：秒。
            /// </summary>
            [NameInMap("CreatedTs")]
            [Validation(Required=false)]
            public long? CreatedTs { get; set; }

            /// <summary>
            /// 用户最后一次离开通话时间，使用UNIX时间戳表示，单位：秒。
            /// </summary>
            [NameInMap("DestroyedTs")]
            [Validation(Required=false)]
            public long? DestroyedTs { get; set; }

            /// <summary>
            /// 异常列表。
            /// </summary>
            [NameInMap("FaultList")]
            [Validation(Required=false)]
            public List<DescribeFaultDiagnosisUserListResponseBodyUserListFaultList> FaultList { get; set; }
            public class DescribeFaultDiagnosisUserListResponseBodyUserListFaultList : TeaModel {
                /// <summary>
                /// 异常类型 JOIN_SLOW：进频道慢 AUDIO_STUCK：音频卡顿 VIDEO_STUCK：视频卡顿 VIDEO_VAGUE：视频模糊 HIGH_DELAY：通话延迟高 FIRST_FRAME_SLOW：接收首屏慢
                /// </summary>
                [NameInMap("FaultType")]
                [Validation(Required=false)]
                public string FaultType { get; set; }

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
