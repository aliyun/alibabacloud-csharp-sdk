// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IntelligentCreation20240313.Models
{
    public class CountTextRequest : TeaModel {
        /// <summary>
        /// API
        /// </summary>
        [NameInMap("generationSource")]
        [Validation(Required=false)]
        public string GenerationSource { get; set; }

        [NameInMap("industry")]
        [Validation(Required=false)]
        public string Industry { get; set; }

        [NameInMap("publishStatus")]
        [Validation(Required=false)]
        public string PublishStatus { get; set; }

        [NameInMap("style")]
        [Validation(Required=false)]
        public string Style { get; set; }

    }

}
