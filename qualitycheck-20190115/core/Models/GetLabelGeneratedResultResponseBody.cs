// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class GetLabelGeneratedResultResponseBody : TeaModel {
        /// <summary>
        /// <para>The result code. A value of <b>200</b> indicates success. Other values indicate failure. You can use this field to determine the cause of failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetLabelGeneratedResultResponseBodyData Data { get; set; }
        public class GetLabelGeneratedResultResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The number of input tokens for the LLM.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7371</para>
            /// </summary>
            [NameInMap("InputTokens")]
            [Validation(Required=false)]
            public int? InputTokens { get; set; }

            /// <summary>
            /// <para>The number of LLM calls.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("LlmCallNum")]
            [Validation(Required=false)]
            public int? LlmCallNum { get; set; }

            /// <summary>
            /// <para>The number of output tokens for the LLM.</para>
            /// 
            /// <b>Example:</b>
            /// <para>355</para>
            /// </summary>
            [NameInMap("OutputTokens")]
            [Validation(Required=false)]
            public int? OutputTokens { get; set; }

            /// <summary>
            /// <para>The pre-signed download URL of the result file.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://sca-eas-mining.oss-cn-beijing.aliyuncs.com/xxx.xlsx?Expires=">https://sca-eas-mining.oss-cn-beijing.aliyuncs.com/xxx.xlsx?Expires=</a>...</para>
            /// </summary>
            [NameInMap("ResultFileUrl")]
            [Validation(Required=false)]
            public string ResultFileUrl { get; set; }

            /// <summary>
            /// <para>The ID of the generation task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20260616-4955F615-A74E-171E-86ED-080F60C72EC9</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

        /// <summary>
        /// <para>The error message returned when the request fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>106C6CA0-282D-4AF7-85F0-D2D24***</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful. true: The call was successful. false: The call failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
