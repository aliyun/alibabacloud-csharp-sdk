// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribeVodTranscodeDataResponseBody : TeaModel {
        /// <summary>
        /// The time granularity at which the data was queried. Valid values:
        /// 
        /// *   **hour**
        /// *   **day**
        /// </summary>
        [NameInMap("DataInterval")]
        [Validation(Required=false)]
        public string DataInterval { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The statistics on transcoding.
        /// </summary>
        [NameInMap("TranscodeData")]
        [Validation(Required=false)]
        public DescribeVodTranscodeDataResponseBodyTranscodeData TranscodeData { get; set; }
        public class DescribeVodTranscodeDataResponseBodyTranscodeData : TeaModel {
            [NameInMap("TranscodeDataItem")]
            [Validation(Required=false)]
            public List<DescribeVodTranscodeDataResponseBodyTranscodeDataTranscodeDataItem> TranscodeDataItem { get; set; }
            public class DescribeVodTranscodeDataResponseBodyTranscodeDataTranscodeDataItem : TeaModel {
                /// <summary>
                /// The statistics on transcoding of different specifications.
                /// </summary>
                [NameInMap("Data")]
                [Validation(Required=false)]
                public DescribeVodTranscodeDataResponseBodyTranscodeDataTranscodeDataItemData Data { get; set; }
                public class DescribeVodTranscodeDataResponseBodyTranscodeDataTranscodeDataItemData : TeaModel {
                    [NameInMap("DataItem")]
                    [Validation(Required=false)]
                    public List<DescribeVodTranscodeDataResponseBodyTranscodeDataTranscodeDataItemDataDataItem> DataItem { get; set; }
                    public class DescribeVodTranscodeDataResponseBodyTranscodeDataTranscodeDataItemDataDataItem : TeaModel {
                        /// <summary>
                        /// The transcoding specification. Valid values:
                        /// 
                        /// *   **Audio**: audio transcoding
                        /// *   **Segmentation**: container format conversion
                        /// *   H.264 and H.265-related video transcoding specifications, such as **H264.LD, H264.SD, H264.HD, H264.2K, and H264.4K**
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        /// <summary>
                        /// The transcoding length. Unit: seconds.
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                /// <summary>
                /// The timestamp of the returned data. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

            }

        }

    }

}
