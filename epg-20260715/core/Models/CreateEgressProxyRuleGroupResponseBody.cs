// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EPG20260715.Models
{
    public class CreateEgressProxyRuleGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the egress proxy rule group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eprg-uf60966a9633667c51d7</para>
        /// </summary>
        [NameInMap("EgressProxyRuleGroupId")]
        [Validation(Required=false)]
        public string EgressProxyRuleGroupId { get; set; }

        /// <summary>
        /// <para>The list of egress rules grouped by phase (PreDns, PreRequest, and PostResponse).</para>
        /// </summary>
        [NameInMap("EgressProxyRules")]
        [Validation(Required=false)]
        public CreateEgressProxyRuleGroupResponseBodyEgressProxyRules EgressProxyRules { get; set; }
        public class CreateEgressProxyRuleGroupResponseBodyEgressProxyRules : TeaModel {
            /// <summary>
            /// <para>The list of rules in the PostResponse stage, which is executed after the response is returned.</para>
            /// </summary>
            [NameInMap("PostResponse")]
            [Validation(Required=false)]
            public List<CreateEgressProxyRuleGroupResponseBodyEgressProxyRulesPostResponse> PostResponse { get; set; }
            public class CreateEgressProxyRuleGroupResponseBodyEgressProxyRulesPostResponse : TeaModel {
                /// <summary>
                /// <para>The ID of the egress proxy rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>epr-g2w80bb6a91dbb775****</para>
                /// </summary>
                [NameInMap("EgressProxyRuleId")]
                [Validation(Required=false)]
                public string EgressProxyRuleId { get; set; }

                /// <summary>
                /// <para>The priority of the egress proxy rule in the stage to which it belongs. Valid values: 1 to 1000. A smaller value indicates a higher priority.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Priority")]
                [Validation(Required=false)]
                public int? Priority { get; set; }

            }

            /// <summary>
            /// <para>The list of rules in the PreDns stage, which is executed before DNS resolution.</para>
            /// </summary>
            [NameInMap("PreDns")]
            [Validation(Required=false)]
            public List<CreateEgressProxyRuleGroupResponseBodyEgressProxyRulesPreDns> PreDns { get; set; }
            public class CreateEgressProxyRuleGroupResponseBodyEgressProxyRulesPreDns : TeaModel {
                /// <summary>
                /// <para>The ID of the egress proxy rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>epr-gw80bb6a91dbb775****</para>
                /// </summary>
                [NameInMap("EgressProxyRuleId")]
                [Validation(Required=false)]
                public string EgressProxyRuleId { get; set; }

                /// <summary>
                /// <para>The priority of the egress proxy rule in the stage to which it belongs. Valid values: 1 to 1000. A smaller value indicates a higher priority.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Priority")]
                [Validation(Required=false)]
                public int? Priority { get; set; }

            }

            /// <summary>
            /// <para>The list of rules in the PreRequest stage, which is executed before the request is forwarded.</para>
            /// </summary>
            [NameInMap("PreRequest")]
            [Validation(Required=false)]
            public List<CreateEgressProxyRuleGroupResponseBodyEgressProxyRulesPreRequest> PreRequest { get; set; }
            public class CreateEgressProxyRuleGroupResponseBodyEgressProxyRulesPreRequest : TeaModel {
                /// <summary>
                /// <para>The ID of the egress proxy rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>epr-g1w80bb6a91dbb775****</para>
                /// </summary>
                [NameInMap("EgressProxyRuleId")]
                [Validation(Required=false)]
                public string EgressProxyRuleId { get; set; }

                /// <summary>
                /// <para>The priority of the egress proxy rule in the stage to which it belongs. Valid values: 1 to 1000. A smaller value indicates a higher priority.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Priority")]
                [Validation(Required=false)]
                public int? Priority { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>019F3A67-2D1B-537B-B08D-B2DEB69E8E8B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
