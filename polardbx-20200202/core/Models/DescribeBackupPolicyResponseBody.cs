// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class DescribeBackupPolicyResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeBackupPolicyResponseBodyData> Data { get; set; }
        public class DescribeBackupPolicyResponseBodyData : TeaModel {
            [NameInMap("BackupPeriod")]
            [Validation(Required=false)]
            public string BackupPeriod { get; set; }

            [NameInMap("BackupPlanBegin")]
            [Validation(Required=false)]
            public string BackupPlanBegin { get; set; }

            [NameInMap("BackupSetRetention")]
            [Validation(Required=false)]
            public int? BackupSetRetention { get; set; }

            [NameInMap("BackupType")]
            [Validation(Required=false)]
            public string BackupType { get; set; }

            [NameInMap("BackupWay")]
            [Validation(Required=false)]
            public string BackupWay { get; set; }

            [NameInMap("DBInstanceName")]
            [Validation(Required=false)]
            public string DBInstanceName { get; set; }

            [NameInMap("ForceCleanOnHighSpaceUsage")]
            [Validation(Required=false)]
            public int? ForceCleanOnHighSpaceUsage { get; set; }

            [NameInMap("IsEnabled")]
            [Validation(Required=false)]
            public int? IsEnabled { get; set; }

            [NameInMap("LocalLogRetention")]
            [Validation(Required=false)]
            public int? LocalLogRetention { get; set; }

            [NameInMap("LogLocalRetentionSpace")]
            [Validation(Required=false)]
            public int? LogLocalRetentionSpace { get; set; }

            [NameInMap("RemoveLogRetention")]
            [Validation(Required=false)]
            public int? RemoveLogRetention { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
