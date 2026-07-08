// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class GetInterveneRuleDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>Status code</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Business data</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetInterveneRuleDetailResponseBodyData Data { get; set; }
        public class GetInterveneRuleDetailResponseBodyData : TeaModel {
            [NameInMap("Code")]
            [Validation(Required=false)]
            public int? Code { get; set; }

            /// <summary>
            /// <para>Structure of the rule details</para>
            /// </summary>
            [NameInMap("InterveneRuleDetail")]
            [Validation(Required=false)]
            public GetInterveneRuleDetailResponseBodyDataInterveneRuleDetail InterveneRuleDetail { get; set; }
            public class GetInterveneRuleDetailResponseBodyDataInterveneRuleDetail : TeaModel {
                /// <summary>
                /// <para>Answer configuration</para>
                /// </summary>
                [NameInMap("AnswerConfig")]
                [Validation(Required=false)]
                public List<GetInterveneRuleDetailResponseBodyDataInterveneRuleDetailAnswerConfig> AnswerConfig { get; set; }
                public class GetInterveneRuleDetailResponseBodyDataInterveneRuleDetailAnswerConfig : TeaModel {
                    /// <summary>
                    /// <para>Answer type</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("AnswerType")]
                    [Validation(Required=false)]
                    public int? AnswerType { get; set; }

                    /// <summary>
                    /// <para>Answer content</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>早上好</para>
                    /// </summary>
                    [NameInMap("Message")]
                    [Validation(Required=false)]
                    public string Message { get; set; }

                    /// <summary>
                    /// <para>Namespace</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>namespace_qa_query</para>
                    /// </summary>
                    [NameInMap("Namespace")]
                    [Validation(Required=false)]
                    public string Namespace { get; set; }

                }

                /// <summary>
                /// <para>Activation configuration</para>
                /// </summary>
                [NameInMap("EffectConfig")]
                [Validation(Required=false)]
                public GetInterveneRuleDetailResponseBodyDataInterveneRuleDetailEffectConfig EffectConfig { get; set; }
                public class GetInterveneRuleDetailResponseBodyDataInterveneRuleDetailEffectConfig : TeaModel {
                    /// <summary>
                    /// <para>Activation type</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("EffectType")]
                    [Validation(Required=false)]
                    public int? EffectType { get; set; }

                    /// <summary>
                    /// <para>End time</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2023-11-25 14:21:15</para>
                    /// </summary>
                    [NameInMap("EndTime")]
                    [Validation(Required=false)]
                    public string EndTime { get; set; }

                    /// <summary>
                    /// <para>Start time</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2023-11-25 14:21:15</para>
                    /// </summary>
                    [NameInMap("StartTime")]
                    [Validation(Required=false)]
                    public string StartTime { get; set; }

                }

                /// <summary>
                /// <para>Intervention type</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("InterveneType")]
                [Validation(Required=false)]
                public int? InterveneType { get; set; }

                /// <summary>
                /// <para>Namespace list</para>
                /// </summary>
                [NameInMap("NamespaceList")]
                [Validation(Required=false)]
                public List<string> NamespaceList { get; set; }

                /// <summary>
                /// <para>Rule ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>100418</para>
                /// </summary>
                [NameInMap("RuleId")]
                [Validation(Required=false)]
                public long? RuleId { get; set; }

                /// <summary>
                /// <para>Rule name</para>
                /// 
                /// <b>Example:</b>
                /// <para>规则001</para>
                /// </summary>
                [NameInMap("RuleName")]
                [Validation(Required=false)]
                public string RuleName { get; set; }

            }

        }

        /// <summary>
        /// <para>HTTP status code</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>Error message</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Unique request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>428DCC0D-3C63-5306-BD1B-124396AB97BE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates success: true for success, false for failure</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
