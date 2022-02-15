// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeSpecificationRequest : TeaModel {
        [NameInMap("CpuCores")]
        [Validation(Required=false)]
        public int? CpuCores { get; set; }

        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("StorageType")]
        [Validation(Required=false)]
        public string StorageType { get; set; }

        [NameInMap("TotalNodeNum")]
        [Validation(Required=false)]
        public int? TotalNodeNum { get; set; }

    }

}
