// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveStreamsOnlineListResponseBody : TeaModel {
        [NameInMap("TotalNum")]
        [Validation(Required=false)]
        public int? TotalNum { get; set; }

        [NameInMap("TotalPage")]
        [Validation(Required=false)]
        public int? TotalPage { get; set; }

        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("OnlineInfo")]
        [Validation(Required=false)]
        public DescribeLiveStreamsOnlineListResponseBodyOnlineInfo OnlineInfo { get; set; }
        public class DescribeLiveStreamsOnlineListResponseBodyOnlineInfo : TeaModel {
            [NameInMap("LiveStreamOnlineInfo")]
            [Validation(Required=false)]
            public List<DescribeLiveStreamsOnlineListResponseBodyOnlineInfoLiveStreamOnlineInfo> LiveStreamOnlineInfo { get; set; }
            public class DescribeLiveStreamsOnlineListResponseBodyOnlineInfoLiveStreamOnlineInfo : TeaModel {
                public string PublishUrl { get; set; }
                public string StreamName { get; set; }
                public string DomainName { get; set; }
                public string PublishDomain { get; set; }
                public string AppName { get; set; }
                public string PublishTime { get; set; }
            }
        };

    }

}
