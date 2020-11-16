// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveStreamsOnlineListResponse : TeaModel {
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

        [NameInMap("OnlineInfo")]
        [Validation(Required=true)]
        public DescribeLiveStreamsOnlineListResponseOnlineInfo OnlineInfo { get; set; }
        public class DescribeLiveStreamsOnlineListResponseOnlineInfo : TeaModel {
            [NameInMap("LiveStreamOnlineInfo")]
            [Validation(Required=true)]
            public List<DescribeLiveStreamsOnlineListResponseOnlineInfoLiveStreamOnlineInfo> LiveStreamOnlineInfo { get; set; }
            public class DescribeLiveStreamsOnlineListResponseOnlineInfoLiveStreamOnlineInfo : TeaModel {
                public string DomainName { get; set; }
                public string AppName { get; set; }
                public string StreamName { get; set; }
                public string PublishTime { get; set; }
                public string PublishUrl { get; set; }
                public string PublishDomain { get; set; }
                public string PublishType { get; set; }
                public string Transcoded { get; set; }
                public string TranscodeId { get; set; }
                public string ServerIp { get; set; }
                public string ClientIp { get; set; }
                public int? VideoCodecId { get; set; }
                public int? VideoDataRate { get; set; }
                public int? FrameRate { get; set; }
                public int? Width { get; set; }
                public int? Height { get; set; }
                public int? AudioCodecId { get; set; }
                public int? AudioDataRate { get; set; }
            }
        };

    }

}
