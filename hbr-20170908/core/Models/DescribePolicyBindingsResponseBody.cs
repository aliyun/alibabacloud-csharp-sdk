// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class DescribePolicyBindingsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0a</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The association between the backup policy and data sources.</para>
        /// </summary>
        [NameInMap("PolicyBindings")]
        [Validation(Required=false)]
        public List<DescribePolicyBindingsResponseBodyPolicyBindings> PolicyBindings { get; set; }
        public class DescribePolicyBindingsResponseBodyPolicyBindings : TeaModel {
            /// <summary>
            /// <para>The advanced options.</para>
            /// </summary>
            [NameInMap("AdvancedOptions")]
            [Validation(Required=false)]
            public DescribePolicyBindingsResponseBodyPolicyBindingsAdvancedOptions AdvancedOptions { get; set; }
            public class DescribePolicyBindingsResponseBodyPolicyBindingsAdvancedOptions : TeaModel {
                /// <summary>
                /// <para>The advanced options for large-scale file system backup.</para>
                /// </summary>
                [NameInMap("CommonFileSystemDetail")]
                [Validation(Required=false)]
                public DescribePolicyBindingsResponseBodyPolicyBindingsAdvancedOptionsCommonFileSystemDetail CommonFileSystemDetail { get; set; }
                public class DescribePolicyBindingsResponseBodyPolicyBindingsAdvancedOptionsCommonFileSystemDetail : TeaModel {
                    /// <summary>
                    /// <para>The size of backup shards (the number of files).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100000</para>
                    /// </summary>
                    [NameInMap("FetchSliceSize")]
                    [Validation(Required=false)]
                    public long? FetchSliceSize { get; set; }

                    /// <summary>
                    /// <para>Specifies whether the system performs full backup if incremental backup fails. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>true</b>: The system performs full backup if incremental backup fails.</description></item>
                    /// <item><description><b>false</b>: The system does not perform full backup if incremental backup fails.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("FullOnIncrementFail")]
                    [Validation(Required=false)]
                    public bool? FullOnIncrementFail { get; set; }

                }

                /// <summary>
                /// <para>The advanced options for on-premises NAS backup.</para>
                /// </summary>
                [NameInMap("CommonNasDetail")]
                [Validation(Required=false)]
                public DescribePolicyBindingsResponseBodyPolicyBindingsAdvancedOptionsCommonNasDetail CommonNasDetail { get; set; }
                public class DescribePolicyBindingsResponseBodyPolicyBindingsAdvancedOptionsCommonNasDetail : TeaModel {
                    /// <summary>
                    /// <para>The ID of the Cloud Backup client.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>c-0001eg6mcvjs93f46s2d</para>
                    /// </summary>
                    [NameInMap("ClientId")]
                    [Validation(Required=false)]
                    public string ClientId { get; set; }

                    /// <summary>
                    /// <para>The ID of the client group.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cl-000gkcofngi04j6k680a</para>
                    /// </summary>
                    [NameInMap("ClusterId")]
                    [Validation(Required=false)]
                    public string ClusterId { get; set; }

                    /// <summary>
                    /// <para>The size of backup shards (the number of files).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100000</para>
                    /// </summary>
                    [NameInMap("FetchSliceSize")]
                    [Validation(Required=false)]
                    public long? FetchSliceSize { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the system performs full backup if incremental backup fails. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>true</b>: The system performs full backup if incremental backup fails.</description></item>
                    /// <item><description><b>false</b>: The system does not perform full backup if incremental backup fails.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("FullOnIncrementFail")]
                    [Validation(Required=false)]
                    public bool? FullOnIncrementFail { get; set; }

                }

                /// <summary>
                /// <para>The advanced options for file backup.</para>
                /// </summary>
                [NameInMap("FileDetail")]
                [Validation(Required=false)]
                public DescribePolicyBindingsResponseBodyPolicyBindingsAdvancedOptionsFileDetail FileDetail { get; set; }
                public class DescribePolicyBindingsResponseBodyPolicyBindingsAdvancedOptionsFileDetail : TeaModel {
                    /// <summary>
                    /// <para>Indicates whether an advanced policy is used. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>true</b></description></item>
                    /// <item><description><b>false</b></description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("AdvPolicy")]
                    [Validation(Required=false)]
                    public bool? AdvPolicy { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the Volume Shadow Copy Service (VSS) feature is enabled. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>true</b>: The feature is enabled.</description></item>
                    /// <item><description><b>false</b>: The feature is disabled.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("UseVSS")]
                    [Validation(Required=false)]
                    public bool? UseVSS { get; set; }

                }

                /// <summary>
                /// <para>The advanced options for OSS backup.</para>
                /// </summary>
                [NameInMap("OssDetail")]
                [Validation(Required=false)]
                public DescribePolicyBindingsResponseBodyPolicyBindingsAdvancedOptionsOssDetail OssDetail { get; set; }
                public class DescribePolicyBindingsResponseBodyPolicyBindingsAdvancedOptionsOssDetail : TeaModel {
                    /// <summary>
                    /// <para>不在任务统计和失败文件列表中提示归档型对象</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("IgnoreArchiveObject")]
                    [Validation(Required=false)]
                    public bool? IgnoreArchiveObject { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the system deletes the inventory lists when a backup is completed. This parameter is valid only when OSS inventories are used. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>NO_CLEANUP</b>: Inventory lists are not deleted.</description></item>
                    /// <item><description><b>DELETE_CURRENT</b>: The current inventory list is deleted.</description></item>
                    /// <item><description><b>DELETE_CURRENT_AND_PREVIOUS</b>: All inventory lists are deleted.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>DELETE_CURRENT_AND_PREVIOUS</para>
                    /// </summary>
                    [NameInMap("InventoryCleanupPolicy")]
                    [Validation(Required=false)]
                    public string InventoryCleanupPolicy { get; set; }

                    /// <summary>
                    /// <para>The name of the OSS inventory. If this parameter is not empty, the OSS inventory is used for performance optimization.</para>
                    /// <list type="bullet">
                    /// <item><description>If you want to back up more than 100 million OSS objects, we recommend that you use inventory lists to accelerate incremental backup. Storage fees for inventory lists are included into your OSS bills.</description></item>
                    /// <item><description>A certain amount of time is required for OSS to generate inventory lists. Before inventory lists are generated, OSS objects may fail to be backed up. In this case, you can back up the OSS objects in the next backup cycle.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>inventory_test</para>
                    /// </summary>
                    [NameInMap("InventoryId")]
                    [Validation(Required=false)]
                    public string InventoryId { get; set; }

                }

                /// <summary>
                /// <para>The advanced options for ECS instance backup.</para>
                /// </summary>
                [NameInMap("UdmDetail")]
                [Validation(Required=false)]
                public DescribePolicyBindingsResponseBodyPolicyBindingsAdvancedOptionsUdmDetail UdmDetail { get; set; }
                public class DescribePolicyBindingsResponseBodyPolicyBindingsAdvancedOptionsUdmDetail : TeaModel {
                    /// <summary>
                    /// <para>Indicates whether application consistency is enabled. You can enable application consistency only if all disks are ESSDs.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("AppConsistent")]
                    [Validation(Required=false)]
                    public bool? AppConsistent { get; set; }

                    /// <summary>
                    /// <para>The ID of the custom KMS key in the destination region. If this parameter is not empty and geo-replication is enabled, the key is used for encrypted geo-replication.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>4ed37b1e-da51-4187-aceb-9db4f9b7148b</para>
                    /// </summary>
                    [NameInMap("DestinationKmsKeyId")]
                    [Validation(Required=false)]
                    public string DestinationKmsKeyId { get; set; }

                    /// <summary>
                    /// <para>The IDs of the disks that need to be protected. If all disks need to be protected, this parameter is empty.</para>
                    /// </summary>
                    [NameInMap("DiskIdList")]
                    [Validation(Required=false)]
                    public List<string> DiskIdList { get; set; }

                    /// <summary>
                    /// <para>This parameter is required only if you set the <b>AppConsistent</b> parameter to <b>true</b>. This parameter indicates whether to enable Linux fsfreeze to put file systems into the read-only state before application-consistent snapshots are created. Default value: true.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("EnableFsFreeze")]
                    [Validation(Required=false)]
                    public bool? EnableFsFreeze { get; set; }

                    /// <summary>
                    /// <para>This parameter is required only if you set the <b>AppConsistent</b> parameter to <b>true</b>. This parameter indicates whether application-consistent snapshots are created. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>true: Application-consistent snapshots are created.</description></item>
                    /// <item><description>false: File system-consistent snapshots are created.</description></item>
                    /// </list>
                    /// <para>Default value: true.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("EnableWriters")]
                    [Validation(Required=false)]
                    public bool? EnableWriters { get; set; }

                    /// <summary>
                    /// <para>The IDs of the disks that do not need to be protected. If the DiskIdList parameter is not empty, this parameter is ignored.</para>
                    /// </summary>
                    [NameInMap("ExcludeDiskIdList")]
                    [Validation(Required=false)]
                    public List<string> ExcludeDiskIdList { get; set; }

                    /// <summary>
                    /// <para>This parameter is required only if you set the <b>AppConsistent</b> parameter to <b>true</b>. This parameter indicates the path of the post-thaw scripts that are executed after application-consistent snapshots are created.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>/tmp/postscript.sh</para>
                    /// </summary>
                    [NameInMap("PostScriptPath")]
                    [Validation(Required=false)]
                    public string PostScriptPath { get; set; }

                    /// <summary>
                    /// <para>This parameter is required only if you set the <b>AppConsistent</b> parameter to <b>true</b>. This parameter indicates the path of the pre-freeze scripts that are executed before application-consistent snapshots are created.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>/tmp/prescript.sh</para>
                    /// </summary>
                    [NameInMap("PreScriptPath")]
                    [Validation(Required=false)]
                    public string PreScriptPath { get; set; }

                    /// <summary>
                    /// <para>This parameter is required only if you set the <b>AppConsistent</b> parameter to <b>true</b>. This parameter indicates the name of the RAM role that is required to create application-consistent snapshots.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>AliyunECSInstanceForHbrRole</para>
                    /// </summary>
                    [NameInMap("RamRoleName")]
                    [Validation(Required=false)]
                    public string RamRoleName { get; set; }

                    /// <summary>
                    /// <para>Indicates whether a snapshot-consistent group is created. You can create a snapshot-consistent group only if all disks are enhanced SSDs (ESSDs).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("SnapshotGroup")]
                    [Validation(Required=false)]
                    public bool? SnapshotGroup { get; set; }

                    /// <summary>
                    /// <para>This parameter is required only if you set the <b>AppConsistent</b> parameter to <b>true</b>. This parameter indicates the I/O freeze timeout period. Default value: 30. Unit: seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>30</para>
                    /// </summary>
                    [NameInMap("TimeoutInSeconds")]
                    [Validation(Required=false)]
                    public long? TimeoutInSeconds { get; set; }

                }

            }

            /// <summary>
            /// <para>Indicates whether the resource is automatically associated with the related resource tag in the backup policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("CreatedByTag")]
            [Validation(Required=false)]
            public bool? CreatedByTag { get; set; }

            /// <summary>
            /// <para>The time when the backup policy was created. The value is a UNIX timestamp. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1661399570</para>
            /// </summary>
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public long? CreatedTime { get; set; }

            /// <summary>
            /// <para>The name of the RAM role that is created within the source Alibaba Cloud account and assigned to the current Alibaba Cloud account to authorize the current Alibaba Cloud account to back up data across Alibaba Cloud accounts.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hbrcrossrole</para>
            /// </summary>
            [NameInMap("CrossAccountRoleName")]
            [Validation(Required=false)]
            public string CrossAccountRoleName { get; set; }

            /// <summary>
            /// <para>Indicates whether data is backed up within the same Alibaba Cloud account or across Alibaba Cloud accounts. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>SELF_ACCOUNT: Data is backed up within the same Alibaba Cloud account.</description></item>
            /// <item><description>CROSS_ACCOUNT: Data is backed up across Alibaba Cloud accounts.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CROSS_ACCOUNT</para>
            /// </summary>
            [NameInMap("CrossAccountType")]
            [Validation(Required=false)]
            public string CrossAccountType { get; set; }

            /// <summary>
            /// <para>The ID of the source Alibaba Cloud account that authorizes the current Alibaba Cloud account to back up data across Alibaba Cloud accounts.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1480************</para>
            /// </summary>
            [NameInMap("CrossAccountUserId")]
            [Validation(Required=false)]
            public long? CrossAccountUserId { get; set; }

            /// <summary>
            /// <para>The ID of the data source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-8vb************5ly</para>
            /// </summary>
            [NameInMap("DataSourceId")]
            [Validation(Required=false)]
            public string DataSourceId { get; set; }

            /// <summary>
            /// <para>Indicates whether the backup policy is enabled for the data source. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: The backup policy is disabled.</description></item>
            /// <item><description>false: The backup policy is enabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Disabled")]
            [Validation(Required=false)]
            public bool? Disabled { get; set; }

            /// <summary>
            /// <para>This parameter is required only if you set the <b>SourceType</b> parameter to <b>ECS_FILE</b> or <b>File</b>. This parameter specifies the type of files that do not need to be backed up. No files of the specified type are backed up. The value can be up to 255 characters in length.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[\&quot;<em>.doc\&quot;,\&quot;</em>.xltm\&quot;]</para>
            /// </summary>
            [NameInMap("Exclude")]
            [Validation(Required=false)]
            public string Exclude { get; set; }

            /// <summary>
            /// <para>The matched tag rules.</para>
            /// </summary>
            [NameInMap("HitTags")]
            [Validation(Required=false)]
            public List<DescribePolicyBindingsResponseBodyPolicyBindingsHitTags> HitTags { get; set; }
            public class DescribePolicyBindingsResponseBodyPolicyBindingsHitTags : TeaModel {
                /// <summary>
                /// <para>The tag key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>env</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag-based matching rule.</para>
                /// <list type="bullet">
                /// <item><description><b>EQUAL</b>: Both the tag key and tag value are matched.</description></item>
                /// <item><description><b>NOT</b>: The tag key is matched and the tag value is not matched.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>EQUAL</para>
                /// </summary>
                [NameInMap("Operator")]
                [Validation(Required=false)]
                public string Operator { get; set; }

                /// <summary>
                /// <para>The tag value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>prod</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>This parameter is required only if you set the <b>SourceType</b> parameter to <b>ECS_FILE</b> or <b>File</b>. This parameter specifies the type of files to be backed up. All files of the specified type are backed up. The value can be up to 255 characters in length.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[\&quot;<em>.doc\&quot;,\&quot;</em>.xltm\&quot;]</para>
            /// </summary>
            [NameInMap("Include")]
            [Validation(Required=false)]
            public string Include { get; set; }

            /// <summary>
            /// <para>The description of the association.</para>
            /// 
            /// <b>Example:</b>
            /// <para>po-000<b><b><b><b><b><b>eslc-i-uf6</b></b></b></b></b></b>y5g</para>
            /// </summary>
            [NameInMap("PolicyBindingDescription")]
            [Validation(Required=false)]
            public string PolicyBindingDescription { get; set; }

            /// <summary>
            /// <para>The ID of the association.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pd-000************slc</para>
            /// </summary>
            [NameInMap("PolicyBindingId")]
            [Validation(Required=false)]
            public string PolicyBindingId { get; set; }

            /// <summary>
            /// <para>The ID of the backup policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>po-000************56y</para>
            /// </summary>
            [NameInMap("PolicyId")]
            [Validation(Required=false)]
            public string PolicyId { get; set; }

            /// <summary>
            /// <list type="bullet">
            /// <item><description>If the SourceType parameter is set to <b>OSS</b>, set the Source parameter to the prefix of the path to the folder that you want to back up. If you do not specify the Source parameter, the entire bucket (root directory) is backed up.</description></item>
            /// <item><description>If the SourceType parameter is set to <b>ECS_FILE</b> or <b>File</b>, set the Source parameter to the path to the files that you want to back up. If you do not specify the Source parameter, all paths backed up.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>backup/</para>
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <para>The type of the data source. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>UDM_ECS</b>: ECS instances</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>UDM_ECS</para>
            /// </summary>
            [NameInMap("SourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }

            /// <summary>
            /// <para>This parameter is required only if you set the <b>SourceType</b> parameter to <b>ECS_FILE</b> or <b>File</b>. This parameter specifies the throttling rules. Format: <c>{start}{end}{bandwidth}</c>. Separate multiple throttling rules with vertical bars (|). The time ranges of the throttling rules cannot overlap.</para>
            /// <list type="bullet">
            /// <item><description><b>start</b>: the start hour.</description></item>
            /// <item><description><b>end</b>: the end hour.</description></item>
            /// <item><description><b>bandwidth</b>: the bandwidth. Unit: KB/s.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0:24:10240</para>
            /// </summary>
            [NameInMap("SpeedLimit")]
            [Validation(Required=false)]
            public string SpeedLimit { get; set; }

            /// <summary>
            /// <para>The time when the backup policy was updated. The value is a UNIX timestamp. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1653611573</para>
            /// </summary>
            [NameInMap("UpdatedTime")]
            [Validation(Required=false)]
            public long? UpdatedTime { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5225929A-4EBD-55EE-9FE1-4A130E582A76</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>38</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
