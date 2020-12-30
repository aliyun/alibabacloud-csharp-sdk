// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyplsapi20170525.Models
{
    public class BindAxgResponseBody : TeaModel {
        [NameInMap("SecretBindDTO")]
        [Validation(Required=false)]
        public BindAxgResponseBodySecretBindDTO SecretBindDTO { get; set; }
        public class BindAxgResponseBodySecretBindDTO : TeaModel {
            [NameInMap("Extension")]
            [Validation(Required=false)]
            public string Extension { get; set; }
            [NameInMap("SubsId")]
            [Validation(Required=false)]
            public string SubsId { get; set; }
            [NameInMap("SecretNo")]
            [Validation(Required=false)]
            public string SecretNo { get; set; }
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
