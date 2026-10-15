// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class CreateRbacRoleRequest : TeaModel {
        /// <summary>
        /// <para>The business ID of the customer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WS20250731233102000001</para>
        /// </summary>
        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        /// <summary>
        /// <para>The role data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;name&quot;:&quot;customer&quot;,&quot;label&quot;:&quot;xx
        /// &quot;,&quot;is_default&quot;:true,&quot;is_system&quot;:false}</para>
        /// </summary>
        [NameInMap("RoleData")]
        [Validation(Required=false)]
        public string RoleData { get; set; }

    }

}
