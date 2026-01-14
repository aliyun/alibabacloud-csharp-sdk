// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class DeleteForwardingRulesResponseBody : TeaModel {
        /// <summary>
        /// <para>The forwarding rules.</para>
        /// </summary>
        [NameInMap("ForwardingRules")]
        [Validation(Required=false)]
        public List<DeleteForwardingRulesResponseBodyForwardingRules> ForwardingRules { get; set; }
        public class DeleteForwardingRulesResponseBodyForwardingRules : TeaModel {
            /// <summary>
            /// <para>The forwarding rule ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>frule-bp19a3t3yzr21q3****</para>
            /// </summary>
            [NameInMap("ForwardingRuleId")]
            [Validation(Required=false)]
            public string ForwardingRuleId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CFC67ED9-4AB1-431F-B6E3-A752B7B8CCD4</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
