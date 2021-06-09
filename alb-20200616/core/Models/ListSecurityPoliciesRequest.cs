// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class ListSecurityPoliciesRequest : TeaModel {
        /// <summary>
        /// 资源组ID
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// 分页查询标识
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// 查询数量
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// 安全策略名称
        /// </summary>
        [NameInMap("SecurityPolicyNames")]
        [Validation(Required=false)]
        public List<string> SecurityPolicyNames { get; set; }

        /// <summary>
        /// 安全策略id
        /// </summary>
        [NameInMap("SecurityPolicyIds")]
        [Validation(Required=false)]
        public List<string> SecurityPolicyIds { get; set; }

    }

}
