// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FaRui20240628.Models
{
    public class RunContractResultGenerationRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>farui</para>
        /// </summary>
        [NameInMap("appId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("assistant")]
        [Validation(Required=false)]
        public RunContractResultGenerationRequestAssistant Assistant { get; set; }
        public class RunContractResultGenerationRequestAssistant : TeaModel {
            [NameInMap("metaData")]
            [Validation(Required=false)]
            public RunContractResultGenerationRequestAssistantMetaData MetaData { get; set; }
            public class RunContractResultGenerationRequestAssistantMetaData : TeaModel {
                [NameInMap("customRuleConfig")]
                [Validation(Required=false)]
                public RunContractResultGenerationRequestAssistantMetaDataCustomRuleConfig CustomRuleConfig { get; set; }
                public class RunContractResultGenerationRequestAssistantMetaDataCustomRuleConfig : TeaModel {
                    [NameInMap("customRules")]
                    [Validation(Required=false)]
                    public List<RunContractResultGenerationRequestAssistantMetaDataCustomRuleConfigCustomRules> CustomRules { get; set; }
                    public class RunContractResultGenerationRequestAssistantMetaDataCustomRuleConfigCustomRules : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>high</para>
                        /// </summary>
                        [NameInMap("riskLevel")]
                        [Validation(Required=false)]
                        public string RiskLevel { get; set; }

                        [NameInMap("ruleDesc")]
                        [Validation(Required=false)]
                        public string RuleDesc { get; set; }

                        [NameInMap("ruleTitle")]
                        [Validation(Required=false)]
                        public string RuleTitle { get; set; }

                    }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>9a6b1ba60d9944249363ec3cc1529b7b</para>
                /// </summary>
                [NameInMap("fileId")]
                [Validation(Required=false)]
                public string FileId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("position")]
                [Validation(Required=false)]
                public string Position { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>b265b416-ca1f-425d-9340-c968f39624e1</para>
                /// </summary>
                [NameInMap("ruleTaskId")]
                [Validation(Required=false)]
                public string RuleTaskId { get; set; }

                [NameInMap("rules")]
                [Validation(Required=false)]
                public List<RunContractResultGenerationRequestAssistantMetaDataRules> Rules { get; set; }
                public class RunContractResultGenerationRequestAssistantMetaDataRules : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>medium</para>
                    /// </summary>
                    [NameInMap("riskLevel")]
                    [Validation(Required=false)]
                    public string RiskLevel { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2.1</para>
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
            /// <para>contract_examime</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1.0.0</para>
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("stream")]
        [Validation(Required=false)]
        public bool? Stream { get; set; }

    }

}
