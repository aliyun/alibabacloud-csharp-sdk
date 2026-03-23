// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ModifyBackupPolicyResponseBody : TeaModel {
        [NameInMap("CompressType")]
        [Validation(Required=false)]
        public string CompressType { get; set; }

        [NameInMap("DBInstanceID")]
        [Validation(Required=false)]
        public string DBInstanceID { get; set; }

        [NameInMap("EnableBackupLog")]
        [Validation(Required=false)]
        public string EnableBackupLog { get; set; }

        [NameInMap("HighSpaceUsageProtection")]
        [Validation(Required=false)]
        public string HighSpaceUsageProtection { get; set; }

        [NameInMap("LocalLogRetentionHours")]
        [Validation(Required=false)]
        public int? LocalLogRetentionHours { get; set; }

        [NameInMap("LocalLogRetentionSpace")]
        [Validation(Required=false)]
        public string LocalLogRetentionSpace { get; set; }

        [NameInMap("LogBackupLocalRetentionNumber")]
        [Validation(Required=false)]
        public int? LogBackupLocalRetentionNumber { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
