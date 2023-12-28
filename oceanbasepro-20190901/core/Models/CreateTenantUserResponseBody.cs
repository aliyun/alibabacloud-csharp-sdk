// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class CreateTenantUserResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The list of database accounts in the tenant.
        /// </summary>
        [NameInMap("TenantUser")]
        [Validation(Required=false)]
        public CreateTenantUserResponseBodyTenantUser TenantUser { get; set; }
        public class CreateTenantUserResponseBodyTenantUser : TeaModel {
            [NameInMap("Roles")]
            [Validation(Required=false)]
            public List<CreateTenantUserResponseBodyTenantUserRoles> Roles { get; set; }
            public class CreateTenantUserResponseBodyTenantUserRoles : TeaModel {
                [NameInMap("Database")]
                [Validation(Required=false)]
                public string Database { get; set; }

                [NameInMap("Role")]
                [Validation(Required=false)]
                public string Role { get; set; }

            }

            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

            [NameInMap("UserStatus")]
            [Validation(Required=false)]
            public string UserStatus { get; set; }

            [NameInMap("UserType")]
            [Validation(Required=false)]
            public string UserType { get; set; }

        }

    }

}
