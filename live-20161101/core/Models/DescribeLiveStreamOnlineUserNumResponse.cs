// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveStreamOnlineUserNumResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("TotalUserNumber")]
        [Validation(Required=true)]
        public long TotalUserNumber { get; set; }

        [NameInMap("OnlineUserInfo")]
        [Validation(Required=true)]
        public DescribeLiveStreamOnlineUserNumResponseOnlineUserInfo OnlineUserInfo { get; set; }
        public class DescribeLiveStreamOnlineUserNumResponseOnlineUserInfo : TeaModel {
            [NameInMap("LiveStreamOnlineUserNumInfo")]
            [Validation(Required=true)]
            public List<DescribeLiveStreamOnlineUserNumResponseOnlineUserInfoLiveStreamOnlineUserNumInfo> LiveStreamOnlineUserNumInfo { get; set; }
            public class DescribeLiveStreamOnlineUserNumResponseOnlineUserInfoLiveStreamOnlineUserNumInfo : TeaModel {
                public string StreamUrl { get; set; }
                public long UserNumber { get; set; }
                public string Time { get; set; }
            }
        };

    }

}
