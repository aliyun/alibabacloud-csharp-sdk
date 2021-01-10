// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class ListMqSofamqRouterconfigResponseBody : TeaModel {
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
        public ListMqSofamqRouterconfigResponseBodyData Data { get; set; }
        public class ListMqSofamqRouterconfigResponseBodyData : TeaModel {
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
            public List<ListMqSofamqRouterconfigResponseBodyDataContent> Content { get; set; }
            public class ListMqSofamqRouterconfigResponseBodyDataContent : TeaModel {
                public string ConsumerId { get; set; }
                public string ConsumeFromType { get; set; }
                public string ConsumeFromValue { get; set; }
                public string ConsumeToType { get; set; }
                public string ConsumeToValue { get; set; }
                public string Description { get; set; }
                public string DestinationCell { get; set; }
                public string DestinationNamespaceId { get; set; }
                public string DestinationTopic { get; set; }
                public string Disaster { get; set; }
                public string GmtCreate { get; set; }
                public string GmtModified { get; set; }
                public long? Id { get; set; }
                public string SourceCell { get; set; }
                public string SourceNamespaceId { get; set; }
                public string SourceTopic { get; set; }
                public string Tag { get; set; }
                public string TaskStatus { get; set; }
            }
        };

    }

}
