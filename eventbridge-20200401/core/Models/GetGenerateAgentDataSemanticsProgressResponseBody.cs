// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class GetGenerateAgentDataSemanticsProgressResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code of the operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The generation progress details. When the initial generation is complete, a full snapshot of the current generation round is returned. When regeneration is complete, the current Metrics, Joins, Examples, and new Text are returned. To discard a regeneration, first call Get to retrieve the current official version, and then call Save with the four types of content unchanged to idempotently clean up temporary results.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetGenerateAgentDataSemanticsProgressResponseBodyData Data { get; set; }
        public class GetGenerateAgentDataSemanticsProgressResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The error code returned when the generation task fails.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DataSemanticsGenerateFailed</para>
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <para>The error message returned when the generation task fails.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Failed to generate data semantics. Please retry later.</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <para>The SQL example knowledge returned when the generation is complete. A maximum of 50 items can be returned.</para>
            /// </summary>
            [NameInMap("Examples")]
            [Validation(Required=false)]
            public List<AgentDataSemanticsExample> Examples { get; set; }

            /// <summary>
            /// <para>The data association knowledge returned when the generation is complete. A maximum of 100 items can be returned.</para>
            /// </summary>
            [NameInMap("Joins")]
            [Validation(Required=false)]
            public List<AgentDataSemanticsJoin> Joins { get; set; }

            /// <summary>
            /// <para>The SQL expression knowledge returned when the generation is complete. A maximum of 100 items can be returned.</para>
            /// </summary>
            [NameInMap("Metrics")]
            [Validation(Required=false)]
            public List<AgentDataSemanticsMetric> Metrics { get; set; }

            /// <summary>
            /// <para>The four-phase stage progress. This parameter may not be returned when the overall generation is complete.</para>
            /// </summary>
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public List<AgentDataSemanticsStageProgress> Progress { get; set; }

            /// <summary>
            /// <para>The current overall stage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>GENERATE</para>
            /// </summary>
            [NameInMap("Stage")]
            [Validation(Required=false)]
            public string Stage { get; set; }

            /// <summary>
            /// <para>The Markdown text knowledge returned when the generation is complete.</para>
            /// </summary>
            [NameInMap("Text")]
            [Validation(Required=false)]
            public AgentDataSemanticsText Text { get; set; }

        }

        /// <summary>
        /// <para>The response message. If the request fails, an error message is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Data semantics generation task not found.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The unique identifier that Alibaba Cloud generates for the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5DAF96FB-A4DF-548C-B8A1-F2A8D2F4****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
