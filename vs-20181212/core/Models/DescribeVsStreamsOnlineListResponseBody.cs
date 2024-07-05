// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class DescribeVsStreamsOnlineListResponseBody : TeaModel {
        [NameInMap("OnlineInfo")]
        [Validation(Required=false)]
        public DescribeVsStreamsOnlineListResponseBodyOnlineInfo OnlineInfo { get; set; }
        public class DescribeVsStreamsOnlineListResponseBodyOnlineInfo : TeaModel {
            [NameInMap("LiveStreamOnlineInfo")]
            [Validation(Required=false)]
            public List<DescribeVsStreamsOnlineListResponseBodyOnlineInfoLiveStreamOnlineInfo> LiveStreamOnlineInfo { get; set; }
            public class DescribeVsStreamsOnlineListResponseBodyOnlineInfoLiveStreamOnlineInfo : TeaModel {
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                [NameInMap("PublishDomain")]
                [Validation(Required=false)]
                public string PublishDomain { get; set; }

                [NameInMap("PublishTime")]
                [Validation(Required=false)]
                public string PublishTime { get; set; }

                [NameInMap("PublishType")]
                [Validation(Required=false)]
                public string PublishType { get; set; }

                [NameInMap("PublishUrl")]
                [Validation(Required=false)]
                public string PublishUrl { get; set; }

                [NameInMap("StreamName")]
                [Validation(Required=false)]
                public string StreamName { get; set; }

                [NameInMap("TranscodeId")]
                [Validation(Required=false)]
                public string TranscodeId { get; set; }

                [NameInMap("Transcoded")]
                [Validation(Required=false)]
                public string Transcoded { get; set; }

            }

        }

        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalNum")]
        [Validation(Required=false)]
        public int? TotalNum { get; set; }

        [NameInMap("TotalPage")]
        [Validation(Required=false)]
        public int? TotalPage { get; set; }

    }

}
