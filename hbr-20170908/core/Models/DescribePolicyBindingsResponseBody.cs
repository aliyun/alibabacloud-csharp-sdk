// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class DescribePolicyBindingsResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code. 200 indicates success.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The number of results for each query.</para>
        /// <para>Valid values: 10 to 100. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The returned message. &quot;successful&quot; is returned for success. An error message is returned for failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The token required to obtain the next page of policy-data source bindings.</para>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0a</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The list of policy bindings.</para>
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
                    /// <item><description><b>true</b>: Switches to a full backup upon failure.</description></item>
                    /// <item><description><b>false</b>: Does not switch to a full backup upon failure.</description></item>
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
                /// <para>The advanced options for on-premises NAS.</para>
                /// </summary>
                [NameInMap("CommonNasDetail")]
                [Validation(Required=false)]
                public DescribePolicyBindingsResponseBodyPolicyBindingsAdvancedOptionsCommonNasDetail CommonNasDetail { get; set; }
                public class DescribePolicyBindingsResponseBodyPolicyBindingsAdvancedOptionsCommonNasDetail : TeaModel {
                    /// <summary>
                    /// <para>The backup client ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>c-0001eg6mcvjs93f46s2d</para>
                    /// </summary>
                    [NameInMap("ClientId")]
                    [Validation(Required=false)]
                    public string ClientId { get; set; }

                    /// <summary>
                    /// <para>The client group ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cl-000gkcofngi04j6k680a</para>
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
                    /// <item><description><b>true</b>: Switches to a full backup upon failure.</description></item>
                    /// <item><description><b>false</b>: Does not switch to a full backup upon failure.</description></item>
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
                    /// <para>Specifies whether to use an advanced policy. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>true</b>: Used.</description></item>
                    /// <item><description><b>false</b>: Not used.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
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
                    /// <para>Specifies whether to exclude archive objects from task statistics and failed file lists.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("IgnoreArchiveObject")]
                    [Validation(Required=false)]
                    public bool? IgnoreArchiveObject { get; set; }

                    /// <summary>
                    /// <para>Specifies whether to delete inventory files after backup. This parameter is valid only when OSS inventory is used. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>NO_CLEANUP</b>: Do not delete.</description></item>
                    /// <item><description><b>DELETE_CURRENT</b>: Delete the current file.</description></item>
                    /// <item><description><b>DELETE_CURRENT_AND_PREVIOUS</b>: Delete all files.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>DELETE_CURRENT_AND_PREVIOUS</para>
                    /// </summary>
                    [NameInMap("InventoryCleanupPolicy")]
                    [Validation(Required=false)]
                    public string InventoryCleanupPolicy { get; set; }

                    /// <summary>
                    /// <para>The OSS inventory name. If this value is not empty, the OSS inventory is used for performance tuning.</para>
                    /// <list type="bullet">
                    /// <item><description>Using an inventory to improve incremental performance is recommended when backing up more than 100 million OSS objects. Storage fees generated by inventory files are charged separately by OSS.</description></item>
                    /// <item><description>OSS inventory files take time to generate. Backup may fail before the OSS inventory file is generated. Wait for the next cycle to execute.</description></item>
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
                    /// <para>Specifies whether to create an application-consistent snapshot. Creating an application-consistent snapshot is supported only when all cloud disk types are ESSD.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("AppConsistent")]
                    [Validation(Required=false)]
                    public bool? AppConsistent { get; set; }

                    /// <summary>
                    /// <para>The custom KMS key ID in the destination region. If this field is not empty and cross-region replication is enabled, this key is used to encrypt the cross-region replication.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>4ed37b1e-da51-4187-aceb-9db4f9b7148b</para>
                    /// </summary>
                    [NameInMap("DestinationKmsKeyId")]
                    [Validation(Required=false)]
                    public string DestinationKmsKeyId { get; set; }

                    /// <summary>
                    /// <para>The list of cloud disk IDs that need to be protected. This value is empty when all cloud disks are protected.</para>
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
                    /// <para>This parameter is required only when <b>AppConsistent</b> is set to <b>true</b>. The path of the post-thaw script to execute after creating an application-consistent snapshot.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>/tmp/postscript.sh</para>
                    /// </summary>
                    [NameInMap("PostScriptPath")]
                    [Validation(Required=false)]
                    public string PostScriptPath { get; set; }

                    /// <summary>
                    /// <para>This parameter is required only when <b>AppConsistent</b> is set to <b>true</b>. The path of the pre-freeze script to execute before creating an application-consistent snapshot.</para>
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
                    /// <para>Specifies whether to create a snapshot-consistent group. Creating a snapshot-consistent group is supported only when all cloud disk types are ESSD.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("SnapshotGroup")]
                    [Validation(Required=false)]
                    public bool? SnapshotGroup { get; set; }

                    /// <summary>
                    /// <para>This parameter is required only when <b>AppConsistent</b> is set to <b>true</b>. The I/O freeze timeout period. Unit: seconds. Default value: 30.</para>
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
            /// <para>Indicates whether the resource is automatically associated through a backup policy resource tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("CreatedByTag")]
            [Validation(Required=false)]
            public bool? CreatedByTag { get; set; }

            /// <summary>
            /// <para>The creation time. UNIX timestamp, in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1661399570</para>
            /// </summary>
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public long? CreatedTime { get; set; }

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
            /// <para>The cross-account backup type. Valid values: </para>
            /// <list type="bullet">
            /// <item><description>SELF_ACCOUNT: backup within the current account.</description></item>
            /// <item><description>CROSS_ACCOUNT: cross-account backup.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CROSS_ACCOUNT</para>
            /// </summary>
            [NameInMap("CrossAccountType")]
            [Validation(Required=false)]
            public string CrossAccountType { get; set; }

            /// <summary>
            /// <para>The ID of the source account for cross-account backup.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1480************</para>
            /// </summary>
            [NameInMap("CrossAccountUserId")]
            [Validation(Required=false)]
            public long? CrossAccountUserId { get; set; }

            /// <summary>
            /// <para>The data source ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-8vb************5ly</para>
            /// </summary>
            [NameInMap("DataSourceId")]
            [Validation(Required=false)]
            public string DataSourceId { get; set; }

            /// <summary>
            /// <para>Indicates whether the policy is effective for the data source.</para>
            /// <list type="bullet">
            /// <item><description>true: paused.</description></item>
            /// <item><description>false: not paused.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Disabled")]
            [Validation(Required=false)]
            public bool? Disabled { get; set; }

            /// <summary>
            /// <para>This parameter is required only when <b>SourceType</b> is set to <b>ECS_FILE</b> or <b>File</b>. Specifies the file types to exclude from backup. All files of these types are not backed up. Maximum of 255 characters.</para>
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
                /// <para>The tag matching rule.</para>
                /// <list type="bullet">
                /// <item><description><b>EQUAL</b>: Matches both the tag key and tag value.</description></item>
                /// <item><description><b>NOT</b>: Matches the tag key but does not match the tag value.</description></item>
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
            /// <para>This parameter is required only when <b>SourceType</b> is set to <b>ECS_FILE</b> or <b>File</b>. Specifies the file types to back up. All files of these types are backed up. Maximum of 255 characters.</para>
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
            /// <para>po-000<b><b><b><b><b><b>eslc-i-uf6</b></b></b></b></b></b>y5g</para>
            /// </summary>
            [NameInMap("PolicyBindingDescription")]
            [Validation(Required=false)]
            public string PolicyBindingDescription { get; set; }

            /// <summary>
            /// <para>The policy binding ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pd-000************slc</para>
            /// </summary>
            [NameInMap("PolicyBindingId")]
            [Validation(Required=false)]
            public string PolicyBindingId { get; set; }

            /// <summary>
            /// <para>The policy ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>po-000************56y</para>
            /// </summary>
            [NameInMap("PolicyId")]
            [Validation(Required=false)]
            public string PolicyId { get; set; }

            /// <summary>
            /// <list type="bullet">
            /// <item><description>If SourceType is set to <b>OSS</b>, this parameter specifies the prefix to back up. If not specified, the entire Bucket root directory is backed up.</description></item>
            /// <item><description>If SourceType is set to <b>ECS_FILE</b> or <b>File</b>, this parameter specifies the file directory to back up. If not specified, all directories are backed up.</description></item>
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
            /// <item><description><b>UDM_ECS</b>: ECS instance backup.</description></item>
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
            /// <para>This parameter is required only when <b>SourceType</b> is set to <b>ECS_FILE</b> or <b>File</b>. Specifies the backup traffic control. Format: <c>{start}{end}{bandwidth}</c>. Multiple traffic control configurations are separated by delimiters, and configuration times cannot overlap.</para>
            /// <list type="bullet">
            /// <item><description><b>start</b>: start hour.</description></item>
            /// <item><description><b>end</b>: end hour.</description></item>
            /// <item><description><b>bandwidth</b>: rate limit, in KB/s.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0:24:10240</para>
            /// </summary>
            [NameInMap("SpeedLimit")]
            [Validation(Required=false)]
            public string SpeedLimit { get; set; }

            /// <summary>
            /// <para>The update time. UNIX timestamp, in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1653611573</para>
            /// </summary>
            [NameInMap("UpdatedTime")]
            [Validation(Required=false)]
            public long? UpdatedTime { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5225929A-4EBD-55EE-9FE1-4A130E582A76</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// <list type="bullet">
        /// <item><description>true: Successful.</description></item>
        /// <item><description>false: Failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>38</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
