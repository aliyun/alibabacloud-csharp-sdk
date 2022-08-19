// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam_developerapi20220225.Models
{
    public class CreateUserRequest : TeaModel {
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("displayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        [NameInMap("email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        [NameInMap("emailVerified")]
        [Validation(Required=false)]
        public bool? EmailVerified { get; set; }

        [NameInMap("password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        [NameInMap("phoneNumber")]
        [Validation(Required=false)]
        public string PhoneNumber { get; set; }

        [NameInMap("phoneNumberVerified")]
        [Validation(Required=false)]
        public bool? PhoneNumberVerified { get; set; }

        [NameInMap("phoneRegion")]
        [Validation(Required=false)]
        public string PhoneRegion { get; set; }

        [NameInMap("primaryOrganizationalUnitId")]
        [Validation(Required=false)]
        public string PrimaryOrganizationalUnitId { get; set; }

        [NameInMap("userExternalId")]
        [Validation(Required=false)]
        public string UserExternalId { get; set; }

        [NameInMap("username")]
        [Validation(Required=false)]
        public string Username { get; set; }

    }

}
