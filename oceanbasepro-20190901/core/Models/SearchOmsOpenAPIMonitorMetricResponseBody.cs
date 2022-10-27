// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class SearchOmsOpenAPIMonitorMetricResponseBody : TeaModel {
        [NameInMap("Advice")]
        [Validation(Required=false)]
        public string Advice { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Cost")]
        [Validation(Required=false)]
        public string Cost { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<SearchOmsOpenAPIMonitorMetricResponseBodyData> Data { get; set; }
        public class SearchOmsOpenAPIMonitorMetricResponseBodyData : TeaModel {
            [NameInMap("DataPoints")]
            [Validation(Required=false)]
            public List<SearchOmsOpenAPIMonitorMetricResponseBodyDataDataPoints> DataPoints { get; set; }
            public class SearchOmsOpenAPIMonitorMetricResponseBodyDataDataPoints : TeaModel {
                [NameInMap("Timestamp")]
                [Validation(Required=false)]
                public long? Timestamp { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public double? Value { get; set; }

            }

            [NameInMap("Metric")]
            [Validation(Required=false)]
            public string Metric { get; set; }

            [NameInMap("Tags")]
            [Validation(Required=false)]
            public Dictionary<string, string> Tags { get; set; }

        }

        [NameInMap("ErrorDetail")]
        [Validation(Required=false)]
        public SearchOmsOpenAPIMonitorMetricResponseBodyErrorDetail ErrorDetail { get; set; }
        public class SearchOmsOpenAPIMonitorMetricResponseBodyErrorDetail : TeaModel {
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            [NameInMap("Level")]
            [Validation(Required=false)]
            public string Level { get; set; }

            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            [NameInMap("Proposal")]
            [Validation(Required=false)]
            public string Proposal { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
