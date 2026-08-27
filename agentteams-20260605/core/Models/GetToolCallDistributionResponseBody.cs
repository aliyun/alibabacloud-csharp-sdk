// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentTeams20260605.Models
{
    public class GetToolCallDistributionResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetToolCallDistributionResponseBodyData Data { get; set; }
        public class GetToolCallDistributionResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The tool calling distribution list.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[...]</para>
            /// </summary>
            [NameInMap("Items")]
            [Validation(Required=false)]
            public List<GetToolCallDistributionResponseBodyDataItems> Items { get; set; }
            public class GetToolCallDistributionResponseBodyDataItems : TeaModel {
                /// <summary>
                /// <para>The number of calls for the tool.</para>
                /// 
                /// <b>Example:</b>
                /// <para>300</para>
                /// </summary>
                [NameInMap("CallCount")]
                [Validation(Required=false)]
                public int? CallCount { get; set; }

                /// <summary>
                /// <para>The tool name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>web_search</para>
                /// </summary>
                [NameInMap("ToolName")]
                [Validation(Required=false)]
                public string ToolName { get; set; }

            }

            /// <summary>
            /// <para>The total number of tool invocations.</para>
            /// 
            /// <b>Example:</b>
            /// <para>500</para>
            /// </summary>
            [NameInMap("TotalCalls")]
            [Validation(Required=false)]
            public int? TotalCalls { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>req-xxx</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
