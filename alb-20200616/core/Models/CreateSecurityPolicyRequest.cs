// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class CreateSecurityPolicyRequest : TeaModel {
        /// <summary>
        /// 幂等标识
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        ///  是否只预检此次请求
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// tls版本
        /// </summary>
        [NameInMap("TLSVersions")]
        [Validation(Required=false)]
        public List<string> TLSVersions { get; set; }

        /// <summary>
        /// 资源组id
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// 安全策略名称
        /// </summary>
        [NameInMap("SecurityPolicyName")]
        [Validation(Required=false)]
        public string SecurityPolicyName { get; set; }

        /// <summary>
        /// 加密套件
        /// </summary>
        [NameInMap("Ciphers")]
        [Validation(Required=false)]
        public List<string> Ciphers { get; set; }

    }

}
