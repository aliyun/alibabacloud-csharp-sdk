// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class UpdateRoleRequest : TeaModel {
        /// <summary>
        /// The set of permissions to be granted to the role. The value is in the format of `Permission group ID 1:Permission serial number 1;...;Permission group ID n:Permission serial number n`. Example: `1:1;1:2;2:1;2:2`. For more information about permission groups and permission serial numbers, see [ListAuthority](~~149409~~).
        /// </summary>
        [NameInMap("ActionData")]
        [Validation(Required=false)]
        public string ActionData { get; set; }

        /// <summary>
        /// The ID of the role. You can call the ListRole operation to query the role IDs. For more information, see [ListRole](~~149410~~).
        /// </summary>
        [NameInMap("RoleId")]
        [Validation(Required=false)]
        public int? RoleId { get; set; }

    }

}
