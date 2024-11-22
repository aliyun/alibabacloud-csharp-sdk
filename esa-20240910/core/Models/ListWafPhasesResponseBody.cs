// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListWafPhasesResponseBody : TeaModel {
        /// <summary>
        /// <para>The WAF rule categories.</para>
        /// </summary>
        [NameInMap("Phases")]
        [Validation(Required=false)]
        public List<ListWafPhasesResponseBodyPhases> Phases { get; set; }
        public class ListWafPhasesResponseBodyPhases : TeaModel {
            /// <summary>
            /// <para>The name of the WAF rule category.</para>
            /// 
            /// <b>Example:</b>
            /// <para>http_custom</para>
            /// </summary>
            [NameInMap("Phase")]
            [Validation(Required=false)]
            public string Phase { get; set; }

            /// <summary>
            /// <para>The WAF rulesets.</para>
            /// </summary>
            [NameInMap("Rulesets")]
            [Validation(Required=false)]
            public List<ListWafPhasesResponseBodyPhasesRulesets> Rulesets { get; set; }
            public class ListWafPhasesResponseBodyPhasesRulesets : TeaModel {
                /// <summary>
                /// <para>The ID of the WAF ruleset.<a href="~~2850233~~"></a></para>
                /// 
                /// <b>Example:</b>
                /// <para>10000001</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The name of the WAF ruleset.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The rule configurations in the WAF ruleset.</para>
                /// </summary>
                [NameInMap("Rules")]
                [Validation(Required=false)]
                public List<WafRuleConfig> Rules { get; set; }

                /// <summary>
                /// <para>The configurations shared by the rules in the WAF ruleset.</para>
                /// </summary>
                [NameInMap("Shared")]
                [Validation(Required=false)]
                public WafBatchRuleShared Shared { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>36af3fcc-43d0-441c-86b1-428951dc8225</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
