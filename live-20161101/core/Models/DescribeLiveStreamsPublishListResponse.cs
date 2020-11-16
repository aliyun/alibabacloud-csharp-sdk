// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveStreamsPublishListResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("PageNum")]
        [Validation(Required=true)]
        public int? PageNum { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=true)]
        public int? PageSize { get; set; }

        [NameInMap("TotalNum")]
        [Validation(Required=true)]
        public int? TotalNum { get; set; }

        [NameInMap("TotalPage")]
        [Validation(Required=true)]
        public int? TotalPage { get; set; }

        [NameInMap("PublishInfo")]
        [Validation(Required=true)]
        public DescribeLiveStreamsPublishListResponsePublishInfo PublishInfo { get; set; }
        public class DescribeLiveStreamsPublishListResponsePublishInfo : TeaModel {
            [NameInMap("LiveStreamPublishInfo")]
            [Validation(Required=true)]
            public List<DescribeLiveStreamsPublishListResponsePublishInfoLiveStreamPublishInfo> LiveStreamPublishInfo { get; set; }
            public class DescribeLiveStreamsPublishListResponsePublishInfoLiveStreamPublishInfo : TeaModel {
                public string DomainName { get; set; }
                public string AppName { get; set; }
                public string StreamName { get; set; }
                public string StreamUrl { get; set; }
                public string PublishTime { get; set; }
                public string StopTime { get; set; }
                public string PublishUrl { get; set; }
                public string ClientAddr { get; set; }
                public string EdgeNodeAddr { get; set; }
                public string PublishDomain { get; set; }
                public string PublishType { get; set; }
                public string Transcoded { get; set; }
                public string TranscodeId { get; set; }
            }
        };

    }

}
