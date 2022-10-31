// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveStreamMetricDetailDataResponseBody : TeaModel {
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("NextPageToken")]
        [Validation(Required=false)]
        public string NextPageToken { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        [NameInMap("StreamDetailData")]
        [Validation(Required=false)]
        public DescribeLiveStreamMetricDetailDataResponseBodyStreamDetailData StreamDetailData { get; set; }
        public class DescribeLiveStreamMetricDetailDataResponseBodyStreamDetailData : TeaModel {
            [NameInMap("StreamData")]
            [Validation(Required=false)]
            public List<DescribeLiveStreamMetricDetailDataResponseBodyStreamDetailDataStreamData> StreamData { get; set; }
            public class DescribeLiveStreamMetricDetailDataResponseBodyStreamDetailDataStreamData : TeaModel {
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                [NameInMap("Bps")]
                [Validation(Required=false)]
                public float? Bps { get; set; }

                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                [NameInMap("FlvBps")]
                [Validation(Required=false)]
                public float? FlvBps { get; set; }

                [NameInMap("FlvCount")]
                [Validation(Required=false)]
                public long? FlvCount { get; set; }

                [NameInMap("FlvTraffic")]
                [Validation(Required=false)]
                public long? FlvTraffic { get; set; }

                [NameInMap("HlsBps")]
                [Validation(Required=false)]
                public float? HlsBps { get; set; }

                [NameInMap("HlsCount")]
                [Validation(Required=false)]
                public long? HlsCount { get; set; }

                [NameInMap("HlsTraffic")]
                [Validation(Required=false)]
                public long? HlsTraffic { get; set; }

                [NameInMap("P2pBps")]
                [Validation(Required=false)]
                public float? P2pBps { get; set; }

                [NameInMap("P2pCount")]
                [Validation(Required=false)]
                public long? P2pCount { get; set; }

                [NameInMap("P2pTraffic")]
                [Validation(Required=false)]
                public long? P2pTraffic { get; set; }

                [NameInMap("RtmpBps")]
                [Validation(Required=false)]
                public float? RtmpBps { get; set; }

                [NameInMap("RtmpCount")]
                [Validation(Required=false)]
                public long? RtmpCount { get; set; }

                [NameInMap("RtmpTraffic")]
                [Validation(Required=false)]
                public long? RtmpTraffic { get; set; }

                [NameInMap("RtsBps")]
                [Validation(Required=false)]
                public float? RtsBps { get; set; }

                [NameInMap("RtsCount")]
                [Validation(Required=false)]
                public long? RtsCount { get; set; }

                [NameInMap("RtsTraffic")]
                [Validation(Required=false)]
                public long? RtsTraffic { get; set; }

                [NameInMap("StreamName")]
                [Validation(Required=false)]
                public string StreamName { get; set; }

                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

                [NameInMap("Traffic")]
                [Validation(Required=false)]
                public long? Traffic { get; set; }

            }

        }

    }

}
