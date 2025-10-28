// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class UpdateRoleRequest : TeaModel {
        /// <summary>
        /// <para>The set of permissions to be granted to the role. The value is in the format of <c>Permission group ID 1:Permission serial number 1;...;Permission group ID n:Permission serial number n</c>. Example: <c>1:1;1:2;2:1;2:2</c>. For more information about permission groups and permission serial numbers, see <a href="https://help.aliyun.com/document_detail/149409.html">ListAuthority</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15:1</para>
        /// </summary>
        [NameInMap("ActionData")]
        [Validation(Required=false)]
        public string ActionData { get; set; }

        /// <summary>
        /// <para>The ID of the role. You can call the ListRole operation to query the role IDs. For more information, see <a href="https://help.aliyun.com/document_detail/149410.html">ListRole</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>32371</para>
        /// </summary>
        [NameInMap("RoleId")]
        [Validation(Required=false)]
        public int? RoleId { get; set; }

    }

}
