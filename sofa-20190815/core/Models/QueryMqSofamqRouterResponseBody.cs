// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryMqSofamqRouterResponseBody : TeaModel {
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
        public List<QueryMqSofamqRouterResponseBodyData> Data { get; set; }
        public class QueryMqSofamqRouterResponseBodyData : TeaModel {
            [NameInMap("ConsumerId")]
            [Validation(Required=false)]
            public string ConsumerId { get; set; }

            [NameInMap("ConsumeFromType")]
            [Validation(Required=false)]
            public long? ConsumeFromType { get; set; }

            [NameInMap("ConsumeFromValue")]
            [Validation(Required=false)]
            public long? ConsumeFromValue { get; set; }

            [NameInMap("ConsumeToType")]
            [Validation(Required=false)]
            public long? ConsumeToType { get; set; }

            [NameInMap("ConsumeToValue")]
            [Validation(Required=false)]
            public long? ConsumeToValue { get; set; }

            [NameInMap("DelayTime")]
            [Validation(Required=false)]
            public string DelayTime { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("DestinationCell")]
            [Validation(Required=false)]
            public string DestinationCell { get; set; }

            [NameInMap("DestinationInstanceId")]
            [Validation(Required=false)]
            public string DestinationInstanceId { get; set; }

            [NameInMap("DestinationTopic")]
            [Validation(Required=false)]
            public string DestinationTopic { get; set; }

            [NameInMap("Disaster")]
            [Validation(Required=false)]
            public bool? Disaster { get; set; }

            [NameInMap("DisasterRecoveryDatacenter")]
            [Validation(Required=false)]
            public string DisasterRecoveryDatacenter { get; set; }

            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("SourceCell")]
            [Validation(Required=false)]
            public string SourceCell { get; set; }

            [NameInMap("SourceInstanceId")]
            [Validation(Required=false)]
            public string SourceInstanceId { get; set; }

            [NameInMap("SourceTopic")]
            [Validation(Required=false)]
            public string SourceTopic { get; set; }

            [NameInMap("Tag")]
            [Validation(Required=false)]
            public string Tag { get; set; }

            [NameInMap("TaskStatus")]
            [Validation(Required=false)]
            public long? TaskStatus { get; set; }

            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public long? TaskType { get; set; }

        }

    }

}
