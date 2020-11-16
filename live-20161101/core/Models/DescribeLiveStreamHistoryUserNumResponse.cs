// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveStreamHistoryUserNumResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("LiveStreamUserNumInfos")]
        [Validation(Required=true)]
        public DescribeLiveStreamHistoryUserNumResponseLiveStreamUserNumInfos LiveStreamUserNumInfos { get; set; }
        public class DescribeLiveStreamHistoryUserNumResponseLiveStreamUserNumInfos : TeaModel {
            [NameInMap("LiveStreamUserNumInfo")]
            [Validation(Required=true)]
            public List<DescribeLiveStreamHistoryUserNumResponseLiveStreamUserNumInfosLiveStreamUserNumInfo> LiveStreamUserNumInfo { get; set; }
            public class DescribeLiveStreamHistoryUserNumResponseLiveStreamUserNumInfosLiveStreamUserNumInfo : TeaModel {
                public string StreamTime { get; set; }
                public string UserNum { get; set; }
            }
        };

    }

}
