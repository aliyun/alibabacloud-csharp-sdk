// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class ListSecurityPoliciesResponseBody : TeaModel {
        /// <summary>
        /// 本次查询返回记录数量
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// 分页查询标识
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

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
        public List<ListSecurityPoliciesResponseBodySecurityPolicies> SecurityPolicies { get; set; }
        public class ListSecurityPoliciesResponseBodySecurityPolicies : TeaModel {
            /// <summary>
            /// 加密套件
            /// </summary>
            [NameInMap("Ciphers")]
            [Validation(Required=false)]
            public List<string> Ciphers { get; set; }

            /// <summary>
            /// 资源组id
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// 安全策略id
            /// </summary>
            [NameInMap("SecurityPolicyId")]
            [Validation(Required=false)]
            public string SecurityPolicyId { get; set; }

            /// <summary>
            /// 安全策略名称
            /// </summary>
            [NameInMap("SecurityPolicyName")]
            [Validation(Required=false)]
            public string SecurityPolicyName { get; set; }

            /// <summary>
            /// 状态
            /// </summary>
            [NameInMap("SecurityPolicyStatus")]
            [Validation(Required=false)]
            public string SecurityPolicyStatus { get; set; }

            /// <summary>
            /// TLS策略
            /// </summary>
            [NameInMap("TLSVersions")]
            [Validation(Required=false)]
            public List<string> TLSVersions { get; set; }

        }

        /// <summary>
        /// 总记录数
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
