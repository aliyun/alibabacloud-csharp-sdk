// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dbs20210101.Models
{
    public class DescribeSandboxRecoveryTimeResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeSandboxRecoveryTimeResponseBodyData Data { get; set; }
        public class DescribeSandboxRecoveryTimeResponseBodyData : TeaModel {
            [NameInMap("BackupPlanId")]
            [Validation(Required=false)]
            public string BackupPlanId { get; set; }
            [NameInMap("RecoveryBeginTime")]
            [Validation(Required=false)]
            public string RecoveryBeginTime { get; set; }
            [NameInMap("RecoveryEndTime")]
            [Validation(Required=false)]
            public string RecoveryEndTime { get; set; }
        };

        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
