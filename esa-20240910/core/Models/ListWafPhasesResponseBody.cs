// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListWafPhasesResponseBody : TeaModel {
        /// <summary>
        /// <para>List of WAF operation phases.</para>
        /// </summary>
        [NameInMap("Phases")]
        [Validation(Required=false)]
        public List<ListWafPhasesResponseBodyPhases> Phases { get; set; }
        public class ListWafPhasesResponseBodyPhases : TeaModel {
            /// <summary>
            /// <para>Name of the WAF operation phase.</para>
            /// 
            /// <b>Example:</b>
            /// <para>http_custom</para>
            /// </summary>
            [NameInMap("Phase")]
            [Validation(Required=false)]
            public string Phase { get; set; }

            /// <summary>
            /// <para>List of WAF rulesets.</para>
            /// </summary>
            [NameInMap("Rulesets")]
            [Validation(Required=false)]
            public List<ListWafPhasesResponseBodyPhasesRulesets> Rulesets { get; set; }
            public class ListWafPhasesResponseBodyPhasesRulesets : TeaModel {
                /// <summary>
                /// <para>ID of the WAF ruleset.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10000001</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>Name of the WAF ruleset.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>List of rule configurations in the WAF ruleset.</para>
                /// </summary>
                [NameInMap("Rules")]
                [Validation(Required=false)]
                public List<WafRuleConfig> Rules { get; set; }

                /// <summary>
                /// <para>Shared configuration for rules in the WAF ruleset.</para>
                /// </summary>
                [NameInMap("Shared")]
                [Validation(Required=false)]
                public WafBatchRuleShared Shared { get; set; }

            }

        }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>36af3fcc-43d0-441c-86b1-428951dc8225</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
