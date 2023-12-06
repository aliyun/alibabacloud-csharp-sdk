// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adp20210720.Models
{
    public class CreateProductVersionRequest : TeaModel {
        [NameInMap("baseProductVersionUID")]
        [Validation(Required=false)]
        public string BaseProductVersionUID { get; set; }

        [NameInMap("version")]
        [Validation(Required=false)]
        public string Version { get; set; }

        [NameInMap("withoutBaseProductVersion")]
        [Validation(Required=false)]
        public bool? WithoutBaseProductVersion { get; set; }

    }

}
