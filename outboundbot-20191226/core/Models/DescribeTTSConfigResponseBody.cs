// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class DescribeTTSConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>API status code</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>HTTP status code</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>API message</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>f765d3ee-ec03-4765-b235-6877501d99d1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the operation was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>TTS configuration</para>
        /// </summary>
        [NameInMap("TTSConfig")]
        [Validation(Required=false)]
        public DescribeTTSConfigResponseBodyTTSConfig TTSConfig { get; set; }
        public class DescribeTTSConfigResponseBodyTTSConfig : TeaModel {
            /// <summary>
            /// <para>AppKey for invoking TTS</para>
            /// 
            /// <b>Example:</b>
            /// <para>p2SjSj4zxxxxxxxx</para>
            /// </summary>
            [NameInMap("AppKey")]
            [Validation(Required=false)]
            public string AppKey { get; set; }

            /// <summary>
            /// <para>Instance ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>947e0875-b5d4-4b33-b18c-7b2cf85bcb4f</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>Service type</para>
            /// 
            /// <b>Example:</b>
            /// <para>Managed</para>
            /// </summary>
            [NameInMap("NlsServiceType")]
            [Validation(Required=false)]
            public string NlsServiceType { get; set; }

            /// <summary>
            /// <para>Speech rate</para>
            /// 
            /// <b>Example:</b>
            /// <para>-150</para>
            /// </summary>
            [NameInMap("SpeechRate")]
            [Validation(Required=false)]
            public string SpeechRate { get; set; }

            /// <summary>
            /// <para>TTS model</para>
            /// 
            /// <b>Example:</b>
            /// <para>xiaoyun</para>
            /// </summary>
            [NameInMap("Voice")]
            [Validation(Required=false)]
            public string Voice { get; set; }

            /// <summary>
            /// <para>Volume</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Volume")]
            [Validation(Required=false)]
            public string Volume { get; set; }

        }

    }

}
