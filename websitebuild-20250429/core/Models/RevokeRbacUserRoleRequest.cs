// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class RevokeRbacUserRoleRequest : TeaModel {
        /// <summary>
        /// <para>The business ID of the application instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WS20250731233102000001</para>
        /// </summary>
        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        /// <summary>
        /// <para>The user role information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///         &quot;org_id&quot;: &quot;f0534aa7-94ec-4368-a34a-310390f66253&quot;,
        ///         &quot;role_id&quot;: &quot;804a6b2a-82ac-49f2-960a-a6c2ed9e73dd&quot;,
        ///         &quot;user_id&quot;: &quot;c1721c87-5401-40b3-b836-9b2653507feb&quot;
        ///       }</para>
        /// </summary>
        [NameInMap("UserRoleData")]
        [Validation(Required=false)]
        public string UserRoleData { get; set; }

    }

}
