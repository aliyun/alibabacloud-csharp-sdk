// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vdc20201214.Models
{
    public class DescribeRtcChannelUsersResponseBody : TeaModel {
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
        /// 请求ID
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 总数
        /// </summary>
        [NameInMap("TotalCnt")]
        [Validation(Required=false)]
        public int? TotalCnt { get; set; }

        /// <summary>
        /// 用户列表
        /// </summary>
        [NameInMap("UserList")]
        [Validation(Required=false)]
        public DescribeRtcChannelUsersResponseBodyUserList UserList { get; set; }
        public class DescribeRtcChannelUsersResponseBodyUserList : TeaModel {
            [NameInMap("UserList")]
            [Validation(Required=false)]
            public List<DescribeRtcChannelUsersResponseBodyUserListUserList> UserList { get; set; }
            public class DescribeRtcChannelUsersResponseBodyUserListUserList : TeaModel {
                public string Channel { get; set; }
                public string EndTime { get; set; }
                public string Location { get; set; }
                public int? PubAudio { get; set; }
                public int? PubContent { get; set; }
                public int? PubVideo1080 { get; set; }
                public int? PubVideo360 { get; set; }
                public int? PubVideo720 { get; set; }
                public string ServiceArea { get; set; }
                public string StartTime { get; set; }
                public int? SubAudio { get; set; }
                public int? SubContent { get; set; }
                public int? SubVideo1080 { get; set; }
                public int? SubVideo360 { get; set; }
                public int? SubVideo720 { get; set; }
                public string UserId { get; set; }
            }
        };

    }

}
