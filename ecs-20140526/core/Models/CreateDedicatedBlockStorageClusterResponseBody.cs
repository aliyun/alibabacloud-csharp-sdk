// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class CreateDedicatedBlockStorageClusterResponseBody : TeaModel {
        [NameInMap("DedicatedBlockStorageClusterId")]
        [Validation(Required=false)]
        public string DedicatedBlockStorageClusterId { get; set; }

        [NameInMap("DedicatedBlockStorageClusterOrderId")]
        [Validation(Required=false)]
        public string DedicatedBlockStorageClusterOrderId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
