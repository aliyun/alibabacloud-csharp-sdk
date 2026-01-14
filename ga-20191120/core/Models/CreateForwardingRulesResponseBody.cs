// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class CreateForwardingRulesResponseBody : TeaModel {
        /// <summary>
        /// <para>The forwarding rules.</para>
        /// </summary>
        [NameInMap("ForwardingRules")]
        [Validation(Required=false)]
        public List<CreateForwardingRulesResponseBodyForwardingRules> ForwardingRules { get; set; }
        public class CreateForwardingRulesResponseBodyForwardingRules : TeaModel {
            /// <summary>
            /// <para>The ID of the forwarding rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>frule-bp1dii16gu9qdvb34****</para>
            /// </summary>
            [NameInMap("ForwardingRuleId")]
            [Validation(Required=false)]
            public string ForwardingRuleId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>64ADAB1E-0B7F-4FD8-A404-3BECC0E9CCFF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
