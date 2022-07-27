// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class CreateRestoreJobShrinkRequest : TeaModel {
        [NameInMap("CrossAccountRoleName")]
        [Validation(Required=false)]
        public string CrossAccountRoleName { get; set; }

        [NameInMap("CrossAccountType")]
        [Validation(Required=false)]
        public string CrossAccountType { get; set; }

        [NameInMap("CrossAccountUserId")]
        [Validation(Required=false)]
        public long? CrossAccountUserId { get; set; }

        [NameInMap("Exclude")]
        [Validation(Required=false)]
        public string Exclude { get; set; }

        [NameInMap("Include")]
        [Validation(Required=false)]
        public string Include { get; set; }

        [NameInMap("InitiatedByAck")]
        [Validation(Required=false)]
        public bool? InitiatedByAck { get; set; }

        [NameInMap("OtsDetail")]
        [Validation(Required=false)]
        public string OtsDetailShrink { get; set; }

        [NameInMap("RestoreType")]
        [Validation(Required=false)]
        public string RestoreType { get; set; }

        [NameInMap("SnapshotHash")]
        [Validation(Required=false)]
        public string SnapshotHash { get; set; }

        [NameInMap("SnapshotId")]
        [Validation(Required=false)]
        public string SnapshotId { get; set; }

        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        [NameInMap("TargetBucket")]
        [Validation(Required=false)]
        public string TargetBucket { get; set; }

        [NameInMap("TargetContainer")]
        [Validation(Required=false)]
        public string TargetContainer { get; set; }

        [NameInMap("TargetContainerClusterId")]
        [Validation(Required=false)]
        public string TargetContainerClusterId { get; set; }

        [NameInMap("TargetCreateTime")]
        [Validation(Required=false)]
        public long? TargetCreateTime { get; set; }

        [NameInMap("TargetFileSystemId")]
        [Validation(Required=false)]
        public string TargetFileSystemId { get; set; }

        [NameInMap("TargetInstanceId")]
        [Validation(Required=false)]
        public string TargetInstanceId { get; set; }

        [NameInMap("TargetInstanceName")]
        [Validation(Required=false)]
        public string TargetInstanceName { get; set; }

        [NameInMap("TargetPath")]
        [Validation(Required=false)]
        public string TargetPath { get; set; }

        [NameInMap("TargetPrefix")]
        [Validation(Required=false)]
        public string TargetPrefix { get; set; }

        [NameInMap("TargetTableName")]
        [Validation(Required=false)]
        public string TargetTableName { get; set; }

        [NameInMap("TargetTime")]
        [Validation(Required=false)]
        public long? TargetTime { get; set; }

        [NameInMap("UdmDetail")]
        [Validation(Required=false)]
        public string UdmDetailShrink { get; set; }

        [NameInMap("VaultId")]
        [Validation(Required=false)]
        public string VaultId { get; set; }

    }

}
