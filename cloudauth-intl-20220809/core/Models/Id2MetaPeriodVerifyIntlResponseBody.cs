// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809.Models
{
    public class Id2MetaPeriodVerifyIntlResponseBody : TeaModel {
        /// <summary>
        /// <para><a href="https://www.alibabacloud.com/help/en/ekyc/latest/dateverify?spm=a2c63.p38356.0.i32#22facb6ab6ui1">Return to Code</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>A detailed description of the response code.</para>
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
        /// <para>7B97D932-7FF5-517D-BF39-7CA1BEE3CDD9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Return result</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public Id2MetaPeriodVerifyIntlResponseBodyResult Result { get; set; }
        public class Id2MetaPeriodVerifyIntlResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The final authentication result. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Y</b>, via</para>
            /// </description></item>
            /// <item><description><para><b>N</b>: The authentication is not passed.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Y</para>
            /// </summary>
            [NameInMap("Passed")]
            [Validation(Required=false)]
            public string Passed { get; set; }

            /// <summary>
            /// <para>A description of the authentication result. For more information, see <a href="https://www.alibabacloud.com/help/en/ekyc/latest/dateverify?spm=a2c63.p38356.0.i32#d1f36d445az8i">ResultObject.SubCode error codes</a>.</para>
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
