// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class ListAvailableTtsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>Access Denied</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListAvailableTtsResponseBodyData> Data { get; set; }
        public class ListAvailableTtsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>音色试听文件</para>
            /// 
            /// <b>Example:</b>
            /// <para>示例值</para>
            /// </summary>
            [NameInMap("TtsAuditionFileUrl")]
            [Validation(Required=false)]
            public string TtsAuditionFileUrl { get; set; }

            /// <summary>
            /// <para>音色平台CosyVoice/Volcano</para>
            /// 
            /// <b>Example:</b>
            /// <para>CosyVoice/Volcano</para>
            /// </summary>
            [NameInMap("TtsEngine")]
            [Validation(Required=false)]
            public string TtsEngine { get; set; }

            /// <summary>
            /// <para>音色cosy类型 cosyvoice-v2-XXXX-XXXX</para>
            /// 
            /// <b>Example:</b>
            /// <para>5EBAEBE6-0E77-5E1F-99E4-7B20512FCB3C</para>
            /// </summary>
            [NameInMap("TtsStyle")]
            [Validation(Required=false)]
            public string TtsStyle { get; set; }

            /// <summary>
            /// <para>音色编码</para>
            /// 
            /// <b>Example:</b>
            /// <para>V123456789</para>
            /// </summary>
            [NameInMap("TtsVoiceCode")]
            [Validation(Required=false)]
            public string TtsVoiceCode { get; set; }

            /// <summary>
            /// <para>音色名称</para>
            /// 
            /// <b>Example:</b>
            /// <para>示例值示例值</para>
            /// </summary>
            [NameInMap("TtsVoiceName")]
            [Validation(Required=false)]
            public string TtsVoiceName { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5EBAEBE6-0E77-5E1F-99E4-7B20512F22222</para>
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

    }

}
