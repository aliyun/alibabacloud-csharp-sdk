// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sts20150401.Models
{
    public class AssumeRoleWithOIDCRequest : TeaModel {
        /// <summary>
        /// Session过期时间，单位为秒。
        /// </summary>
        [NameInMap("DurationSeconds")]
        [Validation(Required=false)]
        public long? DurationSeconds { get; set; }

        /// <summary>
        /// OIDC Provider的ARN
        /// </summary>
        [NameInMap("OIDCProviderArn")]
        [Validation(Required=false)]
        public string OIDCProviderArn { get; set; }

        /// <summary>
        /// OIDC的ID Token，需输入原始Token，无需Base64解码
        /// </summary>
        [NameInMap("OIDCToken")]
        [Validation(Required=false)]
        public string OIDCToken { get; set; }

        /// <summary>
        /// 权限策略。 生成STS Token时可以指定一个额外的权限策略，以进一步限制STS Token的权限。若不指定则返回的Token拥有指定角色的所有权限。
        /// </summary>
        [NameInMap("Policy")]
        [Validation(Required=false)]
        public string Policy { get; set; }

        /// <summary>
        /// 需要扮演的角色的ARN
        /// </summary>
        [NameInMap("RoleArn")]
        [Validation(Required=false)]
        public string RoleArn { get; set; }

        /// <summary>
        /// 用户自定义参数。此参数用来区分不同的令牌，可用于用户级别的访问审计。
        /// </summary>
        [NameInMap("RoleSessionName")]
        [Validation(Required=false)]
        public string RoleSessionName { get; set; }

    }

}
