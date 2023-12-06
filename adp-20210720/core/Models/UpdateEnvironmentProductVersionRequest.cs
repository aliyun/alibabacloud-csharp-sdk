// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adp20210720.Models
{
    public class UpdateEnvironmentProductVersionRequest : TeaModel {
        [NameInMap("oldProductVersionSpecUID")]
        [Validation(Required=false)]
        public string OldProductVersionSpecUID { get; set; }

        [NameInMap("oldProductVersionUID")]
        [Validation(Required=false)]
        public string OldProductVersionUID { get; set; }

        [NameInMap("productVersionSpecUID")]
        [Validation(Required=false)]
        public string ProductVersionSpecUID { get; set; }

        [NameInMap("productVersionUID")]
        [Validation(Required=false)]
        public string ProductVersionUID { get; set; }

    }

}
