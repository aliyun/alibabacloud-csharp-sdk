// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bailian20231229.Models
{
    public class GetAlipayUrlResponseBody : TeaModel {
        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetAlipayUrlResponseBodyData Data { get; set; }
        public class GetAlipayUrlResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The tipping code used to query the tipping status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxsdfasfw</para>
            /// </summary>
            [NameInMap("code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>The generated tipping URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://xxxxxx.aliyun-inc.com">https://xxxxxx.aliyun-inc.com</a></para>
            /// </summary>
            [NameInMap("qrUrl")]
            [Validation(Required=false)]
            public string QrUrl { get; set; }

        }

        /// <summary>
        /// <para>The unique ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6a71f2d9-f1c9-913b-818b-11402910xxxx</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
