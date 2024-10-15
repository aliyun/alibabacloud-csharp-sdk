// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class InsureOrderUrlDetailResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://siopuat.mingya.com.cn/siop-fliggy/index.html#/list?token=fR4iOOZWgG">https://siopuat.mingya.com.cn/siop-fliggy/index.html#/list?token=fR4iOOZWgG</a></para>
        /// </summary>
        [NameInMap("module")]
        [Validation(Required=false)]
        public string Module { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>210bc59616861088185764700d7589</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>213e212c16975080875814628effac</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
