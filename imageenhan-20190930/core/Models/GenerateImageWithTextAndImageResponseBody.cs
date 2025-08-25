// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageenhan20190930.Models
{
    public class GenerateImageWithTextAndImageResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GenerateImageWithTextAndImageResponseBodyData Data { get; set; }
        public class GenerateImageWithTextAndImageResponseBodyData : TeaModel {
            [NameInMap("ImageUrls")]
            [Validation(Required=false)]
            public List<string> ImageUrls { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>141fb6d1-28e8-4d93-8165-d966f7092e6a</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
