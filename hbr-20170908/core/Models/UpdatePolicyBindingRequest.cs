// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class UpdatePolicyBindingRequest : TeaModel {
        /// <summary>
        /// The advanced options.
        /// </summary>
        [NameInMap("AdvancedOptions")]
        [Validation(Required=false)]
        public UpdatePolicyBindingRequestAdvancedOptions AdvancedOptions { get; set; }
        public class UpdatePolicyBindingRequestAdvancedOptions : TeaModel {
            [NameInMap("CommonFileSystemDetail")]
            [Validation(Required=false)]
            public UpdatePolicyBindingRequestAdvancedOptionsCommonFileSystemDetail CommonFileSystemDetail { get; set; }
            public class UpdatePolicyBindingRequestAdvancedOptionsCommonFileSystemDetail : TeaModel {
                [NameInMap("FetchSliceSize")]
                [Validation(Required=false)]
                public long? FetchSliceSize { get; set; }

                [NameInMap("FullOnIncrementFail")]
                [Validation(Required=false)]
                public bool? FullOnIncrementFail { get; set; }

            }

            /// <summary>
            /// The details of the Object Storage Service (OSS) backup.
            /// </summary>
            [NameInMap("OssDetail")]
            [Validation(Required=false)]
            public UpdatePolicyBindingRequestAdvancedOptionsOssDetail OssDetail { get; set; }
            public class UpdatePolicyBindingRequestAdvancedOptionsOssDetail : TeaModel {
                /// <summary>
                /// Specifies whether the system deletes the inventory lists after a backup is complete. This parameter is available only when OSS inventory lists are used. Valid values:
                /// 
                /// *   **NO_CLEANUP**: Does not delete inventory lists.
                /// *   **DELETE_CURRENT**: Deletes the current inventory list.
                /// *   **DELETE_CURRENT_AND_PREVIOUS**: Deletes all inventory lists.
                /// </summary>
                [NameInMap("InventoryCleanupPolicy")]
                [Validation(Required=false)]
                public string InventoryCleanupPolicy { get; set; }

                /// <summary>
                /// The name of the OSS inventory list. The OSS inventory list specified for this parameter is used for performance optimization.
                /// 
                /// *   If you want to back up more than 100 million OSS objects, we recommend that you use inventory lists to accelerate incremental backup. Storage fees for inventory lists are included in your OSS bills.
                /// *   An extended period of time is required for OSS to generate inventory lists. Before inventory lists are generated, OSS objects may fail to be backed up. In this case, you can back up the OSS objects in the next backup cycle.
                /// </summary>
                [NameInMap("InventoryId")]
                [Validation(Required=false)]
                public string InventoryId { get; set; }

            }

            /// <summary>
            /// The backup details of the Elastic Compute Service (ECS) instance.
            /// </summary>
            [NameInMap("UdmDetail")]
            [Validation(Required=false)]
            public UpdatePolicyBindingRequestAdvancedOptionsUdmDetail UdmDetail { get; set; }
            public class UpdatePolicyBindingRequestAdvancedOptionsUdmDetail : TeaModel {
                /// <summary>
                /// Specifies whether to enable application consistency. You can enable application consistency only if all disks are ESSDs.
                /// </summary>
                [NameInMap("AppConsistent")]
                [Validation(Required=false)]
                public bool? AppConsistent { get; set; }

                /// <summary>
                /// The IDs of the disks that require protection. This parameter is not required if all disks require protection.
                /// </summary>
                [NameInMap("DiskIdList")]
                [Validation(Required=false)]
                public List<string> DiskIdList { get; set; }

                /// <summary>
                /// This parameter is required only if the **AppConsistent** parameter is set to **true**. This parameter specifies whether to enable Linux fsfreeze to put file systems into the read-only state before application-consistent snapshots are created. Default value: true.
                /// </summary>
                [NameInMap("EnableFsFreeze")]
                [Validation(Required=false)]
                public bool? EnableFsFreeze { get; set; }

                /// <summary>
                /// This parameter is required only if the **AppConsistent** parameter is set to **true**. This parameter specifies whether to create application-consistent snapshots. Valid values:
                /// 
                /// *   true: creates application-consistent snapshots.
                /// *   false: creates file system-consistent snapshots.
                /// 
                /// Default value: true.
                /// </summary>
                [NameInMap("EnableWriters")]
                [Validation(Required=false)]
                public bool? EnableWriters { get; set; }

                /// <summary>
                /// The IDs of the disks that require no protection. This parameter is not required if the DiskIdList parameter is specified.
                /// </summary>
                [NameInMap("ExcludeDiskIdList")]
                [Validation(Required=false)]
                public List<string> ExcludeDiskIdList { get; set; }

                /// <summary>
                /// This parameter is required only if the **AppConsistent** parameter is set to **true**. This parameter specifies the path of the post-thaw scripts that are executed after application-consistent snapshots are created.
                /// </summary>
                [NameInMap("PostScriptPath")]
                [Validation(Required=false)]
                public string PostScriptPath { get; set; }

                /// <summary>
                /// This parameter is required only if the **AppConsistent** parameter is set to **true**. This parameter specifies the path of the pre-freeze scripts that are executed before application-consistent snapshots are created.
                /// </summary>
                [NameInMap("PreScriptPath")]
                [Validation(Required=false)]
                public string PreScriptPath { get; set; }

                /// <summary>
                /// This parameter is required only if the **AppConsistent** parameter is set to **true**. This parameter specifies the name of the Resource Access Management (RAM) role that is required to create application-consistent snapshots.
                /// </summary>
                [NameInMap("RamRoleName")]
                [Validation(Required=false)]
                public string RamRoleName { get; set; }

                /// <summary>
                /// Specifies whether to create a snapshot-consistent group. You can create a snapshot-consistent group only if all disks are enhanced SSDs (ESSDs).
                /// </summary>
                [NameInMap("SnapshotGroup")]
                [Validation(Required=false)]
                public bool? SnapshotGroup { get; set; }

                /// <summary>
                /// This parameter is required only if the **AppConsistent** parameter is set to **true**. This parameter specifies the I/O freeze timeout period. Default value: 30. Unit: seconds.
                /// </summary>
                [NameInMap("TimeoutInSeconds")]
                [Validation(Required=false)]
                public long? TimeoutInSeconds { get; set; }

            }

        }

        /// <summary>
        /// The ID of the data source.
        /// </summary>
        [NameInMap("DataSourceId")]
        [Validation(Required=false)]
        public string DataSourceId { get; set; }

        /// <summary>
        /// Specifies whether to disable the backup policy for the data source.
        /// 
        /// *   true: disables the backup policy for the data source
        /// *   false: enables the backup policy for the data source
        /// </summary>
        [NameInMap("Disabled")]
        [Validation(Required=false)]
        public bool? Disabled { get; set; }

        /// <summary>
        /// The description of the association.
        /// </summary>
        [NameInMap("PolicyBindingDescription")]
        [Validation(Required=false)]
        public string PolicyBindingDescription { get; set; }

        /// <summary>
        /// The ID of the backup policy.
        /// </summary>
        [NameInMap("PolicyId")]
        [Validation(Required=false)]
        public string PolicyId { get; set; }

        /// <summary>
        /// The type of the data source. Valid values:
        /// 
        /// *   **UDM_ECS**: ECS instance backup
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

    }

}
