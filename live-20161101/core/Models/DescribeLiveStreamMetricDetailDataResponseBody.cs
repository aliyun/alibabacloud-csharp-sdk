// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveStreamMetricDetailDataResponseBody : TeaModel {
        /// <summary>
        /// <para>The accelerated domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The end of the time range during which data was queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2015-12-10T21:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The token that determines the start point of the next query. This parameter is returned if more data results are available.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UjsM9x3aVcJi9a0-ArwJUTTC67C***37C0=</para>
        /// </summary>
        [NameInMap("NextPageToken")]
        [Validation(Required=false)]
        public string NextPageToken { get; set; }

        /// <summary>
        /// <para>The number of rows returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5000</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B955107D-E658-4E77-B913-E0AC3D31693E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The beginning of the time range during which data was queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2015-12-10T20:00:00Z</para>
        /// </summary>
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

                [NameInMap("NewConns")]
                [Validation(Required=false)]
                public string NewConns { get; set; }

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
