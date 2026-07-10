// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class CompareFaceVerifyResponseBody : TeaModel {
        /// <summary>
        /// <para>The return code. A value of 200 indicates success. Other values indicate failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>130A2C10-B9EE-4D84-88E3-5384FF039795</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The face comparison result.</para>
        /// </summary>
        [NameInMap("ResultObject")]
        [Validation(Required=false)]
        public CompareFaceVerifyResponseBodyResultObject ResultObject { get; set; }
        public class CompareFaceVerifyResponseBodyResultObject : TeaModel {
            /// <summary>
            /// <para>The unique identifier of the ID Verification request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>08573be80f944d95ac812e019e3655a8</para>
            /// </summary>
            [NameInMap("CertifyId")]
            [Validation(Required=false)]
            public string CertifyId { get; set; }

            /// <summary>
            /// <para>Indicates whether the verification passed. A value of T indicates passed. A value of F indicates not passed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>T</para>
            /// </summary>
            [NameInMap("Passed")]
            [Validation(Required=false)]
            public string Passed { get; set; }

            /// <summary>
            /// <para>The face comparison score.</para>
            /// 
            /// <b>Example:</b>
            /// <para>99.60875</para>
            /// </summary>
            [NameInMap("VerifyScore")]
            [Validation(Required=false)]
            public float? VerifyScore { get; set; }

        }

    }

}
