// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vdc20201214.Models
{
    public class DescribePubUserListBySubUserResponseBody : TeaModel {
        /// <summary>
        /// 订阅端用户详细信息。
        /// </summary>
        [NameInMap("SubUserDetail")]
        [Validation(Required=false)]
        public DescribePubUserListBySubUserResponseBodySubUserDetail SubUserDetail { get; set; }
        public class DescribePubUserListBySubUserResponseBodySubUserDetail : TeaModel {
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }
            [NameInMap("UserIdAlias")]
            [Validation(Required=false)]
            public string UserIdAlias { get; set; }
            [NameInMap("Roles")]
            [Validation(Required=false)]
            public List<string> Roles { get; set; }
            [NameInMap("Location")]
            [Validation(Required=false)]
            public string Location { get; set; }
            [NameInMap("OnlinePeriods")]
            [Validation(Required=false)]
            public List<DescribePubUserListBySubUserResponseBodySubUserDetailOnlinePeriods> OnlinePeriods { get; set; }
            public class DescribePubUserListBySubUserResponseBodySubUserDetailOnlinePeriods : TeaModel {
                public long? JoinTs { get; set; }
                public long? LeaveTs { get; set; }
            }
            [NameInMap("CreatedTs")]
            [Validation(Required=false)]
            public long? CreatedTs { get; set; }
            [NameInMap("DestroyedTs")]
            [Validation(Required=false)]
            public long? DestroyedTs { get; set; }
            [NameInMap("OnlineDuration")]
            [Validation(Required=false)]
            public long? OnlineDuration { get; set; }
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public long? Duration { get; set; }
            [NameInMap("SdkVersion")]
            [Validation(Required=false)]
            public string SdkVersion { get; set; }
            [NameInMap("SdkVersionList")]
            [Validation(Required=false)]
            public List<string> SdkVersionList { get; set; }
            [NameInMap("Os")]
            [Validation(Required=false)]
            public string Os { get; set; }
            [NameInMap("OsList")]
            [Validation(Required=false)]
            public List<string> OsList { get; set; }
            [NameInMap("Network")]
            [Validation(Required=false)]
            public string Network { get; set; }
            [NameInMap("NetworkList")]
            [Validation(Required=false)]
            public List<string> NetworkList { get; set; }
            [NameInMap("ClientType")]
            [Validation(Required=false)]
            public string ClientType { get; set; }
        };

        /// <summary>
        /// 发布端用户详情信息。
        /// </summary>
        [NameInMap("PubUserDetailList")]
        [Validation(Required=false)]
        public List<DescribePubUserListBySubUserResponseBodyPubUserDetailList> PubUserDetailList { get; set; }
        public class DescribePubUserListBySubUserResponseBodyPubUserDetailList : TeaModel {
            /// <summary>
            /// 用户ID。
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// 用户ID别称
            /// </summary>
            [NameInMap("UserIdAlias")]
            [Validation(Required=false)]
            public string UserIdAlias { get; set; }

            /// <summary>
            /// 用户角色，取值：SENDER：发起者。RECEIVER：接收者。
            /// </summary>
            [NameInMap("Roles")]
            [Validation(Required=false)]
            public List<string> Roles { get; set; }

            /// <summary>
            /// 地理位置信息，例如：浙江省-杭州市。
            /// </summary>
            [NameInMap("Location")]
            [Validation(Required=false)]
            public string Location { get; set; }

            /// <summary>
            /// 在线时段信息。
            /// </summary>
            [NameInMap("OnlinePeriods")]
            [Validation(Required=false)]
            public List<DescribePubUserListBySubUserResponseBodyPubUserDetailListOnlinePeriods> OnlinePeriods { get; set; }
            public class DescribePubUserListBySubUserResponseBodyPubUserDetailListOnlinePeriods : TeaModel {
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
            /// 第一次加入通话的时间，使用UNIX时间戳表示，单位：秒。
            /// </summary>
            [NameInMap("CreatedTs")]
            [Validation(Required=false)]
            public long? CreatedTs { get; set; }

            /// <summary>
            /// 最后一次离开通话的时间，使用UNIX时间戳表示，单位：秒。
            /// </summary>
            [NameInMap("DestroyedTs")]
            [Validation(Required=false)]
            public long? DestroyedTs { get; set; }

            /// <summary>
            /// 在线时长，单位：秒。
            /// </summary>
            [NameInMap("OnlineDuration")]
            [Validation(Required=false)]
            public long? OnlineDuration { get; set; }

            /// <summary>
            /// 通话时长，首次进入到最后离开，单位：秒。
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public long? Duration { get; set; }

            /// <summary>
            /// SDK版本。
            /// </summary>
            [NameInMap("SdkVersion")]
            [Validation(Required=false)]
            public string SdkVersion { get; set; }

            /// <summary>
            /// SDK版本列表，如1.0.0、1.1.1等
            /// </summary>
            [NameInMap("SdkVersionList")]
            [Validation(Required=false)]
            public List<string> SdkVersionList { get; set; }

            /// <summary>
            /// 平台类型：若用户客户端为WEB则是浏览器类型，若客户端为NATIVE则是操作系统类型
            /// </summary>
            [NameInMap("Os")]
            [Validation(Required=false)]
            public string Os { get; set; }

            /// <summary>
            /// 平台类型：若用户客户端为WEB则是浏览器类型，若客户端为NATIVE则是操作系统类型
            /// </summary>
            [NameInMap("OsList")]
            [Validation(Required=false)]
            public List<string> OsList { get; set; }

            /// <summary>
            /// 网络类型，如WiFi，4G等
            /// </summary>
            [NameInMap("Network")]
            [Validation(Required=false)]
            public string Network { get; set; }

            /// <summary>
            /// 网络类型，如WiFi，4G等
            /// </summary>
            [NameInMap("NetworkList")]
            [Validation(Required=false)]
            public List<string> NetworkList { get; set; }

            /// <summary>
            /// 端类型，取值：WEB：Web端。NATIVE：本地端。
            /// </summary>
            [NameInMap("ClientType")]
            [Validation(Required=false)]
            public string ClientType { get; set; }

            /// <summary>
            /// 用户通信流的Call ID。
            /// </summary>
            [NameInMap("CallIdList")]
            [Validation(Required=false)]
            public List<string> CallIdList { get; set; }

        }

        /// <summary>
        /// 通信状态。取值：IN：进行中。OUT：已结束。
        /// </summary>
        [NameInMap("CallStatus")]
        [Validation(Required=false)]
        public string CallStatus { get; set; }

        /// <summary>
        /// 请求ID。
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
