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
                public DescribeVodAIDataResponseBodyAIDataAIDataItemData Data { get; set; }
                public class DescribeVodAIDataResponseBodyAIDataAIDataItemData : TeaModel {
                    [NameInMap("DataItem")]
                    [Validation(Required=false)]
                    public List<DescribeVodAIDataResponseBodyAIDataAIDataItemDataDataItem> DataItem { get; set; }
                    public class DescribeVodAIDataResponseBodyAIDataAIDataItemDataDataItem : TeaModel {
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                    }

                }
                public string TimeStamp { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("DataInterval")]
        [Validation(Required=false)]
        public string DataInterval { get; set; }

    }

}
