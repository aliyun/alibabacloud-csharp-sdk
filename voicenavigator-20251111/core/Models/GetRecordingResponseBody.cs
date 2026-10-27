// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VoiceNavigator20251111.Models
{
    public class GetRecordingResponseBody : TeaModel {
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
        /// <para>The recording object.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetRecordingResponseBodyData Data { get; set; }
        public class GetRecordingResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The recording file name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>61f7f225-3a2e-4b6e-8a1d-888f1862590f.wav</para>
            /// </summary>
            [NameInMap("FileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            /// <summary>
            /// <para>The recording file URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://bgc-us-east.oss-accelerate.aliyuncs.com/intellidocs/2025-08-27/bc84ce11-f110-436d-af70-382ce7c5690a.pdf">https://bgc-us-east.oss-accelerate.aliyuncs.com/intellidocs/2025-08-27/bc84ce11-f110-436d-af70-382ce7c5690a.pdf</a></para>
            /// </summary>
            [NameInMap("FileUrl")]
            [Validation(Required=false)]
            public string FileUrl { get; set; }

            /// <summary>
            /// <para>The session ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>f814f3ae-b2a7-44fb-883c-771221274673</para>
            /// </summary>
            [NameInMap("SessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

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
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The error parameter list.</para>
        /// </summary>
        [NameInMap("Params")]
        [Validation(Required=false)]
        public List<string> Params { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F132DDBA-66C4-5BD3-BF7E-9642FE877158</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
