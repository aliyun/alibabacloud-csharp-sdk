// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ocr_api20210707.Models
{
    public class RecognizeEduPaperCutRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("CutType")]
        [Validation(Required=false)]
        public string CutType { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ImageType")]
        [Validation(Required=false)]
        public string ImageType { get; set; }

        [NameInMap("OutputOricoord")]
        [Validation(Required=false)]
        public bool? OutputOricoord { get; set; }

        [NameInMap("Subject")]
        [Validation(Required=false)]
        public string Subject { get; set; }

        [NameInMap("Url")]
        [Validation(Required=false)]
        public string Url { get; set; }

        [NameInMap("body")]
        [Validation(Required=false)]
        public Stream Body { get; set; }

    }

}
