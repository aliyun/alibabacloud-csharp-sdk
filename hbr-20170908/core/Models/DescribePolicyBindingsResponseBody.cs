// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class DescribePolicyBindingsResponseBody : TeaModel {
        /// <summary>
        /// <para>Return code, 200 indicates success.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The number of results per query.</para>
        /// <para>Range: 10~100. Default: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>Description of the return message. A successful response usually returns \&quot;successful\&quot;, while an error will return a corresponding error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The token required to fetch the next page of policy and data source bindings.</para>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0a</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>List of bound policies.</para>
        /// </summary>
        [NameInMap("PolicyBindings")]
        [Validation(Required=false)]
        public List<DescribePolicyBindingsResponseBodyPolicyBindings> PolicyBindings { get; set; }
        public class DescribePolicyBindingsResponseBodyPolicyBindings : TeaModel {
            /// <summary>
            /// <para>Advanced options.</para>
            /// </summary>
            [NameInMap("AdvancedOptions")]
            [Validation(Required=false)]
            public DescribePolicyBindingsResponseBodyPolicyBindingsAdvancedOptions AdvancedOptions { get; set; }
            public class DescribePolicyBindingsResponseBodyPolicyBindingsAdvancedOptions : TeaModel {
                /// <summary>
                /// <para>Advanced options for large-scale file system backup.</para>
                /// </summary>
                [NameInMap("CommonFileSystemDetail")]
                [Validation(Required=false)]
                public DescribePolicyBindingsResponseBodyPolicyBindingsAdvancedOptionsCommonFileSystemDetail CommonFileSystemDetail { get; set; }
                public class DescribePolicyBindingsResponseBodyPolicyBindingsAdvancedOptionsCommonFileSystemDetail : TeaModel {
                    /// <summary>
                    /// <para>Backup shard size (number of files).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100000</para>
                    /// </summary>
                    [NameInMap("FetchSliceSize")]
                    [Validation(Required=false)]
                    public long? FetchSliceSize { get; set; }

                    /// <summary>
                    /// <para>Whether to switch to a full backup when an incremental backup fails. Values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>true</b>: Switch to full backup on failure.</description></item>
                    /// <item><description><b>false</b>: Do not switch to full backup on failure.</description></item>
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
                /// <para>Advanced options for local NAS.</para>
                /// </summary>
                [NameInMap("CommonNasDetail")]
                [Validation(Required=false)]
                public DescribePolicyBindingsResponseBodyPolicyBindingsAdvancedOptionsCommonNasDetail CommonNasDetail { get; set; }
                public class DescribePolicyBindingsResponseBodyPolicyBindingsAdvancedOptionsCommonNasDetail : TeaModel {
                    /// <summary>
                    /// <para>Backup client ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>c-0001eg6mcvjs93f46s2d</para>
                    /// </summary>
                    [NameInMap("ClientId")]
                    [Validation(Required=false)]
                    public string ClientId { get; set; }

                    /// <summary>
                    /// <para>Client group ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cl-000gkcofngi04j6k680a</para>
                    /// </summary>
                    [NameInMap("ClusterId")]
                    [Validation(Required=false)]
                    public string ClusterId { get; set; }

                    /// <summary>
                    /// <para>Backup slice size (number of files).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100000</para>
                    /// </summary>
                    [NameInMap("FetchSliceSize")]
                    [Validation(Required=false)]
                    public long? FetchSliceSize { get; set; }

                    /// <summary>
                    /// <para>Whether to switch to a full backup when an incremental backup fails. Values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>true</b>: Switch to full backup on failure.</description></item>
                    /// <item><description><b>false</b>: Do not switch to full backup on failure.</description></item>
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
                /// <para>Advanced options for file backup.</para>
                /// </summary>
                [NameInMap("FileDetail")]
                [Validation(Required=false)]
                public DescribePolicyBindingsResponseBodyPolicyBindingsAdvancedOptionsFileDetail FileDetail { get; set; }
                public class DescribePolicyBindingsResponseBodyPolicyBindingsAdvancedOptionsFileDetail : TeaModel {
                    /// <summary>
                    /// <para>Whether to use advanced policies. Values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>true</b>: Use.</description></item>
                    /// <item><description><b>false</b>: Do not use.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("AdvPolicy")]
                    [Validation(Required=false)]
                    public bool? AdvPolicy { get; set; }

                    /// <summary>
                    /// <para>Whether to enable VSS (Windows) functionality. Values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>true</b>: Enable.</description></item>
                    /// <item><description><b>false</b>: Disable.</description></item>
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
                /// <para>Advanced options for OSS backup.</para>
                /// </summary>
                [NameInMap("OssDetail")]
                [Validation(Required=false)]
                public DescribePolicyBindingsResponseBodyPolicyBindingsAdvancedOptionsOssDetail OssDetail { get; set; }
                public class DescribePolicyBindingsResponseBodyPolicyBindingsAdvancedOptionsOssDetail : TeaModel {
                    /// <summary>
                    /// <para>Do not prompt for archive-type objects in the task statistics and failed file list.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("IgnoreArchiveObject")]
                    [Validation(Required=false)]
                    public bool? IgnoreArchiveObject { get; set; }

                    /// <summary>
                    /// <para>Whether to delete the inventory file after the backup. This is only effective when using an OSS inventory. Supported values:</para>
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
                    /// <para>The name of the OSS inventory. If this value is not empty, the OSS inventory will be used for performance optimization.</para>
                    /// <list type="bullet">
                    /// <item><description>It is recommended to use an inventory for backing up more than 100 million OSS objects to improve incremental performance. Storage costs for the inventory files are charged separately by the OSS service.</description></item>
                    /// <item><description>The generation of the OSS inventory file takes time, and the backup may fail before the inventory file is generated. You can wait for the next cycle to execute.</description></item>
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
                /// <para>Advanced options for full machine backup.</para>
                /// </summary>
                [NameInMap("UdmDetail")]
                [Validation(Required=false)]
                public DescribePolicyBindingsResponseBodyPolicyBindingsAdvancedOptionsUdmDetail UdmDetail { get; set; }
                public class DescribePolicyBindingsResponseBodyPolicyBindingsAdvancedOptionsUdmDetail : TeaModel {
                    /// <summary>
                    /// <para>是否创建应用一致性。仅云盘类型全部为ESSD时，支持创建快照应用一致性。</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("AppConsistent")]
                    [Validation(Required=false)]
                    public bool? AppConsistent { get; set; }

                    /// <summary>
                    /// <para>The custom KMS key ID in the destination region. When this field is not empty and cross-region replication is enabled, the specified key will be used for encrypting the cross-region replication.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>4ed37b1e-da51-4187-aceb-9db4f9b7148b</para>
                    /// </summary>
                    [NameInMap("DestinationKmsKeyId")]
                    [Validation(Required=false)]
                    public string DestinationKmsKeyId { get; set; }

                    /// <summary>
                    /// <para>List of disk IDs that need protection. This value is empty when protecting all disks.</para>
                    /// </summary>
                    [NameInMap("DiskIdList")]
                    [Validation(Required=false)]
                    public List<string> DiskIdList { get; set; }

                    /// <summary>
                    /// <para>This parameter is required when <b>AppConsistent</b> is <b>true</b>. It indicates whether to use the Linux FsFreeze mechanism to ensure the file system is in a read-only consistent state before creating an application-consistent snapshot. The default value is true.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("EnableFsFreeze")]
                    [Validation(Required=false)]
                    public bool? EnableFsFreeze { get; set; }

                    /// <summary>
                    /// <para>This parameter is required when <b>AppConsistent</b> is <b>true</b>. It determines whether to set an application-consistent snapshot:</para>
                    /// <list type="bullet">
                    /// <item><description><b>true</b>: Create an application-consistent snapshot</description></item>
                    /// <item><description><b>false</b>: Create a file system-consistent snapshot</description></item>
                    /// </list>
                    /// <para>The default value is true.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("EnableWriters")]
                    [Validation(Required=false)]
                    public bool? EnableWriters { get; set; }

                    /// <summary>
                    /// <para>List of disk IDs that do not need protection. This parameter is ignored if DiskIdList is not empty.</para>
                    /// </summary>
                    [NameInMap("ExcludeDiskIdList")]
                    [Validation(Required=false)]
                    public List<string> ExcludeDiskIdList { get; set; }

                    /// <summary>
                    /// <para>This parameter is required when <b>AppConsistent</b> is <b>true</b>. It specifies the path of the unfreeze script to be executed after creating an application-consistent snapshot.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>/tmp/postscript.sh</para>
                    /// </summary>
                    [NameInMap("PostScriptPath")]
                    [Validation(Required=false)]
                    public string PostScriptPath { get; set; }

                    /// <summary>
                    /// <para>This parameter is required when <b>AppConsistent</b> is <b>true</b>. It specifies the path of the freeze script to be executed before creating an application-consistent snapshot.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>/tmp/prescript.sh</para>
                    /// </summary>
                    [NameInMap("PreScriptPath")]
                    [Validation(Required=false)]
                    public string PreScriptPath { get; set; }

                    /// <summary>
                    /// <para>This parameter is required when <b>AppConsistent</b> is <b>true</b>. It specifies the RAM role name needed for creating an application-consistent snapshot.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>AliyunECSInstanceForHbrRole</para>
                    /// </summary>
                    [NameInMap("RamRoleName")]
                    [Validation(Required=false)]
                    public string RamRoleName { get; set; }

                    /// <summary>
                    /// <para>Indicates whether to create a snapshot consistency group. Only supported when all disk types are ESSD.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("SnapshotGroup")]
                    [Validation(Required=false)]
                    public bool? SnapshotGroup { get; set; }

                    /// <summary>
                    /// <para>This parameter is required when <b>AppConsistent</b> is <b>true</b>. It specifies the IO freeze timeout duration. The default value is 30 seconds.</para>
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
            /// <para>Whether the resource is automatically associated through the backup policy resource tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("CreatedByTag")]
            [Validation(Required=false)]
            public bool? CreatedByTag { get; set; }

            /// <summary>
            /// <para>Creation time. UNIX timestamp, in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1661399570</para>
            /// </summary>
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public long? CreatedTime { get; set; }

            /// <summary>
            /// <para>The name of the role created in the RAM of the original account for cross-account backup.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hbrcrossrole</para>
            /// </summary>
            [NameInMap("CrossAccountRoleName")]
            [Validation(Required=false)]
            public string CrossAccountRoleName { get; set; }

            /// <summary>
            /// <para>Cross-account backup type. Supported values: </para>
            /// <list type="bullet">
            /// <item><description>SELF_ACCOUNT: Backup within the same account</description></item>
            /// <item><description>CROSS_ACCOUNT: Cross-account backup</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CROSS_ACCOUNT</para>
            /// </summary>
            [NameInMap("CrossAccountType")]
            [Validation(Required=false)]
            public string CrossAccountType { get; set; }

            /// <summary>
            /// <para>The ID of the original account for cross-account backup.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1480************</para>
            /// </summary>
            [NameInMap("CrossAccountUserId")]
            [Validation(Required=false)]
            public long? CrossAccountUserId { get; set; }

            /// <summary>
            /// <para>Data source ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-8vb************5ly</para>
            /// </summary>
            [NameInMap("DataSourceId")]
            [Validation(Required=false)]
            public string DataSourceId { get; set; }

            /// <summary>
            /// <para>Whether the policy is disbaled for this data source.</para>
            /// <list type="bullet">
            /// <item><description>true: disabled</description></item>
            /// <item><description>false: Not disabled</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Disabled")]
            [Validation(Required=false)]
            public bool? Disabled { get; set; }

            /// <summary>
            /// <para>This parameter is required only when <b>SourceType</b> is <b>ECS_FILE</b> or <b>File</b>. It specifies the file types that should not be backed up, and all files of these types will be excluded. Supports up to 255 characters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[\&quot;<em>.doc\&quot;,\&quot;</em>.xltm\&quot;]</para>
            /// </summary>
            [NameInMap("Exclude")]
            [Validation(Required=false)]
            public string Exclude { get; set; }

            /// <summary>
            /// <para>Hit tag rules.</para>
            /// </summary>
            [NameInMap("HitTags")]
            [Validation(Required=false)]
            public List<DescribePolicyBindingsResponseBodyPolicyBindingsHitTags> HitTags { get; set; }
            public class DescribePolicyBindingsResponseBodyPolicyBindingsHitTags : TeaModel {
                /// <summary>
                /// <para>Tag key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>env</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>Tag matching rule.</para>
                /// <list type="bullet">
                /// <item><description><b>EQUAL</b>: Matches both the tag key and tag value.</description></item>
                /// <item><description><b>NOT</b>: Matches the tag key but not the tag value.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>EQUAL</para>
                /// </summary>
                [NameInMap("Operator")]
                [Validation(Required=false)]
                public string Operator { get; set; }

                /// <summary>
                /// <para>Tag value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>prod</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>This parameter is required only when <b>SourceType</b> is <b>ECS_FILE</b> or <b>File</b>. It specifies the file types to be backed up, and all files of these types will be backed up. Supports up to 255 characters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[\&quot;<em>.doc\&quot;,\&quot;</em>.xltm\&quot;]</para>
            /// </summary>
            [NameInMap("Include")]
            [Validation(Required=false)]
            public string Include { get; set; }

            /// <summary>
            /// <para>Bound policy description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>po-000<b><b><b><b><b><b>eslc-i-uf6</b></b></b></b></b></b>y5g</para>
            /// </summary>
            [NameInMap("PolicyBindingDescription")]
            [Validation(Required=false)]
            public string PolicyBindingDescription { get; set; }

            /// <summary>
            /// <para>Bound policy ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pd-000************slc</para>
            /// </summary>
            [NameInMap("PolicyBindingId")]
            [Validation(Required=false)]
            public string PolicyBindingId { get; set; }

            /// <summary>
            /// <para>Policy ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>po-000************56y</para>
            /// </summary>
            [NameInMap("PolicyId")]
            [Validation(Required=false)]
            public string PolicyId { get; set; }

            /// <summary>
            /// <list type="bullet">
            /// <item><description>When <b>SourceType</b> is <b>OSS</b>, it indicates the prefix to be backed up. If not specified, it means backing up the entire root directory of the Bucket.</description></item>
            /// <item><description>When <b>SourceType</b> is <b>ECS_FILE</b> or <b>File</b>, it indicates the file directory to be backed up. If not specified, it means backing up all directories.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>backup/</para>
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <para>Data source type, with the value range:</para>
            /// <list type="bullet">
            /// <item><description><b>UDM_ECS</b>: indicates ECS full machine backup</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>UDM_ECS</para>
            /// </summary>
            [NameInMap("SourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }

            /// <summary>
            /// <para>This parameter is required only when <b>SourceType</b> is <b>ECS_FILE</b> or <b>File</b>. It specifies the backup traffic control. The format is <c>{start}{end}{bandwidth}</c>. Multiple traffic control configurations are separated by commas, and the configured times must not overlap.</para>
            /// <list type="bullet">
            /// <item><description><b>start</b>: Start hour.</description></item>
            /// <item><description><b>end</b>: End hour.</description></item>
            /// <item><description><b>bandwidth</b>: Limit rate, in KB/s.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0:24:10240</para>
            /// </summary>
            [NameInMap("SpeedLimit")]
            [Validation(Required=false)]
            public string SpeedLimit { get; set; }

            /// <summary>
            /// <para>Update time. UNIX timestamp, in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1653611573</para>
            /// </summary>
            [NameInMap("UpdatedTime")]
            [Validation(Required=false)]
            public long? UpdatedTime { get; set; }

        }

        /// <summary>
        /// <para>Request ID.</para>
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
        /// <item><description>true: Success</description></item>
        /// <item><description>false: Failure</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>Total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>38</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
