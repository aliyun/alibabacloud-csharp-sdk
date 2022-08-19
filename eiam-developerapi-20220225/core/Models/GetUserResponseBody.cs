// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam_developerapi20220225.Models
{
    public class GetUserResponseBody : TeaModel {
        [NameInMap("accountExpireTime")]
        [Validation(Required=false)]
        public long? AccountExpireTime { get; set; }

        [NameInMap("createTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

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

        [NameInMap("instanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("lockExpireTime")]
        [Validation(Required=false)]
        public long? LockExpireTime { get; set; }

        [NameInMap("organizationalUnits")]
        [Validation(Required=false)]
        public List<GetUserResponseBodyOrganizationalUnits> OrganizationalUnits { get; set; }
        public class GetUserResponseBodyOrganizationalUnits : TeaModel {
            [NameInMap("organizationalUnitId")]
            [Validation(Required=false)]
            public string OrganizationalUnitId { get; set; }

            [NameInMap("organizationalUnitName")]
            [Validation(Required=false)]
            public string OrganizationalUnitName { get; set; }

            [NameInMap("primary")]
            [Validation(Required=false)]
            public bool? Primary { get; set; }

        }

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

        [NameInMap("registerTime")]
        [Validation(Required=false)]
        public long? RegisterTime { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("updateTime")]
        [Validation(Required=false)]
        public long? UpdateTime { get; set; }

        [NameInMap("userExternalId")]
        [Validation(Required=false)]
        public string UserExternalId { get; set; }

        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        [NameInMap("userSourceId")]
        [Validation(Required=false)]
        public string UserSourceId { get; set; }

        [NameInMap("userSourceType")]
        [Validation(Required=false)]
        public string UserSourceType { get; set; }

        [NameInMap("username")]
        [Validation(Required=false)]
        public string Username { get; set; }

    }

}
