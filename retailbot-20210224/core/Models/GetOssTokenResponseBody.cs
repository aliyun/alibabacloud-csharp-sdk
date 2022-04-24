// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RetailBot20210224.Models
{
    public class GetOssTokenResponseBody : TeaModel {
        [NameInMap("WebUpoadPolicy")]
        [Validation(Required=false)]
        public GetOssTokenResponseBodyWebUpoadPolicy WebUpoadPolicy { get; set; }
        public class GetOssTokenResponseBodyWebUpoadPolicy : TeaModel {
            [NameInMap("AccessId")]
            [Validation(Required=false)]
            public string AccessId { get; set; }
            [NameInMap("Dir")]
            [Validation(Required=false)]
            public string Dir { get; set; }
            [NameInMap("Expire")]
            [Validation(Required=false)]
            public string Expire { get; set; }
            [NameInMap("Host")]
            [Validation(Required=false)]
            public string Host { get; set; }
            [NameInMap("Policy")]
            [Validation(Required=false)]
            public string Policy { get; set; }
            [NameInMap("Signature")]
            [Validation(Required=false)]
            public string Signature { get; set; }
        };

    }

}
