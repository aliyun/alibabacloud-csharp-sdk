// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adp20210720.Models
{
    public class GetProductDeploymentRequest : TeaModel {
        [NameInMap("environmentUID")]
        [Validation(Required=false)]
        public string EnvironmentUID { get; set; }

        [NameInMap("productVersionUID")]
        [Validation(Required=false)]
        public string ProductVersionUID { get; set; }

        [NameInMap("withParamConfig")]
        [Validation(Required=false)]
        public bool? WithParamConfig { get; set; }

    }

}
