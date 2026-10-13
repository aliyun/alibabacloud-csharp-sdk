// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class GetChatModelResponseBody : TeaModel {
        /// <summary>
        /// <para>The query result.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetChatModelResponseBodyData> Data { get; set; }
        public class GetChatModelResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The context window size of the model.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000000</para>
            /// </summary>
            [NameInMap("ContextWindow")]
            [Validation(Required=false)]
            public long? ContextWindow { get; set; }

            /// <summary>
            /// <para>Indicates whether this is the default model.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Default")]
            [Validation(Required=false)]
            public bool? Default { get; set; }

            /// <summary>
            /// <para>The list of supported modalities.</para>
            /// </summary>
            [NameInMap("Features")]
            [Validation(Required=false)]
            public List<string> Features { get; set; }

            /// <summary>
            /// <para>The model ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>qwen3.7-max</para>
            /// </summary>
            [NameInMap("ModelId")]
            [Validation(Required=false)]
            public string ModelId { get; set; }

            /// <summary>
            /// <para>The list of thinking depth levels for the model.</para>
            /// </summary>
            [NameInMap("ThinkingLevels")]
            [Validation(Required=false)]
            public List<string> ThinkingLevels { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>FE9C65D7-930F-57A5-A207-8C396329****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
