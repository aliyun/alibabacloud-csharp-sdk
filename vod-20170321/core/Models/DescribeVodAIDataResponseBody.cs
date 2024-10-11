// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribeVodAIDataResponseBody : TeaModel {
        /// <summary>
        /// <para>The statistics on video AI.</para>
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
                /// <para>The statistics on video AI of each type.</para>
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
                        /// <para>The type of video AI. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>AIVideoCensor</b>: automated review</description></item>
                        /// <item><description><b>AIVideoFPShot</b>: media fingerprinting</description></item>
                        /// <item><description><b>AIVideoTag</b>: smart tagging</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>AIVideoCensor</para>
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        /// <summary>
                        /// <para>The processing duration. Unit: seconds.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>111</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                /// <summary>
                /// <para>The timestamp of the returned data. The time follows the ISO 8601 standard in the <c>yyyy-MM-ddTHH:mm:ssZ</c> format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-02-01T13:00:00Z</para>
                /// </summary>
                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

            }

        }

        /// <summary>
        /// <para>The time granularity at which the data was queried. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>hour</b></description></item>
        /// <item><description><b>day</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>day</para>
        /// </summary>
        [NameInMap("DataInterval")]
        [Validation(Required=false)]
        public string DataInterval { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C370DAF1-C838-4288-****-9A87633D248E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
