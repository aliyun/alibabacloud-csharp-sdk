// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryLinkefabricFabricAllmsgappliesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("ResponseStatusCode")]
        [Validation(Required=false)]
        public long? ResponseStatusCode { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryLinkefabricFabricAllmsgappliesResponseBodyData Data { get; set; }
        public class QueryLinkefabricFabricAllmsgappliesResponseBodyData : TeaModel {
            [NameInMap("FinishedMsgApplies")]
            [Validation(Required=false)]
            public List<string> FinishedMsgApplies { get; set; }
            [NameInMap("HandledMsgApplies")]
            [Validation(Required=false)]
            public List<string> HandledMsgApplies { get; set; }
            [NameInMap("UnHandledMsgApplies")]
            [Validation(Required=false)]
            public List<string> UnHandledMsgApplies { get; set; }
        };

    }

}
