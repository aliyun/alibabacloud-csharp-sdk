// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class CreateCustomRoleRequest : TeaModel {
        /// <summary>
        /// <para>The custom role ID.</para>
        /// <list type="bullet">
        /// <item><description>This is the unique identifier of the role. Ensure that the value is unique for each request.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>role_1234</para>
        /// </summary>
        [NameInMap("role_id")]
        [Validation(Required=false)]
        public string RoleId { get; set; }

        /// <summary>
        /// <para>The custom role name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>华东地区日常出差</para>
        /// </summary>
        [NameInMap("role_name")]
        [Validation(Required=false)]
        public string RoleName { get; set; }

    }

}
