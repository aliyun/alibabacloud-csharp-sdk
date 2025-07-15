// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveUpVideoAudioInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The end of the time range to query. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BC858082-736F-4A25-867B-E5B67C85ACF7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// </summary>
        [NameInMap("UpItems")]
        [Validation(Required=false)]
        public DescribeLiveUpVideoAudioInfoResponseBodyUpItems UpItems { get; set; }
        public class DescribeLiveUpVideoAudioInfoResponseBodyUpItems : TeaModel {
            [NameInMap("PublishItem")]
            [Validation(Required=false)]
            public List<DescribeLiveUpVideoAudioInfoResponseBodyUpItemsPublishItem> PublishItem { get; set; }
            public class DescribeLiveUpVideoAudioInfoResponseBodyUpItemsPublishItem : TeaModel {
                /// <summary>
                /// <para>The details about the audio and video data of the stream ingest occurrences.</para>
                /// </summary>
                [NameInMap("AacHeaders")]
                [Validation(Required=false)]
                public DescribeLiveUpVideoAudioInfoResponseBodyUpItemsPublishItemAacHeaders AacHeaders { get; set; }
                public class DescribeLiveUpVideoAudioInfoResponseBodyUpItemsPublishItemAacHeaders : TeaModel {
                    [NameInMap("AacHeaders")]
                    [Validation(Required=false)]
                    public List<DescribeLiveUpVideoAudioInfoResponseBodyUpItemsPublishItemAacHeadersAacHeaders> AacHeaders { get; set; }
                    public class DescribeLiveUpVideoAudioInfoResponseBodyUpItemsPublishItemAacHeadersAacHeaders : TeaModel {
                        /// <summary>
                        /// <para>The number of AAC headers in the audio.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1538134750408</para>
                        /// </summary>
                        [NameInMap("Time")]
                        [Validation(Required=false)]
                        public long? Time { get; set; }

                        /// <summary>
                        /// <para>The query time. The value is a UNIX timestamp in milliseconds.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>20</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public int? Value { get; set; }

                    }

                }

                /// <summary>
                /// <para>The metric value at a granularity of seconds at the query time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>AppName</para>
                /// </summary>
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                /// <summary>
                /// <para>The name of the application to which the ingested stream belongs.</para>
                /// </summary>
                [NameInMap("AudioBitRate")]
                [Validation(Required=false)]
                public DescribeLiveUpVideoAudioInfoResponseBodyUpItemsPublishItemAudioBitRate AudioBitRate { get; set; }
                public class DescribeLiveUpVideoAudioInfoResponseBodyUpItemsPublishItemAudioBitRate : TeaModel {
                    [NameInMap("AudioBitRate")]
                    [Validation(Required=false)]
                    public List<DescribeLiveUpVideoAudioInfoResponseBodyUpItemsPublishItemAudioBitRateAudioBitRate> AudioBitRate { get; set; }
                    public class DescribeLiveUpVideoAudioInfoResponseBodyUpItemsPublishItemAudioBitRateAudioBitRate : TeaModel {
                        /// <summary>
                        /// <para>The bitrate of the audio. Unit: bit/s.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1538134750408</para>
                        /// </summary>
                        [NameInMap("Time")]
                        [Validation(Required=false)]
                        public long? Time { get; set; }

                        /// <summary>
                        /// <para>The query time. The value is a UNIX timestamp in milliseconds.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>24552</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public int? Value { get; set; }

                    }

                }

                /// <summary>
                /// <para>The metric value at a granularity of seconds at the query time.</para>
                /// </summary>
                [NameInMap("AudioFrames")]
                [Validation(Required=false)]
                public DescribeLiveUpVideoAudioInfoResponseBodyUpItemsPublishItemAudioFrames AudioFrames { get; set; }
                public class DescribeLiveUpVideoAudioInfoResponseBodyUpItemsPublishItemAudioFrames : TeaModel {
                    [NameInMap("AudioFrames")]
                    [Validation(Required=false)]
                    public List<DescribeLiveUpVideoAudioInfoResponseBodyUpItemsPublishItemAudioFramesAudioFrames> AudioFrames { get; set; }
                    public class DescribeLiveUpVideoAudioInfoResponseBodyUpItemsPublishItemAudioFramesAudioFrames : TeaModel {
                        /// <summary>
                        /// <para>The frame rate of the audio. Unit: frames.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1538134750408</para>
                        /// </summary>
                        [NameInMap("Time")]
                        [Validation(Required=false)]
                        public long? Time { get; set; }

                        /// <summary>
                        /// <para>The query time. The value is a UNIX timestamp in milliseconds.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>23</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public int? Value { get; set; }

                    }

                }

                /// <summary>
                /// <para>The metric value at a granularity of seconds at the query time.</para>
                /// </summary>
                [NameInMap("AudioInterval")]
                [Validation(Required=false)]
                public DescribeLiveUpVideoAudioInfoResponseBodyUpItemsPublishItemAudioInterval AudioInterval { get; set; }
                public class DescribeLiveUpVideoAudioInfoResponseBodyUpItemsPublishItemAudioInterval : TeaModel {
                    [NameInMap("AudioInterval")]
                    [Validation(Required=false)]
                    public List<DescribeLiveUpVideoAudioInfoResponseBodyUpItemsPublishItemAudioIntervalAudioInterval> AudioInterval { get; set; }
                    public class DescribeLiveUpVideoAudioInfoResponseBodyUpItemsPublishItemAudioIntervalAudioInterval : TeaModel {
                        /// <summary>
                        /// <para>The maximum audio frame interval. Unit: milliseconds.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1538134750408</para>
                        /// </summary>
                        [NameInMap("Time")]
                        [Validation(Required=false)]
                        public long? Time { get; set; }

                        /// <summary>
                        /// <para>The query time. The value is a UNIX timestamp in milliseconds.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>254</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public int? Value { get; set; }

                    }

                }

                /// <summary>
                /// <para>The metric value at a granularity of seconds at the query time.</para>
                /// </summary>
                [NameInMap("AudioStamps")]
                [Validation(Required=false)]
                public DescribeLiveUpVideoAudioInfoResponseBodyUpItemsPublishItemAudioStamps AudioStamps { get; set; }
                public class DescribeLiveUpVideoAudioInfoResponseBodyUpItemsPublishItemAudioStamps : TeaModel {
                    [NameInMap("AudioStamps")]
                    [Validation(Required=false)]
                    public List<DescribeLiveUpVideoAudioInfoResponseBodyUpItemsPublishItemAudioStampsAudioStamps> AudioStamps { get; set; }
                    public class DescribeLiveUpVideoAudioInfoResponseBodyUpItemsPublishItemAudioStampsAudioStamps : TeaModel {
                        /// <summary>
                        /// <para>The audio timestamp. Unit: milliseconds.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1538134750408</para>
                        /// </summary>
                        [NameInMap("Time")]
                        [Validation(Required=false)]
                        public long? Time { get; set; }

                        /// <summary>
                        /// <para>The query time. The value is a UNIX timestamp in milliseconds.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>725053422</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public int? Value { get; set; }

                    }

                }

                /// <summary>
                /// <para>The metric value at a granularity of seconds at the query time.</para>
                /// </summary>
                [NameInMap("AvcHeaders")]
                [Validation(Required=false)]
                public DescribeLiveUpVideoAudioInfoResponseBodyUpItemsPublishItemAvcHeaders AvcHeaders { get; set; }
                public class DescribeLiveUpVideoAudioInfoResponseBodyUpItemsPublishItemAvcHeaders : TeaModel {
                    [NameInMap("AvcHeaders")]
                    [Validation(Required=false)]
                    public List<DescribeLiveUpVideoAudioInfoResponseBodyUpItemsPublishItemAvcHeadersAvcHeaders> AvcHeaders { get; set; }
                    public class DescribeLiveUpVideoAudioInfoResponseBodyUpItemsPublishItemAvcHeadersAvcHeaders : TeaModel {
                        /// <summary>
                        /// <para>The number of AVC headers in the audio.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1538134750408</para>
                        /// </summary>
                        [NameInMap("Time")]
                        [Validation(Required=false)]
                        public long? Time { get; set; }

                        /// <summary>
                        /// <para>The query time. The value is a UNIX timestamp in milliseconds.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>11</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public int? Value { get; set; }

                    }

                }

                /// <summary>
                /// <para>The metric value at a granularity of seconds at the query time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>H264/AAC</para>
                /// </summary>
                [NameInMap("CodecInfo")]
                [Validation(Required=false)]
                public string CodecInfo { get; set; }

                /// <summary>
                /// <para>The audio and video encoding information.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example.com</para>
                /// </summary>
                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                /// <summary>
                /// <para>The ingest domain.</para>
                /// </summary>
                [NameInMap("ErrorFlags")]
                [Validation(Required=false)]
                public DescribeLiveUpVideoAudioInfoResponseBodyUpItemsPublishItemErrorFlags ErrorFlags { get; set; }
                public class DescribeLiveUpVideoAudioInfoResponseBodyUpItemsPublishItemErrorFlags : TeaModel {
                    [NameInMap("ErrorFlags")]
                    [Validation(Required=false)]
                    public List<DescribeLiveUpVideoAudioInfoResponseBodyUpItemsPublishItemErrorFlagsErrorFlags> ErrorFlags { get; set; }
                    public class DescribeLiveUpVideoAudioInfoResponseBodyUpItemsPublishItemErrorFlagsErrorFlags : TeaModel {
                        /// <summary>
                        /// <para>The number of times the error code that indicates interrupted stream ingest was returned.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1538134750408</para>
                        /// </summary>
                        [NameInMap("Time")]
                        [Validation(Required=false)]
                        public long? Time { get; set; }

                        /// <summary>
                        /// <para>The query time. The value is a UNIX timestamp in milliseconds.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public int? Value { get; set; }

                    }

                }

                /// <summary>
                /// <para>The metric value at a granularity of seconds at the query time.</para>
                /// 
                /// <b>Example:</b>
                /// <list type="bullet">
                /// <item><description></description></item>
                /// </list>
                /// </summary>
                [NameInMap("PublishInterval")]
                [Validation(Required=false)]
                public string PublishInterval { get; set; }

                /// <summary>
                /// <para>The stream ingest duration. Unit: seconds. A hyphen (-) indicates that the stream is being ingested and the duration cannot be returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn397</para>
                /// </summary>
                [NameInMap("PublishIp")]
                [Validation(Required=false)]
                public string PublishIp { get; set; }

                /// <summary>
                /// <para>The IP address of the stream ingest client.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("PublishStatus")]
                [Validation(Required=false)]
                public string PublishStatus { get; set; }

                /// <summary>
                /// <para>The stream ingest status. A value of 1 indicates that the stream is being ingested. A value of 0 indicates that the stream was ingested.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2015-12-10T15:00:00Z</para>
                /// </summary>
                [NameInMap("PublishTime")]
                [Validation(Required=false)]
                public string PublishTime { get; set; }

                /// <summary>
                /// <para>The start time of stream ingest. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2015-12-10T15:10:00Z</para>
                /// </summary>
                [NameInMap("StopTime")]
                [Validation(Required=false)]
                public string StopTime { get; set; }

                /// <summary>
                /// <para>The end time of stream ingest. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>StreamName</para>
                /// </summary>
                [NameInMap("StreamName")]
                [Validation(Required=false)]
                public string StreamName { get; set; }

                /// <summary>
                /// <para>The name of the stream.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2.-395_37261_9848098_1538080899396</para>
                /// </summary>
                [NameInMap("UniqueId")]
                [Validation(Required=false)]
                public string UniqueId { get; set; }

                /// <summary>
                /// <para>The unique ID of each stream ingest occurrence.</para>
                /// </summary>
                [NameInMap("VideoAndAudioStamp")]
                [Validation(Required=false)]
                public DescribeLiveUpVideoAudioInfoResponseBodyUpItemsPublishItemVideoAndAudioStamp VideoAndAudioStamp { get; set; }
                public class DescribeLiveUpVideoAudioInfoResponseBodyUpItemsPublishItemVideoAndAudioStamp : TeaModel {
                    [NameInMap("V_AStamp")]
                    [Validation(Required=false)]
                    public List<DescribeLiveUpVideoAudioInfoResponseBodyUpItemsPublishItemVideoAndAudioStampVAStamp> VAStamp { get; set; }
                    public class DescribeLiveUpVideoAudioInfoResponseBodyUpItemsPublishItemVideoAndAudioStampVAStamp : TeaModel {
                        /// <summary>
                        /// <para>The difference between the audio and video timestamps. Unit: milliseconds.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1538134750408</para>
                        /// </summary>
                        [NameInMap("Time")]
                        [Validation(Required=false)]
                        public long? Time { get; set; }

                        /// <summary>
                        /// <para>The query time. The value is a UNIX timestamp in milliseconds.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>359</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public int? Value { get; set; }

                    }

                }

                /// <summary>
                /// <para>The metric value at a granularity of seconds at the query time.</para>
                /// </summary>
                [NameInMap("VideoBitRate")]
                [Validation(Required=false)]
                public DescribeLiveUpVideoAudioInfoResponseBodyUpItemsPublishItemVideoBitRate VideoBitRate { get; set; }
                public class DescribeLiveUpVideoAudioInfoResponseBodyUpItemsPublishItemVideoBitRate : TeaModel {
                    [NameInMap("VideoBitRate")]
                    [Validation(Required=false)]
                    public List<DescribeLiveUpVideoAudioInfoResponseBodyUpItemsPublishItemVideoBitRateVideoBitRate> VideoBitRate { get; set; }
                    public class DescribeLiveUpVideoAudioInfoResponseBodyUpItemsPublishItemVideoBitRateVideoBitRate : TeaModel {
                        /// <summary>
                        /// <para>The bitrate of the video. Unit: bit/s.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1538134750408</para>
                        /// </summary>
                        [NameInMap("Time")]
                        [Validation(Required=false)]
                        public long? Time { get; set; }

                        /// <summary>
                        /// <para>The query time. The value is a UNIX timestamp in milliseconds.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>3970160</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public int? Value { get; set; }

                    }

                }

                /// <summary>
                /// <para>The metric value at a granularity of seconds at the query time.</para>
                /// </summary>
                [NameInMap("VideoFrames")]
                [Validation(Required=false)]
                public DescribeLiveUpVideoAudioInfoResponseBodyUpItemsPublishItemVideoFrames VideoFrames { get; set; }
                public class DescribeLiveUpVideoAudioInfoResponseBodyUpItemsPublishItemVideoFrames : TeaModel {
                    [NameInMap("VideoFrames")]
                    [Validation(Required=false)]
                    public List<DescribeLiveUpVideoAudioInfoResponseBodyUpItemsPublishItemVideoFramesVideoFrames> VideoFrames { get; set; }
                    public class DescribeLiveUpVideoAudioInfoResponseBodyUpItemsPublishItemVideoFramesVideoFrames : TeaModel {
                        /// <summary>
                        /// <para>The frame rate of the video. Unit: frames.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1538134750408</para>
                        /// </summary>
                        [NameInMap("Time")]
                        [Validation(Required=false)]
                        public long? Time { get; set; }

                        /// <summary>
                        /// <para>The query time. The value is a UNIX timestamp in milliseconds.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>29</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public int? Value { get; set; }

                    }

                }

                /// <summary>
                /// <para>The metric value at a granularity of seconds at the query time.</para>
                /// </summary>
                [NameInMap("VideoInterval")]
                [Validation(Required=false)]
                public DescribeLiveUpVideoAudioInfoResponseBodyUpItemsPublishItemVideoInterval VideoInterval { get; set; }
                public class DescribeLiveUpVideoAudioInfoResponseBodyUpItemsPublishItemVideoInterval : TeaModel {
                    [NameInMap("VideoInterval")]
                    [Validation(Required=false)]
                    public List<DescribeLiveUpVideoAudioInfoResponseBodyUpItemsPublishItemVideoIntervalVideoInterval> VideoInterval { get; set; }
                    public class DescribeLiveUpVideoAudioInfoResponseBodyUpItemsPublishItemVideoIntervalVideoInterval : TeaModel {
                        /// <summary>
                        /// <para>The maximum video frame interval. Unit: milliseconds.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1538134750408</para>
                        /// </summary>
                        [NameInMap("Time")]
                        [Validation(Required=false)]
                        public long? Time { get; set; }

                        /// <summary>
                        /// <para>The query time. The value is a UNIX timestamp in milliseconds.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>278</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public int? Value { get; set; }

                    }

                }

                /// <summary>
                /// <para>The metric value at a granularity of seconds at the query time.</para>
                /// </summary>
                [NameInMap("VideoStamps")]
                [Validation(Required=false)]
                public DescribeLiveUpVideoAudioInfoResponseBodyUpItemsPublishItemVideoStamps VideoStamps { get; set; }
                public class DescribeLiveUpVideoAudioInfoResponseBodyUpItemsPublishItemVideoStamps : TeaModel {
                    [NameInMap("VideoStamps")]
                    [Validation(Required=false)]
                    public List<DescribeLiveUpVideoAudioInfoResponseBodyUpItemsPublishItemVideoStampsVideoStamps> VideoStamps { get; set; }
                    public class DescribeLiveUpVideoAudioInfoResponseBodyUpItemsPublishItemVideoStampsVideoStamps : TeaModel {
                        /// <summary>
                        /// <para>The video timestamp. Unit: milliseconds.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1538134750408</para>
                        /// </summary>
                        [NameInMap("Time")]
                        [Validation(Required=false)]
                        public long? Time { get; set; }

                        /// <summary>
                        /// <para>The query time. The value is a UNIX timestamp in milliseconds.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>725053781</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public int? Value { get; set; }

                    }

                }

            }

        }

    }

}
