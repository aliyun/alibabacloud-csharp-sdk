// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class GetAsrVocabResponseBody : TeaModel {
        /// <summary>
        /// <para>The result code. A value of <b>200</b> means success. Any other value means failure. Use this field to identify the cause of failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetAsrVocabResponseBodyData Data { get; set; }
        public class GetAsrVocabResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ASR version.</para>
            /// <list type="bullet">
            /// <item><description><para>2 or <b>null</b>: V2 (Intelligent Speech Interaction ASR)</para>
            /// </description></item>
            /// <item><description><para><b>3</b>: V3 (Paraformer ASR)</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("AsrVersion")]
            [Validation(Required=false)]
            public int? AsrVersion { get; set; }

            /// <summary>
            /// <para>The language model ID. This field appears only for V3.</para>
            /// 
            /// <b>Example:</b>
            /// <para>paraformer-8k-v2</para>
            /// </summary>
            [NameInMap("ModelCustomizationId")]
            [Validation(Required=false)]
            public string ModelCustomizationId { get; set; }

            /// <summary>
            /// <para>The hotword group name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Words")]
            [Validation(Required=false)]
            public GetAsrVocabResponseBodyDataWords Words { get; set; }
            public class GetAsrVocabResponseBodyDataWords : TeaModel {
                [NameInMap("Word")]
                [Validation(Required=false)]
                public List<GetAsrVocabResponseBodyDataWordsWord> Word { get; set; }
                public class GetAsrVocabResponseBodyDataWordsWord : TeaModel {
                    [NameInMap("Weight")]
                    [Validation(Required=false)]
                    public int? Weight { get; set; }

                    [NameInMap("Word")]
                    [Validation(Required=false)]
                    public string Word { get; set; }

                }

            }

        }

        /// <summary>
        /// <para>Error details if the request fails. If successful, the value is <b>successful</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3CEA0495-341B-4482-9AD9-8191EF4***</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request succeeded. Use this field to check the result:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b> means success</para>
        /// </description></item>
        /// <item><description><para>false or <b>null</b> means failure</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
