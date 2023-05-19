// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class ModifyDatabaseUserRolesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The name of the database.
        /// </summary>
        [NameInMap("TenantUser")]
        [Validation(Required=false)]
        public ModifyDatabaseUserRolesResponseBodyTenantUser TenantUser { get; set; }
        public class ModifyDatabaseUserRolesResponseBodyTenantUser : TeaModel {
            /// <summary>
            /// Example 1
            /// </summary>
            [NameInMap("DatabaseName")]
            [Validation(Required=false)]
            public string DatabaseName { get; set; }

            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

            [NameInMap("Users")]
            [Validation(Required=false)]
            public List<ModifyDatabaseUserRolesResponseBodyTenantUserUsers> Users { get; set; }
            public class ModifyDatabaseUserRolesResponseBodyTenantUserUsers : TeaModel {
                [NameInMap("Role")]
                [Validation(Required=false)]
                public string Role { get; set; }

                [NameInMap("UserName")]
                [Validation(Required=false)]
                public string UserName { get; set; }

            }

        }

    }

}
