// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DeleteDedicatedHostClusterRequest : TeaModel {
        [NameInMap("RegionId")]
        [Validation(Required=true)]
        public string RegionId { get; set; }

        [NameInMap("DedicatedHostClusterId")]
        [Validation(Required=true)]
        public string DedicatedHostClusterId { get; set; }

    }

}
