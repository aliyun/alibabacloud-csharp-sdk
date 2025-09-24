// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809.Models
{
    public class KeepaliveIntlResponseBody : TeaModel {
        /// <summary>
        /// <para>The <a href="https://www.alibabacloud.com/help/en/ekyc/latest/client-connection-hold?spm=a3c0i.23458820.2359477120.1.48207d3ftEYld2#74d291dfaaxci">return code.</a></para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>A detailed description of the Code.</para>
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
        public KeepaliveIntlResponseBodyResult Result { get; set; }
        public class KeepaliveIntlResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The result of the call.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SUCCESS</para>
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public string Result { get; set; }

        }

    }

}
