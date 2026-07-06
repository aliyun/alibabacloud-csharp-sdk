// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class SignOutOrgAccountRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>企业安全合规要求，执行账号强制登出</para>
        /// </summary>
        [NameInMap("Reason")]
        [Validation(Required=false)]
        public string Reason { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;zh_CN&quot;:&quot;管理员已执行登出&quot;,&quot;en_US&quot;:&quot;Signed out by admin&quot;}</para>
        /// </summary>
        [NameInMap("ReasonI18nForEmployee")]
        [Validation(Required=false)]
        public Dictionary<string, string> ReasonI18nForEmployee { get; set; }

        [NameInMap("TenantContext")]
        [Validation(Required=false)]
        public SignOutOrgAccountRequestTenantContext TenantContext { get; set; }
        public class SignOutOrgAccountRequestTenantContext : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>xxxxxx</para>
            /// </summary>
            [NameInMap("tenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

        }

    }

}
