// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveStreamsOnlineListResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the live streams that are being ingested.</para>
        /// </summary>
        [NameInMap("OnlineInfo")]
        [Validation(Required=false)]
        public DescribeLiveStreamsOnlineListResponseBodyOnlineInfo OnlineInfo { get; set; }
        public class DescribeLiveStreamsOnlineListResponseBodyOnlineInfo : TeaModel {
            [NameInMap("LiveStreamOnlineInfo")]
            [Validation(Required=false)]
            public List<DescribeLiveStreamsOnlineListResponseBodyOnlineInfoLiveStreamOnlineInfo> LiveStreamOnlineInfo { get; set; }
            public class DescribeLiveStreamsOnlineListResponseBodyOnlineInfoLiveStreamOnlineInfo : TeaModel {
                /// <summary>
                /// <para>The name of the application to which the live stream belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>liveApp****</para>
                /// </summary>
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                /// <summary>
                /// <para>The ID of the audio codec.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("AudioCodecId")]
                [Validation(Required=false)]
                public int? AudioCodecId { get; set; }

                /// <summary>
                /// <para>The audio bitrate of the live stream. Unit: Kbit/s.</para>
                /// <remarks>
                /// <para> This parameter can be returned after you submit a ticket for whitelist configuration. For more information about how to submit a ticket, see Contact us.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>600</para>
                /// </summary>
                [NameInMap("AudioDataRate")]
                [Validation(Required=false)]
                public int? AudioDataRate { get; set; }

                /// <summary>
                /// <para>The IP address of the client for stream ingest.</para>
                /// 
                /// <b>Example:</b>
                /// <para>106.11.XX.XX</para>
                /// </summary>
                [NameInMap("ClientIp")]
                [Validation(Required=false)]
                public string ClientIp { get; set; }

                /// <summary>
                /// <para>The main streaming domain.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example.com</para>
                /// </summary>
                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                /// <summary>
                /// <para>The frame rate. Unit: FPS.</para>
                /// 
                /// <b>Example:</b>
                /// <para>15</para>
                /// </summary>
                [NameInMap("FrameRate")]
                [Validation(Required=false)]
                public int? FrameRate { get; set; }

                /// <summary>
                /// <para>The height of the video resolution. Unit: pixels.</para>
                /// 
                /// <b>Example:</b>
                /// <para>720</para>
                /// </summary>
                [NameInMap("Height")]
                [Validation(Required=false)]
                public int? Height { get; set; }

                /// <summary>
                /// <para>The ingest domain. If live center ingest was used, the streaming domain is returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>demo.aliyundoc.com</para>
                /// </summary>
                [NameInMap("PublishDomain")]
                [Validation(Required=false)]
                public string PublishDomain { get; set; }

                /// <summary>
                /// <para>The start time of stream ingest. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-08-09T02:37:59Z</para>
                /// </summary>
                [NameInMap("PublishTime")]
                [Validation(Required=false)]
                public string PublishTime { get; set; }

                /// <summary>
                /// <para>The ingest type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>edge</b>: edge ingest.</description></item>
                /// <item><description><b>center</b>: live center ingest.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>edge</para>
                /// </summary>
                [NameInMap("PublishType")]
                [Validation(Required=false)]
                public string PublishType { get; set; }

                /// <summary>
                /// <para>The complete URL that was used to ingest the stream.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rtmp://demo.aliyundoc.com/live/test****</para>
                /// </summary>
                [NameInMap("PublishUrl")]
                [Validation(Required=false)]
                public string PublishUrl { get; set; }

                /// <summary>
                /// <para>The IP address of the ingest node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>120.221.XX.XX</para>
                /// </summary>
                [NameInMap("ServerIp")]
                [Validation(Required=false)]
                public string ServerIp { get; set; }

                /// <summary>
                /// <para>The name of the live stream.</para>
                /// 
                /// <b>Example:</b>
                /// <para>liveStream****</para>
                /// </summary>
                [NameInMap("StreamName")]
                [Validation(Required=false)]
                public string StreamName { get; set; }

                /// <summary>
                /// <para>Indicates whether the stream was transcoded. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>yes</b></description></item>
                /// <item><description><b>no</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>no</para>
                /// </summary>
                [NameInMap("Transcoded")]
                [Validation(Required=false)]
                public string Transcoded { get; set; }

                /// <summary>
                /// <para>The ID of the video codec.</para>
                /// 
                /// <b>Example:</b>
                /// <para>7</para>
                /// </summary>
                [NameInMap("VideoCodecId")]
                [Validation(Required=false)]
                public int? VideoCodecId { get; set; }

                /// <summary>
                /// <para>The video bitrate of the live stream. Unit: Kbit/s.</para>
                /// <remarks>
                /// <para> This parameter can be returned after you submit a ticket for whitelist configuration. For more information about how to submit a ticket, see Contact us.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>600</para>
                /// </summary>
                [NameInMap("VideoDataRate")]
                [Validation(Required=false)]
                public int? VideoDataRate { get; set; }

                /// <summary>
                /// <para>The width of the video resolution. Unit: pixels.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1280</para>
                /// </summary>
                [NameInMap("Width")]
                [Validation(Required=false)]
                public int? Width { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5c6a2a0df228-4a64- af62-20e91b9676b3</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of streams that meet the specified conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>11</para>
        /// </summary>
        [NameInMap("TotalNum")]
        [Validation(Required=false)]
        public int? TotalNum { get; set; }

        /// <summary>
        /// <para>The total number of pages returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalPage")]
        [Validation(Required=false)]
        public int? TotalPage { get; set; }

    }

}
