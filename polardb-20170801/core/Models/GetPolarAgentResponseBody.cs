// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class GetPolarAgentResponseBody : TeaModel {
        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>QZ-13661677-80</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        [NameInMap("FunctionCall")]
        [Validation(Required=false)]
        public List<GetPolarAgentResponseBodyFunctionCall> FunctionCall { get; set; }
        public class GetPolarAgentResponseBodyFunctionCall : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>---narguments:n  parameters: []n</para>
            /// </summary>
            [NameInMap("Arguments")]
            [Validation(Required=false)]
            public string Arguments { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>393</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>rule04</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>polardb</para>
        /// </summary>
        [NameInMap("Product")]
        [Validation(Required=false)]
        public string Product { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2548026401648157601743560466154</para>
        /// </summary>
        [NameInMap("QueryId")]
        [Validation(Required=false)]
        public string QueryId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xxxx</para>
        /// </summary>
        [NameInMap("ReasoningContent")]
        [Validation(Required=false)]
        public string ReasoningContent { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>34458CD3-33E0-4624-BFEF-840C15******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>40315d708f0806903b08813bf4c9db2e</para>
        /// </summary>
        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        [NameInMap("UiFunctionCall")]
        [Validation(Required=false)]
        public List<GetPolarAgentResponseBodyUiFunctionCall> UiFunctionCall { get; set; }
        public class GetPolarAgentResponseBodyUiFunctionCall : TeaModel {
            /// <summary>
            /// <para>xxx</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("ArgsText")]
            [Validation(Required=false)]
            public string ArgsText { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("ToolName")]
            [Validation(Required=false)]
            public string ToolName { get; set; }

        }

    }

}
