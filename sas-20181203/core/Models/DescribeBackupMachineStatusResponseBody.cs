// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeBackupMachineStatusResponseBody : TeaModel {
        [NameInMap("BackupMachineStatus")]
        [Validation(Required=false)]
        public DescribeBackupMachineStatusResponseBodyBackupMachineStatus BackupMachineStatus { get; set; }
        public class DescribeBackupMachineStatusResponseBodyBackupMachineStatus : TeaModel {
            [NameInMap("ClientId")]
            [Validation(Required=false)]
            public string ClientId { get; set; }
            [NameInMap("ClientStatus")]
            [Validation(Required=false)]
            public string ClientStatus { get; set; }
            [NameInMap("ClientVersion")]
            [Validation(Required=false)]
            public string ClientVersion { get; set; }
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }
            [NameInMap("ErrorList")]
            [Validation(Required=false)]
            public List<DescribeBackupMachineStatusResponseBodyBackupMachineStatusErrorList> ErrorList { get; set; }
            public class DescribeBackupMachineStatusResponseBodyBackupMachineStatusErrorList : TeaModel {
                public string ErrorCode { get; set; }
                public string ErrorFile { get; set; }
                public string ErrorFileUrl { get; set; }
                public string ErrorMsg { get; set; }
                public string ErrorStatus { get; set; }
                public long? ErrorTime { get; set; }
                public string ErrorType { get; set; }
                public string Key { get; set; }
                public string Path { get; set; }
                public string RequestId { get; set; }
            }
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }
            [NameInMap("RequestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }
            [NameInMap("SavedBackupCount")]
            [Validation(Required=false)]
            public int? SavedBackupCount { get; set; }
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }
            [NameInMap("VaultId")]
            [Validation(Required=false)]
            public string VaultId { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
