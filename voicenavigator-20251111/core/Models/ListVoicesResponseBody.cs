// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VoiceNavigator20251111.Models
{
    public class ListVoicesResponseBody : TeaModel {
        /// <summary>
        /// <para>The internal error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>A paginated list of voices.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListVoicesResponseBodyData Data { get; set; }
        public class ListVoicesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries on the current page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total count of voices.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

            /// <summary>
            /// <para>A list of voices.</para>
            /// </summary>
            [NameInMap("Voices")]
            [Validation(Required=false)]
            public List<ListVoicesResponseBodyDataVoices> Voices { get; set; }
            public class ListVoicesResponseBodyDataVoices : TeaModel {
                /// <summary>
                /// <para>The category of the voice.</para>
                /// 
                /// <b>Example:</b>
                /// <para>千问音色</para>
                /// </summary>
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// <para>The language supported by the voice.</para>
                /// 
                /// <b>Example:</b>
                /// <para>中文及中英文混合</para>
                /// </summary>
                [NameInMap("Language")]
                [Validation(Required=false)]
                public string Language { get; set; }

                /// <summary>
                /// <para>The TTS model.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Qwen</para>
                /// </summary>
                [NameInMap("Model")]
                [Validation(Required=false)]
                public string Model { get; set; }

                /// <summary>
                /// <para>The name of the voice.</para>
                /// 
                /// <b>Example:</b>
                /// <para>芊悦</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The TTS engine.</para>
                /// 
                /// <b>Example:</b>
                /// <para>BAILIAN</para>
                /// </summary>
                [NameInMap("NlsEngine")]
                [Validation(Required=false)]
                public string NlsEngine { get; set; }

                /// <summary>
                /// <para>The style of the voice.</para>
                /// 
                /// <b>Example:</b>
                /// <para>女声</para>
                /// </summary>
                [NameInMap("Style")]
                [Validation(Required=false)]
                public string Style { get; set; }

                /// <summary>
                /// <para>A list of supported parameters.</para>
                /// </summary>
                [NameInMap("SupportedParams")]
                [Validation(Required=false)]
                public List<string> SupportedParams { get; set; }

                /// <summary>
                /// <para>The identifier for the voice.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Cherry</para>
                /// </summary>
                [NameInMap("Voice")]
                [Validation(Required=false)]
                public string Voice { get; set; }

            }

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
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Instance af81a389-91f0-4157-8d82-720edd02b66a
        ///  does not exist.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>A list of dynamic parameters related to the error.</para>
        /// </summary>
        [NameInMap("Params")]
        [Validation(Required=false)]
        public List<string> Params { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9DB8BA95-4513-54B9-9C67-A28909CFB4AD</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
