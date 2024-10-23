// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FaRui20240628.Models
{
    public class RunContractResultGenerationResponseBody : TeaModel {
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
        public RunContractResultGenerationResponseBodyOutput Output { get; set; }
        public class RunContractResultGenerationResponseBodyOutput : TeaModel {
            [NameInMap("result")]
            [Validation(Required=false)]
            public RunContractResultGenerationResponseBodyOutputResult Result { get; set; }
            public class RunContractResultGenerationResponseBodyOutputResult : TeaModel {
                [NameInMap("examineBrief")]
                [Validation(Required=false)]
                public string ExamineBrief { get; set; }

                [NameInMap("examineResult")]
                [Validation(Required=false)]
                public string ExamineResult { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>high</para>
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

                [NameInMap("subRisks")]
                [Validation(Required=false)]
                public List<RunContractResultGenerationResponseBodyOutputResultSubRisks> SubRisks { get; set; }
                public class RunContractResultGenerationResponseBodyOutputResultSubRisks : TeaModel {
                    [NameInMap("originalContent")]
                    [Validation(Required=false)]
                    public string OriginalContent { get; set; }

                    [NameInMap("resultContent")]
                    [Validation(Required=false)]
                    public string ResultContent { get; set; }

                    [NameInMap("resultType")]
                    [Validation(Required=false)]
                    public string ResultType { get; set; }

                    [NameInMap("riskBrief")]
                    [Validation(Required=false)]
                    public string RiskBrief { get; set; }

                    [NameInMap("riskClause")]
                    [Validation(Required=false)]
                    public string RiskClause { get; set; }

                    [NameInMap("riskExplain")]
                    [Validation(Required=false)]
                    public string RiskExplain { get; set; }

                }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>eaa56e1e-e205-4f5e-926e-5e2269ae7f68</para>
            /// </summary>
            [NameInMap("resultTaskId")]
            [Validation(Required=false)]
            public string ResultTaskId { get; set; }

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
        public RunContractResultGenerationResponseBodyUsage Usage { get; set; }
        public class RunContractResultGenerationResponseBodyUsage : TeaModel {
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
        public string HttpStatusCode { get; set; }

    }

}
