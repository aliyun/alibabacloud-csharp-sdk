// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class DescribeVsStreamsOnlineListResponseBody : TeaModel {
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
        public DescribeVsStreamsOnlineListResponseBodyOnlineInfo OnlineInfo { get; set; }
        public class DescribeVsStreamsOnlineListResponseBodyOnlineInfo : TeaModel {
            [NameInMap("LiveStreamOnlineInfo")]
            [Validation(Required=false)]
            public List<DescribeVsStreamsOnlineListResponseBodyOnlineInfoLiveStreamOnlineInfo> LiveStreamOnlineInfo { get; set; }
            public class DescribeVsStreamsOnlineListResponseBodyOnlineInfoLiveStreamOnlineInfo : TeaModel {
                public string PublishTime { get; set; }
                public string AppName { get; set; }
                public string PublishType { get; set; }
                public string PublishUrl { get; set; }
                public string Transcoded { get; set; }
                public string StreamName { get; set; }
                public string DomainName { get; set; }
                public string TranscodeId { get; set; }
                public string PublishDomain { get; set; }
            }
        };

    }

}
