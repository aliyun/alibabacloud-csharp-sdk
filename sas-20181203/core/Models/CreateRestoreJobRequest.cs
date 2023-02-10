// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CreateRestoreJobRequest : TeaModel {
        /// <summary>
        /// The directory in which the files included in the restoration task are located. This parameter is specified when you create the anti-ransomware policy. The value is a directory that requires protection.
        /// </summary>
        [NameInMap("Includes")]
        [Validation(Required=false)]
        public string Includes { get; set; }

        /// <summary>
        /// The hash value of the snapshot.
        /// 
        /// > You can call the [DescribeSnapshots](~~DescribeSnapshots~~) operation to obtain the value of this parameter.
        /// </summary>
        [NameInMap("SnapshotHash")]
        [Validation(Required=false)]
        public string SnapshotHash { get; set; }

        /// <summary>
        /// The ID of the snapshot that you want to use for restoration.
        /// 
        /// > You can call the [DescribeSnapshots](~~DescribeSnapshots~~) operation to obtain the value of this parameter.
        /// </summary>
        [NameInMap("SnapshotId")]
        [Validation(Required=false)]
        public string SnapshotId { get; set; }

        /// <summary>
        /// The version of the backup data.
        /// 
        /// > You can call the [DescribeSnapshots](~~DescribeSnapshots~~) operation to obtain the value of this parameter.
        /// </summary>
        [NameInMap("SnapshotVersion")]
        [Validation(Required=false)]
        public string SnapshotVersion { get; set; }

        /// <summary>
        /// The type of the data source. Valid values:
        /// 
        /// *   **ECS_FILE**: backup snapshots for Elastic Compute Service (ECS) files
        /// *   **File**: backup snapshots for on-premises servers
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// The path to which you want to restore data.
        /// </summary>
        [NameInMap("Target")]
        [Validation(Required=false)]
        public string Target { get; set; }

        /// <summary>
        /// The UUID of the server whose data you want to restore.
        /// </summary>
        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

        /// <summary>
        /// The ID of the backup vault that is used in the restoration task.
        /// 
        /// > You can call the [DescribeSnapshots](~~DescribeSnapshots~~) operation to obtain the value of this parameter.
        /// </summary>
        [NameInMap("VaultId")]
        [Validation(Required=false)]
        public string VaultId { get; set; }

    }

}
