// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sts20150401.Models
{
    public class AssumeRoleWithOIDCRequest : TeaModel {
        /// <summary>
        /// <para>The validity period of the STS token. Unit: seconds.</para>
        /// <para>Default value: 3600. Minimum value: 900. Maximum value: the value of the <c>MaxSessionDuration</c> parameter.</para>
        /// <para>For more information about how to specify <c>MaxSessionDuration</c>, see <a href="https://help.aliyun.com/document_detail/28710.html">CreateRole</a> or <a href="https://help.aliyun.com/document_detail/28712.html">UpdateRole</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3600</para>
        /// </summary>
        [NameInMap("DurationSeconds")]
        [Validation(Required=false)]
        public long? DurationSeconds { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud Resource Name (ARN) of the OIDC IdP.</para>
        /// <para>You can view the ARN in the RAM console or by calling operations.</para>
        /// <list type="bullet">
        /// <item><description>For more information about how to view the ARN in the RAM console, see <a href="https://help.aliyun.com/document_detail/327123.html">View the information about an OIDC IdP</a>.</description></item>
        /// <item><description>For more information about how to view the ARN by calling operations, see <a href="https://help.aliyun.com/document_detail/327126.html">GetOIDCProvider</a> or <a href="https://help.aliyun.com/document_detail/327127.html">ListOIDCProviders</a>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ram::113511544585****:oidc-provider/TestOidcIdp</para>
        /// </summary>
        [NameInMap("OIDCProviderArn")]
        [Validation(Required=false)]
        public string OIDCProviderArn { get; set; }

        /// <summary>
        /// <para>The OIDC token that is issued by the external IdP.</para>
        /// <para>The OIDC token must be 4 to 20,000 characters in length.</para>
        /// <remarks>
        /// <para>You must enter the original OIDC token. You do not need to enter the Base64-encoded OIDC token.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>eyJraWQiOiJKQzl3eHpyaHFKMGd0****</para>
        /// </summary>
        [NameInMap("OIDCToken")]
        [Validation(Required=false)]
        public string OIDCToken { get; set; }

        /// <summary>
        /// <para>The policy that specifies the permissions of the returned STS token. You can use this parameter to grant the STS token fewer permissions than the permissions granted to the RAM role.</para>
        /// <list type="bullet">
        /// <item><description>If you specify this parameter, the permissions of the returned STS token are the permissions that are included in the value of this parameter and owned by the RAM role.</description></item>
        /// <item><description>If you do not specify this parameter, the returned STS token has all the permissions of the RAM role.</description></item>
        /// </list>
        /// <para>The value must be 1 to 2,048 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Statement&quot;: [{&quot;Action&quot;: [&quot;<em>&quot;],&quot;Effect&quot;: &quot;Allow&quot;,&quot;Resource&quot;: [&quot;</em>&quot;]}],&quot;Version&quot;:&quot;1&quot;}</para>
        /// </summary>
        [NameInMap("Policy")]
        [Validation(Required=false)]
        public string Policy { get; set; }

        /// <summary>
        /// <para>The ARN of the RAM role.</para>
        /// <para>You can view the ARN in the RAM console or by calling operations.</para>
        /// <list type="bullet">
        /// <item><description>For more information about how to view the ARN in the RAM console, see <a href="https://help.aliyun.com/document_detail/39744.html">How do I view the ARN of the RAM role?</a></description></item>
        /// <item><description>For more information about how to view the ARN by calling operations, see <a href="https://help.aliyun.com/document_detail/28713.html">ListRoles</a> or <a href="https://help.aliyun.com/document_detail/28711.html">GetRole</a>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ram::113511544585****:role/testoidc</para>
        /// </summary>
        [NameInMap("RoleArn")]
        [Validation(Required=false)]
        public string RoleArn { get; set; }

        /// <summary>
        /// <para>The custom name of the role session.</para>
        /// <para>Set this parameter based on your business requirements. In most cases, this parameter is set to the identity of the user who calls the operation, for example, the username. In ActionTrail logs, you can distinguish the users who assume the same RAM role to perform operations based on the value of the RoleSessionName parameter. This way, you can perform user-specific auditing.</para>
        /// <para>The value can contain letters, digits, periods (.), at signs (@), hyphens (-), and underscores (_).</para>
        /// <para>The value must be 2 to 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TestOidcAssumedRoleSession</para>
        /// </summary>
        [NameInMap("RoleSessionName")]
        [Validation(Required=false)]
        public string RoleSessionName { get; set; }

    }

}
