// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IntelligentCreation20240313.Models
{
    public class SubmitImageToVideoTaskRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="http://xxx/image.png">http://xxx/image.png</a></para>
        /// </summary>
        [NameInMap("imageUrl")]
        [Validation(Required=false)]
        public string ImageUrl { get; set; }

        [NameInMap("posPrompt")]
        [Validation(Required=false)]
        public string PosPrompt { get; set; }

    }

}
