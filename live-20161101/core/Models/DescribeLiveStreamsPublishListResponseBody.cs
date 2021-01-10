// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveStreamsPublishListResponseBody : TeaModel {
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

        [NameInMap("PublishInfo")]
        [Validation(Required=false)]
        public DescribeLiveStreamsPublishListResponseBodyPublishInfo PublishInfo { get; set; }
        public class DescribeLiveStreamsPublishListResponseBodyPublishInfo : TeaModel {
            [NameInMap("LiveStreamPublishInfo")]
            [Validation(Required=false)]
            public List<DescribeLiveStreamsPublishListResponseBodyPublishInfoLiveStreamPublishInfo> LiveStreamPublishInfo { get; set; }
            public class DescribeLiveStreamsPublishListResponseBodyPublishInfoLiveStreamPublishInfo : TeaModel {
                public string EdgeNodeAddr { get; set; }
                public string PublishUrl { get; set; }
                public string StreamName { get; set; }
                public string StopTime { get; set; }
                public string DomainName { get; set; }
                public string TranscodeId { get; set; }
                public string PublishDomain { get; set; }
                public string PublishTime { get; set; }
                public string AppName { get; set; }
                public string PublishType { get; set; }
                public string Transcoded { get; set; }
                public string ClientAddr { get; set; }
                public string StreamUrl { get; set; }
            }
        };

    }

}
