// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class ModifyTenantUserStatusResponseBody : TeaModel {
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
        public List<ModifyTenantUserStatusResponseBodyTenantUser> TenantUser { get; set; }
        public class ModifyTenantUserStatusResponseBodyTenantUser : TeaModel {
            /// <summary>
            /// The ID of the tenant.
            /// </summary>
            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

            /// <summary>
            /// The name of the account.
            /// </summary>
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

            /// <summary>
            /// The status of the database account. Valid values:   
            /// - LOCKED: The account is locked. 
            /// - ONLINE: The account is unlocked.
            /// </summary>
            [NameInMap("UserStatus")]
            [Validation(Required=false)]
            public string UserStatus { get; set; }

        }

    }

}
