// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class CreateRulesResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the asynchronous task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>72dcd26b-f12d-4c27-b3af-18f6aed5****</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>365F4154-92F6-4AE4-92F8-7FF34B540710</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The priority of the forwarding rule. Valid values: <b>1 to 10000</b>. A lower value specifies a higher priority.</para>
        /// <remarks>
        /// <para>The priorities of the forwarding rules created for the same listener is unique.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("RuleIds")]
        [Validation(Required=false)]
        public List<CreateRulesResponseBodyRuleIds> RuleIds { get; set; }
        public class CreateRulesResponseBodyRuleIds : TeaModel {
            /// <summary>
            /// <para>The priority of the forwarding rule. Valid values: <b>1 to 10000</b>. A smaller value indicates a higher priority.</para>
            /// <remarks>
            /// <para>The priorities of the forwarding rules created for the same listener must be unique.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            /// <summary>
            /// <para>The forwarding rule ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rule-a3x3pg1yohq3lq****</para>
            /// </summary>
            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public string RuleId { get; set; }

        }

    }

}
