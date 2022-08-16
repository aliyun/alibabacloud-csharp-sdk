// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class SimpleQueryResponseBody : TeaModel {
        [NameInMap("Aggregations")]
        [Validation(Required=false)]
        public List<SimpleQueryResponseBodyAggregations> Aggregations { get; set; }
        public class SimpleQueryResponseBodyAggregations : TeaModel {
            [NameInMap("Field")]
            [Validation(Required=false)]
            public string Field { get; set; }

            [NameInMap("Groups")]
            [Validation(Required=false)]
            public List<SimpleQueryResponseBodyAggregationsGroups> Groups { get; set; }
            public class SimpleQueryResponseBodyAggregationsGroups : TeaModel {
                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            [NameInMap("Operation")]
            [Validation(Required=false)]
            public string Operation { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public double? Value { get; set; }

        }

        [NameInMap("Files")]
        [Validation(Required=false)]
        public List<File> Files { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
