// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class UpdateRbacRoleRequest : TeaModel {
        /// <summary>
        /// <para>The application instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WD20250814102215000001</para>
        /// </summary>
        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        /// <summary>
        /// <para>The role data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;name&quot;:&quot;customer&quot;,&quot;label&quot;:&quot;xx1
        /// &quot;,&quot;is_default&quot;:true,&quot;is_system&quot;:false}</para>
        /// </summary>
        [NameInMap("RoleData")]
        [Validation(Required=false)]
        public string RoleData { get; set; }

        /// <summary>
        /// <para>The role ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>agent@ly-online</para>
        /// </summary>
        [NameInMap("RoleId")]
        [Validation(Required=false)]
        public string RoleId { get; set; }

    }

}
