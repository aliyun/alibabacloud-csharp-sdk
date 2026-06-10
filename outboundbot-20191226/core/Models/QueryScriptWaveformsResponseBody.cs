// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class QueryScriptWaveformsResponseBody : TeaModel {
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
        /// <para>254EB995-DEDF-48A4-9101-9CA5B72FFBCC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Recording list of scenario voices</para>
        /// <remarks>
        /// <para>Recording data is returned only when the voice type is recording. It is not returned when the voice is speech synthesis.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("ScriptWaveforms")]
        [Validation(Required=false)]
        public List<QueryScriptWaveformsResponseBodyScriptWaveforms> ScriptWaveforms { get; set; }
        public class QueryScriptWaveformsResponseBodyScriptWaveforms : TeaModel {
            /// <summary>
            /// <para>File key in OSS</para>
            /// 
            /// <b>Example:</b>
            /// <para>UPLOADED/RECORDING/a8xxxxx-2b26-4b6d-a54f-696b95xxx1/a6bf591a-cf6d-4xxxxxx.wav</para>
            /// </summary>
            [NameInMap("FileId")]
            [Validation(Required=false)]
            public string FileId { get; set; }

            /// <summary>
            /// <para>Recording file name</para>
            /// 
            /// <b>Example:</b>
            /// <para>SHUKE_ZA_ol_32_邀约.wav</para>
            /// </summary>
            [NameInMap("FileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            /// <summary>
            /// <para>Scenario voice name</para>
            /// 
            /// <b>Example:</b>
            /// <para>测试</para>
            /// </summary>
            [NameInMap("ScriptContent")]
            [Validation(Required=false)]
            public string ScriptContent { get; set; }

            /// <summary>
            /// <para>Scenario ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>25b26ce1-009c-4791-a720-e7ac4f9821a1</para>
            /// </summary>
            [NameInMap("ScriptId")]
            [Validation(Required=false)]
            public string ScriptId { get; set; }

            /// <summary>
            /// <para>Scenario voice recording ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>444df4-009c-4791-a720-e7ac4f9821a1</para>
            /// </summary>
            [NameInMap("ScriptWaveformId")]
            [Validation(Required=false)]
            public string ScriptWaveformId { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the request succeeded.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
