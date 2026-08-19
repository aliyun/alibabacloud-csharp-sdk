// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribeVodAIDataResponseBody : TeaModel {
        [NameInMap("AIData")]
        [Validation(Required=false)]
        public DescribeVodAIDataResponseBodyAIData AIData { get; set; }
        public class DescribeVodAIDataResponseBodyAIData : TeaModel {
            [NameInMap("AIDataItem")]
            [Validation(Required=false)]
            public List<DescribeVodAIDataResponseBodyAIDataAIDataItem> AIDataItem { get; set; }
            public class DescribeVodAIDataResponseBodyAIDataAIDataItem : TeaModel {
                [NameInMap("Data")]
                [Validation(Required=false)]
                public DescribeVodAIDataResponseBodyAIDataAIDataItemData Data { get; set; }
                public class DescribeVodAIDataResponseBodyAIDataAIDataItemData : TeaModel {
                    [NameInMap("DataItem")]
                    [Validation(Required=false)]
                    public List<DescribeVodAIDataResponseBodyAIDataAIDataItemDataDataItem> DataItem { get; set; }
                    public class DescribeVodAIDataResponseBodyAIDataAIDataItemDataDataItem : TeaModel {
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

        /// <summary>
        /// <para>The time granularity of the returned data. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>hour</b>: hourly data.</description></item>
        /// <item><description><b>day</b>: daily data.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>day</para>
        /// </summary>
        [NameInMap("DataInterval")]
        [Validation(Required=false)]
        public string DataInterval { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C370DAF1-C838-4288-****-9A87633D248E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
