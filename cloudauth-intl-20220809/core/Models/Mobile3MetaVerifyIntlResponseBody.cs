// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809.Models
{
    public class Mobile3MetaVerifyIntlResponseBody : TeaModel {
        /// <summary>
        /// <para>The return code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The return message.</para>
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
        /// <para>D241532C-4EE9-5A2A-A5A5-C1FD98CE2EDD</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The verification result.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public Mobile3MetaVerifyIntlResponseBodyResult Result { get; set; }
        public class Mobile3MetaVerifyIntlResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The verification result code. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1: Consistent.</description></item>
            /// <item><description>2: Inconsistent.</description></item>
            /// <item><description>3: No record found.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("BizCode")]
            [Validation(Required=false)]
            public string BizCode { get; set; }

            /// <summary>
            /// <para>The carrier name. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>CMCC: China Mobile</description></item>
            /// <item><description>CUCC: China Unicom</description></item>
            /// <item><description>CTCC: China Telecom.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CMCC</para>
            /// </summary>
            [NameInMap("IspName")]
            [Validation(Required=false)]
            public string IspName { get; set; }

            /// <summary>
            /// <para>The detailed verification result. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>101: Verification passed. </description></item>
            /// <item><description>201: The phone number is inconsistent with the name, and the phone number is inconsistent with the ID card number. </description></item>
            /// <item><description>202: The phone number is consistent with the name, but the phone number is inconsistent with the ID card number. </description></item>
            /// <item><description>203: The phone number is consistent with the ID card number, but the phone number is inconsistent with the name. </description></item>
            /// <item><description>204: Other inconsistency.</description></item>
            /// <item><description>301: No record found.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>101</para>
            /// </summary>
            [NameInMap("SubCode")]
            [Validation(Required=false)]
            public string SubCode { get; set; }

        }

    }

}
