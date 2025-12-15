// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchplat20240529.Models
{
    public class GetImageObjectDetectionRequest : TeaModel {
        [NameInMap("image")]
        [Validation(Required=false)]
        public GetImageObjectDetectionRequestImage Image { get; set; }
        public class GetImageObjectDetectionRequestImage : TeaModel {
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            [NameInMap("url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        [NameInMap("options")]
        [Validation(Required=false)]
        public Dictionary<string, object> Options { get; set; }

    }

}
