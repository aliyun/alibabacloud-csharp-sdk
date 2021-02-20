// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class DescribeRtcChannelUserListResponseBody : TeaModel {
        [NameInMap("TotalCnt")]
        [Validation(Required=false)]
        public long? TotalCnt { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public long? PageNo { get; set; }

        [NameInMap("UserList")]
        [Validation(Required=false)]
        public DescribeRtcChannelUserListResponseBodyUserList UserList { get; set; }
        public class DescribeRtcChannelUserListResponseBodyUserList : TeaModel {
            [NameInMap("UserList")]
            [Validation(Required=false)]
            public List<DescribeRtcChannelUserListResponseBodyUserListUserList> UserList { get; set; }
            public class DescribeRtcChannelUserListResponseBodyUserListUserList : TeaModel {
                public int? SubVideo720 { get; set; }
                public int? SubVideo1080 { get; set; }
                public int? SubContent { get; set; }
                public string UserId { get; set; }
                public int? PubVideo360 { get; set; }
                public int? SubVideo360 { get; set; }
                public string ServiceArea { get; set; }
                public string EndTime { get; set; }
                public string StartTime { get; set; }
                public int? PubContent { get; set; }
                public string ChannelId { get; set; }
                public int? PubVideo1080 { get; set; }
                public int? PubAudio { get; set; }
                public int? PubVideo720 { get; set; }
                public int? SubAudio { get; set; }
            }
        };

    }

}
