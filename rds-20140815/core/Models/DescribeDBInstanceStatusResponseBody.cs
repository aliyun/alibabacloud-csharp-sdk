// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeDBInstanceStatusResponseBody : TeaModel {
        [NameInMap("DBInstanceName")]
        [Validation(Required=false)]
        public string DBInstanceName { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("DBInstanceCpuCores")]
        [Validation(Required=false)]
        public string DBInstanceCpuCores { get; set; }

        [NameInMap("TaskStatus")]
        [Validation(Required=false)]
        public int? TaskStatus { get; set; }

        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public int? DBInstanceId { get; set; }

        [NameInMap("DBInstanceStatus")]
        [Validation(Required=false)]
        public int? DBInstanceStatus { get; set; }

        [NameInMap("DBInstanceUseType")]
        [Validation(Required=false)]
        public string DBInstanceUseType { get; set; }

    }

}
