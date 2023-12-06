// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adp20210720.Models
{
    public class GenerateProductInstanceDeploymentConfigResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public GenerateProductInstanceDeploymentConfigResponseBodyData Data { get; set; }
        public class GenerateProductInstanceDeploymentConfigResponseBodyData : TeaModel {
            [NameInMap("packageConfig")]
            [Validation(Required=false)]
            public string PackageConfig { get; set; }

        }

        [NameInMap("msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

    }

}
