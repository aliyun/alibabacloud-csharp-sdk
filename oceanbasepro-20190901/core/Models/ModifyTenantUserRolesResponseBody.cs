// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class ModifyTenantUserRolesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The ID of the tenant.
        /// </summary>
        [NameInMap("TenantUser")]
        [Validation(Required=false)]
        public ModifyTenantUserRolesResponseBodyTenantUser TenantUser { get; set; }
        public class ModifyTenantUserRolesResponseBodyTenantUser : TeaModel {
            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

            /// <summary>
            /// The name of the database (MySQL mode) or schema (Oracle mode).
            /// </summary>
            [NameInMap("UserRole")]
            [Validation(Required=false)]
            public List<ModifyTenantUserRolesResponseBodyTenantUserUserRole> UserRole { get; set; }
            public class ModifyTenantUserRolesResponseBodyTenantUserUserRole : TeaModel {
                /// <summary>
                /// ```
                /// http(s)://[Endpoint]/?Action=ModifyTenantUserRoles
                /// &UserName=pay_test
                /// &TenantId=ob2mr3oae0****
                /// &UserRole=[{"Database":"20210824160559","Role":"readwrite"}]
                /// &InstanceId=ob317v4uif****
                /// &ModifyType=update
                /// &Common request parameters
                /// ```
                /// </summary>
                [NameInMap("Database")]
                [Validation(Required=false)]
                public string Database { get; set; }

                [NameInMap("IsSuccess")]
                [Validation(Required=false)]
                public bool? IsSuccess { get; set; }

                /// <summary>
                /// You can call this operation to modify the database privileges of a specified account in a tenant.
                /// </summary>
                [NameInMap("Role")]
                [Validation(Required=false)]
                public string Role { get; set; }

                [NameInMap("Table")]
                [Validation(Required=false)]
                public string Table { get; set; }

            }

        }

    }

}
