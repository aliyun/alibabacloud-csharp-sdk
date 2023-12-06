// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adp20210720.Models
{
    public class ListProductEnvironmentsShrinkRequest : TeaModel {
        [NameInMap("compatibleProductVersionUID")]
        [Validation(Required=false)]
        public string CompatibleProductVersionUID { get; set; }

        [NameInMap("envType")]
        [Validation(Required=false)]
        public string EnvType { get; set; }

        [NameInMap("options")]
        [Validation(Required=false)]
        public string OptionsShrink { get; set; }

        [NameInMap("platforms")]
        [Validation(Required=false)]
        public string PlatformsShrink { get; set; }

        [NameInMap("productVersionSpecUID")]
        [Validation(Required=false)]
        public string ProductVersionSpecUID { get; set; }

        [NameInMap("productVersionUID")]
        [Validation(Required=false)]
        public string ProductVersionUID { get; set; }

    }

}
