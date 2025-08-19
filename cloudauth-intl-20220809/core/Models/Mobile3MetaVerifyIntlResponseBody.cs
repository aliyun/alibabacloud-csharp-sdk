// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809.Models
{
    public class Mobile3MetaVerifyIntlResponseBody : TeaModel {
        /// <summary>
        /// <para>Return code</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Return message</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>D241532C-4EE9-5A2A-A5A5-C1FD98CE2EDD</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Return result</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public Mobile3MetaVerifyIntlResponseBodyResult Result { get; set; }
        public class Mobile3MetaVerifyIntlResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>Verification result code.</para>
            /// <list type="bullet">
            /// <item><description>1: Verification consistent</description></item>
            /// <item><description>2: Verification inconsistent</description></item>
            /// <item><description>3: No record found</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("BizCode")]
            [Validation(Required=false)]
            public string BizCode { get; set; }

            /// <summary>
            /// <para>ISP name</para>
            /// <list type="bullet">
            /// <item><description>CMCC: China Mobile</description></item>
            /// <item><description>CUCC: China Unicom</description></item>
            /// <item><description>CTCC: China Telecom</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CMCC</para>
            /// </summary>
            [NameInMap("IspName")]
            [Validation(Required=false)]
            public string IspName { get; set; }

            /// <summary>
            /// <para>Detailed verification results</para>
            /// <list type="bullet">
            /// <item><description>101: Verification passed </description></item>
            /// <item><description>201: Mobile number and name do not match, mobile number and ID number do not match </description></item>
            /// <item><description>202: Mobile number and name match, but mobile number and ID number do not match </description></item>
            /// <item><description>203: Mobile number and ID number match, but mobile number and name do not match </description></item>
            /// <item><description>204: Other inconsistencies</description></item>
            /// <item><description>301: No record found</description></item>
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
