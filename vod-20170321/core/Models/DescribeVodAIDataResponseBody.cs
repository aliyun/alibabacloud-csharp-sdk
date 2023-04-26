// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribeVodAIDataResponseBody : TeaModel {
        /// <summary>
        /// The statistics on video AI.
        /// </summary>
        [NameInMap("AIData")]
        [Validation(Required=false)]
        public DescribeVodAIDataResponseBodyAIData AIData { get; set; }
        public class DescribeVodAIDataResponseBodyAIData : TeaModel {
            [NameInMap("AIDataItem")]
            [Validation(Required=false)]
            public List<DescribeVodAIDataResponseBodyAIDataAIDataItem> AIDataItem { get; set; }
            public class DescribeVodAIDataResponseBodyAIDataAIDataItem : TeaModel {
                /// <summary>
                /// The statistics on video AI of each type.
                /// </summary>
                [NameInMap("Data")]
                [Validation(Required=false)]
                public DescribeVodAIDataResponseBodyAIDataAIDataItemData Data { get; set; }
                public class DescribeVodAIDataResponseBodyAIDataAIDataItemData : TeaModel {
                    [NameInMap("DataItem")]
                    [Validation(Required=false)]
                    public List<DescribeVodAIDataResponseBodyAIDataAIDataItemDataDataItem> DataItem { get; set; }
                    public class DescribeVodAIDataResponseBodyAIDataAIDataItemDataDataItem : TeaModel {
                        /// <summary>
                        /// The type of video AI. Valid values:
                        /// 
                        /// *   **AIVideoCensor**: automated review
                        /// *   **AIVideoFPShot**: media fingerprinting
                        /// *   **AIVideoTag**: smart tagging
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        /// <summary>
                        /// The processing duration. Unit: seconds.
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                /// <summary>
                /// The timestamp of the returned data. The time follows the ISO 8601 standard in the `yyyy-MM-ddTHH:mm:ssZ` format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

            }

        }

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

    }

}
