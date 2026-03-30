// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VoiceNavigator20251111.Models
{
    public class ListVoiceEnginesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListVoiceEnginesResponseBodyData Data { get; set; }
        public class ListVoiceEnginesResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

            [NameInMap("VoiceEngines")]
            [Validation(Required=false)]
            public List<ListVoiceEnginesResponseBodyDataVoiceEngines> VoiceEngines { get; set; }
            public class ListVoiceEnginesResponseBodyDataVoiceEngines : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>[{\&quot;displayName\&quot;:\&quot;AppKey\&quot;,\&quot;maxLength\&quot;:64,\&quot;name\&quot;:\&quot;AppKey\&quot;,\&quot;order\&quot;:1,\&quot;required\&quot;:true},{\&quot;displayName\&quot;:\&quot;AccessKey\&quot;,\&quot;maxLength\&quot;:64,\&quot;name\&quot;:\&quot;AccessKey\&quot;,\&quot;order\&quot;:2,\&quot;required\&quot;:true}]</para>
                /// </summary>
                [NameInMap("ConfigSchema")]
                [Validation(Required=false)]
                public string ConfigSchema { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>VOLC</para>
                /// </summary>
                [NameInMap("NlsEngine")]
                [Validation(Required=false)]
                public string NlsEngine { get; set; }

                [NameInMap("NlsEngineName")]
                [Validation(Required=false)]
                public string NlsEngineName { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Instance af81a389-91f0-4157-8d82-720edd02b66a
        ///  does not exist.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Params")]
        [Validation(Required=false)]
        public List<string> Params { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>7401D698-0AAC-5909-B68E-88C68805FFB8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
