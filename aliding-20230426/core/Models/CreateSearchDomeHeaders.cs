// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class CreateSearchDomeHeaders : TeaModel {
        [NameInMap("commonHeaders")]
        [Validation(Required=false)]
        public Dictionary<string, string> CommonHeaders { get; set; }

        [NameInMap("AccountContext")]
        [Validation(Required=false)]
        public CreateSearchDomeHeadersAccountContext AccountContext { get; set; }
        public class CreateSearchDomeHeadersAccountContext : TeaModel {
            [NameInMap("userToken")]
            [Validation(Required=false)]
            public string UserToken { get; set; }

        }

    }

}
