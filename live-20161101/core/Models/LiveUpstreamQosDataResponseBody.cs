// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class LiveUpstreamQosDataResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<LiveUpstreamQosDataResponseBodyData> Data { get; set; }
        public class LiveUpstreamQosDataResponseBodyData : TeaModel {
            [NameInMap("CdnDomain")]
            [Validation(Required=false)]
            public string CdnDomain { get; set; }

            [NameInMap("CdnIsp")]
            [Validation(Required=false)]
            public string CdnIsp { get; set; }

            [NameInMap("CdnOcid")]
            [Validation(Required=false)]
            public string CdnOcid { get; set; }

            [NameInMap("CdnProvince")]
            [Validation(Required=false)]
            public string CdnProvince { get; set; }

            [NameInMap("DetailData")]
            [Validation(Required=false)]
            public List<LiveUpstreamQosDataResponseBodyDataDetailData> DetailData { get; set; }
            public class LiveUpstreamQosDataResponseBodyDataDetailData : TeaModel {
                [NameInMap("ConnectDur")]
                [Validation(Required=false)]
                public long? ConnectDur { get; set; }

                [NameInMap("ConnectFailedCount")]
                [Validation(Required=false)]
                public long? ConnectFailedCount { get; set; }

                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                [NameInMap("FirstDataDur")]
                [Validation(Required=false)]
                public long? FirstDataDur { get; set; }

                [NameInMap("FirstDataFailedCount")]
                [Validation(Required=false)]
                public long? FirstDataFailedCount { get; set; }

                [NameInMap("FirstFrameDur")]
                [Validation(Required=false)]
                public long? FirstFrameDur { get; set; }

                [NameInMap("FirstFrameSuccessCount")]
                [Validation(Required=false)]
                public long? FirstFrameSuccessCount { get; set; }

                [NameInMap("StatusCode2Xx")]
                [Validation(Required=false)]
                public long? StatusCode2Xx { get; set; }

                [NameInMap("StatusCode3Xx")]
                [Validation(Required=false)]
                public long? StatusCode3Xx { get; set; }

                [NameInMap("StatusCode4Xx")]
                [Validation(Required=false)]
                public long? StatusCode4Xx { get; set; }

                [NameInMap("StatusCode5Xx")]
                [Validation(Required=false)]
                public long? StatusCode5Xx { get; set; }

                [NameInMap("Timestamp")]
                [Validation(Required=false)]
                public string Timestamp { get; set; }

            }

            [NameInMap("KwaiSidc")]
            [Validation(Required=false)]
            public string KwaiSidc { get; set; }

            [NameInMap("KwaiTsc")]
            [Validation(Required=false)]
            public long? KwaiTsc { get; set; }

            [NameInMap("UpstreamDomain")]
            [Validation(Required=false)]
            public string UpstreamDomain { get; set; }

        }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
