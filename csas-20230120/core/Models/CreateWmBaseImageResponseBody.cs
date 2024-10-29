// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class CreateWmBaseImageResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateWmBaseImageResponseBodyData Data { get; set; }
        public class CreateWmBaseImageResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>fafb432cdede9b20640e12105845386e-496883833-8242409229217337*****</para>
            /// </summary>
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://example.com/test-*****.png">https://example.com/test-*****.png</a></para>
            /// </summary>
            [NameInMap("ImageUrl")]
            [Validation(Required=false)]
            public string ImageUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>17185*****</para>
            /// </summary>
            [NameInMap("ImageUrlExp")]
            [Validation(Required=false)]
            public long? ImageUrlExp { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>58D6B23E-E5DA-5418-8F61-51A3B5A30049</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
