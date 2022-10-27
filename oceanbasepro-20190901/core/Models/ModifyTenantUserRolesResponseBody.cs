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

            [NameInMap("UserRole")]
            [Validation(Required=false)]
            public List<ModifyTenantUserRolesResponseBodyTenantUserUserRole> UserRole { get; set; }
            public class ModifyTenantUserRolesResponseBodyTenantUserUserRole : TeaModel {
                [NameInMap("Database")]
                [Validation(Required=false)]
                public string Database { get; set; }

                [NameInMap("IsSuccess")]
                [Validation(Required=false)]
                public bool? IsSuccess { get; set; }

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
