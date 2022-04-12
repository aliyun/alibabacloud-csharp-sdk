// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ScaleOutApplicationRequest : TeaModel {
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("DeployGroup")]
        [Validation(Required=false)]
        public string DeployGroup { get; set; }

        [NameInMap("EcuInfo")]
        [Validation(Required=false)]
        public string EcuInfo { get; set; }

    }

}
