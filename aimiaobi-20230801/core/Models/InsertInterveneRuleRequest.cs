// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class InsertInterveneRuleRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxxx_p_efm</para>
        /// </summary>
        [NameInMap("AgentKey")]
        [Validation(Required=false)]
        public string AgentKey { get; set; }

        [NameInMap("InterveneRuleConfig")]
        [Validation(Required=false)]
        public InsertInterveneRuleRequestInterveneRuleConfig InterveneRuleConfig { get; set; }
        public class InsertInterveneRuleRequestInterveneRuleConfig : TeaModel {
            [NameInMap("AnswerConfig")]
            [Validation(Required=false)]
            public List<InsertInterveneRuleRequestInterveneRuleConfigAnswerConfig> AnswerConfig { get; set; }
            public class InsertInterveneRuleRequestInterveneRuleConfigAnswerConfig : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("AnswerType")]
                [Validation(Required=false)]
                public int? AnswerType { get; set; }

                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>namespace_qa_query</para>
                /// </summary>
                [NameInMap("Namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

            }

            [NameInMap("EffectConfig")]
            [Validation(Required=false)]
            public InsertInterveneRuleRequestInterveneRuleConfigEffectConfig EffectConfig { get; set; }
            public class InsertInterveneRuleRequestInterveneRuleConfigEffectConfig : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("EffectType")]
                [Validation(Required=false)]
                public int? EffectType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2023-03-28 06:04:29</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2023-03-28 06:04:29</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

            }

            [NameInMap("InterveneConfigList")]
            [Validation(Required=false)]
            public List<InsertInterveneRuleRequestInterveneRuleConfigInterveneConfigList> InterveneConfigList { get; set; }
            public class InsertInterveneRuleRequestInterveneRuleConfigInterveneConfigList : TeaModel {
                /// <summary>
                /// <para>id</para>
                /// 
                /// <b>Example:</b>
                /// <para>37249</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("OperationType")]
                [Validation(Required=false)]
                public int? OperationType { get; set; }

                [NameInMap("Query")]
                [Validation(Required=false)]
                public string Query { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("InterveneType")]
            [Validation(Required=false)]
            public int? InterveneType { get; set; }

            [NameInMap("NamespaceList")]
            [Validation(Required=false)]
            public List<string> NamespaceList { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public long? RuleId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>tf-test-rule</para>
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

        }

    }

}
