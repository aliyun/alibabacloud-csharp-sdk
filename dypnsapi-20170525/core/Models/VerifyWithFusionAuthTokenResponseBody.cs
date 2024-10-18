// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dypnsapi20170525.Models
{
    public class VerifyWithFusionAuthTokenResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code. If OK is returned, the request is successful. Other values indicate that the request failed. For more information, see Error codes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Model")]
        [Validation(Required=false)]
        public VerifyWithFusionAuthTokenResponseBodyModel Model { get; set; }
        public class VerifyWithFusionAuthTokenResponseBodyModel : TeaModel {
            /// <summary>
            /// <para>The phone number, which is returned when the verification is successful.</para>
            /// 
            /// <b>Example:</b>
            /// <para>180********</para>
            /// </summary>
            [NameInMap("PhoneNumber")]
            [Validation(Required=false)]
            public string PhoneNumber { get; set; }

            /// <summary>
            /// <para>The phone number score, which is generated only after the phone number scoring node is enabled and the verification is successful. The higher the score, the more risky the phone number. Valid values: 0 to 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PhoneScore")]
            [Validation(Required=false)]
            public long? PhoneScore { get; set; }

            /// <summary>
            /// <para>The verification result. Valid values: PASS and UNKNOWN.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PASS</para>
            /// </summary>
            [NameInMap("VerifyResult")]
            [Validation(Required=false)]
            public string VerifyResult { get; set; }

        }

        /// <summary>
        /// <para>The request ID, which is used to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CC3BB6D2-2FDF-4321-9DCE-B38165CE4C47</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful. Valid values: true false</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
