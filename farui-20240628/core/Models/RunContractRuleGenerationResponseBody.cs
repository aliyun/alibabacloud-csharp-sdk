// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FaRui20240628.Models
{
    public class RunContractRuleGenerationResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Output")]
        [Validation(Required=false)]
        public RunContractRuleGenerationResponseBodyOutput Output { get; set; }
        public class RunContractRuleGenerationResponseBodyOutput : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>b265b416-ca1f-425d-9340-c968f39624e9</para>
            /// </summary>
            [NameInMap("ruleTaskId")]
            [Validation(Required=false)]
            public string RuleTaskId { get; set; }

            [NameInMap("rules")]
            [Validation(Required=false)]
            public List<RunContractRuleGenerationResponseBodyOutputRules> Rules { get; set; }
            public class RunContractRuleGenerationResponseBodyOutputRules : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>medium</para>
                /// </summary>
                [NameInMap("riskLevel")]
                [Validation(Required=false)]
                public string RiskLevel { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1.1</para>
                /// </summary>
                [NameInMap("ruleSequence")]
                [Validation(Required=false)]
                public string RuleSequence { get; set; }

                [NameInMap("ruleTag")]
                [Validation(Required=false)]
                public string RuleTag { get; set; }

                [NameInMap("ruleTitle")]
                [Validation(Required=false)]
                public string RuleTitle { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>744419D0-671A-5997-9840-E8AE48356194</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Usage")]
        [Validation(Required=false)]
        public RunContractRuleGenerationResponseBodyUsage Usage { get; set; }
        public class RunContractRuleGenerationResponseBodyUsage : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("input")]
            [Validation(Required=false)]
            public long? Input { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>page</para>
            /// </summary>
            [NameInMap("unit")]
            [Validation(Required=false)]
            public string Unit { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

    }

}
