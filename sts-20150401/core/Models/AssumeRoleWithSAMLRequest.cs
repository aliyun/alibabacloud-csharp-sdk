// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sts20150401.Models
{
    public class AssumeRoleWithSAMLRequest : TeaModel {
        /// <summary>
        /// <para>The validity period of the STS token. Unit: seconds.</para>
        /// <para>Minimum value: 900. Maximum value: the value of the <c>MaxSessionDuration</c> parameter. Default value: 3600.</para>
        /// <para>You can call the CreateRole or UpdateRole operation to configure the <c>MaxSessionDuration</c> parameter. For more information, see <a href="https://help.aliyun.com/document_detail/28710.html">CreateRole</a> or <a href="https://help.aliyun.com/document_detail/28712.html">UpdateRole</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3600</para>
        /// </summary>
        [NameInMap("DurationSeconds")]
        [Validation(Required=false)]
        public long? DurationSeconds { get; set; }

        /// <summary>
        /// <para>The policy that specifies the permissions of the returned STS token. You can use this parameter to grant the STS token fewer permissions than the permissions granted to the RAM role.</para>
        /// <list type="bullet">
        /// <item><description>If you specify this parameter, the permissions of the returned STS token are the permissions that are included in the value of this parameter and owned by the RAM role.</description></item>
        /// <item><description>If you do not specify this parameter, the returned STS token has all the permissions of the RAM role.</description></item>
        /// </list>
        /// <para>The value must be 1 to 2,048 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>url_encoded_policy</para>
        /// </summary>
        [NameInMap("Policy")]
        [Validation(Required=false)]
        public string Policy { get; set; }

        /// <summary>
        /// <para>The ARN of the RAM role.</para>
        /// <para>The trust entity of the RAM role is a SAML IdP. For more information, see <a href="https://help.aliyun.com/document_detail/116805.html">Create a RAM role for a trusted IdP</a> or <a href="https://help.aliyun.com/document_detail/28710.html">CreateRole</a>.</para>
        /// <para>Format: <c>acs:ram::&lt;account_id&gt;:role/&lt;role_name&gt;</c>.</para>
        /// <para>You can view the ARN in the RAM console or by calling operations.</para>
        /// <list type="bullet">
        /// <item><description>For more information about how to view the ARN in the RAM console, see <a href="https://help.aliyun.com/document_detail/39744.html">How do I view the ARN of the RAM role?</a>.</description></item>
        /// <item><description>For more information about how to view the ARN by calling operations, see <a href="https://help.aliyun.com/document_detail/28713.html">ListRoles</a> or <a href="https://help.aliyun.com/document_detail/28711.html">GetRole</a>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ram::123456789012****:role/adminrole</para>
        /// </summary>
        [NameInMap("RoleArn")]
        [Validation(Required=false)]
        public string RoleArn { get; set; }

        /// <summary>
        /// <para>The Base64-encoded SAML assertion.</para>
        /// <para>The value must be 4 to 100,000 characters in length.</para>
        /// <remarks>
        /// <para>A complete SAML response rather than a single SAMLAssertion field must be retrieved from the external IdP.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>base64_encoded_saml_assertion</para>
        /// </summary>
        [NameInMap("SAMLAssertion")]
        [Validation(Required=false)]
        public string SAMLAssertion { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud Resource Name (ARN) of the SAML IdP that is created in the RAM console.</para>
        /// <para>Format: <c>acs:ram::&lt;account_id&gt;:saml-provider/&lt;saml_provider_id&gt;</c>.</para>
        /// <para>You can view the ARN in the RAM console or by calling operations.</para>
        /// <list type="bullet">
        /// <item><description>For more information about how to view the ARN in the RAM console, see <a href="https://help.aliyun.com/document_detail/116795.html">How do I view the ARN of a RAM role?</a></description></item>
        /// <item><description>For more information about how to view the ARN by calling operations, see <a href="https://help.aliyun.com/document_detail/186833.html">GetSAMLProvider</a> or <a href="https://help.aliyun.com/document_detail/186851.html">ListSAMLProviders</a>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ram::123456789012****:saml-provider/company1</para>
        /// </summary>
        [NameInMap("SAMLProviderArn")]
        [Validation(Required=false)]
        public string SAMLProviderArn { get; set; }

    }

}
