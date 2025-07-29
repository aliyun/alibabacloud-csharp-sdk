// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveUserStreamMetricDataResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>test.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>YYYY-MM-DDThh:mm:ssZ</para>
        /// 
        /// <b>Example:</b>
        /// <para>2015-12-10T21:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>16A96B9A-F203-4EC5-8E43-CB92E68F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2015-12-10T20:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        [NameInMap("StreamDetailData")]
        [Validation(Required=false)]
        public List<DescribeLiveUserStreamMetricDataResponseBodyStreamDetailData> StreamDetailData { get; set; }
        public class DescribeLiveUserStreamMetricDataResponseBodyStreamDetailData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>app</para>
            /// </summary>
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>423304182.66</para>
            /// </summary>
            [NameInMap("Bps")]
            [Validation(Required=false)]
            public float? Bps { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>423304182</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public long? Count { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>454</para>
            /// </summary>
            [NameInMap("FlvBps")]
            [Validation(Required=false)]
            public float? FlvBps { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>32</para>
            /// </summary>
            [NameInMap("FlvCount")]
            [Validation(Required=false)]
            public long? FlvCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1254</para>
            /// </summary>
            [NameInMap("FlvTraffic")]
            [Validation(Required=false)]
            public double? FlvTraffic { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>4456</para>
            /// </summary>
            [NameInMap("HlsBps")]
            [Validation(Required=false)]
            public float? HlsBps { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>56</para>
            /// </summary>
            [NameInMap("HlsCount")]
            [Validation(Required=false)]
            public long? HlsCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>568</para>
            /// </summary>
            [NameInMap("HlsTraffic")]
            [Validation(Required=false)]
            public double? HlsTraffic { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>450</para>
            /// </summary>
            [NameInMap("NewConns")]
            [Validation(Required=false)]
            public long? NewConns { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>6845</para>
            /// </summary>
            [NameInMap("P2pBps")]
            [Validation(Required=false)]
            public float? P2pBps { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>78</para>
            /// </summary>
            [NameInMap("P2pCount")]
            [Validation(Required=false)]
            public long? P2pCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>4102</para>
            /// </summary>
            [NameInMap("P2pTraffic")]
            [Validation(Required=false)]
            public double? P2pTraffic { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3323</para>
            /// </summary>
            [NameInMap("RtmpBps")]
            [Validation(Required=false)]
            public float? RtmpBps { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>63</para>
            /// </summary>
            [NameInMap("RtmpCount")]
            [Validation(Required=false)]
            public long? RtmpCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>5568</para>
            /// </summary>
            [NameInMap("RtmpTraffic")]
            [Validation(Required=false)]
            public double? RtmpTraffic { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2361</para>
            /// </summary>
            [NameInMap("RtsBps")]
            [Validation(Required=false)]
            public double? RtsBps { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>89</para>
            /// </summary>
            [NameInMap("RtsCount")]
            [Validation(Required=false)]
            public long? RtsCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2322</para>
            /// </summary>
            [NameInMap("RtsTraffic")]
            [Validation(Required=false)]
            public double? RtsTraffic { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test.flv</para>
            /// </summary>
            [NameInMap("StreamName")]
            [Validation(Required=false)]
            public string StreamName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2015-12-10T20:00:00Z</para>
            /// </summary>
            [NameInMap("TimeStamp")]
            [Validation(Required=false)]
            public string TimeStamp { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>423304182</para>
            /// </summary>
            [NameInMap("Traffic")]
            [Validation(Required=false)]
            public double? Traffic { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
