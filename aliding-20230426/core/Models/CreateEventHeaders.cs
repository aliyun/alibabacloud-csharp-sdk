// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class CreateEventHeaders : TeaModel {
        [NameInMap("commonHeaders")]
        [Validation(Required=false)]
        public Dictionary<string, string> CommonHeaders { get; set; }

        [NameInMap("AccountContext")]
        [Validation(Required=false)]
        public CreateEventHeadersAccountContext AccountContext { get; set; }
        public class CreateEventHeadersAccountContext : TeaModel {
            [NameInMap("accountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

        }

    }

}
