// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dytnsapi20230101.Models
{
    public class GetPhoneNumberIdentificationResultResponseBody : TeaModel {
        /// <summary>
        /// <para>The return code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>OK: The request is successful.</description></item>
        /// <item><description>NoIdentificationResult: No verification result is available or the verification failed.</description></item>
        /// <item><description>SessionNotValid: The session is invalid or expired.</description></item>
        /// <item><description>MobileNumberIllegal: The format of the phone number is invalid.</description></item>
        /// </list>
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
        public GetPhoneNumberIdentificationResultResponseBodyData Data { get; set; }
        public class GetPhoneNumberIdentificationResultResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Indicates whether the phone number passed the verification.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsIdentified")]
            [Validation(Required=false)]
            public string IsIdentified { get; set; }

        }

        /// <summary>
        /// <para>The description of the return code.</para>
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
        /// <para>68A40250-50CD-034C-B728-0BD******177</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
