// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class CreatePackageRequest : TeaModel {
        [NameInMap("body")]
        [Validation(Required=false)]
        public string Body { get; set; }

        [NameInMap("isInstall")]
        [Validation(Required=false)]
        public bool? IsInstall { get; set; }

    }

}
