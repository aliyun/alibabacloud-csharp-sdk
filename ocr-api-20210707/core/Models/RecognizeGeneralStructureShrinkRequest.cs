// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ocr_api20210707.Models
{
    public class RecognizeGeneralStructureShrinkRequest : TeaModel {
        [NameInMap("Keys")]
        [Validation(Required=false)]
        public string KeysShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://example.png">https://example.png</a></para>
        /// </summary>
        [NameInMap("Url")]
        [Validation(Required=false)]
        public string Url { get; set; }

        [NameInMap("body")]
        [Validation(Required=false)]
        public Stream Body { get; set; }

    }

}
