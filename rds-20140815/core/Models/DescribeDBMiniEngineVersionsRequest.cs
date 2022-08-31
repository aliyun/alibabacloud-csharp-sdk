// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeDBMiniEngineVersionsRequest : TeaModel {
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        [NameInMap("DedicatedHostGroupId")]
        [Validation(Required=false)]
        public string DedicatedHostGroupId { get; set; }

        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        [NameInMap("MinorVersionTag")]
        [Validation(Required=false)]
        public string MinorVersionTag { get; set; }

        [NameInMap("NodeType")]
        [Validation(Required=false)]
        public string NodeType { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("StorageType")]
        [Validation(Required=false)]
        public string StorageType { get; set; }

    }

}
