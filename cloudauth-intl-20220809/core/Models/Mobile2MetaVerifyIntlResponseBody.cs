// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809.Models
{
    public class Mobile2MetaVerifyIntlResponseBody : TeaModel {
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
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>4EB35****87EBA1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The returned result.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public Mobile2MetaVerifyIntlResponseBodyResult Result { get; set; }
        public class Mobile2MetaVerifyIntlResponseBodyResult : TeaModel {
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
            /// <para>The name of the telecommunications service provider. Valid values:</para>
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

        }

    }

}
