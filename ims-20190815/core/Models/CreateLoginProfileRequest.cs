// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class CreateLoginProfileRequest : TeaModel {
        [NameInMap("UserPrincipalName")]
        [Validation(Required=false)]
        public string UserPrincipalName { get; set; }

        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        [NameInMap("PasswordResetRequired")]
        [Validation(Required=false)]
        public bool? PasswordResetRequired { get; set; }

        [NameInMap("MFABindRequired")]
        [Validation(Required=false)]
        public bool? MFABindRequired { get; set; }

        [NameInMap("GenerateRandomPassword")]
        [Validation(Required=false)]
        public bool? GenerateRandomPassword { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("AkProxySuffix")]
        [Validation(Required=false)]
        public string AkProxySuffix { get; set; }

    }

}
