// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveStreamTranscodeMetricDataResponseBody : TeaModel {
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
        /// <para>The end of the time range during which data was queried. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-06-11T02:46:40Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>A pagination token. When you call this operation, up to 5,000 rows of data can be returned per query. If the number of rows exceeds 5,000, the response includes a pagination token that is used in the next request to retrieve a new page of results.</para>
        /// <para>When you specify the token in the next query, data continues to be obtained from the end of the previous query.</para>
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
        /// <para>16A96B9A-F203-4EC5-8E43-CB92E68F4CD8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The beginning of the time range during which data was queried. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-06-11T03:46:40Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The data array returned.</para>
        /// </summary>
        [NameInMap("StreamDetailData")]
        [Validation(Required=false)]
        public DescribeLiveStreamTranscodeMetricDataResponseBodyStreamDetailData StreamDetailData { get; set; }
        public class DescribeLiveStreamTranscodeMetricDataResponseBodyStreamDetailData : TeaModel {
            [NameInMap("StreamData")]
            [Validation(Required=false)]
            public List<DescribeLiveStreamTranscodeMetricDataResponseBodyStreamDetailDataStreamData> StreamData { get; set; }
            public class DescribeLiveStreamTranscodeMetricDataResponseBodyStreamDetailDataStreamData : TeaModel {
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
                /// <para>The duration. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>300</para>
                /// </summary>
                [NameInMap("Duration")]
                [Validation(Required=false)]
                public long? Duration { get; set; }

                /// <summary>
                /// <para>The frame rate.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description><!-- -->
                /// 
                /// <!-- -->
                /// 
                /// <para>normal</para>
                /// <!-- -->
                /// </description></item>
                /// <item><description><!-- -->
                /// 
                /// <!-- -->
                /// 
                /// <para>high</para>
                /// <!-- -->
                /// </description></item>
                /// <item><description><!-- -->
                /// 
                /// <!-- -->
                /// 
                /// <para>def</para>
                /// <!-- --></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>high</para>
                /// </summary>
                [NameInMap("Fps")]
                [Validation(Required=false)]
                public string Fps { get; set; }

                /// <summary>
                /// <para>The region.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-shanghai</para>
                /// </summary>
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                /// <summary>
                /// <para>The resolution. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>2K: 2K resolution</description></item>
                /// <item><description>4K: 4K resolution</description></item>
                /// <item><description>LD: low definition</description></item>
                /// <item><description>SD: standard definition</description></item>
                /// <item><description>HD: high definition</description></item>
                /// <item><description>def: audio</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>4K</para>
                /// </summary>
                [NameInMap("Resolution")]
                [Validation(Required=false)]
                public string Resolution { get; set; }

                /// <summary>
                /// <para>The name of the stream.</para>
                /// 
                /// <b>Example:</b>
                /// <para>stream</para>
                /// </summary>
                [NameInMap("StreamName")]
                [Validation(Required=false)]
                public string StreamName { get; set; }

                /// <summary>
                /// <para>The timestamp of the returned data.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-06-11T02:45:00Z</para>
                /// </summary>
                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

                /// <summary>
                /// <para>The transcoding type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>H264STD: standard transcoding based on H.264</description></item>
                /// <item><description>H264NBHD: Narrowband HD™ transcoding based on H.264</description></item>
                /// <item><description>H265STD: standard transcoding based on H.265</description></item>
                /// <item><description>AUDIO: audio transcoding</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>H264STD</para>
                /// </summary>
                [NameInMap("TranscodeType")]
                [Validation(Required=false)]
                public string TranscodeType { get; set; }

            }

        }

    }

}
