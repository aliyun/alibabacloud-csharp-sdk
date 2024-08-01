// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class Personalizedtxt2imgAddInferenceJobCmd : TeaModel {
        [NameInMap("imageNumber")]
        [Validation(Required=false)]
        public int? ImageNumber { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("modelId")]
        [Validation(Required=false)]
        public string ModelId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("prompt")]
        [Validation(Required=false)]
        public string Prompt { get; set; }

        [NameInMap("seed")]
        [Validation(Required=false)]
        public int? Seed { get; set; }

    }

}
