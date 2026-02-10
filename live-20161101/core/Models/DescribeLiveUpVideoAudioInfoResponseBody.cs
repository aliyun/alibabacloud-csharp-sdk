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

        [NameInMap("UpItems")]
        [Validation(Required=false)]
        public DescribeLiveUpVideoAudioInfoResponseBodyUpItems UpItems { get; set; }
        public class DescribeLiveUpVideoAudioInfoResponseBodyUpItems : TeaModel {
            [NameInMap("PublishItem")]
            [Validation(Required=false)]
            public List<DescribeLiveUpVideoAudioInfoResponseBodyUpItemsPublishItem> PublishItem { get; set; }
            public class DescribeLiveUpVideoAudioInfoResponseBodyUpItemsPublishItem : TeaModel {
                [NameInMap("AacHeaders")]
                [Validation(Required=false)]
                public DescribeLiveUpVideoAudioInfoResponseBodyUpItemsPublishItemAacHeaders AacHeaders { get; set; }
                public class DescribeLiveUpVideoAudioInfoResponseBodyUpItemsPublishItemAacHeaders : TeaModel {
                    [NameInMap("AacHeaders")]
                    [Validation(Required=false)]
                    public List<DescribeLiveUpVideoAudioInfoResponseBodyUpItemsPublishItemAacHeadersAacHeaders> AacHeaders { get; set; }
                    public class DescribeLiveUpVideoAudioInfoResponseBodyUpItemsPublishItemAacHeadersAacHeaders : TeaModel {
                        [NameInMap("Time")]
                        [Validation(Required=false)]
                        public long? Time { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public int? Value { get; set; }

                    }

                }

                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                [NameInMap("AudioBitRate")]
                [Validation(Required=false)]
                public DescribeLiveUpVideoAudioInfoResponseBodyUpItemsPublishItemAudioBitRate AudioBitRate { get; set; }
                public class DescribeLiveUpVideoAudioInfoResponseBodyUpItemsPublishItemAudioBitRate : TeaModel {
                    [NameInMap("AudioBitRate")]
                    [Validation(Required=false)]
                    public List<DescribeLiveUpVideoAudioInfoResponseBodyUpItemsPublishItemAudioBitRateAudioBitRate> AudioBitRate { get; set; }
                    public class DescribeLiveUpVideoAudioInfoResponseBodyUpItemsPublishItemAudioBitRateAudioBitRate : TeaModel {
                        [NameInMap("Time")]
                        [Validation(Required=false)]
                        public long? Time { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public int? Value { get; set; }

                    }

                }

                [NameInMap("AudioFrames")]
                [Validation(Required=false)]
                public DescribeLiveUpVideoAudioInfoResponseBodyUpItemsPublishItemAudioFrames AudioFrames { get; set; }
                public class DescribeLiveUpVideoAudioInfoResponseBodyUpItemsPublishItemAudioFrames : TeaModel {
                    [NameInMap("AudioFrames")]
                    [Validation(Required=false)]
                    public List<DescribeLiveUpVideoAudioInfoResponseBodyUpItemsPublishItemAudioFramesAudioFrames> AudioFrames { get; set; }
                    public class DescribeLiveUpVideoAudioInfoResponseBodyUpItemsPublishItemAudioFramesAudioFrames : TeaModel {
                        [NameInMap("Time")]
                        [Validation(Required=false)]
                        public long? Time { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public int? Value { get; set; }

                    }

                }

                [NameInMap("AudioInterval")]
                [Validation(Required=false)]
                public DescribeLiveUpVideoAudioInfoResponseBodyUpItemsPublishItemAudioInterval AudioInterval { get; set; }
                public class DescribeLiveUpVideoAudioInfoResponseBodyUpItemsPublishItemAudioInterval : TeaModel {
                    [NameInMap("AudioInterval")]
                    [Validation(Required=false)]
                    public List<DescribeLiveUpVideoAudioInfoResponseBodyUpItemsPublishItemAudioIntervalAudioInterval> AudioInterval { get; set; }
                    public class DescribeLiveUpVideoAudioInfoResponseBodyUpItemsPublishItemAudioIntervalAudioInterval : TeaModel {
                        [NameInMap("Time")]
                        [Validation(Required=false)]
                        public long? Time { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public int? Value { get; set; }

                    }

                }

                [NameInMap("AudioStamps")]
                [Validation(Required=false)]
                public DescribeLiveUpVideoAudioInfoResponseBodyUpItemsPublishItemAudioStamps AudioStamps { get; set; }
                public class DescribeLiveUpVideoAudioInfoResponseBodyUpItemsPublishItemAudioStamps : TeaModel {
                    [NameInMap("AudioStamps")]
                    [Validation(Required=false)]
                    public List<DescribeLiveUpVideoAudioInfoResponseBodyUpItemsPublishItemAudioStampsAudioStamps> AudioStamps { get; set; }
                    public class DescribeLiveUpVideoAudioInfoResponseBodyUpItemsPublishItemAudioStampsAudioStamps : TeaModel {
                        [NameInMap("Time")]
                        [Validation(Required=false)]
                        public long? Time { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public int? Value { get; set; }

                    }

                }

                [NameInMap("AvcHeaders")]
                [Validation(Required=false)]
                public DescribeLiveUpVideoAudioInfoResponseBodyUpItemsPublishItemAvcHeaders AvcHeaders { get; set; }
                public class DescribeLiveUpVideoAudioInfoResponseBodyUpItemsPublishItemAvcHeaders : TeaModel {
                    [NameInMap("AvcHeaders")]
                    [Validation(Required=false)]
                    public List<DescribeLiveUpVideoAudioInfoResponseBodyUpItemsPublishItemAvcHeadersAvcHeaders> AvcHeaders { get; set; }
                    public class DescribeLiveUpVideoAudioInfoResponseBodyUpItemsPublishItemAvcHeadersAvcHeaders : TeaModel {
                        [NameInMap("Time")]
                        [Validation(Required=false)]
                        public long? Time { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public int? Value { get; set; }

                    }

                }

                [NameInMap("CodecInfo")]
                [Validation(Required=false)]
                public string CodecInfo { get; set; }

                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                [NameInMap("ErrorFlags")]
                [Validation(Required=false)]
                public DescribeLiveUpVideoAudioInfoResponseBodyUpItemsPublishItemErrorFlags ErrorFlags { get; set; }
                public class DescribeLiveUpVideoAudioInfoResponseBodyUpItemsPublishItemErrorFlags : TeaModel {
                    [NameInMap("ErrorFlags")]
                    [Validation(Required=false)]
                    public List<DescribeLiveUpVideoAudioInfoResponseBodyUpItemsPublishItemErrorFlagsErrorFlags> ErrorFlags { get; set; }
                    public class DescribeLiveUpVideoAudioInfoResponseBodyUpItemsPublishItemErrorFlagsErrorFlags : TeaModel {
                        [NameInMap("Time")]
                        [Validation(Required=false)]
                        public long? Time { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public int? Value { get; set; }

                    }

                }

                [NameInMap("PublishInterval")]
                [Validation(Required=false)]
                public string PublishInterval { get; set; }

                [NameInMap("PublishIp")]
                [Validation(Required=false)]
                public string PublishIp { get; set; }

                [NameInMap("PublishStatus")]
                [Validation(Required=false)]
                public string PublishStatus { get; set; }

                [NameInMap("PublishTime")]
                [Validation(Required=false)]
                public string PublishTime { get; set; }

                [NameInMap("StopTime")]
                [Validation(Required=false)]
                public string StopTime { get; set; }

                [NameInMap("StreamName")]
                [Validation(Required=false)]
                public string StreamName { get; set; }

                [NameInMap("UniqueId")]
                [Validation(Required=false)]
                public string UniqueId { get; set; }

                [NameInMap("VideoAndAudioStamp")]
                [Validation(Required=false)]
                public DescribeLiveUpVideoAudioInfoResponseBodyUpItemsPublishItemVideoAndAudioStamp VideoAndAudioStamp { get; set; }
                public class DescribeLiveUpVideoAudioInfoResponseBodyUpItemsPublishItemVideoAndAudioStamp : TeaModel {
                    [NameInMap("V_AStamp")]
                    [Validation(Required=false)]
                    public List<DescribeLiveUpVideoAudioInfoResponseBodyUpItemsPublishItemVideoAndAudioStampVAStamp> VAStamp { get; set; }
                    public class DescribeLiveUpVideoAudioInfoResponseBodyUpItemsPublishItemVideoAndAudioStampVAStamp : TeaModel {
                        [NameInMap("Time")]
                        [Validation(Required=false)]
                        public long? Time { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public int? Value { get; set; }

                    }

                }

                [NameInMap("VideoBitRate")]
                [Validation(Required=false)]
                public DescribeLiveUpVideoAudioInfoResponseBodyUpItemsPublishItemVideoBitRate VideoBitRate { get; set; }
                public class DescribeLiveUpVideoAudioInfoResponseBodyUpItemsPublishItemVideoBitRate : TeaModel {
                    [NameInMap("VideoBitRate")]
                    [Validation(Required=false)]
                    public List<DescribeLiveUpVideoAudioInfoResponseBodyUpItemsPublishItemVideoBitRateVideoBitRate> VideoBitRate { get; set; }
                    public class DescribeLiveUpVideoAudioInfoResponseBodyUpItemsPublishItemVideoBitRateVideoBitRate : TeaModel {
                        [NameInMap("Time")]
                        [Validation(Required=false)]
                        public long? Time { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public int? Value { get; set; }

                    }

                }

                [NameInMap("VideoFrames")]
                [Validation(Required=false)]
                public DescribeLiveUpVideoAudioInfoResponseBodyUpItemsPublishItemVideoFrames VideoFrames { get; set; }
                public class DescribeLiveUpVideoAudioInfoResponseBodyUpItemsPublishItemVideoFrames : TeaModel {
                    [NameInMap("VideoFrames")]
                    [Validation(Required=false)]
                    public List<DescribeLiveUpVideoAudioInfoResponseBodyUpItemsPublishItemVideoFramesVideoFrames> VideoFrames { get; set; }
                    public class DescribeLiveUpVideoAudioInfoResponseBodyUpItemsPublishItemVideoFramesVideoFrames : TeaModel {
                        [NameInMap("Time")]
                        [Validation(Required=false)]
                        public long? Time { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public int? Value { get; set; }

                    }

                }

                [NameInMap("VideoInterval")]
                [Validation(Required=false)]
                public DescribeLiveUpVideoAudioInfoResponseBodyUpItemsPublishItemVideoInterval VideoInterval { get; set; }
                public class DescribeLiveUpVideoAudioInfoResponseBodyUpItemsPublishItemVideoInterval : TeaModel {
                    [NameInMap("VideoInterval")]
                    [Validation(Required=false)]
                    public List<DescribeLiveUpVideoAudioInfoResponseBodyUpItemsPublishItemVideoIntervalVideoInterval> VideoInterval { get; set; }
                    public class DescribeLiveUpVideoAudioInfoResponseBodyUpItemsPublishItemVideoIntervalVideoInterval : TeaModel {
                        [NameInMap("Time")]
                        [Validation(Required=false)]
                        public long? Time { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public int? Value { get; set; }

                    }

                }

                [NameInMap("VideoStamps")]
                [Validation(Required=false)]
                public DescribeLiveUpVideoAudioInfoResponseBodyUpItemsPublishItemVideoStamps VideoStamps { get; set; }
                public class DescribeLiveUpVideoAudioInfoResponseBodyUpItemsPublishItemVideoStamps : TeaModel {
                    [NameInMap("VideoStamps")]
                    [Validation(Required=false)]
                    public List<DescribeLiveUpVideoAudioInfoResponseBodyUpItemsPublishItemVideoStampsVideoStamps> VideoStamps { get; set; }
                    public class DescribeLiveUpVideoAudioInfoResponseBodyUpItemsPublishItemVideoStampsVideoStamps : TeaModel {
                        [NameInMap("Time")]
                        [Validation(Required=false)]
                        public long? Time { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public int? Value { get; set; }

                    }

                }

            }

        }

    }

}
