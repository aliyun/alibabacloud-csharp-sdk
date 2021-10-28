// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sgw20180511.Models
{
    public class DeployCSGClientsShrinkRequest : TeaModel {
        [NameInMap("ClientRegionId")]
        [Validation(Required=false)]
        public string ClientRegionId { get; set; }

        [NameInMap("EcsInstanceIds")]
        [Validation(Required=false)]
        public string EcsInstanceIdsShrink { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
