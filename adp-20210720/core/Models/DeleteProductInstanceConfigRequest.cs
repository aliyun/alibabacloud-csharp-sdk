// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adp20210720.Models
{
    public class DeleteProductInstanceConfigRequest : TeaModel {
        [NameInMap("environmentUID")]
        [Validation(Required=false)]
        public string EnvironmentUID { get; set; }

        [NameInMap("productVersionUID")]
        [Validation(Required=false)]
        public string ProductVersionUID { get; set; }

    }

}
