// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class SetPasswordPolicyRequest : TeaModel {
        [NameInMap("DirectoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

        [NameInMap("MaxLoginAttempts")]
        [Validation(Required=false)]
        public int? MaxLoginAttempts { get; set; }

        [NameInMap("MaxPasswordAge")]
        [Validation(Required=false)]
        public int? MaxPasswordAge { get; set; }

        [NameInMap("MinPasswordDifferentChars")]
        [Validation(Required=false)]
        public int? MinPasswordDifferentChars { get; set; }

        [NameInMap("MinPasswordLength")]
        [Validation(Required=false)]
        public int? MinPasswordLength { get; set; }

        [NameInMap("PasswordNotContainUsername")]
        [Validation(Required=false)]
        public bool? PasswordNotContainUsername { get; set; }

        [NameInMap("PasswordReusePrevention")]
        [Validation(Required=false)]
        public int? PasswordReusePrevention { get; set; }

    }

}
