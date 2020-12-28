// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtrace20190808.Models
{
    public class GetTokenResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Token")]
        [Validation(Required=false)]
        public GetTokenResponseBodyToken Token { get; set; }
        public class GetTokenResponseBodyToken : TeaModel {
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }
            [NameInMap("LicenseKey")]
            [Validation(Required=false)]
            public string LicenseKey { get; set; }
            [NameInMap("InternalDomain")]
            [Validation(Required=false)]
            public string InternalDomain { get; set; }
            [NameInMap("Pid")]
            [Validation(Required=false)]
            public string Pid { get; set; }
        };

    }

}
