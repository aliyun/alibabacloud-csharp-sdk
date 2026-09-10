// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BailianVoiceBot20250101.Models
{
    public class ListVoiceEnginesResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code. A value of <c>OK</c> indicates that the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The pagination data, which includes the list of voice engines.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListVoiceEnginesResponseBodyData Data { get; set; }
        public class ListVoiceEnginesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The current page number.</para>
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
            /// <para>The total number of voice engines.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

            /// <summary>
            /// <para>A list of voice engine objects.</para>
            /// </summary>
            [NameInMap("VoiceEngines")]
            [Validation(Required=false)]
            public List<ListVoiceEnginesResponseBodyDataVoiceEngines> VoiceEngines { get; set; }
            public class ListVoiceEnginesResponseBodyDataVoiceEngines : TeaModel {
                /// <summary>
                /// <para>The engine configuration schema, provided as a JSON string.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[{\&quot;displayName\&quot;:\&quot;AppKey\&quot;,\&quot;maxLength\&quot;:64,\&quot;name\&quot;:\&quot;AppKey\&quot;,\&quot;order\&quot;:1,\&quot;required\&quot;:true},{\&quot;displayName\&quot;:\&quot;AccessKey\&quot;,\&quot;maxLength\&quot;:64,\&quot;name\&quot;:\&quot;AccessKey\&quot;,\&quot;order\&quot;:2,\&quot;required\&quot;:true}]</para>
                /// </summary>
                [NameInMap("ConfigSchema")]
                [Validation(Required=false)]
                public string ConfigSchema { get; set; }

                /// <summary>
                /// <para>The identifier for the voice engine.</para>
                /// 
                /// <b>Example:</b>
                /// <para>VOLC</para>
                /// </summary>
                [NameInMap("NlsEngine")]
                [Validation(Required=false)]
                public string NlsEngine { get; set; }

                /// <summary>
                /// <para>The display name of the voice engine.</para>
                /// 
                /// <b>Example:</b>
                /// <para>豆包</para>
                /// </summary>
                [NameInMap("NlsEngineName")]
                [Validation(Required=false)]
                public string NlsEngineName { get; set; }

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
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Instance llm-rj6aqmctjcit4acy does not exist.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>A list of dynamic error parameters.</para>
        /// </summary>
        [NameInMap("Params")]
        [Validation(Required=false)]
        public List<string> Params { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D771A1B6-3D5F-174A-BEE1-98CE1000D337</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
