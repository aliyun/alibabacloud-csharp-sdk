// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220302.Models
{
    public class MultiModalAgentSSEResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code.</para>
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
        public MultiModalAgentSSEResponseBodyData Data { get; set; }
        public class MultiModalAgentSSEResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The timestamp when the session was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1783328536</para>
            /// </summary>
            [NameInMap("Created")]
            [Validation(Required=false)]
            public long? Created { get; set; }

            /// <summary>
            /// <para>The value of dataId passed in the API request. This field is not returned if dataId is not specified in the request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dataId-XXX</para>
            /// </summary>
            [NameInMap("DataId")]
            [Validation(Required=false)]
            public string DataId { get; set; }

            /// <summary>
            /// <para>If streaming output is used, this field is null during generation. When generation ends, this field is set to stop if the generation stopped due to a stop token.</para>
            /// 
            /// <b>Example:</b>
            /// <para>stop</para>
            /// </summary>
            [NameInMap("FinishReason")]
            [Validation(Required=false)]
            public string FinishReason { get; set; }

            /// <summary>
            /// <para>The output result.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;违规，原因XX&quot;</para>
            /// </summary>
            [NameInMap("Output")]
            [Validation(Required=false)]
            public string Output { get; set; }

            /// <summary>
            /// <para>The credits usage.</para>
            /// </summary>
            [NameInMap("Usage")]
            [Validation(Required=false)]
            public MultiModalAgentSSEResponseBodyDataUsage Usage { get; set; }
            public class MultiModalAgentSSEResponseBodyDataUsage : TeaModel {
                /// <summary>
                /// <para>The number of credits consumed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.23</para>
                /// </summary>
                [NameInMap("Credits")]
                [Validation(Required=false)]
                public double? Credits { get; set; }

            }

        }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAA-BBBB-CCCCC-DDDD-EEEEEEEE****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
