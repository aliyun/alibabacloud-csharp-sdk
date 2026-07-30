// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class GetYaoChiAgentResponseBody : TeaModel {
        /// <summary>
        /// <para>The response content.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>The tool calling invoke list.</para>
        /// </summary>
        [NameInMap("FunctionCall")]
        [Validation(Required=false)]
        public List<GetYaoChiAgentResponseBodyFunctionCall> FunctionCall { get; set; }
        public class GetYaoChiAgentResponseBodyFunctionCall : TeaModel {
            /// <summary>
            /// <para>The parameters of the called tool.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;arg&quot;: &quot;xxx&quot;}</para>
            /// </summary>
            [NameInMap("Arguments")]
            [Validation(Required=false)]
            public string Arguments { get; set; }

            /// <summary>
            /// <para>The tool ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12345</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The name of the called tool.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sqlReview</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The tool calling invoke status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RUNNING</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The ParentId field. This field exists only when the message is output by a sub-agent, and the value is the sub-agent ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345</para>
        /// </summary>
        [NameInMap("ParentId")]
        [Validation(Required=false)]
        public string ParentId { get; set; }

        /// <summary>
        /// <para>The cloud service type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>polardb</para>
        /// </summary>
        [NameInMap("Product")]
        [Validation(Required=false)]
        public string Product { get; set; }

        /// <summary>
        /// <para>The query ID. This value is the same as the QueryId request parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-xxxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("QueryId")]
        [Validation(Required=false)]
        public string QueryId { get; set; }

        /// <summary>
        /// <para>The reasoning content of the model.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("ReasoningContent")]
        [Validation(Required=false)]
        public string ReasoningContent { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7172BECE-588A-5961-8126-C216E16B****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The session ID. This value is the same as the SessionId request parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-xxxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <para>The list of sub-agent call information.</para>
        /// </summary>
        [NameInMap("SubAgentCall")]
        [Validation(Required=false)]
        public List<GetYaoChiAgentResponseBodySubAgentCall> SubAgentCall { get; set; }
        public class GetYaoChiAgentResponseBodySubAgentCall : TeaModel {
            /// <summary>
            /// <para>The sub-agent status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>running</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The sub-agent ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12345</para>
            /// </summary>
            [NameInMap("SubAgentId")]
            [Validation(Required=false)]
            public string SubAgentId { get; set; }

            /// <summary>
            /// <para>The sub-agent name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>XX Agent</para>
            /// </summary>
            [NameInMap("SubAgentName")]
            [Validation(Required=false)]
            public string SubAgentName { get; set; }

        }

        /// <summary>
        /// <para>The card tool calling invoke list.</para>
        /// </summary>
        [NameInMap("UiFunctionCall")]
        [Validation(Required=false)]
        public List<GetYaoChiAgentResponseBodyUiFunctionCall> UiFunctionCall { get; set; }
        public class GetYaoChiAgentResponseBodyUiFunctionCall : TeaModel {
            /// <summary>
            /// <para>The parameters of the card tool.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;arg&quot;: &quot;xxx&quot;}</para>
            /// </summary>
            [NameInMap("ArgsText")]
            [Validation(Required=false)]
            public string ArgsText { get; set; }

            /// <summary>
            /// <para>The name of the card tool.</para>
            /// 
            /// <b>Example:</b>
            /// <para>card</para>
            /// </summary>
            [NameInMap("ToolName")]
            [Validation(Required=false)]
            public string ToolName { get; set; }

        }

    }

}
