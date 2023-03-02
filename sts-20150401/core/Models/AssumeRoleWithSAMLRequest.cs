// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sts20150401.Models
{
    public class AssumeRoleWithSAMLRequest : TeaModel {
        /// <summary>
        /// The validity period of the STS token. Unit: seconds.
        /// 
        /// Minimum value: 900. Maximum value: the value of the `MaxSessionDuration` parameter. Default value: 3600.
        /// 
        /// You can call the CreateRole or UpdateRole operation to configure the `MaxSessionDuration` parameter. For more information, see [CreateRole](~~28710~~) or [UpdateRole](~~28712~~).
        /// </summary>
        [NameInMap("DurationSeconds")]
        [Validation(Required=false)]
        public long? DurationSeconds { get; set; }

        /// <summary>
        /// The policy that specifies the permissions of the returned STS token. You can use this parameter to grant the STS token fewer permissions than the permissions granted to the RAM role.
        /// 
        /// - If you specify this parameter, the permissions of the returned STS token are the permissions that are included in the value of this parameter and owned by the RAM role.
        /// - If you do not specify this parameter, the returned STS token has all the permissions of the RAM role.
        /// 
        /// The value must be 1 to 2,048 characters in length.
        /// </summary>
        [NameInMap("Policy")]
        [Validation(Required=false)]
        public string Policy { get; set; }

        /// <summary>
        /// The ARN of the RAM role.
        /// 
        /// The trust entity of the RAM role is a SAML IdP. For more information, see [Create a RAM role for a trusted IdP](~~116805~~) or [CreateRole](~~28710~~).
        /// 
        /// Format: `acs:ram::<account_id>:role/<role_name>`.
        /// 
        /// You can view the ARN in the RAM console or by calling operations.
        /// 
        /// - For more information about how to view the ARN in the RAM console, see [How do I view the ARN of the RAM role?](~~39744~~).
        /// - For more information about how to view the ARN by calling operations, see [ListRoles](~~28713~~) or [GetRole](~~28711~~).
        /// </summary>
        [NameInMap("RoleArn")]
        [Validation(Required=false)]
        public string RoleArn { get; set; }

        /// <summary>
        /// The Base64-encoded SAML assertion.
        /// 
        /// The value must be 4 to 100,000 characters in length.
        /// 
        /// > A complete SAML response rather than a single SAMLAssertion field must be retrieved from the external IdP.
        /// </summary>
        [NameInMap("SAMLAssertion")]
        [Validation(Required=false)]
        public string SAMLAssertion { get; set; }

        /// <summary>
        /// The Alibaba Cloud Resource Name (ARN) of the SAML IdP that is created in the RAM console.
        /// 
        /// Format: `acs:ram::<account_id>:saml-provider/<saml_provider_id>`.
        /// 
        /// You can view the ARN in the RAM console or by calling operations.
        /// 
        /// - For more information about how to view the ARN in the RAM console, see [How do I view the ARN of a RAM role?](~~116795~~)
        /// - For more information about how to view the ARN by calling operations, see [GetSAMLProvider](~~186833~~) or [ListSAMLProviders](~~186851~~).
        /// </summary>
        [NameInMap("SAMLProviderArn")]
        [Validation(Required=false)]
        public string SAMLProviderArn { get; set; }

    }

}
