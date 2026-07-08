// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class ListInterveneRulesResponseBody : TeaModel {
        /// <summary>
        /// <para>Status code</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Business data</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListInterveneRulesResponseBodyData Data { get; set; }
        public class ListInterveneRulesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Status code returned by the intervention service</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public int? Code { get; set; }

            /// <summary>
            /// <para>Number of items</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public long? Count { get; set; }

            /// <summary>
            /// <para>List of rules</para>
            /// </summary>
            [NameInMap("InterveneRuleList")]
            [Validation(Required=false)]
            public List<ListInterveneRulesResponseBodyDataInterveneRuleList> InterveneRuleList { get; set; }
            public class ListInterveneRulesResponseBodyDataInterveneRuleList : TeaModel {
                /// <summary>
                /// <para>Answer configuration</para>
                /// </summary>
                [NameInMap("AnswerConfig")]
                [Validation(Required=false)]
                public List<ListInterveneRulesResponseBodyDataInterveneRuleListAnswerConfig> AnswerConfig { get; set; }
                public class ListInterveneRulesResponseBodyDataInterveneRuleListAnswerConfig : TeaModel {
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
                    /// <para>抱歉我无法回答</para>
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
                /// <para>Creation time</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-06-05 15:17:01</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>Effective time</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-04-03 02:42:01</para>
                /// </summary>
                [NameInMap("EffectTime")]
                [Validation(Required=false)]
                public string EffectTime { get; set; }

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
                /// <para>List of namespaces</para>
                /// </summary>
                [NameInMap("NamespaceList")]
                [Validation(Required=false)]
                public List<string> NamespaceList { get; set; }

                /// <summary>
                /// <para>Rule ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>mr-iuo9pi9w555phfbb</para>
                /// </summary>
                [NameInMap("RuleId")]
                [Validation(Required=false)]
                public long? RuleId { get; set; }

                /// <summary>
                /// <para>Rule name</para>
                /// 
                /// <b>Example:</b>
                /// <para>ruletest</para>
                /// </summary>
                [NameInMap("RuleName")]
                [Validation(Required=false)]
                public string RuleName { get; set; }

            }

            /// <summary>
            /// <para>Page number</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageIndex")]
            [Validation(Required=false)]
            public int? PageIndex { get; set; }

            /// <summary>
            /// <para>Page size</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

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
        /// <para>Unique request identifier</para>
        /// 
        /// <b>Example:</b>
        /// <para>DA021073-17CE-5CCF-9FEB-93226C766887</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the operation succeeded: true for success, false for failure</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
