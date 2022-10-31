// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveStreamMonitorListResponseBody : TeaModel {
        [NameInMap("LiveStreamMonitorList")]
        [Validation(Required=false)]
        public List<DescribeLiveStreamMonitorListResponseBodyLiveStreamMonitorList> LiveStreamMonitorList { get; set; }
        public class DescribeLiveStreamMonitorListResponseBodyLiveStreamMonitorList : TeaModel {
            [NameInMap("AudioFrom")]
            [Validation(Required=false)]
            public int? AudioFrom { get; set; }

            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            [NameInMap("InputList")]
            [Validation(Required=false)]
            public List<DescribeLiveStreamMonitorListResponseBodyLiveStreamMonitorListInputList> InputList { get; set; }
            public class DescribeLiveStreamMonitorListResponseBodyLiveStreamMonitorListInputList : TeaModel {
                [NameInMap("Index")]
                [Validation(Required=false)]
                public int? Index { get; set; }

                [NameInMap("InputUrl")]
                [Validation(Required=false)]
                public string InputUrl { get; set; }

                [NameInMap("LayoutConfig")]
                [Validation(Required=false)]
                public DescribeLiveStreamMonitorListResponseBodyLiveStreamMonitorListInputListLayoutConfig LayoutConfig { get; set; }
                public class DescribeLiveStreamMonitorListResponseBodyLiveStreamMonitorListInputListLayoutConfig : TeaModel {
                    [NameInMap("FillMode")]
                    [Validation(Required=false)]
                    public string FillMode { get; set; }

                    [NameInMap("PositionNormalized")]
                    [Validation(Required=false)]
                    public List<float?> PositionNormalized { get; set; }

                    [NameInMap("PositionRefer")]
                    [Validation(Required=false)]
                    public string PositionRefer { get; set; }

                    [NameInMap("SizeNormalized")]
                    [Validation(Required=false)]
                    public List<float?> SizeNormalized { get; set; }

                }

                [NameInMap("LayoutId")]
                [Validation(Required=false)]
                public int? LayoutId { get; set; }

                [NameInMap("PlayConfig")]
                [Validation(Required=false)]
                public DescribeLiveStreamMonitorListResponseBodyLiveStreamMonitorListInputListPlayConfig PlayConfig { get; set; }
                public class DescribeLiveStreamMonitorListResponseBodyLiveStreamMonitorListInputListPlayConfig : TeaModel {
                    [NameInMap("VolumeRate")]
                    [Validation(Required=false)]
                    public float? VolumeRate { get; set; }

                }

                [NameInMap("StreamName")]
                [Validation(Required=false)]
                public string StreamName { get; set; }

            }

            [NameInMap("MonitorId")]
            [Validation(Required=false)]
            public string MonitorId { get; set; }

            [NameInMap("MonitorName")]
            [Validation(Required=false)]
            public string MonitorName { get; set; }

            [NameInMap("OutputTemplate")]
            [Validation(Required=false)]
            public string OutputTemplate { get; set; }

            [NameInMap("OutputUrls")]
            [Validation(Required=false)]
            public DescribeLiveStreamMonitorListResponseBodyLiveStreamMonitorListOutputUrls OutputUrls { get; set; }
            public class DescribeLiveStreamMonitorListResponseBodyLiveStreamMonitorListOutputUrls : TeaModel {
                [NameInMap("FlvUrl")]
                [Validation(Required=false)]
                public string FlvUrl { get; set; }

                [NameInMap("RtmpUrl")]
                [Validation(Required=false)]
                public string RtmpUrl { get; set; }

            }

            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            [NameInMap("StopTime")]
            [Validation(Required=false)]
            public string StopTime { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
