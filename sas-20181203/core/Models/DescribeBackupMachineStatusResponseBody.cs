// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeBackupMachineStatusResponseBody : TeaModel {
        /// <summary>
        /// The backup status of the server.
        /// </summary>
        [NameInMap("BackupMachineStatus")]
        [Validation(Required=false)]
        public DescribeBackupMachineStatusResponseBodyBackupMachineStatus BackupMachineStatus { get; set; }
        public class DescribeBackupMachineStatusResponseBodyBackupMachineStatus : TeaModel {
            /// <summary>
            /// The ID of the anti-ransomware agent.
            /// </summary>
            [NameInMap("ClientId")]
            [Validation(Required=false)]
            public string ClientId { get; set; }

            /// <summary>
            /// The status of the anti-ransomware agent. Valid values:
            /// 
            /// *   **ONLINE**: normal
            /// *   **CLIENT_CONNECTION_ERROR**: abnormal
            /// *   **UNINSTALLING**: being uninstalled
            /// *   **UNINSTALL_FAILED**: failed to be uninstalled
            /// *   **UPGRADING**: being upgraded
            /// *   **UPGRADE_FAILED**: failed to be upgraded
            /// </summary>
            [NameInMap("ClientStatus")]
            [Validation(Required=false)]
            public string ClientStatus { get; set; }

            /// <summary>
            /// The version of the anti-ransomware agent.
            /// </summary>
            [NameInMap("ClientVersion")]
            [Validation(Required=false)]
            public string ClientVersion { get; set; }

            /// <summary>
            /// The error code returned.
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// An array that consists of the error information reported by the backup server.
            /// </summary>
            [NameInMap("ErrorList")]
            [Validation(Required=false)]
            public List<DescribeBackupMachineStatusResponseBodyBackupMachineStatusErrorList> ErrorList { get; set; }
            public class DescribeBackupMachineStatusResponseBodyBackupMachineStatusErrorList : TeaModel {
                /// <summary>
                /// The error code returned.
                /// </summary>
                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                /// <summary>
                /// The error message returned.
                /// </summary>
                [NameInMap("ErrorStatus")]
                [Validation(Required=false)]
                public string ErrorStatus { get; set; }

            }

            /// <summary>
            /// The ID of the server.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The ID of the region in which the server resides.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// The number of backup versions.
            /// </summary>
            [NameInMap("SavedBackupCount")]
            [Validation(Required=false)]
            public int? SavedBackupCount { get; set; }

            /// <summary>
            /// The status of the anti-ransomware agent. Valid values:
            /// 
            /// *   **NOT_INSTALLED**: not installed
            /// *   **CLIENT_CONNECTION_ERROR**: abnormal
            /// *   **ACTIVATED**: normal
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The UUID of the server.
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

            /// <summary>
            /// The ID of the backup vault in which the backup data is stored.
            /// </summary>
            [NameInMap("VaultId")]
            [Validation(Required=false)]
            public string VaultId { get; set; }

        }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
