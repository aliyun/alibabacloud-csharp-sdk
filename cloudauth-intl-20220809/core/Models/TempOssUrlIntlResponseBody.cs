// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809.Models
{
    public class TempOssUrlIntlResponseBody : TeaModel {
        /// <summary>
        /// <para>Return code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Result.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public TempOssUrlIntlResponseBodyData Data { get; set; }
        public class TempOssUrlIntlResponseBodyData : TeaModel {
            /// <summary>
            /// <para>File URL</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://bzxh.cdn.weijin365.com/assets/index-55338127.png">http://bzxh.cdn.weijin365.com/assets/index-55338127.png</a></para>
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        /// <summary>
        /// <para>Return message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>ID of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>EFA11401-C961-5E89-A2D3-BF9883E5CC3D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
