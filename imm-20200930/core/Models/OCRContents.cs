// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class OCRContents : TeaModel {
        /// <summary>
        /// Boundary
        /// </summary>
        [NameInMap("Boundary")]
        [Validation(Required=false)]
        public Boundary Boundary { get; set; }

        /// <summary>
        /// Confidence
        /// </summary>
        [NameInMap("Confidence")]
        [Validation(Required=false)]
        public float? Confidence { get; set; }

        /// <summary>
        /// Contents
        /// </summary>
        [NameInMap("Contents")]
        [Validation(Required=false)]
        public string Contents { get; set; }

        /// <summary>
        /// Language
        /// </summary>
        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

    }

}
