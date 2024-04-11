// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribeVodMediaPlayDataResponseBody : TeaModel {
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public long? PageNo { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("QoeInfoList")]
        [Validation(Required=false)]
        public List<DescribeVodMediaPlayDataResponseBodyQoeInfoList> QoeInfoList { get; set; }
        public class DescribeVodMediaPlayDataResponseBodyQoeInfoList : TeaModel {
            [NameInMap("DAU")]
            [Validation(Required=false)]
            public float? DAU { get; set; }

            [NameInMap("MediaId")]
            [Validation(Required=false)]
            public string MediaId { get; set; }

            [NameInMap("PlayDuration")]
            [Validation(Required=false)]
            public float? PlayDuration { get; set; }

            [NameInMap("PlayDurationPerUv")]
            [Validation(Required=false)]
            public float? PlayDurationPerUv { get; set; }

            [NameInMap("PlayPerVv")]
            [Validation(Required=false)]
            public float? PlayPerVv { get; set; }

            [NameInMap("PlaySuccessVv")]
            [Validation(Required=false)]
            public float? PlaySuccessVv { get; set; }

            [NameInMap("VideoDuration")]
            [Validation(Required=false)]
            public float? VideoDuration { get; set; }

            [NameInMap("VideoTitle")]
            [Validation(Required=false)]
            public float? VideoTitle { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
