// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryLinkedeploycoreDeploycoreOrderqueryorderidactionsResponseBody : TeaModel {
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
        public QueryLinkedeploycoreDeploycoreOrderqueryorderidactionsResponseBodyData Data { get; set; }
        public class QueryLinkedeploycoreDeploycoreOrderqueryorderidactionsResponseBodyData : TeaModel {
            [NameInMap("EnvType")]
            [Validation(Required=false)]
            public string EnvType { get; set; }
            [NameInMap("Actions")]
            [Validation(Required=false)]
            public List<string> Actions { get; set; }
        };

    }

}
