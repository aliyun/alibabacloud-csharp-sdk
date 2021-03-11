// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class DescribeVsStreamsPublishListResponseBody : TeaModel {
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
        public DescribeVsStreamsPublishListResponseBodyPublishInfo PublishInfo { get; set; }
        public class DescribeVsStreamsPublishListResponseBodyPublishInfo : TeaModel {
            [NameInMap("LiveStreamPublishInfo")]
            [Validation(Required=false)]
            public List<DescribeVsStreamsPublishListResponseBodyPublishInfoLiveStreamPublishInfo> LiveStreamPublishInfo { get; set; }
            public class DescribeVsStreamsPublishListResponseBodyPublishInfoLiveStreamPublishInfo : TeaModel {
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
