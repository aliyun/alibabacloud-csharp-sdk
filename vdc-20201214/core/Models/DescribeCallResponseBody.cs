// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vdc20201214.Models
{
    public class DescribeCallResponseBody : TeaModel {
        /// <summary>
        /// 通信基本信息。
        /// </summary>
        [NameInMap("CallInfo")]
        [Validation(Required=false)]
        public DescribeCallResponseBodyCallInfo CallInfo { get; set; }
        public class DescribeCallResponseBodyCallInfo : TeaModel {
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }
            [NameInMap("CallStatus")]
            [Validation(Required=false)]
            public string CallStatus { get; set; }
            [NameInMap("ChannelId")]
            [Validation(Required=false)]
            public string ChannelId { get; set; }
            [NameInMap("CreatedTs")]
            [Validation(Required=false)]
            public long? CreatedTs { get; set; }
            [NameInMap("DestroyedTs")]
            [Validation(Required=false)]
            public long? DestroyedTs { get; set; }
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public long? Duration { get; set; }
        };

        /// <summary>
        /// 请求ID
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 用户详情列表。
        /// </summary>
        [NameInMap("UserDetailList")]
        [Validation(Required=false)]
        public List<DescribeCallResponseBodyUserDetailList> UserDetailList { get; set; }
        public class DescribeCallResponseBodyUserDetailList : TeaModel {
            /// <summary>
            /// 通话体验，取值：GOOD:优良，BAD:欠佳。
            /// </summary>
            [NameInMap("CallExp")]
            [Validation(Required=false)]
            public string CallExp { get; set; }

            /// <summary>
            /// 创建通话时间，使用UNIX时间戳表示，单位：秒。
            /// </summary>
            [NameInMap("CreatedTs")]
            [Validation(Required=false)]
            public long? CreatedTs { get; set; }

            /// <summary>
            /// 释放通话时间，使用UNIX时间戳表示，单位：秒。通话未结束时值为0。
            /// </summary>
            [NameInMap("DestroyedTs")]
            [Validation(Required=false)]
            public long? DestroyedTs { get; set; }

            /// <summary>
            /// 时长统计数据
            /// </summary>
            [NameInMap("DurMetricStatData")]
            [Validation(Required=false)]
            public DescribeCallResponseBodyUserDetailListDurMetricStatData DurMetricStatData { get; set; }
            public class DescribeCallResponseBodyUserDetailListDurMetricStatData : TeaModel {
                [NameInMap("PubAudio")]
                [Validation(Required=false)]
                public long? PubAudio { get; set; }
                [NameInMap("PubVideo1080")]
                [Validation(Required=false)]
                public long? PubVideo1080 { get; set; }
                [NameInMap("PubVideo360")]
                [Validation(Required=false)]
                public long? PubVideo360 { get; set; }
                [NameInMap("PubVideo720")]
                [Validation(Required=false)]
                public long? PubVideo720 { get; set; }
                [NameInMap("PubVideoScreenShare")]
                [Validation(Required=false)]
                public long? PubVideoScreenShare { get; set; }
                [NameInMap("SubAudio")]
                [Validation(Required=false)]
                public long? SubAudio { get; set; }
                [NameInMap("SubVideo1080")]
                [Validation(Required=false)]
                public long? SubVideo1080 { get; set; }
                [NameInMap("SubVideo360")]
                [Validation(Required=false)]
                public long? SubVideo360 { get; set; }
                [NameInMap("SubVideo720")]
                [Validation(Required=false)]
                public long? SubVideo720 { get; set; }
                [NameInMap("SubVideoScreenShare")]
                [Validation(Required=false)]
                public long? SubVideoScreenShare { get; set; }
            };

            /// <summary>
            /// 通话时长，首次进入到最后离开，单位：秒。
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public long? Duration { get; set; }

            /// <summary>
            /// 地理位置信息，例如：北京市-北京市
            /// </summary>
            [NameInMap("Location")]
            [Validation(Required=false)]
            public string Location { get; set; }

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
            /// 在线时长，单位：秒。
            /// </summary>
            [NameInMap("OnlineDuration")]
            [Validation(Required=false)]
            public long? OnlineDuration { get; set; }

            /// <summary>
            /// 在线时段信息。
            /// </summary>
            [NameInMap("OnlinePeriods")]
            [Validation(Required=false)]
            public List<DescribeCallResponseBodyUserDetailListOnlinePeriods> OnlinePeriods { get; set; }
            public class DescribeCallResponseBodyUserDetailListOnlinePeriods : TeaModel {
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
            /// 用户角色，取值：SENDER：发布端。RECEIVER：订阅端。
            /// </summary>
            [NameInMap("Roles")]
            [Validation(Required=false)]
            public List<string> Roles { get; set; }

            /// <summary>
            /// SDK版本，如1.0.0、1.1.1等
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
            /// 用户ID。
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// 用户ID 别称
            /// </summary>
            [NameInMap("UserIdAlias")]
            [Validation(Required=false)]
            public string UserIdAlias { get; set; }

        }

    }

}
