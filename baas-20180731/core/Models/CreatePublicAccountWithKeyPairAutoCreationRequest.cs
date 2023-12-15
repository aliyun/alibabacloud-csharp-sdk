// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Baas20180731.Models
{
    public class CreatePublicAccountWithKeyPairAutoCreationRequest : TeaModel {
        [NameInMap("Account")]
        [Validation(Required=false)]
        public string Account { get; set; }

        [NameInMap("Bizid")]
        [Validation(Required=false)]
        public string Bizid { get; set; }

        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        [NameInMap("RecoverPassword")]
        [Validation(Required=false)]
        public string RecoverPassword { get; set; }

    }

}
