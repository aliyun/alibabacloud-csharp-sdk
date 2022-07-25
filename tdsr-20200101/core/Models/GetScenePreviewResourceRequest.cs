// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tdsr20200101.Models
{
    public class GetScenePreviewResourceRequest : TeaModel {
        [NameInMap("Draft")]
        [Validation(Required=false)]
        public bool? Draft { get; set; }

        [NameInMap("PreviewToken")]
        [Validation(Required=false)]
        public string PreviewToken { get; set; }

    }

}
