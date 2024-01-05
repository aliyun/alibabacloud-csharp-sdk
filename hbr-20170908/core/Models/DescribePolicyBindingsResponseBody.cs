// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class DescribePolicyBindingsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The association between the backup policy and data sources.
        /// </summary>
        [NameInMap("PolicyBindings")]
        [Validation(Required=false)]
        public List<DescribePolicyBindingsResponseBodyPolicyBindings> PolicyBindings { get; set; }
        public class DescribePolicyBindingsResponseBodyPolicyBindings : TeaModel {
            /// <summary>
            /// The advanced options.
            /// </summary>
            [NameInMap("AdvancedOptions")]
            [Validation(Required=false)]
            public DescribePolicyBindingsResponseBodyPolicyBindingsAdvancedOptions AdvancedOptions { get; set; }
            public class DescribePolicyBindingsResponseBodyPolicyBindingsAdvancedOptions : TeaModel {
                [NameInMap("CommonFileSystemDetail")]
                [Validation(Required=false)]
                public DescribePolicyBindingsResponseBodyPolicyBindingsAdvancedOptionsCommonFileSystemDetail CommonFileSystemDetail { get; set; }
                public class DescribePolicyBindingsResponseBodyPolicyBindingsAdvancedOptionsCommonFileSystemDetail : TeaModel {
                    [NameInMap("FetchSliceSize")]
                    [Validation(Required=false)]
                    public long? FetchSliceSize { get; set; }

                    [NameInMap("FullOnIncrementFail")]
                    [Validation(Required=false)]
                    public bool? FullOnIncrementFail { get; set; }

                }

                /// <summary>
                /// The advanced options for on-premises NAS backup.
                /// </summary>
                [NameInMap("CommonNasDetail")]
                [Validation(Required=false)]
                public DescribePolicyBindingsResponseBodyPolicyBindingsAdvancedOptionsCommonNasDetail CommonNasDetail { get; set; }
                public class DescribePolicyBindingsResponseBodyPolicyBindingsAdvancedOptionsCommonNasDetail : TeaModel {
                    /// <summary>
                    /// The ID of the HBR client.
                    /// </summary>
                    [NameInMap("ClientId")]
                    [Validation(Required=false)]
                    public string ClientId { get; set; }

                    [NameInMap("ClusterId")]
                    [Validation(Required=false)]
                    public string ClusterId { get; set; }

                    /// <summary>
                    /// The size of backup shards (the number of files).
                    /// </summary>
                    [NameInMap("FetchSliceSize")]
                    [Validation(Required=false)]
                    public long? FetchSliceSize { get; set; }

                    /// <summary>
                    /// Indicates whether the system performs full backup if incremental backup fails. Valid values:
                    /// 
                    /// *   **true**: The system performs full backup if incremental backup fails.
                    /// *   **false**: The system does not perform full backup if incremental backup fails.
                    /// </summary>
                    [NameInMap("FullOnIncrementFail")]
                    [Validation(Required=false)]
                    public bool? FullOnIncrementFail { get; set; }

                }

                /// <summary>
                /// The advanced options for file backup.
                /// </summary>
                [NameInMap("FileDetail")]
                [Validation(Required=false)]
                public DescribePolicyBindingsResponseBodyPolicyBindingsAdvancedOptionsFileDetail FileDetail { get; set; }
                public class DescribePolicyBindingsResponseBodyPolicyBindingsAdvancedOptionsFileDetail : TeaModel {
                    /// <summary>
                    /// Indicates whether an advanced policy is used. Valid values:
                    /// 
                    /// *   **true**
                    /// *   **false**
                    /// </summary>
                    [NameInMap("AdvPolicy")]
                    [Validation(Required=false)]
                    public bool? AdvPolicy { get; set; }

                    /// <summary>
                    /// Indicates whether the Volume Shadow Copy Service (VSS) feature is enabled. Valid values:
                    /// 
                    /// *   **true**: The feature is enabled.
                    /// *   **false**: The feature is disabled.
                    /// </summary>
                    [NameInMap("UseVSS")]
                    [Validation(Required=false)]
                    public bool? UseVSS { get; set; }

                }

                /// <summary>
                /// The advanced options for OSS backup.
                /// </summary>
                [NameInMap("OssDetail")]
                [Validation(Required=false)]
                public DescribePolicyBindingsResponseBodyPolicyBindingsAdvancedOptionsOssDetail OssDetail { get; set; }
                public class DescribePolicyBindingsResponseBodyPolicyBindingsAdvancedOptionsOssDetail : TeaModel {
                    /// <summary>
                    /// Indicates whether the system deletes the inventory lists when a backup is completed. This parameter is valid only when OSS inventories are used. Valid values:
                    /// 
                    /// *   **NO_CLEANUP**: Inventory lists are not deleted.
                    /// *   **DELETE_CURRENT**: The current inventory list is deleted.
                    /// *   **DELETE_CURRENT_AND_PREVIOUS**: All inventory lists are deleted.
                    /// </summary>
                    [NameInMap("InventoryCleanupPolicy")]
                    [Validation(Required=false)]
                    public string InventoryCleanupPolicy { get; set; }

                    /// <summary>
                    /// The name of the OSS inventory. If this parameter is not empty, the OSS inventory is used for performance optimization.
                    /// 
                    /// *   If you want to back up more than 100 million OSS objects, we recommend that you use inventory lists to accelerate incremental backup. Storage fees for inventory lists are included into your OSS bills.
                    /// *   A certain amount of time is required for OSS to generate inventory lists. Before inventory lists are generated, OSS objects may fail to be backed up. In this case, you can back up the OSS objects in the next backup cycle.
                    /// </summary>
                    [NameInMap("InventoryId")]
                    [Validation(Required=false)]
                    public string InventoryId { get; set; }

                }

                /// <summary>
                /// The advanced options for ECS instance backup.
                /// </summary>
                [NameInMap("UdmDetail")]
                [Validation(Required=false)]
                public DescribePolicyBindingsResponseBodyPolicyBindingsAdvancedOptionsUdmDetail UdmDetail { get; set; }
                public class DescribePolicyBindingsResponseBodyPolicyBindingsAdvancedOptionsUdmDetail : TeaModel {
                    /// <summary>
                    /// Indicates whether application consistency is enabled. You can enable application consistency only if all disks are ESSDs.
                    /// </summary>
                    [NameInMap("AppConsistent")]
                    [Validation(Required=false)]
                    public bool? AppConsistent { get; set; }

                    [NameInMap("DestinationKmsKeyId")]
                    [Validation(Required=false)]
                    public string DestinationKmsKeyId { get; set; }

                    /// <summary>
                    /// The IDs of the disks that need to be protected. If all disks need to be protected, this parameter is empty.
                    /// </summary>
                    [NameInMap("DiskIdList")]
                    [Validation(Required=false)]
                    public List<string> DiskIdList { get; set; }

                    /// <summary>
                    /// This parameter is returned only if **AppConsistent** is set to **true**. This parameter indicates whether Linux fsfreeze is enabled to put file systems into the read-only state before application-consistent snapshots are created. Default value: true.
                    /// </summary>
                    [NameInMap("EnableFsFreeze")]
                    [Validation(Required=false)]
                    public bool? EnableFsFreeze { get; set; }

                    /// <summary>
                    /// This parameter is returned only if **AppConsistent** is set to **true**. This parameter indicates whether application-consistent snapshots are created. Valid values:
                    /// 
                    /// *   true: Application-consistent snapshots are created.
                    /// *   false: File system-consistent snapshots are created.
                    /// 
                    /// Default value: true.
                    /// </summary>
                    [NameInMap("EnableWriters")]
                    [Validation(Required=false)]
                    public bool? EnableWriters { get; set; }

                    /// <summary>
                    /// The IDs of the disks that do not need to be protected. If DiskIdList is not empty, this parameter is ignored.
                    /// </summary>
                    [NameInMap("ExcludeDiskIdList")]
                    [Validation(Required=false)]
                    public List<string> ExcludeDiskIdList { get; set; }

                    /// <summary>
                    /// This parameter is returned only if **AppConsistent** is set to **true**. This parameter indicates the path of the post-thaw scripts that are executed after application-consistent snapshots are created.
                    /// </summary>
                    [NameInMap("PostScriptPath")]
                    [Validation(Required=false)]
                    public string PostScriptPath { get; set; }

                    /// <summary>
                    /// This parameter is returned only if **AppConsistent** is set to **true**. This parameter indicates the path of the pre-freeze scripts that are executed before application-consistent snapshots are created.
                    /// </summary>
                    [NameInMap("PreScriptPath")]
                    [Validation(Required=false)]
                    public string PreScriptPath { get; set; }

                    /// <summary>
                    /// This parameter is returned only if **AppConsistent** is set to **true**. This parameter indicates the name of the RAM role that is required to create application-consistent snapshots.
                    /// </summary>
                    [NameInMap("RamRoleName")]
                    [Validation(Required=false)]
                    public string RamRoleName { get; set; }

                    /// <summary>
                    /// Indicates whether a snapshot-consistent group is created. You can create a snapshot-consistent group only if all disks are enhanced SSDs (ESSDs).
                    /// </summary>
                    [NameInMap("SnapshotGroup")]
                    [Validation(Required=false)]
                    public bool? SnapshotGroup { get; set; }

                    /// <summary>
                    /// This parameter is returned only if **AppConsistent** is set to **true**. This parameter indicates the I/O freeze timeout period. Default value: 30. Unit: seconds.
                    /// </summary>
                    [NameInMap("TimeoutInSeconds")]
                    [Validation(Required=false)]
                    public long? TimeoutInSeconds { get; set; }

                }

            }

            /// <summary>
            /// The time when the backup policy was created. This value is a UNIX timestamp. Unit: seconds.
            /// </summary>
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public long? CreatedTime { get; set; }

            /// <summary>
            /// The name of the RAM role that is created within the source Alibaba Cloud account and assigned to the current Alibaba Cloud account to authorize the current Alibaba Cloud account to back up data across Alibaba Cloud accounts.
            /// </summary>
            [NameInMap("CrossAccountRoleName")]
            [Validation(Required=false)]
            public string CrossAccountRoleName { get; set; }

            /// <summary>
            /// Indicates whether data is backed up within the same Alibaba Cloud account or across Alibaba Cloud accounts. Valid values:
            /// 
            /// *   SELF_ACCOUNT: Data is backed up within the same Alibaba Cloud account.
            /// *   CROSS_ACCOUNT: Data is backed up across Alibaba Cloud accounts.
            /// </summary>
            [NameInMap("CrossAccountType")]
            [Validation(Required=false)]
            public string CrossAccountType { get; set; }

            /// <summary>
            /// The ID of the source Alibaba Cloud account that authorizes the current Alibaba Cloud account to back up data across Alibaba Cloud accounts.
            /// </summary>
            [NameInMap("CrossAccountUserId")]
            [Validation(Required=false)]
            public long? CrossAccountUserId { get; set; }

            /// <summary>
            /// The ID of the data source.
            /// </summary>
            [NameInMap("DataSourceId")]
            [Validation(Required=false)]
            public string DataSourceId { get; set; }

            /// <summary>
            /// Indicates whether the backup policy is enabled for the data source. Valid values:
            /// 
            /// *   true: The backup policy is disabled.
            /// *   false: The backup policy is enabled.
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
            /// The ID of the association.
            /// </summary>
            [NameInMap("PolicyBindingId")]
            [Validation(Required=false)]
            public string PolicyBindingId { get; set; }

            /// <summary>
            /// The policy ID.
            /// </summary>
            [NameInMap("PolicyId")]
            [Validation(Required=false)]
            public string PolicyId { get; set; }

            /// <summary>
            /// The type of the data source. Valid values:
            /// 
            /// *   **UDM_ECS**: ECS instances
            /// </summary>
            [NameInMap("SourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }

            /// <summary>
            /// The time when the backup policy was updated. The value is a UNIX timestamp. Unit: seconds.
            /// </summary>
            [NameInMap("UpdatedTime")]
            [Validation(Required=false)]
            public long? UpdatedTime { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
