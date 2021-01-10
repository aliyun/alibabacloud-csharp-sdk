// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class GetDWSSubsTaskMetricsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetDWSSubsTaskMetricsResponseBodyData Data { get; set; }
        public class GetDWSSubsTaskMetricsResponseBodyData : TeaModel {
            [NameInMap("Consumer")]
            [Validation(Required=false)]
            public string Consumer { get; set; }
            [NameInMap("Group")]
            [Validation(Required=false)]
            public string Group { get; set; }
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("TableId")]
            [Validation(Required=false)]
            public string TableId { get; set; }
            [NameInMap("Metric")]
            [Validation(Required=false)]
            public GetDWSSubsTaskMetricsResponseBodyDataMetric Metric { get; set; }
            public class GetDWSSubsTaskMetricsResponseBodyDataMetric : TeaModel {
                [NameInMap("ConsumptionLatency")]
                [Validation(Required=false)]
                public long? ConsumptionLatency { get; set; }

                [NameInMap("ConsumptionRps")]
                [Validation(Required=false)]
                public long? ConsumptionRps { get; set; }

                [NameInMap("DailyConsumedRecords")]
                [Validation(Required=false)]
                public long? DailyConsumedRecords { get; set; }

                [NameInMap("SampleTime")]
                [Validation(Required=false)]
                public string SampleTime { get; set; }

                [NameInMap("SlowestPartition")]
                [Validation(Required=false)]
                public string SlowestPartition { get; set; }

            }
        };

    }

}
