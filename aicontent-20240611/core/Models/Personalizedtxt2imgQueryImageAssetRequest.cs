// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class Personalizedtxt2imgQueryImageAssetRequest : TeaModel {
        [NameInMap("encodeFormat")]
        [Validation(Required=false)]
        public string EncodeFormat { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("imageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("modelId")]
        [Validation(Required=false)]
        public string ModelId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("promptId")]
        [Validation(Required=false)]
        public string PromptId { get; set; }

    }

}
