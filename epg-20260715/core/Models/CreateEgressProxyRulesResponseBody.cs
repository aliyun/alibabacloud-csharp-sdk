// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EPG20260715.Models
{
    public class CreateEgressProxyRulesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of egress rules grouped by effective phase (PreDns, PreRequest, or PostResponse).</para>
        /// </summary>
        [NameInMap("EgressProxyRules")]
        [Validation(Required=false)]
        public CreateEgressProxyRulesResponseBodyEgressProxyRules EgressProxyRules { get; set; }
        public class CreateEgressProxyRulesResponseBodyEgressProxyRules : TeaModel {
            /// <summary>
            /// <para>The list of rules in the PostResponse phase (after the response is returned).</para>
            /// </summary>
            [NameInMap("PostResponse")]
            [Validation(Required=false)]
            public List<CreateEgressProxyRulesResponseBodyEgressProxyRulesPostResponse> PostResponse { get; set; }
            public class CreateEgressProxyRulesResponseBodyEgressProxyRulesPostResponse : TeaModel {
                /// <summary>
                /// <para>The ID of the egress rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>epr-gw80bb6a91dbb775****</para>
                /// </summary>
                [NameInMap("EgressProxyRuleId")]
                [Validation(Required=false)]
                public string EgressProxyRuleId { get; set; }

                /// <summary>
                /// <para>The priority of the egress rule within its stage. Valid values: 1 to 1000. A smaller value indicates a higher priority.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Priority")]
                [Validation(Required=false)]
                public int? Priority { get; set; }

            }

            /// <summary>
            /// <para>The list of rules for the pre-DNS stage (before DNS resolution).</para>
            /// </summary>
            [NameInMap("PreDns")]
            [Validation(Required=false)]
            public List<CreateEgressProxyRulesResponseBodyEgressProxyRulesPreDns> PreDns { get; set; }
            public class CreateEgressProxyRulesResponseBodyEgressProxyRulesPreDns : TeaModel {
                /// <summary>
                /// <para>The ID of the egress rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>epr-gw80bb6a91dbb775****</para>
                /// </summary>
                [NameInMap("EgressProxyRuleId")]
                [Validation(Required=false)]
                public string EgressProxyRuleId { get; set; }

                /// <summary>
                /// <para>The priority of the egress rule within its stage. Valid values: 1 to 1000. A smaller value indicates a higher priority.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Priority")]
                [Validation(Required=false)]
                public int? Priority { get; set; }

            }

            /// <summary>
            /// <para>The list of rules in the PreRequest stage (before request forwarding).</para>
            /// </summary>
            [NameInMap("PreRequest")]
            [Validation(Required=false)]
            public List<CreateEgressProxyRulesResponseBodyEgressProxyRulesPreRequest> PreRequest { get; set; }
            public class CreateEgressProxyRulesResponseBodyEgressProxyRulesPreRequest : TeaModel {
                /// <summary>
                /// <para>The ID of the egress rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>epr-gw80bb6a91dbb775****</para>
                /// </summary>
                [NameInMap("EgressProxyRuleId")]
                [Validation(Required=false)]
                public string EgressProxyRuleId { get; set; }

                /// <summary>
                /// <para>The priority of the egress rule within its stage. Valid values: 1 to 1000. A smaller value indicates a higher priority.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
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
        /// <para>01A05AB5-5BED-56ED-8EE9-304FBC2F8537</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
