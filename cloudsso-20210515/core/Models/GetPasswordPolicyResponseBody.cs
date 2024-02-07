// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class GetPasswordPolicyResponseBody : TeaModel {
        [NameInMap("PasswordPolicy")]
        [Validation(Required=false)]
        public GetPasswordPolicyResponseBodyPasswordPolicy PasswordPolicy { get; set; }
        public class GetPasswordPolicyResponseBodyPasswordPolicy : TeaModel {
            [NameInMap("HardExpire")]
            [Validation(Required=false)]
            public bool? HardExpire { get; set; }

            [NameInMap("MaxLoginAttempts")]
            [Validation(Required=false)]
            public int? MaxLoginAttempts { get; set; }

            [NameInMap("MaxPasswordAge")]
            [Validation(Required=false)]
            public int? MaxPasswordAge { get; set; }

            [NameInMap("MaxPasswordLength")]
            [Validation(Required=false)]
            public int? MaxPasswordLength { get; set; }

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

            [NameInMap("RequireLowerCaseChars")]
            [Validation(Required=false)]
            public bool? RequireLowerCaseChars { get; set; }

            [NameInMap("RequireNumbers")]
            [Validation(Required=false)]
            public bool? RequireNumbers { get; set; }

            [NameInMap("RequireSymbols")]
            [Validation(Required=false)]
            public bool? RequireSymbols { get; set; }

            [NameInMap("RequireUpperCaseChars")]
            [Validation(Required=false)]
            public bool? RequireUpperCaseChars { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
