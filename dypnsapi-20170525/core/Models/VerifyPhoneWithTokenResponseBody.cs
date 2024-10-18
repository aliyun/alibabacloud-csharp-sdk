// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dypnsapi20170525.Models
{
    public class VerifyPhoneWithTokenResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code.</para>
        /// <list type="bullet">
        /// <item><description>If OK is returned, the request is successful.</description></item>
        /// <item><description>For more information about other error codes, see <a href="https://help.aliyun.com/document_detail/85198.html">API response codes</a>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response parameters.</para>
        /// </summary>
        [NameInMap("GateVerify")]
        [Validation(Required=false)]
        public VerifyPhoneWithTokenResponseBodyGateVerify GateVerify { get; set; }
        public class VerifyPhoneWithTokenResponseBodyGateVerify : TeaModel {
            /// <summary>
            /// <para>The external ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12134****</para>
            /// </summary>
            [NameInMap("VerifyId")]
            [Validation(Required=false)]
            public string VerifyId { get; set; }

            /// <summary>
            /// <para>The verification results. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PASS: The input phone number is consistent with the phone number used in HTML5 pages.</description></item>
            /// <item><description>REJECT: The input phone number is different from the phone number used in HTML5 pages.</description></item>
            /// <item><description>UNKNOWN: The system cannot judge whether the input phone number is consistent with the phone number used in HTML5 pages.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PASS</para>
            /// </summary>
            [NameInMap("VerifyResult")]
            [Validation(Required=false)]
            public string VerifyResult { get; set; }

        }

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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8906582E-6722</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
