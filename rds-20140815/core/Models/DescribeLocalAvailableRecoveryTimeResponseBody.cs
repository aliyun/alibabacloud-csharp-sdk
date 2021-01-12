// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeLocalAvailableRecoveryTimeResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        [NameInMap("RecoveryBeginTime")]
        [Validation(Required=false)]
        public string RecoveryBeginTime { get; set; }

        [NameInMap("RecoveryEndTime")]
        [Validation(Required=false)]
        public string RecoveryEndTime { get; set; }

    }

}
