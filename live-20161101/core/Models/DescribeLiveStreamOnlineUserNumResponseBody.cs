// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveStreamOnlineUserNumResponseBody : TeaModel {
        [NameInMap("OnlineUserInfo")]
        [Validation(Required=false)]
        public DescribeLiveStreamOnlineUserNumResponseBodyOnlineUserInfo OnlineUserInfo { get; set; }
        public class DescribeLiveStreamOnlineUserNumResponseBodyOnlineUserInfo : TeaModel {
            [NameInMap("LiveStreamOnlineUserNumInfo")]
            [Validation(Required=false)]
            public List<DescribeLiveStreamOnlineUserNumResponseBodyOnlineUserInfoLiveStreamOnlineUserNumInfo> LiveStreamOnlineUserNumInfo { get; set; }
            public class DescribeLiveStreamOnlineUserNumResponseBodyOnlineUserInfoLiveStreamOnlineUserNumInfo : TeaModel {
                public string Time { get; set; }
                public long? UserNumber { get; set; }
                public string StreamUrl { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalUserNumber")]
        [Validation(Required=false)]
        public long? TotalUserNumber { get; set; }

    }

}
