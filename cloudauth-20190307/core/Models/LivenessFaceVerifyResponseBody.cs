// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class LivenessFaceVerifyResponseBody : TeaModel {
        /// <summary>
        /// <para>Return code, <b>200</b> indicates successful API response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Return message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>ID of this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Return result.</para>
        /// </summary>
        [NameInMap("ResultObject")]
        [Validation(Required=false)]
        public LivenessFaceVerifyResponseBodyResultObject ResultObject { get; set; }
        public class LivenessFaceVerifyResponseBodyResultObject : TeaModel {
            /// <summary>
            /// <para>Unique identifier for the real-person authentication request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>91707dc296d469ad38e4c5efa6a0f24b</para>
            /// </summary>
            [NameInMap("CertifyId")]
            [Validation(Required=false)]
            public string CertifyId { get; set; }

            /// <summary>
            /// <para>Attachment information of the face authentication subject, including data such as face quality, face attack, face or OCR image, and intent verification.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;faceAttack&quot;: &quot;F&quot;,&quot;facialPictureFront&quot;: {&quot;qualityScore&quot;: 88.3615493774414,&quot;verifyScore&quot;: 50.28594166529785}}</para>
            /// </summary>
            [NameInMap("MaterialInfo")]
            [Validation(Required=false)]
            public string MaterialInfo { get; set; }

            /// <summary>
            /// <para>Authentication result, values:</para>
            /// <list type="bullet">
            /// <item><description><para>T: Passed</para>
            /// </description></item>
            /// <item><description><para>F: Not passed</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>T</para>
            /// </summary>
            [NameInMap("Passed")]
            [Validation(Required=false)]
            public string Passed { get; set; }

            /// <summary>
            /// <para>Authentication result code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("SubCode")]
            [Validation(Required=false)]
            public string SubCode { get; set; }

        }

    }

}
