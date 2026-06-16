// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809.Models
{
    public class Id2MetaVerifyIntlResponseBody : TeaModel {
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
        /// <para>EFA11401-C961-5E89-A2D3-BF9883E5CC3D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The verification result.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public Id2MetaVerifyIntlResponseBodyResult Result { get; set; }
        public class Id2MetaVerifyIntlResponseBodyResult : TeaModel {
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

        }

    }

}
