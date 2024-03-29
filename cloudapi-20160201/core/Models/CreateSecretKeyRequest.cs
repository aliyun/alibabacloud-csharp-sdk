// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160201.Models
{
    public class CreateSecretKeyRequest : TeaModel {
        [NameInMap("SecretKey")]
        [Validation(Required=false)]
        public string SecretKey { get; set; }

        [NameInMap("SecretKeyName")]
        [Validation(Required=false)]
        public string SecretKeyName { get; set; }

        [NameInMap("SecretValue")]
        [Validation(Required=false)]
        public string SecretValue { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

    }

}
