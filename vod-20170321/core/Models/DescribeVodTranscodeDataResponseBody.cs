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

        [NameInMap("TranscodeData")]
        [Validation(Required=false)]
        public DescribeVodTranscodeDataResponseBodyTranscodeData TranscodeData { get; set; }
        public class DescribeVodTranscodeDataResponseBodyTranscodeData : TeaModel {
            [NameInMap("TranscodeDataItem")]
            [Validation(Required=false)]
            public List<DescribeVodTranscodeDataResponseBodyTranscodeDataTranscodeDataItem> TranscodeDataItem { get; set; }
            public class DescribeVodTranscodeDataResponseBodyTranscodeDataTranscodeDataItem : TeaModel {
                [NameInMap("Data")]
                [Validation(Required=false)]
                public DescribeVodTranscodeDataResponseBodyTranscodeDataTranscodeDataItemData Data { get; set; }
                public class DescribeVodTranscodeDataResponseBodyTranscodeDataTranscodeDataItemData : TeaModel {
                    [NameInMap("DataItem")]
                    [Validation(Required=false)]
                    public List<DescribeVodTranscodeDataResponseBodyTranscodeDataTranscodeDataItemDataDataItem> DataItem { get; set; }
                    public class DescribeVodTranscodeDataResponseBodyTranscodeDataTranscodeDataItemDataDataItem : TeaModel {
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

            }

        }

    }

}
