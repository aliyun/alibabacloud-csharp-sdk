// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809.Models
{
    public class Mobile2MetaVerifyIntlResponseBody : TeaModel {
        /// <summary>
        /// <para><a href="https://www.alibabacloud.com/help/en/ekyc/latest/mobile-2meta?spm=a2c63.p38356.0.i13#cbf2539971xzr">Status codes</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
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
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>4EB35****87EBA1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Return result</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public Mobile2MetaVerifyIntlResponseBodyResult Result { get; set; }
        public class Mobile2MetaVerifyIntlResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The verification result:</para>
            /// <list type="bullet">
            /// <item><description><para>1: The information is consistent. (Billed)</para>
            /// </description></item>
            /// <item><description><para>2: The information is inconsistent. (Billed)</para>
            /// </description></item>
            /// <item><description><para>3: No record is found. (Not billed)</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("BizCode")]
            [Validation(Required=false)]
            public string BizCode { get; set; }

            /// <summary>
            /// <para>The carrier name:</para>
            /// <list type="bullet">
            /// <item><description><para>CMCC: China Mobile</para>
            /// </description></item>
            /// <item><description><para>CUCC: China Unicom</para>
            /// </description></item>
            /// <item><description><para>CTCC: China Telecom</para>
            /// </description></item>
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
