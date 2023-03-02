// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sts20150401.Models
{
    public class AssumeRoleWithOIDCRequest : TeaModel {
        /// <summary>
        /// The validity period of the STS token. Unit: seconds.
        /// 
        /// Default value: 3600. Minimum value: 900. Maximum value: the value of the `MaxSessionDuration` parameter.
        /// 
        /// For more information about how to specify `MaxSessionDuration`, see [CreateRole](~~28710~~) or [UpdateRole](~~28712~~).
        /// </summary>
        [NameInMap("DurationSeconds")]
        [Validation(Required=false)]
        public long? DurationSeconds { get; set; }

        /// <summary>
        /// The Alibaba Cloud Resource Name (ARN) of the OIDC IdP.
        /// 
        /// You can view the ARN in the RAM console or by calling operations.
        /// 
        /// - For more information about how to view the ARN in the RAM console, see [View the information about an OIDC IdP](~~327123~~).
        /// - For more information about how to view the ARN by calling operations, see [GetOIDCProvider](~~327126~~) or [ListOIDCProviders](~~327127~~).
        /// </summary>
        [NameInMap("OIDCProviderArn")]
        [Validation(Required=false)]
        public string OIDCProviderArn { get; set; }

        /// <summary>
        /// The OIDC token that is issued by the external IdP.
        /// 
        /// The OIDC token must be 4 to 20,000 characters in length.
        /// 
        /// > You must enter the original OIDC token. You do not need to enter the Base64-encoded OIDC token.
        /// </summary>
        [NameInMap("OIDCToken")]
        [Validation(Required=false)]
        public string OIDCToken { get; set; }

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
        /// You can view the ARN in the RAM console or by calling operations.
        /// 
        /// - For more information about how to view the ARN in the RAM console, see [How do I view the ARN of the RAM role?](~~39744~~)
        /// - For more information about how to view the ARN by calling operations, see [ListRoles](~~28713~~) or [GetRole](~~28711~~).
        /// </summary>
        [NameInMap("RoleArn")]
        [Validation(Required=false)]
        public string RoleArn { get; set; }

        /// <summary>
        /// The custom name of the role session.
        /// 
        /// You can specify the value of this parameter based on your business requirements. In most cases, you can set this parameter to the identity of the user who calls the operation. For example, specify a username. In ActionTrail logs, you can distinguish the users who assume the same RAM role to perform operations based on the value of the RoleSessionName parameter. This way, you can perform user-specific auditing.
        /// 
        /// The value can contain letters, digits, periods (.), at signs (@), hyphens (-), and underscores (\_).
        /// 
        /// The value must be 2 to 64 characters in length.
        /// </summary>
        [NameInMap("RoleSessionName")]
        [Validation(Required=false)]
        public string RoleSessionName { get; set; }

    }

}
