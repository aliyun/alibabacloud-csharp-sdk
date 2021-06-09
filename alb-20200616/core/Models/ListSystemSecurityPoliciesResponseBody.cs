// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class ListSystemSecurityPoliciesResponseBody : TeaModel {
        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 安全策略
        /// </summary>
        [NameInMap("SecurityPolicies")]
        [Validation(Required=false)]
        public List<ListSystemSecurityPoliciesResponseBodySecurityPolicies> SecurityPolicies { get; set; }
        public class ListSystemSecurityPoliciesResponseBodySecurityPolicies : TeaModel {
            /// <summary>
            /// 加密套件
            /// </summary>
            [NameInMap("Ciphers")]
            [Validation(Required=false)]
            public List<string> Ciphers { get; set; }

            /// <summary>
            /// 安全策略Id
            /// </summary>
            [NameInMap("SecurityPolicyId")]
            [Validation(Required=false)]
            public string SecurityPolicyId { get; set; }

            /// <summary>
            /// 协议版本
            /// </summary>
            [NameInMap("TLSVersions")]
            [Validation(Required=false)]
            public List<string> TLSVersions { get; set; }

        }

    }

}
