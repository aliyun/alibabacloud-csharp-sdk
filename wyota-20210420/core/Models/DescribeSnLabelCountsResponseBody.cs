// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Wyota20210420.Models
{
    public class DescribeSnLabelCountsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeSnLabelCountsResponseBodyData Data { get; set; }
        public class DescribeSnLabelCountsResponseBodyData : TeaModel {
            [NameInMap("LabelCountDTOList")]
            [Validation(Required=false)]
            public List<DescribeSnLabelCountsResponseBodyDataLabelCountDTOList> LabelCountDTOList { get; set; }
            public class DescribeSnLabelCountsResponseBodyDataLabelCountDTOList : TeaModel {
                [NameInMap("Count")]
                [Validation(Required=false)]
                public string Count { get; set; }

                [NameInMap("Label")]
                [Validation(Required=false)]
                public string Label { get; set; }

            }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
