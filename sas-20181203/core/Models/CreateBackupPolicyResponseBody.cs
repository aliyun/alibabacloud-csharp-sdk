// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CreateBackupPolicyResponseBody : TeaModel {
        [NameInMap("BackupPolicy")]
        [Validation(Required=false)]
        public CreateBackupPolicyResponseBodyBackupPolicy BackupPolicy { get; set; }
        public class CreateBackupPolicyResponseBodyBackupPolicy : TeaModel {
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
