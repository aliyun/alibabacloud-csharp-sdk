// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class CreatePolicyBindingsRequest : TeaModel {
        /// <summary>
        /// The data sources that you want to bind to the backup policy.
        /// </summary>
        [NameInMap("PolicyBindingList")]
        [Validation(Required=false)]
        public List<CreatePolicyBindingsRequestPolicyBindingList> PolicyBindingList { get; set; }
        public class CreatePolicyBindingsRequestPolicyBindingList : TeaModel {
            /// <summary>
            /// Advanced options.
            /// </summary>
            [NameInMap("AdvancedOptions")]
            [Validation(Required=false)]
            public CreatePolicyBindingsRequestPolicyBindingListAdvancedOptions AdvancedOptions { get; set; }
            public class CreatePolicyBindingsRequestPolicyBindingListAdvancedOptions : TeaModel {
                [NameInMap("CommonFileSystemDetail")]
                [Validation(Required=false)]
                public CreatePolicyBindingsRequestPolicyBindingListAdvancedOptionsCommonFileSystemDetail CommonFileSystemDetail { get; set; }
                public class CreatePolicyBindingsRequestPolicyBindingListAdvancedOptionsCommonFileSystemDetail : TeaModel {
                    [NameInMap("FetchSliceSize")]
                    [Validation(Required=false)]
                    public long? FetchSliceSize { get; set; }

                    [NameInMap("FullOnIncrementFail")]
                    [Validation(Required=false)]
                    public bool? FullOnIncrementFail { get; set; }

                }

                [NameInMap("CommonNasDetail")]
                [Validation(Required=false)]
                public CreatePolicyBindingsRequestPolicyBindingListAdvancedOptionsCommonNasDetail CommonNasDetail { get; set; }
                public class CreatePolicyBindingsRequestPolicyBindingListAdvancedOptionsCommonNasDetail : TeaModel {
                    [NameInMap("ClusterId")]
                    [Validation(Required=false)]
                    public string ClusterId { get; set; }

                    [NameInMap("FetchSliceSize")]
                    [Validation(Required=false)]
                    public long? FetchSliceSize { get; set; }

                    [NameInMap("FullOnIncrementFail")]
                    [Validation(Required=false)]
                    public bool? FullOnIncrementFail { get; set; }

                }

                [NameInMap("FileDetail")]
                [Validation(Required=false)]
                public CreatePolicyBindingsRequestPolicyBindingListAdvancedOptionsFileDetail FileDetail { get; set; }
                public class CreatePolicyBindingsRequestPolicyBindingListAdvancedOptionsFileDetail : TeaModel {
                    [NameInMap("AdvPolicy")]
                    [Validation(Required=false)]
                    public bool? AdvPolicy { get; set; }

                    [NameInMap("UseVSS")]
                    [Validation(Required=false)]
                    public bool? UseVSS { get; set; }

                }

                /// <summary>
                /// The advanced options for OSS backup.
                /// </summary>
                [NameInMap("OssDetail")]
                [Validation(Required=false)]
                public CreatePolicyBindingsRequestPolicyBindingListAdvancedOptionsOssDetail OssDetail { get; set; }
                public class CreatePolicyBindingsRequestPolicyBindingListAdvancedOptionsOssDetail : TeaModel {
                    /// <summary>
                    /// Whether delete inventory file after backup.
                    /// - **NO_CLEANUP**: Do not delete.
                    /// - **DELETE_CURRENT**: Delete current.
                    /// - **DELETE_CURRENT_AND_PREVIOUS**: Delete all.
                    /// </summary>
                    [NameInMap("InventoryCleanupPolicy")]
                    [Validation(Required=false)]
                    public string InventoryCleanupPolicy { get; set; }

                    /// <summary>
                    /// OSS inventory name.
                    /// - If you want to back up more than 100 million OSS objects, we recommend that you use inventories to accelerate incremental backup. Storage fees for inventory lists are included into your OSS bills.
                    /// - OSS inventory file generation takes time. The backup may fail before the OSS inventory file is generated. You can wait for the next cycle to execute.
                    /// </summary>
                    [NameInMap("InventoryId")]
                    [Validation(Required=false)]
                    public string InventoryId { get; set; }

                }

                /// <summary>
                /// The details of ECS instance backup.
                /// </summary>
                [NameInMap("UdmDetail")]
                [Validation(Required=false)]
                public CreatePolicyBindingsRequestPolicyBindingListAdvancedOptionsUdmDetail UdmDetail { get; set; }
                public class CreatePolicyBindingsRequestPolicyBindingListAdvancedOptionsUdmDetail : TeaModel {
                    /// <summary>
                    /// Specifies whether to enable application consistency. You can enable application consistency only if all disks are ESSDs.
                    /// </summary>
                    [NameInMap("AppConsistent")]
                    [Validation(Required=false)]
                    public bool? AppConsistent { get; set; }

                    /// <summary>
                    /// The IDs of the disks that need to be protected. If all disks need to be protected, this parameter is empty.
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
                    /// The IDs of the disks that do not need to be protected. If the DiskIdList parameter is not empty, this parameter is ignored.
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
                    /// This parameter is required only if the **AppConsistent** parameter is set to **true**. This parameter specifies the name of the RAM role that is required to create application-consistent snapshots.
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
            /// The name of the RAM role that is created within the source Alibaba Cloud account and assigned to the current Alibaba Cloud account to authorize the current Alibaba Cloud account to back up data across Alibaba Cloud accounts.
            /// </summary>
            [NameInMap("CrossAccountRoleName")]
            [Validation(Required=false)]
            public string CrossAccountRoleName { get; set; }

            /// <summary>
            /// Specifies whether data is backed up and restored within the same Alibaba Cloud account or across Alibaba Cloud accounts. Valid values:
            /// 
            /// *   SELF_ACCOUNT: Data is backed up and restored within the same Alibaba Cloud account.
            /// *   CROSS_ACCOUNT: Data is backed up and restored across Alibaba Cloud accounts.
            /// </summary>
            [NameInMap("CrossAccountType")]
            [Validation(Required=false)]
            public string CrossAccountType { get; set; }

            /// <summary>
            /// The source Alibaba Cloud account ID when backup across Alibaba Cloud accounts.
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
            /// The description of the association.
            /// </summary>
            [NameInMap("PolicyBindingDescription")]
            [Validation(Required=false)]
            public string PolicyBindingDescription { get; set; }

            /// <summary>
            /// The prefix of the path to the folder that you want to back up. By default, the entire OSS bucket is backed up.
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// The type of the data source. Valid values:
            /// 
            /// *   **UDM_ECS**: ECS instance backup
            /// </summary>
            [NameInMap("SourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }

        }

        /// <summary>
        /// The ID of the backup policy.
        /// </summary>
        [NameInMap("PolicyId")]
        [Validation(Required=false)]
        public string PolicyId { get; set; }

    }

}
