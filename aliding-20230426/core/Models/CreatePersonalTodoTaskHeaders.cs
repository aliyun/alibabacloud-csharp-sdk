// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class CreatePersonalTodoTaskHeaders : TeaModel {
        [NameInMap("commonHeaders")]
        [Validation(Required=false)]
        public Dictionary<string, string> CommonHeaders { get; set; }

        [NameInMap("AccountContext")]
        [Validation(Required=false)]
        public CreatePersonalTodoTaskHeadersAccountContext AccountContext { get; set; }
        public class CreatePersonalTodoTaskHeadersAccountContext : TeaModel {
            [NameInMap("userToken")]
            [Validation(Required=false)]
            public string UserToken { get; set; }

        }

    }

}
