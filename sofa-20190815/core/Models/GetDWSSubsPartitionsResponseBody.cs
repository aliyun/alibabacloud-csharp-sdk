// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class GetDWSSubsPartitionsResponseBody : TeaModel {
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
        public GetDWSSubsPartitionsResponseBodyData Data { get; set; }
        public class GetDWSSubsPartitionsResponseBodyData : TeaModel {
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
            [NameInMap("Partition")]
            [Validation(Required=false)]
            public long? Partition { get; set; }
            [NameInMap("TableId")]
            [Validation(Required=false)]
            public string TableId { get; set; }
            [NameInMap("Metrics")]
            [Validation(Required=false)]
            public List<GetDWSSubsPartitionsResponseBodyDataMetrics> Metrics { get; set; }
            public class GetDWSSubsPartitionsResponseBodyDataMetrics : TeaModel {
                public string ClientAckTime { get; set; }
                public long? ClientAssignedQueueSize { get; set; }
                public string ClientIp { get; set; }
                public long? ClientLastNotifiedSize { get; set; }
                public long? ClientRealQueueSize { get; set; }
                public long? ConsumptionLatency { get; set; }
                public long? ConsumptionRps { get; set; }
                public long? DailyConsumedRecords { get; set; }
                public string Partition { get; set; }
                public string SampleTime { get; set; }
                public long? StoreLatency { get; set; }
                public string StoreName { get; set; }
                public string StoreSendTime { get; set; }
            }
        };

    }

}
