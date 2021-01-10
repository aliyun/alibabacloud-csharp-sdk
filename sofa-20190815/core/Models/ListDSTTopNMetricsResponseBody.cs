// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class ListDSTTopNMetricsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Results")]
        [Validation(Required=false)]
        public List<ListDSTTopNMetricsResponseBodyResults> Results { get; set; }
        public class ListDSTTopNMetricsResponseBodyResults : TeaModel {
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            [NameInMap("Metric")]
            [Validation(Required=false)]
            public string Metric { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("Values")]
            [Validation(Required=false)]
            public List<ListDSTTopNMetricsResponseBodyResultsValues> Values { get; set; }
            public class ListDSTTopNMetricsResponseBodyResultsValues : TeaModel {
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

                [NameInMap("Tags")]
                [Validation(Required=false)]
                public List<ListDSTTopNMetricsResponseBodyResultsValuesTags> Tags { get; set; }
                public class ListDSTTopNMetricsResponseBodyResultsValuesTags : TeaModel {
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

            }

        }

    }

}
