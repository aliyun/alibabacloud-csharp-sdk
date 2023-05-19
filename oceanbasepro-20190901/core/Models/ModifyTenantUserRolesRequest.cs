// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class ModifyTenantUserRolesRequest : TeaModel {
        /// <summary>
        /// The type of the privilege modification operation.   
        /// Valid values:  
        /// update: updates all privileges. This is the default value.  
        /// add: adds a privilege.  
        /// delete: deletes a privilege.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The name of the table.
        /// </summary>
        [NameInMap("ModifyType")]
        [Validation(Required=false)]
        public string ModifyType { get; set; }

        /// <summary>
        /// The operation that you want to perform.   
        /// Set the value to **ModifyTenantUserRoles**.
        /// </summary>
        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        /// <summary>
        /// The role of the database account.
        /// </summary>
        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

        /// <summary>
        /// The type of the account. Valid values:   
        /// - Admin: the super administrator account.   
        /// - Normal: a general account.
        /// </summary>
        [NameInMap("UserRole")]
        [Validation(Required=false)]
        public string UserRole { get; set; }

    }

}
