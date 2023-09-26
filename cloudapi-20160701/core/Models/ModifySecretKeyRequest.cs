// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160701.Models
{
    public class ModifySecretKeyRequest : TeaModel {
        [NameInMap("SecretKey")]
        [Validation(Required=false)]
        public string SecretKey { get; set; }

        [NameInMap("SecretKeyId")]
        [Validation(Required=false)]
        public string SecretKeyId { get; set; }

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
