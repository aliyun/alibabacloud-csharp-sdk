// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ocr_api20210707.Models
{
    public class RecognizeHealthCodeRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://img.alicdn.com/imgextra/i3/O1CN01ME0L7j29f6VRZKo5e_!!6000000008094-0-tps-1237-1981.jpg">https://img.alicdn.com/imgextra/i3/O1CN01ME0L7j29f6VRZKo5e_!!6000000008094-0-tps-1237-1981.jpg</a></para>
        /// </summary>
        [NameInMap("Url")]
        [Validation(Required=false)]
        public string Url { get; set; }

        [NameInMap("body")]
        [Validation(Required=false)]
        public Stream Body { get; set; }

    }

}
