// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class ListSecurityPolicyRelationsResponseBody : TeaModel {
        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 安全策略关联关系
        /// </summary>
        [NameInMap("SecrityPolicyRelations")]
        [Validation(Required=false)]
        public List<ListSecurityPolicyRelationsResponseBodySecrityPolicyRelations> SecrityPolicyRelations { get; set; }
        public class ListSecurityPolicyRelationsResponseBodySecrityPolicyRelations : TeaModel {
            /// <summary>
            /// 关联的监听列表
            /// </summary>
            [NameInMap("RelatedListeners")]
            [Validation(Required=false)]
            public List<ListSecurityPolicyRelationsResponseBodySecrityPolicyRelationsRelatedListeners> RelatedListeners { get; set; }
            public class ListSecurityPolicyRelationsResponseBodySecrityPolicyRelationsRelatedListeners : TeaModel {
                /// <summary>
                /// 监听id
                /// </summary>
                [NameInMap("ListenerId")]
                [Validation(Required=false)]
                public string ListenerId { get; set; }

                /// <summary>
                /// 监听端口
                /// </summary>
                [NameInMap("ListenerPort")]
                [Validation(Required=false)]
                public long? ListenerPort { get; set; }

                /// <summary>
                /// 监听协议
                /// </summary>
                [NameInMap("ListenerProtocol")]
                [Validation(Required=false)]
                public string ListenerProtocol { get; set; }

                /// <summary>
                /// 实例id
                /// </summary>
                [NameInMap("LoadBalancerId")]
                [Validation(Required=false)]
                public string LoadBalancerId { get; set; }

            }

            /// <summary>
            /// 安全策略id
            /// </summary>
            [NameInMap("SecurityPolicyId")]
            [Validation(Required=false)]
            public string SecurityPolicyId { get; set; }

        }

    }

}
