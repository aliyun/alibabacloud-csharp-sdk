// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class GetDocContentHeaders : TeaModel {
        [NameInMap("commonHeaders")]
        [Validation(Required=false)]
        public Dictionary<string, string> CommonHeaders { get; set; }

        [NameInMap("AccountContext")]
        [Validation(Required=false)]
        public GetDocContentHeadersAccountContext AccountContext { get; set; }
        public class GetDocContentHeadersAccountContext : TeaModel {
            [NameInMap("userToken")]
            [Validation(Required=false)]
            public string UserToken { get; set; }

        }

    }

}
