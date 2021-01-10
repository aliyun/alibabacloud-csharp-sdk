// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class ListMqSofamqRouterResponseBody : TeaModel {
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
        public ListMqSofamqRouterResponseBodyData Data { get; set; }
        public class ListMqSofamqRouterResponseBodyData : TeaModel {
            [NameInMap("PageNum")]
            [Validation(Required=false)]
            public long? PageNum { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }
            [NameInMap("Content")]
            [Validation(Required=false)]
            public List<ListMqSofamqRouterResponseBodyDataContent> Content { get; set; }
            public class ListMqSofamqRouterResponseBodyDataContent : TeaModel {
                public string ConsumerId { get; set; }
                public long? ConsumeFromType { get; set; }
                public long? ConsumeFromValue { get; set; }
                public long? ConsumeToType { get; set; }
                public long? ConsumeToValue { get; set; }
                public string DelayTime { get; set; }
                public string Description { get; set; }
                public string DestinationCell { get; set; }
                public string DestinationInstanceId { get; set; }
                public string DestinationTopic { get; set; }
                public bool? Disaster { get; set; }
                public string DisasterRecoveryDatacenter { get; set; }
                public string GmtCreate { get; set; }
                public string GmtModified { get; set; }
                public long? Id { get; set; }
                public string SourceCell { get; set; }
                public string SourceInstanceId { get; set; }
                public string SourceTopic { get; set; }
                public string Tag { get; set; }
                public long? TaskStatus { get; set; }
                public long? TaskType { get; set; }
            }
        };

    }

}
