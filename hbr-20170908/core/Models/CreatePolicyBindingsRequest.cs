// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class CreatePolicyBindingsRequest : TeaModel {
        /// <summary>
        /// <para>The data sources that you want to bind to the backup policy.</para>
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
                [NameInMap("CommonFileSystemDetail")]
                [Validation(Required=false)]
                public CreatePolicyBindingsRequestPolicyBindingListAdvancedOptionsCommonFileSystemDetail CommonFileSystemDetail { get; set; }
                public class CreatePolicyBindingsRequestPolicyBindingListAdvancedOptionsCommonFileSystemDetail : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>100000</para>
                    /// </summary>
                    [NameInMap("FetchSliceSize")]
                    [Validation(Required=false)]
                    public long? FetchSliceSize { get; set; }

                    /// <summary>
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
                    /// <para>The ID of the backup client group. When you perform on-premises NAS backup, Cloud Backup selects clients from the specified backup client group.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cl-000**************ggu</para>
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
                /// <para>The advanced options for file backup.</para>
                /// </summary>
                [NameInMap("FileDetail")]
                [Validation(Required=false)]
                public CreatePolicyBindingsRequestPolicyBindingListAdvancedOptionsFileDetail FileDetail { get; set; }
                public class CreatePolicyBindingsRequestPolicyBindingListAdvancedOptionsFileDetail : TeaModel {
                    /// <summary>
                    /// <para>Specifies whether to use an advanced policy. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>true</b></description></item>
                    /// <item><description><b>false</b></description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("AdvPolicy")]
                    [Validation(Required=false)]
                    public bool? AdvPolicy { get; set; }

                    /// <summary>
                    /// <para>Specifies whether to enable the Volume Shadow Copy Service (VSS) feature. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>true</b></description></item>
                    /// <item><description><b>false</b></description></item>
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
                    /// <para>Specifies whether the system deletes the inventory lists when a backup is completed. This parameter is valid only when OSS inventories are used. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>NO_CLEANUP</b>: Inventory lists are not deleted.</description></item>
                    /// <item><description><b>DELETE_CURRENT</b>: The current inventory list is deleted.</description></item>
                    /// <item><description><b>DELETE_CURRENT_AND_PREVIOUS</b>: All inventory lists are deleted.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>NO_CLEANUP</para>
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
                    /// <para>oss-inventory-default</para>
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
                public CreatePolicyBindingsRequestPolicyBindingListAdvancedOptionsUdmDetail UdmDetail { get; set; }
                public class CreatePolicyBindingsRequestPolicyBindingListAdvancedOptionsUdmDetail : TeaModel {
                    /// <summary>
                    /// <para>Specifies whether to enable application consistency. You can enable application consistency only if all disks are ESSDs.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("AppConsistent")]
                    [Validation(Required=false)]
                    public bool? AppConsistent { get; set; }

                    /// <summary>
                    /// <para>The IDs of the disks that need to be protected. If all disks need to be protected, leave this parameter empty.</para>
                    /// </summary>
                    [NameInMap("DiskIdList")]
                    [Validation(Required=false)]
                    public List<string> DiskIdList { get; set; }

                    /// <summary>
                    /// <para>This parameter is required only if you set the <b>AppConsistent</b> parameter to <b>true</b>. This parameter specifies whether to enable Linux fsfreeze to put file systems into the read-only state before application-consistent snapshots are created. Default value: true.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("EnableFsFreeze")]
                    [Validation(Required=false)]
                    public bool? EnableFsFreeze { get; set; }

                    /// <summary>
                    /// <para>This parameter is required only if you set the <b>AppConsistent</b> parameter to <b>true</b>. This parameter specifies whether to create application-consistent snapshots. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>true: creates application-consistent snapshots.</description></item>
                    /// <item><description>false: creates file system-consistent snapshots.</description></item>
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
                    /// <para>This parameter is required only if you set the <b>AppConsistent</b> parameter to <b>true</b>. This parameter specifies the path of the post-thaw scripts that are executed after application-consistent snapshots are created.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>/tmp/postscript.sh</para>
                    /// </summary>
                    [NameInMap("PostScriptPath")]
                    [Validation(Required=false)]
                    public string PostScriptPath { get; set; }

                    /// <summary>
                    /// <para>This parameter is required only if you set the <b>AppConsistent</b> parameter to <b>true</b>. This parameter specifies the path of the pre-freeze scripts that are executed before application-consistent snapshots are created.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>/tmp/prescript.sh</para>
                    /// </summary>
                    [NameInMap("PreScriptPath")]
                    [Validation(Required=false)]
                    public string PreScriptPath { get; set; }

                    /// <summary>
                    /// <para>This parameter is required only if you set the <b>AppConsistent</b> parameter to <b>true</b>. This parameter specifies the name of the RAM role that is required to create application-consistent snapshots.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>AliyunECSInstanceForHbrRole</para>
                    /// </summary>
                    [NameInMap("RamRoleName")]
                    [Validation(Required=false)]
                    public string RamRoleName { get; set; }

                    /// <summary>
                    /// <para>Specifies whether to create a snapshot-consistent group. You can create a snapshot-consistent group only if all disks are enhanced SSDs (ESSDs).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("SnapshotGroup")]
                    [Validation(Required=false)]
                    public bool? SnapshotGroup { get; set; }

                    /// <summary>
                    /// <para>This parameter is required only if you set the <b>AppConsistent</b> parameter to <b>true</b>. This parameter specifies the I/O freeze timeout period. Default value: 30. Unit: seconds.</para>
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
            /// <para>The name of the RAM role that is created within the source Alibaba Cloud account and assigned to the current Alibaba Cloud account to authorize the current Alibaba Cloud account to back up data across Alibaba Cloud accounts.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hbrcrossrole</para>
            /// </summary>
            [NameInMap("CrossAccountRoleName")]
            [Validation(Required=false)]
            public string CrossAccountRoleName { get; set; }

            /// <summary>
            /// <para>Specifies whether to back up and restore data within the same Alibaba Cloud account or across Alibaba Cloud accounts. Default value: SELF_ACCOUNT. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>SELF_ACCOUNT</b>: Data is backed up within the same Alibaba Cloud account.</description></item>
            /// <item><description><b>CROSS_ACCOUNT</b>: Data is backed up across Alibaba Cloud accounts.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SELF_ACCOUNT</para>
            /// </summary>
            [NameInMap("CrossAccountType")]
            [Validation(Required=false)]
            public string CrossAccountType { get; set; }

            /// <summary>
            /// <para>The ID of the source Alibaba Cloud account that authorizes the current Alibaba Cloud account to back up data across Alibaba Cloud accounts.</para>
            /// 
            /// <b>Example:</b>
            /// <para>144**********732</para>
            /// </summary>
            [NameInMap("CrossAccountUserId")]
            [Validation(Required=false)]
            public long? CrossAccountUserId { get; set; }

            /// <summary>
            /// <para>The ID of the data source. The meaning of this parameter depends on the <b>SourceType</b> parameter.</para>
            /// <list type="bullet">
            /// <item><description><b>UDM_ECS</b>: the ID of the Elastic Compute Service (ECS) instance</description></item>
            /// <item><description><b>OSS</b>: the name of the Object Storage Service (OSS) bucket</description></item>
            /// <item><description><b>NAS</b>: the ID of the Apsara File Storage NAS (NAS) file system</description></item>
            /// <item><description><b>COMMON_NAS</b>: the ID of the on-premises NAS file system</description></item>
            /// <item><description><b>ECS_FILE</b>: the ID of the ECS instance</description></item>
            /// <item><description><b>File</b>: the ID of the Cloud Backup client</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>i-bp1************dl8</para>
            /// </summary>
            [NameInMap("DataSourceId")]
            [Validation(Required=false)]
            public string DataSourceId { get; set; }

            /// <summary>
            /// <para>策略对该数据源是否暂停生效。</para>
            /// <list type="bullet">
            /// <item><description>true：暂停</description></item>
            /// <item><description>false：未暂停</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Disabled")]
            [Validation(Required=false)]
            public string Disabled { get; set; }

            /// <summary>
            /// <para>仅当<b>SourceType</b>取值为<b>ECS_FILE</b>或<b>File</b>时，需要配置该参数。表示不需要进行备份的文件类型，该类型的所有文件都不备份。最多支持255个字符。</para>
            /// 
            /// <b>Example:</b>
            /// <para>[\&quot;<em>.doc\&quot;,\&quot;</em>.xltm\&quot;]</para>
            /// </summary>
            [NameInMap("Exclude")]
            [Validation(Required=false)]
            public string Exclude { get; set; }

            /// <summary>
            /// <para>仅当<b>SourceType</b>取值为<b>ECS_FILE</b>或<b>File</b>时，需要配置该参数。表示要进行备份的文件类型，这些类型的所有文件都备份。最多支持255个字符。</para>
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
            /// <para>Bind data sources to a backup policy</para>
            /// </summary>
            [NameInMap("PolicyBindingDescription")]
            [Validation(Required=false)]
            public string PolicyBindingDescription { get; set; }

            /// <summary>
            /// <para>The prefix of the path to the folder that you want to back up. By default, the entire OSS bucket is backed up. This parameter is required only if you set the SourceType parameter to <b>OSS</b>.</para>
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
            /// <item><description><b>UDM_ECS</b>: ECS instance</description></item>
            /// <item><description><b>OSS</b>: OSS bucket</description></item>
            /// <item><description><b>NAS</b>: Apsara File Storage NAS file system</description></item>
            /// <item><description><b>COMMON_NAS</b>: on-premises NAS file system</description></item>
            /// <item><description><b>ECS_FILE</b>: ECS files</description></item>
            /// <item><description><b>File</b>: on-premises files</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>UDM_ECS</para>
            /// </summary>
            [NameInMap("SourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }

            /// <summary>
            /// <para>仅当<b>SourceType</b>取值为<b>ECS_FILE</b>或<b>File</b>时，需要配置该参数。表示备份流量控制。格式为<c>{start}{end}{bandwidth}</c>。多个流量控制配置使用分隔，并且配置时间不允许有重叠。</para>
            /// <list type="bullet">
            /// <item><description><b>start</b>：起始小时。</description></item>
            /// <item><description><b>end</b>：结束小时。</description></item>
            /// <item><description><b>bandwidth</b>：限制速率，单位KB/s。</description></item>
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
        /// <para>The ID of the backup policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>po-000************8ep</para>
        /// </summary>
        [NameInMap("PolicyId")]
        [Validation(Required=false)]
        public string PolicyId { get; set; }

    }

}
