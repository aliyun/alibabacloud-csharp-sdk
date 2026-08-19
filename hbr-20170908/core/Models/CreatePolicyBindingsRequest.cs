// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class CreatePolicyBindingsRequest : TeaModel {
        /// <summary>
        /// <para>The list of policy bindings.</para>
        /// </summary>
        [NameInMap("PolicyBindingList")]
        [Validation(Required=false)]
        public List<CreatePolicyBindingsRequestPolicyBindingList> PolicyBindingList { get; set; }
        public class CreatePolicyBindingsRequestPolicyBindingList : TeaModel {
            /// <summary>
            /// <para>The advanced options.</para>
            /// </summary>
            [NameInMap("AdvancedOptions")]
            [Validation(Required=false)]
            public CreatePolicyBindingsRequestPolicyBindingListAdvancedOptions AdvancedOptions { get; set; }
            public class CreatePolicyBindingsRequestPolicyBindingListAdvancedOptions : TeaModel {
                /// <summary>
                /// <para>The advanced options for CPFS backup.</para>
                /// </summary>
                [NameInMap("CommonFileSystemDetail")]
                [Validation(Required=false)]
                public CreatePolicyBindingsRequestPolicyBindingListAdvancedOptionsCommonFileSystemDetail CommonFileSystemDetail { get; set; }
                public class CreatePolicyBindingsRequestPolicyBindingListAdvancedOptionsCommonFileSystemDetail : TeaModel {
                    /// <summary>
                    /// <para>The sub-task slice size (number of files).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100000</para>
                    /// </summary>
                    [NameInMap("FetchSliceSize")]
                    [Validation(Required=false)]
                    public long? FetchSliceSize { get; set; }

                    /// <summary>
                    /// <para>Specifies whether to switch to a full backup when an incremental backup fails. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>true</b>: Switch to a full backup on failure.</description></item>
                    /// <item><description><b>false</b>: Do not switch to a full backup on failure.</description></item>
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
                public CreatePolicyBindingsRequestPolicyBindingListAdvancedOptionsCommonNasDetail CommonNasDetail { get; set; }
                public class CreatePolicyBindingsRequestPolicyBindingListAdvancedOptionsCommonNasDetail : TeaModel {
                    /// <summary>
                    /// <para>The backup client group ID. On-premises NAS backup selects a client from the backup client group to perform the backup.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cl-000**************ggu</para>
                    /// </summary>
                    [NameInMap("ClusterId")]
                    [Validation(Required=false)]
                    public string ClusterId { get; set; }

                    /// <summary>
                    /// <para>The sub-task slice size (number of files).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100000</para>
                    /// </summary>
                    [NameInMap("FetchSliceSize")]
                    [Validation(Required=false)]
                    public long? FetchSliceSize { get; set; }

                    /// <summary>
                    /// <para>Specifies whether to switch to a full backup when an incremental backup fails. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>true</b>: Switch to a full backup on failure.</description></item>
                    /// <item><description><b>false</b>: Do not switch to a full backup on failure.</description></item>
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
                public CreatePolicyBindingsRequestPolicyBindingListAdvancedOptionsFileDetail FileDetail { get; set; }
                public class CreatePolicyBindingsRequestPolicyBindingListAdvancedOptionsFileDetail : TeaModel {
                    /// <summary>
                    /// <para>Specifies whether to use an advanced policy. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>true</b>: Use.</description></item>
                    /// <item><description><b>false</b>: Do not use.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("AdvPolicy")]
                    [Validation(Required=false)]
                    public bool? AdvPolicy { get; set; }

                    /// <summary>
                    /// <para>Specifies whether to enable the Volume Shadow Copy Service (VSS) feature (Windows). Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>true</b>: Enabled.</description></item>
                    /// <item><description><b>false</b>: Disabled.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
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
                public CreatePolicyBindingsRequestPolicyBindingListAdvancedOptionsOssDetail OssDetail { get; set; }
                public class CreatePolicyBindingsRequestPolicyBindingListAdvancedOptionsOssDetail : TeaModel {
                    /// <summary>
                    /// <para>Specifies whether to exclude archive objects from job statistics and failed file lists.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("IgnoreArchiveObject")]
                    [Validation(Required=false)]
                    public bool? IgnoreArchiveObject { get; set; }

                    /// <summary>
                    /// <para>Specifies whether to delete inventory files after backup. This parameter takes effect only when OSS inventory is used. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>NO_CLEANUP</b>: Do not delete.</description></item>
                    /// <item><description><b>DELETE_CURRENT</b>: Delete the current file.</description></item>
                    /// <item><description><b>DELETE_CURRENT_AND_PREVIOUS</b>: Delete all files.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>NO_CLEANUP</para>
                    /// </summary>
                    [NameInMap("InventoryCleanupPolicy")]
                    [Validation(Required=false)]
                    public string InventoryCleanupPolicy { get; set; }

                    /// <summary>
                    /// <para>The OSS inventory name. When this value is not empty, the OSS inventory is used for performance optimization.</para>
                    /// <list type="bullet">
                    /// <item><description>Using an inventory is recommended for backing up more than 100 million OSS objects to improve incremental performance. Storage fees generated by inventory files are charged separately by OSS.</description></item>
                    /// <item><description>OSS inventory files take time to generate. Backup jobs may fail before the inventory files are generated. Wait for the next backup cycle.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>oss-inventory-default</para>
                    /// </summary>
                    [NameInMap("InventoryId")]
                    [Validation(Required=false)]
                    public string InventoryId { get; set; }

                }

                /// <summary>
                /// <para>The advanced options for ECS full server backup.</para>
                /// </summary>
                [NameInMap("UdmDetail")]
                [Validation(Required=false)]
                public CreatePolicyBindingsRequestPolicyBindingListAdvancedOptionsUdmDetail UdmDetail { get; set; }
                public class CreatePolicyBindingsRequestPolicyBindingListAdvancedOptionsUdmDetail : TeaModel {
                    /// <summary>
                    /// <para>Specifies whether to create an application-consistent snapshot. Application-consistent snapshots are supported only when all cloud disk types are ESSD.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("AppConsistent")]
                    [Validation(Required=false)]
                    public bool? AppConsistent { get; set; }

                    /// <summary>
                    /// <para>The list of cloud disk IDs that need to be protected. Leave this value empty to protect all cloud disks.</para>
                    /// </summary>
                    [NameInMap("DiskIdList")]
                    [Validation(Required=false)]
                    public List<string> DiskIdList { get; set; }

                    /// <summary>
                    /// <para>This parameter is required only when <b>AppConsistent</b> is set to <b>true</b>. Specifies whether to use the Linux FsFreeze mechanism to ensure the file system is in read consistency before creating an application-consistent snapshot. Default value: true.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("EnableFsFreeze")]
                    [Validation(Required=false)]
                    public bool? EnableFsFreeze { get; set; }

                    /// <summary>
                    /// <para>This parameter is required only when <b>AppConsistent</b> is set to <b>true</b>. Specifies whether to create an application-consistent snapshot:</para>
                    /// <list type="bullet">
                    /// <item><description>true: Creates an application-consistent snapshot.</description></item>
                    /// <item><description>false: Creates a file system-consistent snapshot.</description></item>
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
                    /// <para>The list of cloud disk IDs that do not need to be protected. This parameter is ignored when DiskIdList is not empty.</para>
                    /// </summary>
                    [NameInMap("ExcludeDiskIdList")]
                    [Validation(Required=false)]
                    public List<string> ExcludeDiskIdList { get; set; }

                    /// <summary>
                    /// <para>This parameter is required only when <b>AppConsistent</b> is set to <b>true</b>. The path of the post-thaw script to run after creating an application-consistent snapshot.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>/tmp/postscript.sh</para>
                    /// </summary>
                    [NameInMap("PostScriptPath")]
                    [Validation(Required=false)]
                    public string PostScriptPath { get; set; }

                    /// <summary>
                    /// <para>This parameter is required only when <b>AppConsistent</b> is set to <b>true</b>. The path of the pre-freeze script to run before creating an application-consistent snapshot.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>/tmp/prescript.sh</para>
                    /// </summary>
                    [NameInMap("PreScriptPath")]
                    [Validation(Required=false)]
                    public string PreScriptPath { get; set; }

                    /// <summary>
                    /// <para>This parameter is required only when <b>AppConsistent</b> is set to <b>true</b>. The RAM role name required for creating application-consistent snapshots.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>AliyunECSInstanceForHbrRole</para>
                    /// </summary>
                    [NameInMap("RamRoleName")]
                    [Validation(Required=false)]
                    public string RamRoleName { get; set; }

                    /// <summary>
                    /// <para>Specifies whether to create a snapshot-consistent group. Snapshot-consistent groups are supported only when all cloud disk types are ESSD.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("SnapshotGroup")]
                    [Validation(Required=false)]
                    public bool? SnapshotGroup { get; set; }

                    /// <summary>
                    /// <para>This parameter is required only when <b>AppConsistent</b> is set to <b>true</b>. The I/O freeze timeout period, in seconds. Default value: 30.</para>
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
            /// <para>The RAM role name created in the source account for cross-account backup.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hbrcrossrole</para>
            /// </summary>
            [NameInMap("CrossAccountRoleName")]
            [Validation(Required=false)]
            public string CrossAccountRoleName { get; set; }

            /// <summary>
            /// <para>The cross-account backup type. Default value: SELF_ACCOUNT. Valid values: </para>
            /// <list type="bullet">
            /// <item><description><b>SELF_ACCOUNT</b>: Backup within the same account.</description></item>
            /// <item><description><b>CROSS_ACCOUNT</b>: Cross-account backup.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SELF_ACCOUNT</para>
            /// </summary>
            [NameInMap("CrossAccountType")]
            [Validation(Required=false)]
            public string CrossAccountType { get; set; }

            /// <summary>
            /// <para>The Alibaba Cloud UID of the source account for cross-account backup.</para>
            /// 
            /// <b>Example:</b>
            /// <para>144**********732</para>
            /// </summary>
            [NameInMap("CrossAccountUserId")]
            [Validation(Required=false)]
            public long? CrossAccountUserId { get; set; }

            /// <summary>
            /// <para>The data source ID. The value has different meanings depending on the <b>SourceType</b> field:</para>
            /// <list type="bullet">
            /// <item><description><b>UDM_ECS</b>: The ECS instance ID.</description></item>
            /// <item><description><b>OSS</b>: The OSS bucket name.</description></item>
            /// <item><description><b>NAS</b>: The Alibaba Cloud NAS file system ID.</description></item>
            /// <item><description><b>COMMON_NAS</b>: The on-premises NAS instance ID.</description></item>
            /// <item><description><b>ECS_FILE</b>: The ECS instance ID.</description></item>
            /// <item><description><b>File</b>: The Cloud Backup client ID.</description></item>
            /// <item><description><b>COMMON_FILE_SYSTEM</b>: The CPFS backup data source ID.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>i-bp1************dl8</para>
            /// </summary>
            [NameInMap("DataSourceId")]
            [Validation(Required=false)]
            public string DataSourceId { get; set; }

            /// <summary>
            /// <para>Specifies whether the policy is suspended for this data source.</para>
            /// <list type="bullet">
            /// <item><description>true: Suspended.</description></item>
            /// <item><description>false: Not suspended.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Disabled")]
            [Validation(Required=false)]
            public string Disabled { get; set; }

            /// <summary>
            /// <para>This parameter can be configured when <b>SourceType</b> is set to <b>ECS_FILE</b>, <b>File</b>, <b>NAS</b>, <b>COMMON_NAS</b>, or <b>COMMON_FILE_SYSTEM</b>. Specifies the file types to exclude from the backup. All files of these types are not backed up. The value can be up to 255 characters in length.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[\&quot;<em>.doc\&quot;,\&quot;</em>.xltm\&quot;]</para>
            /// </summary>
            [NameInMap("Exclude")]
            [Validation(Required=false)]
            public string Exclude { get; set; }

            /// <summary>
            /// <para>This parameter can be configured when <b>SourceType</b> is set to <b>ECS_FILE</b>, <b>File</b>, <b>NAS</b>, <b>COMMON_NAS</b>, or <b>COMMON_FILE_SYSTEM</b>. Specifies the file types to include in the backup. All files of these types are backed up. The value can be up to 255 characters in length.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[\&quot;<em>.doc\&quot;,\&quot;</em>.xltm\&quot;]</para>
            /// </summary>
            [NameInMap("Include")]
            [Validation(Required=false)]
            public string Include { get; set; }

            /// <summary>
            /// <para>The description of the policy binding.</para>
            /// 
            /// <b>Example:</b>
            /// <para>This is a description of the policy binding</para>
            /// </summary>
            [NameInMap("PolicyBindingDescription")]
            [Validation(Required=false)]
            public string PolicyBindingDescription { get; set; }

            /// <summary>
            /// <para>The value has different meanings depending on the SourceType value:</para>
            /// <list type="bullet">
            /// <item><description><b>OSS</b>: The prefix to back up. If not specified, the entire bucket root directory is backed up. Only a single prefix is supported. To back up /backup, specify /backup.</description></item>
            /// <item><description><b>ECS_FILE</b>: The file directories to back up. If not specified, all directories are backed up. Multiple directories are supported. To back up files under /a and /b, specify [&quot;/a&quot;, &quot;/b&quot;].</description></item>
            /// <item><description><b>File</b>: The file directories to back up. If not specified, all directories are backed up. Multiple directories are supported. To back up files under /a and /b, specify [&quot;/a&quot;, &quot;/b&quot;].</description></item>
            /// <item><description><b>COMMON_FILE_SYSTEM</b>: Required. The source paths to back up. Multiple paths are supported. To back up /a and /b, specify [&quot;/a&quot;, &quot;/b&quot;]. To back up the root path, specify [&quot;/&quot;].</description></item>
            /// <item><description><b>COMMON_NAS</b>: Required. The source path to back up. Only a single path is supported. To back up /a, specify [&quot;/a&quot;]. To back up the root path, specify [&quot;/&quot;].</description></item>
            /// <item><description><b>OTS</b>: The list of data tables to back up. If not specified, all data tables are backed up. Multiple data tables are supported. To back up tables a and b, specify [&quot;a&quot;, &quot;b&quot;].</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>backup/</para>
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <para>The data source type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>UDM_ECS</b>: ECS full server backup.</description></item>
            /// <item><description><b>OSS</b>: OSS backup.</description></item>
            /// <item><description><b>NAS</b>: Alibaba Cloud NAS backup.</description></item>
            /// <item><description><b>COMMON_NAS</b>: On-premises NAS backup.</description></item>
            /// <item><description><b>ECS_FILE</b>: ECS File Backup Essential Edition.</description></item>
            /// <item><description><b>File</b>: On-premises file backup.</description></item>
            /// <item><description><b>COMMON_FILE_SYSTEM</b>: CPFS backup.</description></item>
            /// <item><description><b>OTS</b>: Tablestore backup.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>UDM_ECS</para>
            /// </summary>
            [NameInMap("SourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }

            /// <summary>
            /// <para>This parameter is required only when <b>SourceType</b> is set to <b>ECS_FILE</b> or <b>File</b>. Specifies the backup traffic control. The format is <c>{start}{end}{bandwidth}</c>. Multiple traffic control configurations are separated by delimiters, and the time ranges must not overlap.</para>
            /// <list type="bullet">
            /// <item><description><b>start</b>: The start hour.</description></item>
            /// <item><description><b>end</b>: The end hour.</description></item>
            /// <item><description><b>bandwidth</b>: The rate limit, in KB/s.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0:24:1024</para>
            /// </summary>
            [NameInMap("SpeedLimit")]
            [Validation(Required=false)]
            public string SpeedLimit { get; set; }

        }

        /// <summary>
        /// <para>The policy ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>po-000************8ep</para>
        /// </summary>
        [NameInMap("PolicyId")]
        [Validation(Required=false)]
        public string PolicyId { get; set; }

    }

}
