// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class ModifyTTSConfigResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>f765d3ee-ec03-4765-b235-6877501d99d1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TTSConfig")]
        [Validation(Required=false)]
        public ModifyTTSConfigResponseBodyTTSConfig TTSConfig { get; set; }
        public class ModifyTTSConfigResponseBodyTTSConfig : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>291cfc6a-8703-4bdd-a99d-9cba32d5288a</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>语调
            /// [-500,500]之间整数。默认值为0。</para>
            /// <para>大于0表示升高音高。</para>
            /// <para>小于0表示降低音高。</para>
            /// </summary>
            [NameInMap("PitchRate")]
            [Validation(Required=false)]
            public string PitchRate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>947e0875-b5d4-4b33-b18c-7b2cf85bcb4f</para>
            /// </summary>
            [NameInMap("ScriptId")]
            [Validation(Required=false)]
            public string ScriptId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("SpeechRate")]
            [Validation(Required=false)]
            public string SpeechRate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2a07b634-e15d-445f-bbcb-fc4ea2df7b87</para>
            /// </summary>
            [NameInMap("TTSConfigId")]
            [Validation(Required=false)]
            public string TTSConfigId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xiaoyun</para>
            /// </summary>
            [NameInMap("Voice")]
            [Validation(Required=false)]
            public string Voice { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Volume")]
            [Validation(Required=false)]
            public string Volume { get; set; }

        }

    }

}
