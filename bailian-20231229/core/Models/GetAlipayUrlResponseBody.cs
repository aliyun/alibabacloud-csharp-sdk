// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bailian20231229.Models
{
    public class GetAlipayUrlResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetAlipayUrlResponseBodyData Data { get; set; }
        public class GetAlipayUrlResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>xxsdfasfw</para>
            /// </summary>
            [NameInMap("code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            [NameInMap("qrUrl")]
            [Validation(Required=false)]
            public string QrUrl { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>6a71f2d9-f1c9-913b-818b-11402910xxxx</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
