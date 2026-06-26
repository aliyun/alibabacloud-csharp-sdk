// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentIdentity20250901.Models
{
    public class GetLoginPreferenceResponseBody : TeaModel {
        [NameInMap("LoginPreference")]
        [Validation(Required=false)]
        public GetLoginPreferenceResponseBodyLoginPreference LoginPreference { get; set; }
        public class GetLoginPreferenceResponseBodyLoginPreference : TeaModel {
            [NameInMap("EnablePasswordLogin")]
            [Validation(Required=false)]
            public bool? EnablePasswordLogin { get; set; }

        }

        [NameInMap("PasswordPolicy")]
        [Validation(Required=false)]
        public GetLoginPreferenceResponseBodyPasswordPolicy PasswordPolicy { get; set; }
        public class GetLoginPreferenceResponseBodyPasswordPolicy : TeaModel {
            [NameInMap("HardExpire")]
            [Validation(Required=false)]
            public bool? HardExpire { get; set; }

            [NameInMap("MaxLoginAttempts")]
            [Validation(Required=false)]
            public long? MaxLoginAttempts { get; set; }

            [NameInMap("MaxPasswordAge")]
            [Validation(Required=false)]
            public long? MaxPasswordAge { get; set; }

            [NameInMap("MaxPasswordLength")]
            [Validation(Required=false)]
            public int? MaxPasswordLength { get; set; }

            [NameInMap("MinPasswordLength")]
            [Validation(Required=false)]
            public int? MinPasswordLength { get; set; }

            [NameInMap("PasswordNotContainUserName")]
            [Validation(Required=false)]
            public bool? PasswordNotContainUserName { get; set; }

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
