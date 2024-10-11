// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribeVodTranscodeDataResponseBody : TeaModel {
        /// <summary>
        /// <para>The interval at which the data was queried. Valid values:</para>
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

        /// <summary>
        /// <para>The transcoding statistics returned.</para>
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
                /// <para>The statistics on transcoding of different specifications.</para>
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
                        /// <para>The transcoding specification. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>Audio</b>: audio transcoding</description></item>
                        /// <item><description><b>Segmentation</b>: container format conversion</description></item>
                        /// <item><description><b>H264.LD, H264.SD, H264.HD, H264.2K, H264.4K, and more</b></description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>H264.SD</para>
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        /// <summary>
                        /// <para>The transcoding duration. Unit: seconds.</para>
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
                /// <para>The timestamp of the returned data. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-02-01T16:00:00Z</para>
                /// </summary>
                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

            }

        }

    }

}
