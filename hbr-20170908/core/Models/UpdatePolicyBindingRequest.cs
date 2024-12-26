// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class UpdatePolicyBindingRequest : TeaModel {
        /// <summary>
        /// <para>The advanced options.</para>
        /// </summary>
        [NameInMap("AdvancedOptions")]
        [Validation(Required=false)]
        public UpdatePolicyBindingRequestAdvancedOptions AdvancedOptions { get; set; }
        public class UpdatePolicyBindingRequestAdvancedOptions : TeaModel {
            /// <summary>
            /// <para>The details about large-scale file system backup.</para>
            /// </summary>
            [NameInMap("CommonFileSystemDetail")]
            [Validation(Required=false)]
            public UpdatePolicyBindingRequestAdvancedOptionsCommonFileSystemDetail CommonFileSystemDetail { get; set; }
            public class UpdatePolicyBindingRequestAdvancedOptionsCommonFileSystemDetail : TeaModel {
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
            /// <para>The details about Object Storage Service (OSS) backup.</para>
            /// </summary>
            [NameInMap("OssDetail")]
            [Validation(Required=false)]
            public UpdatePolicyBindingRequestAdvancedOptionsOssDetail OssDetail { get; set; }
            public class UpdatePolicyBindingRequestAdvancedOptionsOssDetail : TeaModel {
                /// <summary>
                /// <para>Do not prompt for archival type objects in task statistics and failed file lists.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IgnoreArchiveObject")]
                [Validation(Required=false)]
                public bool? IgnoreArchiveObject { get; set; }

                /// <summary>
                /// <para>Specifies whether the system deletes the inventory lists when a backup is completed. This parameter is valid only when OSS inventories are used. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>NO_CLEANUP</b>: does not delete inventory lists.</description></item>
                /// <item><description><b>DELETE_CURRENT</b>: deletes the current inventory list.</description></item>
                /// <item><description><b>DELETE_CURRENT_AND_PREVIOUS</b>: deletes all inventory lists.</description></item>
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
                /// <para>30663060</para>
                /// </summary>
                [NameInMap("InventoryId")]
                [Validation(Required=false)]
                public string InventoryId { get; set; }

            }

            /// <summary>
            /// <para>The details about Elastic Compute Service (ECS) instance backup.</para>
            /// </summary>
            [NameInMap("UdmDetail")]
            [Validation(Required=false)]
            public UpdatePolicyBindingRequestAdvancedOptionsUdmDetail UdmDetail { get; set; }
            public class UpdatePolicyBindingRequestAdvancedOptionsUdmDetail : TeaModel {
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
                /// <para>The IDs of the disks that need to be protected. If all disks need to be protected, this parameter is empty.</para>
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
                /// <item><description>true: creates application-consistent snapshots</description></item>
                /// <item><description>false: creates file system-consistent snapshots</description></item>
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
                /// <para>This parameter is required only if you set the <b>AppConsistent</b> parameter to <b>true</b>. This parameter specifies the name of the Resource Access Management (RAM) role that is required to create application-consistent snapshots.</para>
                /// 
                /// <b>Example:</b>
                /// <para>AliyunECSInstanceForHbrRole</para>
                /// </summary>
                [NameInMap("RamRoleName")]
                [Validation(Required=false)]
                public string RamRoleName { get; set; }

                /// <summary>
                /// <para>Specifies whether to create a snapshot-consistent group. You can create a snapshot-consistent group only if all disks are Enterprise SSDs (ESSDs).</para>
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
        /// <para>The ID of the data source.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp1************dtv</para>
        /// </summary>
        [NameInMap("DataSourceId")]
        [Validation(Required=false)]
        public string DataSourceId { get; set; }

        /// <summary>
        /// <para>Specifies whether to disable the backup policy for the data source. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: disables the backup policy for the data source</description></item>
        /// <item><description>false: enables the backup policy for the data source</description></item>
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
        /// <para>po-000<b><b><b><b><b><b>5xx-i-2ze</b></b></b></b></b></b>nw4</para>
        /// </summary>
        [NameInMap("PolicyBindingDescription")]
        [Validation(Required=false)]
        public string PolicyBindingDescription { get; set; }

        /// <summary>
        /// <para>The ID of the backup policy.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>po-000************ky9</para>
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
        /// <item><description><b>UDM_ECS</b>: ECS instance backup</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
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
        /// <para>0:24:5120</para>
        /// </summary>
        [NameInMap("SpeedLimit")]
        [Validation(Required=false)]
        public string SpeedLimit { get; set; }

    }

}
