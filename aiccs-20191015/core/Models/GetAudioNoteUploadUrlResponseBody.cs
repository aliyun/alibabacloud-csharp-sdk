// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class GetAudioNoteUploadUrlResponseBody : TeaModel {
        /// <summary>
        /// <para>The detailed reason why access is denied.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetAudioNoteUploadUrlResponseBodyData Data { get; set; }
        public class GetAudioNoteUploadUrlResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The AccessKey ID used for signing.</para>
            /// 
            /// <b>Example:</b>
            /// <para>STS.NYMxfDw3GkXfvEmZHXXXXXX</para>
            /// </summary>
            [NameInMap("AccessKeyId")]
            [Validation(Required=false)]
            public string AccessKeyId { get; set; }

            /// <summary>
            /// <para>The expiration time of the authorization.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-06-13T12:19:13Z</para>
            /// </summary>
            [NameInMap("Expire")]
            [Validation(Required=false)]
            public string Expire { get; set; }

            /// <summary>
            /// <para>The storage path of the OSS file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>audio/file/sample1</para>
            /// </summary>
            [NameInMap("FilePath")]
            [Validation(Required=false)]
            public string FilePath { get; set; }

            /// <summary>
            /// <para>The host address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>//alicom-voice-ai-agent-xxxx.oss-cn-xxxx.aliyuncs.com</para>
            /// </summary>
            [NameInMap("Host")]
            [Validation(Required=false)]
            public string Host { get; set; }

            /// <summary>
            /// <para>The key of the OSS file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>audio/file/sample1</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The maximum file size.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2560000</para>
            /// </summary>
            [NameInMap("MaxFileSize")]
            [Validation(Required=false)]
            public long? MaxFileSize { get; set; }

            /// <summary>
            /// <para>The HTTP method used for upload.</para>
            /// 
            /// <b>Example:</b>
            /// <para>POST</para>
            /// </summary>
            [NameInMap("Method")]
            [Validation(Required=false)]
            public string Method { get; set; }

            /// <summary>
            /// <para>The upload policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>text</para>
            /// </summary>
            [NameInMap("Policy")]
            [Validation(Required=false)]
            public string Policy { get; set; }

            /// <summary>
            /// <para>The authorization licensing key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>text</para>
            /// </summary>
            [NameInMap("SecurityToken")]
            [Validation(Required=false)]
            public string SecurityToken { get; set; }

            /// <summary>
            /// <para>The signature of the temporary upload credential, used to verify legitimacy during upload.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss sig text</para>
            /// </summary>
            [NameInMap("Signature")]
            [Validation(Required=false)]
            public string Signature { get; set; }

            /// <summary>
            /// <para>The upload URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para>//alicom-voice-ai-agent-xxxx.oss-cn-xxxx.aliyuncs.com</para>
            /// </summary>
            [NameInMap("UploadUrl")]
            [Validation(Required=false)]
            public string UploadUrl { get; set; }

        }

        /// <summary>
        /// <para>The status code description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EE339D98-9BD3-4413-B165</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the API call is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
