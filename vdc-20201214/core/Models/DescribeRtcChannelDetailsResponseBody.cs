// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vdc20201214.Models
{
    public class DescribeRtcChannelDetailsResponseBody : TeaModel {
        /// <summary>
        /// 请求Id
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 页号
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// 显示数量
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// 总数量
        /// </summary>
        [NameInMap("TotalSize")]
        [Validation(Required=false)]
        public int? TotalSize { get; set; }

        /// <summary>
        /// 频道ID
        /// </summary>
        [NameInMap("ChannelId")]
        [Validation(Required=false)]
        public string ChannelId { get; set; }

        /// <summary>
        /// 频道信息
        /// </summary>
        [NameInMap("ChannelInfo")]
        [Validation(Required=false)]
        public List<DescribeRtcChannelDetailsResponseBodyChannelInfo> ChannelInfo { get; set; }
        public class DescribeRtcChannelDetailsResponseBodyChannelInfo : TeaModel {
            /// <summary>
            /// SessionID
            /// </summary>
            [NameInMap("Sid")]
            [Validation(Required=false)]
            public string Sid { get; set; }

            /// <summary>
            /// 参会者ID
            /// </summary>
            [NameInMap("Uid")]
            [Validation(Required=false)]
            public string Uid { get; set; }

            /// <summary>
            /// 用户入会时间，UTC格式
            /// </summary>
            [NameInMap("JoinTime")]
            [Validation(Required=false)]
            public string JoinTime { get; set; }

            /// <summary>
            /// 用户离会时间，UTC格式
            /// </summary>
            [NameInMap("LeaveTime")]
            [Validation(Required=false)]
            public string LeaveTime { get; set; }

            /// <summary>
            /// SDK版本
            /// </summary>
            [NameInMap("SdkVersion")]
            [Validation(Required=false)]
            public string SdkVersion { get; set; }

            /// <summary>
            /// 平台信息
            /// </summary>
            [NameInMap("Platform")]
            [Validation(Required=false)]
            public string Platform { get; set; }

            /// <summary>
            /// 操作系统
            /// </summary>
            [NameInMap("OS")]
            [Validation(Required=false)]
            public string OS { get; set; }

            /// <summary>
            /// 设备类型
            /// </summary>
            [NameInMap("DeviceType")]
            [Validation(Required=false)]
            public string DeviceType { get; set; }

        }

    }

}
