// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class CreateCustomRoleRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123abc</para>
        /// </summary>
        [NameInMap("role_id")]
        [Validation(Required=false)]
        public string RoleId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("role_name")]
        [Validation(Required=false)]
        public string RoleName { get; set; }

    }

}
