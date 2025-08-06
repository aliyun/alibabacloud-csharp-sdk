// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetVideoPlayInfoResponseBody : TeaModel {
        [NameInMap("PlayInfo")]
        [Validation(Required=false)]
        public GetVideoPlayInfoResponseBodyPlayInfo PlayInfo { get; set; }
        public class GetVideoPlayInfoResponseBodyPlayInfo : TeaModel {
            [NameInMap("AccessKeyId")]
            [Validation(Required=false)]
            public string AccessKeyId { get; set; }

            [NameInMap("AccessKeySecret")]
            [Validation(Required=false)]
            public string AccessKeySecret { get; set; }

            [NameInMap("AuthInfo")]
            [Validation(Required=false)]
            public string AuthInfo { get; set; }

            [NameInMap("PlayDomain")]
            [Validation(Required=false)]
            public string PlayDomain { get; set; }

            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            [NameInMap("SecurityToken")]
            [Validation(Required=false)]
            public string SecurityToken { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("VideoInfo")]
        [Validation(Required=false)]
        public GetVideoPlayInfoResponseBodyVideoInfo VideoInfo { get; set; }
        public class GetVideoPlayInfoResponseBodyVideoInfo : TeaModel {
            [NameInMap("CoverURL")]
            [Validation(Required=false)]
            public string CoverURL { get; set; }

            [NameInMap("CustomerId")]
            [Validation(Required=false)]
            public long? CustomerId { get; set; }

            [NameInMap("Duration")]
            [Validation(Required=false)]
            public float? Duration { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            [NameInMap("VideoId")]
            [Validation(Required=false)]
            public string VideoId { get; set; }

        }

    }

}
