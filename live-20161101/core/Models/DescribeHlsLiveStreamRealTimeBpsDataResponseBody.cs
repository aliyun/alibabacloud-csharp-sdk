// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeHlsLiveStreamRealTimeBpsDataResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>17C16B18-D3EA-4809-9CC3-8A2CBE14BC7B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The timestamp for which the data was queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2018-08-08T00:00:00Z</para>
        /// </summary>
        [NameInMap("Time")]
        [Validation(Required=false)]
        public string Time { get; set; }

        /// <summary>
        /// <para>The usage data.</para>
        /// </summary>
        [NameInMap("UsageData")]
        [Validation(Required=false)]
        public List<DescribeHlsLiveStreamRealTimeBpsDataResponseBodyUsageData> UsageData { get; set; }
        public class DescribeHlsLiveStreamRealTimeBpsDataResponseBodyUsageData : TeaModel {
            /// <summary>
            /// <para>The domain name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example.com</para>
            /// </summary>
            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }

            /// <summary>
            /// <para>Details about the statistics on each HLS stream under the domain name.</para>
            /// </summary>
            [NameInMap("StreamInfos")]
            [Validation(Required=false)]
            public List<DescribeHlsLiveStreamRealTimeBpsDataResponseBodyUsageDataStreamInfos> StreamInfos { get; set; }
            public class DescribeHlsLiveStreamRealTimeBpsDataResponseBodyUsageDataStreamInfos : TeaModel {
                /// <summary>
                /// <para>The statistics on the HLS stream.</para>
                /// </summary>
                [NameInMap("Infos")]
                [Validation(Required=false)]
                public List<DescribeHlsLiveStreamRealTimeBpsDataResponseBodyUsageDataStreamInfosInfos> Infos { get; set; }
                public class DescribeHlsLiveStreamRealTimeBpsDataResponseBodyUsageDataStreamInfosInfos : TeaModel {
                    /// <summary>
                    /// <para>The bandwidth. Unit: bit/s.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>11440.88</para>
                    /// </summary>
                    [NameInMap("DownFlow")]
                    [Validation(Required=false)]
                    public float? DownFlow { get; set; }

                    /// <summary>
                    /// <para>The number of online users.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Online")]
                    [Validation(Required=false)]
                    public float? Online { get; set; }

                    /// <summary>
                    /// <para>The bitrate.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1028</para>
                    /// </summary>
                    [NameInMap("Rate")]
                    [Validation(Required=false)]
                    public string Rate { get; set; }

                }

                /// <summary>
                /// <para>The name of the stream.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/live/sport.m3u8</para>
                /// </summary>
                [NameInMap("StreamName")]
                [Validation(Required=false)]
                public string StreamName { get; set; }

            }

        }

    }

}
