// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class ModifyTenantUserStatusRequest : TeaModel {
        /// <summary>
        /// The operation that you want to perform.   
        /// Set the value to **ModifyTenantUserStatus**.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The ID of the tenant.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        /// <summary>
        /// The list of database accounts in the tenant.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

        /// <summary>
        /// The status of the database account. Valid values:   
        /// - Locked: The account is locked. 
        /// - Online: The account is unlocked.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("UserStatus")]
        [Validation(Required=false)]
        public string UserStatus { get; set; }

    }

}
