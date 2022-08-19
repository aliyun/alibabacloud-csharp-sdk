// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam_developerapi20220225.Models
{
    public class PatchUserRequest : TeaModel {
        [NameInMap("displayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        [NameInMap("email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        [NameInMap("emailVerified")]
        [Validation(Required=false)]
        public bool? EmailVerified { get; set; }

        [NameInMap("phoneNumber")]
        [Validation(Required=false)]
        public string PhoneNumber { get; set; }

        [NameInMap("phoneNumberVerified")]
        [Validation(Required=false)]
        public bool? PhoneNumberVerified { get; set; }

        [NameInMap("phoneRegion")]
        [Validation(Required=false)]
        public string PhoneRegion { get; set; }

        [NameInMap("username")]
        [Validation(Required=false)]
        public string Username { get; set; }

    }

}
