// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class CroppingSuggestion : TeaModel {
        /// <summary>
        /// AspectRatio
        /// </summary>
        [NameInMap("AspectRatio")]
        [Validation(Required=false)]
        public string AspectRatio { get; set; }

        /// <summary>
        /// Confidence
        /// </summary>
        [NameInMap("Confidence")]
        [Validation(Required=false)]
        public float? Confidence { get; set; }

        /// <summary>
        /// Boundary
        /// </summary>
        [NameInMap("Boundary")]
        [Validation(Required=false)]
        public Boundary Boundary { get; set; }

    }

}
