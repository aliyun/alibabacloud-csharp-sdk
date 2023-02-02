// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class ModifyTenantUserStatusRequest : TeaModel {
        /// <summary>
        /// The ID of the OceanBase cluster.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The ID of the tenant.
        /// </summary>
        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        /// <summary>
        /// The name of the database account.    
        /// You cannot use reserved keywords, such as SYS and root.
        /// </summary>
        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

        /// <summary>
        /// The status of the database account. Valid values:   
        /// - Locked: The account is locked. 
        /// - Online: The account is unlocked.
        /// </summary>
        [NameInMap("UserStatus")]
        [Validation(Required=false)]
        public string UserStatus { get; set; }

    }

}
