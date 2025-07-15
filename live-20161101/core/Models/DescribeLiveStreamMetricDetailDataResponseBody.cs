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

        /// <summary>
        /// <para>The data array returned.</para>
        /// </summary>
        [NameInMap("StreamDetailData")]
        [Validation(Required=false)]
        public DescribeLiveStreamMetricDetailDataResponseBodyStreamDetailData StreamDetailData { get; set; }
        public class DescribeLiveStreamMetricDetailDataResponseBodyStreamDetailData : TeaModel {
            [NameInMap("StreamData")]
            [Validation(Required=false)]
            public List<DescribeLiveStreamMetricDetailDataResponseBodyStreamDetailDataStreamData> StreamData { get; set; }
            public class DescribeLiveStreamMetricDetailDataResponseBodyStreamDetailDataStreamData : TeaModel {
                /// <summary>
                /// <para>The name of the application.</para>
                /// 
                /// <b>Example:</b>
                /// <para>app</para>
                /// </summary>
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                /// <summary>
                /// <para>The total bandwidth consumed by the stream per minute. Unit: bit/s.</para>
                /// 
                /// <b>Example:</b>
                /// <para>423304182.66</para>
                /// </summary>
                [NameInMap("Bps")]
                [Validation(Required=false)]
                public float? Bps { get; set; }

                /// <summary>
                /// <para>The total number of online viewers for the stream per minute.</para>
                /// 
                /// <b>Example:</b>
                /// <para>423304182</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                /// <summary>
                /// <para>The bandwidth over the Flash Video (FLV) protocol. Unit: bit/s.</para>
                /// <remarks>
                /// <para> This parameter is not returned if no traffic is generated over the protocol.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>454</para>
                /// </summary>
                [NameInMap("FlvBps")]
                [Validation(Required=false)]
                public float? FlvBps { get; set; }

                /// <summary>
                /// <para>The number of online viewers over the FLV protocol.</para>
                /// <remarks>
                /// <para> This parameter is not returned if no traffic is generated over the protocol.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>32</para>
                /// </summary>
                [NameInMap("FlvCount")]
                [Validation(Required=false)]
                public long? FlvCount { get; set; }

                /// <summary>
                /// <para>The amount of traffic over the FLV protocol. Unit: bytes.</para>
                /// <remarks>
                /// <para> This parameter is not returned if no traffic is generated over the protocol.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>1254</para>
                /// </summary>
                [NameInMap("FlvTraffic")]
                [Validation(Required=false)]
                public long? FlvTraffic { get; set; }

                /// <summary>
                /// <para>The bandwidth over the HTTP Live Streaming (HLS) protocol. Unit: bit/s.</para>
                /// <remarks>
                /// <para> This parameter is not returned if no traffic is generated over the protocol.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>4456</para>
                /// </summary>
                [NameInMap("HlsBps")]
                [Validation(Required=false)]
                public float? HlsBps { get; set; }

                /// <summary>
                /// <para>The number of online viewers over the HLS protocol.</para>
                /// <remarks>
                /// <para> Currently, this parameter is not supported.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>56</para>
                /// </summary>
                [NameInMap("HlsCount")]
                [Validation(Required=false)]
                public long? HlsCount { get; set; }

                /// <summary>
                /// <para>The amount of traffic over the HLS protocol. Unit: bytes.</para>
                /// <remarks>
                /// <para> This parameter is not returned if no traffic is generated over the protocol.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>568</para>
                /// </summary>
                [NameInMap("HlsTraffic")]
                [Validation(Required=false)]
                public long? HlsTraffic { get; set; }

                /// <summary>
                /// <para>Number of new connections established per minute.</para>
                /// 
                /// <b>Example:</b>
                /// <para>450</para>
                /// </summary>
                [NameInMap("NewConns")]
                [Validation(Required=false)]
                public string NewConns { get; set; }

                /// <summary>
                /// <para>The bandwidth over the P2P protocol. Unit: bit/s.</para>
                /// <remarks>
                /// <para> This parameter is not returned if no traffic is generated over the protocol.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>6845</para>
                /// </summary>
                [NameInMap("P2pBps")]
                [Validation(Required=false)]
                public float? P2pBps { get; set; }

                /// <summary>
                /// <para>The number of online viewers over the P2P protocol.</para>
                /// <remarks>
                /// <para> This parameter is not returned if no traffic is generated over the protocol.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>78</para>
                /// </summary>
                [NameInMap("P2pCount")]
                [Validation(Required=false)]
                public long? P2pCount { get; set; }

                /// <summary>
                /// <para>The amount of traffic over the peer-to-peer (P2P) protocol. Unit: bytes.</para>
                /// <remarks>
                /// <para> This parameter is not returned if no traffic is generated over the protocol.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>4102</para>
                /// </summary>
                [NameInMap("P2pTraffic")]
                [Validation(Required=false)]
                public long? P2pTraffic { get; set; }

                /// <summary>
                /// <para>The bandwidth over the Real-Time Messaging Protocol (RTMP) protocol. Unit: bit/s.</para>
                /// <remarks>
                /// <para> This parameter is not returned if no traffic is generated over the protocol.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>3323</para>
                /// </summary>
                [NameInMap("RtmpBps")]
                [Validation(Required=false)]
                public float? RtmpBps { get; set; }

                /// <summary>
                /// <para>The number of online viewers over the RTMP protocol.</para>
                /// <remarks>
                /// <para> This parameter is not returned if no traffic is generated over the protocol.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>63</para>
                /// </summary>
                [NameInMap("RtmpCount")]
                [Validation(Required=false)]
                public long? RtmpCount { get; set; }

                /// <summary>
                /// <para>The amount of traffic over the RTMP protocol. Unit: bytes.</para>
                /// <remarks>
                /// <para> This parameter is not returned if no traffic is generated over the protocol.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>5568</para>
                /// </summary>
                [NameInMap("RtmpTraffic")]
                [Validation(Required=false)]
                public long? RtmpTraffic { get; set; }

                /// <summary>
                /// <para>The bandwidth over the RTS protocol. Unit: bit/s.</para>
                /// <remarks>
                /// <para> This parameter is not returned if no traffic is generated over the protocol.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>2361</para>
                /// </summary>
                [NameInMap("RtsBps")]
                [Validation(Required=false)]
                public float? RtsBps { get; set; }

                /// <summary>
                /// <para>The number of online viewers over the Real-Time Streaming (RTS) protocol.</para>
                /// <remarks>
                /// <para> This parameter is not returned if no traffic is generated over the protocol.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>89</para>
                /// </summary>
                [NameInMap("RtsCount")]
                [Validation(Required=false)]
                public long? RtsCount { get; set; }

                /// <summary>
                /// <para>The amount of traffic over the RTS protocol. Unit: bytes.</para>
                /// <remarks>
                /// <para> This parameter is not returned if no traffic is generated over the protocol.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>2322</para>
                /// </summary>
                [NameInMap("RtsTraffic")]
                [Validation(Required=false)]
                public long? RtsTraffic { get; set; }

                /// <summary>
                /// <para>The name of the stream.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test.flv</para>
                /// </summary>
                [NameInMap("StreamName")]
                [Validation(Required=false)]
                public string StreamName { get; set; }

                /// <summary>
                /// <para>The timestamp of the returned data.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2015-12-10T20:00:00Z</para>
                /// </summary>
                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

                /// <summary>
                /// <para>The total amount of traffic consumed by the stream per minute. Unit: bytes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>423304182</para>
                /// </summary>
                [NameInMap("Traffic")]
                [Validation(Required=false)]
                public long? Traffic { get; set; }

            }

        }

    }

}
