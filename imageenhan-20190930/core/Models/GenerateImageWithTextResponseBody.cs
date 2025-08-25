// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageenhan20190930.Models
{
    public class GenerateImageWithTextResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GenerateImageWithTextResponseBodyData Data { get; set; }
        public class GenerateImageWithTextResponseBodyData : TeaModel {
            [NameInMap("ImageUrls")]
            [Validation(Required=false)]
            public List<string> ImageUrls { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>7574ee8f-38a3-4b1e-9280-11c33ab46e51</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
