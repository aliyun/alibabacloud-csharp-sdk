// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class AppAccessStrategy : TeaModel {
        /// <summary>
        /// <para>The global access policy of the application. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>allow: The domain allows access from all applications.</description></item>
        /// <item><description>deny: The domain denies access from all apps. This is the default value.</description></item>
        /// </list>
        /// <para>Recommended settings:</para>
        /// <ol>
        /// <item><description>Set effect to deny.</description></item>
        /// <item><description>Specify except_app_id_list to allow specific applications to access the domain. Example: [&quot;appid1&quot;, &quot;appid2&quot;].</description></item>
        /// </ol>
        /// 
        /// <b>Example:</b>
        /// <para>deny</para>
        /// </summary>
        [NameInMap("effect")]
        [Validation(Required=false)]
        public string Effect { get; set; }

        /// <summary>
        /// <para>The IDs of applications excluded from the global access policy.</para>
        /// <list type="bullet">
        /// <item><description>If you set effect to allow, which indicates that the domain allows access from all applications, the applications specified by this parameter value cannot access the domain.</description></item>
        /// <item><description>If you set effect to deny, which indicates that the domain denies access from all applications, the applications specified by this parameter value can access the domain.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("except_app_id_list")]
        [Validation(Required=false)]
        public List<string> ExceptAppIdList { get; set; }

    }

}
