// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeSpecificationRequest : TeaModel {
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        [NameInMap("StorageType")]
        [Validation(Required=true)]
        public string StorageType { get; set; }

        [NameInMap("CpuCores")]
        [Validation(Required=true)]
        public int? CpuCores { get; set; }

        [NameInMap("TotalNodeNum")]
        [Validation(Required=true)]
        public int? TotalNodeNum { get; set; }

    }

}
