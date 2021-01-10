// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryCasLoadbalanceSecurityipResponseBody : TeaModel {
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
        public QueryCasLoadbalanceSecurityipResponseBodyData Data { get; set; }
        public class QueryCasLoadbalanceSecurityipResponseBodyData : TeaModel {
            [NameInMap("AccessControl")]
            [Validation(Required=false)]
            public bool? AccessControl { get; set; }
            [NameInMap("Ips")]
            [Validation(Required=false)]
            public List<string> Ips { get; set; }
        };

    }

}
