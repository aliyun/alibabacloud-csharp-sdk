// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class DescribeDSTTimeSeriesMetricsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Results")]
        [Validation(Required=false)]
        public List<DescribeDSTTimeSeriesMetricsResponseBodyResults> Results { get; set; }
        public class DescribeDSTTimeSeriesMetricsResponseBodyResults : TeaModel {
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            [NameInMap("Values")]
            [Validation(Required=false)]
            public List<DescribeDSTTimeSeriesMetricsResponseBodyResultsValues> Values { get; set; }
            public class DescribeDSTTimeSeriesMetricsResponseBodyResultsValues : TeaModel {
                [NameInMap("Value")]
                [Validation(Required=false)]
                public List<DescribeDSTTimeSeriesMetricsResponseBodyResultsValuesValue> Value { get; set; }
                public class DescribeDSTTimeSeriesMetricsResponseBodyResultsValuesValue : TeaModel {
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                [NameInMap("Timestamp")]
                [Validation(Required=false)]
                public long? Timestamp { get; set; }

            }

            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<DescribeDSTTimeSeriesMetricsResponseBodyResultsTags> Tags { get; set; }
            public class DescribeDSTTimeSeriesMetricsResponseBodyResultsTags : TeaModel {
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

    }

}
