// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.XrEngine20230313.Models
{
    public class PopGetAITryOnJobRequest : TeaModel {
        [NameInMap("JwtToken")]
        [Validation(Required=false)]
        public string JwtToken { get; set; }

        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        [NameInMap("WithMaterial")]
        [Validation(Required=false)]
        public bool? WithMaterial { get; set; }

        [NameInMap("WithResult")]
        [Validation(Required=false)]
        public bool? WithResult { get; set; }

    }

}
