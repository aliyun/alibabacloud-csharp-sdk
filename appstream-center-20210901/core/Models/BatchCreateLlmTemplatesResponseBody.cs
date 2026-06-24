// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class BatchCreateLlmTemplatesResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data object.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public BatchCreateLlmTemplatesResponseBodyData Data { get; set; }
        public class BatchCreateLlmTemplatesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of IDs of the model templates that are created.</para>
            /// </summary>
            [NameInMap("LlmTemplateIds")]
            [Validation(Required=false)]
            public List<string> LlmTemplateIds { get; set; }

            /// <summary>
            /// <para>The list of skipped model configuration items.</para>
            /// </summary>
            [NameInMap("SkippedItems")]
            [Validation(Required=false)]
            public List<BatchCreateLlmTemplatesResponseBodyDataSkippedItems> SkippedItems { get; set; }
            public class BatchCreateLlmTemplatesResponseBodyDataSkippedItems : TeaModel {
                /// <summary>
                /// <para>The model code that is skipped.</para>
                /// 
                /// <b>Example:</b>
                /// <para>qwen3.5-plus</para>
                /// </summary>
                [NameInMap("LlmCode")]
                [Validation(Required=false)]
                public string LlmCode { get; set; }

                /// <summary>
                /// <para>The reason why the model is skipped.</para>
                /// 
                /// <b>Example:</b>
                /// <para>LLM template already exists with same providerTemplateId and llmCode.</para>
                /// </summary>
                [NameInMap("Reason")]
                [Validation(Required=false)]
                public string Reason { get; set; }

            }

            /// <summary>
            /// <para>The number of model templates that are created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("SuccessCount")]
            [Validation(Required=false)]
            public int? SuccessCount { get; set; }

            /// <summary>
            /// <para>The total number of requests.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
