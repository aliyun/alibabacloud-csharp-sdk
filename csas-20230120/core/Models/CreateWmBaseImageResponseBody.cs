// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class CreateWmBaseImageResponseBody : TeaModel {
        /// <summary>
        /// <para>Transparent image information.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateWmBaseImageResponseBodyData Data { get; set; }
        public class CreateWmBaseImageResponseBodyData : TeaModel {
            /// <summary>
            /// <para>ID of the transparent image. Images with the same ID have identical content.</para>
            /// 
            /// <b>Example:</b>
            /// <para>fafb432cdede9b20640e12105845386e-496883833-8242409229217337*****</para>
            /// </summary>
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// <para>Temporary URL for downloading the image.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://example.com/test-*****.png">https://example.com/test-*****.png</a></para>
            /// </summary>
            [NameInMap("ImageUrl")]
            [Validation(Required=false)]
            public string ImageUrl { get; set; }

            /// <summary>
            /// <para>Expiration time of the temporary image URL, in seconds as a UNIX timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>17185*****</para>
            /// </summary>
            [NameInMap("ImageUrlExp")]
            [Validation(Required=false)]
            public long? ImageUrlExp { get; set; }

        }

        /// <summary>
        /// <para>ID of the current request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>58D6B23E-E5DA-5418-8F61-51A3B5A30049</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
