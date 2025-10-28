// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class DeleteRoleRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the RAM role.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>99999999</para>
        /// </summary>
        [NameInMap("RoleId")]
        [Validation(Required=false)]
        public int? RoleId { get; set; }

    }

}
