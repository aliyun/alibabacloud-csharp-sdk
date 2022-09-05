// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class UpgradeDBInstanceRequest : TeaModel {
        [NameInMap("DBInstanceClass")]
        [Validation(Required=false)]
        public string DBInstanceClass { get; set; }

        [NameInMap("DBInstanceGroupCount")]
        [Validation(Required=false)]
        public string DBInstanceGroupCount { get; set; }

        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        [NameInMap("InstanceSpec")]
        [Validation(Required=false)]
        public string InstanceSpec { get; set; }

        [NameInMap("MasterNodeNum")]
        [Validation(Required=false)]
        public string MasterNodeNum { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("SegNodeNum")]
        [Validation(Required=false)]
        public string SegNodeNum { get; set; }

        [NameInMap("StorageSize")]
        [Validation(Required=false)]
        public string StorageSize { get; set; }

        [NameInMap("UpgradeType")]
        [Validation(Required=false)]
        public long? UpgradeType { get; set; }

    }

}
