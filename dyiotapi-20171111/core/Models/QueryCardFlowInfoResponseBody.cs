// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyiotapi20171111.Models
{
    public class QueryCardFlowInfoResponseBody : TeaModel {
        [NameInMap("CardFlowInfos")]
        [Validation(Required=false)]
        public QueryCardFlowInfoResponseBodyCardFlowInfos CardFlowInfos { get; set; }
        public class QueryCardFlowInfoResponseBodyCardFlowInfos : TeaModel {
            [NameInMap("CardFlowInfo")]
            [Validation(Required=false)]
            public List<QueryCardFlowInfoResponseBodyCardFlowInfosCardFlowInfo> CardFlowInfo { get; set; }
            public class QueryCardFlowInfoResponseBodyCardFlowInfosCardFlowInfo : TeaModel {
                public string ValidDate { get; set; }
                public long? VoiceUsed { get; set; }
                public string ResourceType { get; set; }
                public long? FlowUsed { get; set; }
                public long? VoiceTotal { get; set; }
                public string ExpireDate { get; set; }
                public long? SmsUsed { get; set; }
                public long? RestOfFlow { get; set; }
                public long? FlowResource { get; set; }
                public string ResName { get; set; }
            }
        };

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

    }

}
