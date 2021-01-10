// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveStreamHistoryUserNumResponseBody : TeaModel {
        [NameInMap("LiveStreamUserNumInfos")]
        [Validation(Required=false)]
        public DescribeLiveStreamHistoryUserNumResponseBodyLiveStreamUserNumInfos LiveStreamUserNumInfos { get; set; }
        public class DescribeLiveStreamHistoryUserNumResponseBodyLiveStreamUserNumInfos : TeaModel {
            [NameInMap("LiveStreamUserNumInfo")]
            [Validation(Required=false)]
            public List<DescribeLiveStreamHistoryUserNumResponseBodyLiveStreamUserNumInfosLiveStreamUserNumInfo> LiveStreamUserNumInfo { get; set; }
            public class DescribeLiveStreamHistoryUserNumResponseBodyLiveStreamUserNumInfosLiveStreamUserNumInfo : TeaModel {
                public string UserNum { get; set; }
                public string StreamTime { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
