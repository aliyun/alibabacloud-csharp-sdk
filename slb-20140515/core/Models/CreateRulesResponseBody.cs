// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class CreateRulesResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9DEC9C28-AB05-4DDF-9A78-6B08EC9CE18C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The forwarding rules.</para>
        /// </summary>
        [NameInMap("Rules")]
        [Validation(Required=false)]
        public CreateRulesResponseBodyRules Rules { get; set; }
        public class CreateRulesResponseBodyRules : TeaModel {
            [NameInMap("Rule")]
            [Validation(Required=false)]
            public List<CreateRulesResponseBodyRulesRule> Rule { get; set; }
            public class CreateRulesResponseBodyRulesRule : TeaModel {
                /// <summary>
                /// <para>The forwarding rule ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rule-bp12jzy0*****</para>
                /// </summary>
                [NameInMap("RuleId")]
                [Validation(Required=false)]
                public string RuleId { get; set; }

                /// <summary>
                /// <para>The name of the forwarding rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Rule2</para>
                /// </summary>
                [NameInMap("RuleName")]
                [Validation(Required=false)]
                public string RuleName { get; set; }

            }

        }

    }

}
