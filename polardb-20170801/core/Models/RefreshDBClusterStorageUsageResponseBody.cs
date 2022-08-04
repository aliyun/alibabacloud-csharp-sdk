// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class RefreshDBClusterStorageUsageResponseBody : TeaModel {
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("UsedStorage")]
        [Validation(Required=false)]
        public string UsedStorage { get; set; }

        [NameInMap("UsedStorageModified")]
        [Validation(Required=false)]
        public string UsedStorageModified { get; set; }

    }

}
