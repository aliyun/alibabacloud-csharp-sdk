// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class GetYaoChiAgentResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        [NameInMap("FunctionCall")]
        [Validation(Required=false)]
        public List<GetYaoChiAgentResponseBodyFunctionCall> FunctionCall { get; set; }
        public class GetYaoChiAgentResponseBodyFunctionCall : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;arg&quot;: &quot;xxx&quot;}</para>
            /// </summary>
            [NameInMap("Arguments")]
            [Validation(Required=false)]
            public string Arguments { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123447</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>sqlReview</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>RUNNING</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        [NameInMap("ParentId")]
        [Validation(Required=false)]
        public string ParentId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>polardb</para>
        /// </summary>
        [NameInMap("Product")]
        [Validation(Required=false)]
        public string Product { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-xxxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("QueryId")]
        [Validation(Required=false)]
        public string QueryId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("ReasoningContent")]
        [Validation(Required=false)]
        public string ReasoningContent { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>7172BECE-588A-5961-8126-C216E16B****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-xxxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        [NameInMap("SubAgentCall")]
        [Validation(Required=false)]
        public List<GetYaoChiAgentResponseBodySubAgentCall> SubAgentCall { get; set; }
        public class GetYaoChiAgentResponseBodySubAgentCall : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("SubAgentId")]
            [Validation(Required=false)]
            public string SubAgentId { get; set; }

            [NameInMap("SubAgentName")]
            [Validation(Required=false)]
            public string SubAgentName { get; set; }

        }

        [NameInMap("UiFunctionCall")]
        [Validation(Required=false)]
        public List<GetYaoChiAgentResponseBodyUiFunctionCall> UiFunctionCall { get; set; }
        public class GetYaoChiAgentResponseBodyUiFunctionCall : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;arg&quot;: &quot;xxx&quot;}</para>
            /// </summary>
            [NameInMap("ArgsText")]
            [Validation(Required=false)]
            public string ArgsText { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>card</para>
            /// </summary>
            [NameInMap("ToolName")]
            [Validation(Required=false)]
            public string ToolName { get; set; }

        }

    }

}
