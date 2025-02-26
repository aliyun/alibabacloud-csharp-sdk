// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class CreateBackupJobShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The backup type. This parameter is required only if you set the SourceType parameter to UDM_ECS.</para>
        /// <list type="bullet">
        /// <item><description><b>COMPLETE</b>: full backup</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>INCREMENTAL</para>
        /// </summary>
        [NameInMap("BackupType")]
        [Validation(Required=false)]
        public string BackupType { get; set; }

        /// <summary>
        /// <para>You do not need to specify this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cl-00068btz******oku</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>You do not need to specify this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cc-000xxxxxxxxxxxxxxi00</para>
        /// </summary>
        [NameInMap("ContainerClusterId")]
        [Validation(Required=false)]
        public string ContainerClusterId { get; set; }

        /// <summary>
        /// <para>You do not need to specify this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{\&quot;resourceType\&quot;:\&quot;PV\&quot;,\&quot;backupMethod\&quot;:\&quot;FILE\&quot;,\&quot;resourceId\&quot;:\&quot;674dac6d-74cd-47e9-a675-09e2f10d2c45\&quot;,\&quot;resourceInfo\&quot;:\&quot;{\\\&quot;pv_name\\\&quot;:\\\&quot;nas-650dac6d-74cd-47e9-a675-09e2f10d2c45\\\&quot;,\\\&quot;pv_size\\\&quot;:\\\&quot;8Gi\\\&quot;,\\\&quot;storage_class\\\&quot;:\\\&quot;alibabacloud-cnfs-nas\\\&quot;,\\\&quot;pvc_name\\\&quot;:\\\&quot;data-postgresql-default-0\\\&quot;,\\\&quot;namespace\\\&quot;:\\\&quot;database\\\&quot;}\&quot;,\&quot;host\&quot;:\&quot;cn-huhehaote.192.168.13.133\&quot;,\&quot;hostPrefix\&quot;:\&quot;6f5e758e-8d35-4584-b9ce-8333adfc7547/volumes/kubernetes.io~csi/nas-670dac6d-74cd-47e9-a675-09e2f10d2c45/mount\&quot;,\&quot;pvPath\&quot;:\&quot;/\&quot;}]</para>
        /// </summary>
        [NameInMap("ContainerResources")]
        [Validation(Required=false)]
        public string ContainerResources { get; set; }

        /// <summary>
        /// <para>The name of the RAM role that is created within the source Alibaba Cloud account and assigned to the current Alibaba Cloud account to authorize the current Alibaba Cloud account to back up data across Alibaba Cloud accounts.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BackupRole</para>
        /// </summary>
        [NameInMap("CrossAccountRoleName")]
        [Validation(Required=false)]
        public string CrossAccountRoleName { get; set; }

        /// <summary>
        /// <para>Specifies whether data is backed up within the same Alibaba Cloud account or across Alibaba Cloud accounts. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>SELF_ACCOUNT: Data is backed up within the same Alibaba Cloud account.</description></item>
        /// <item><description>CROSS_ACCOUNT: Data is backed up across Alibaba Cloud accounts.</description></item>
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
        /// <para>158975xxxxxx4625</para>
        /// </summary>
        [NameInMap("CrossAccountUserId")]
        [Validation(Required=false)]
        public long? CrossAccountUserId { get; set; }

        /// <summary>
        /// <para>This parameter is required only if you set the <b>SourceType</b> parameter to <b>UDM_ECS</b>. The value is a JSON string. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>doCopy: specifies whether to enable remote replication.</para>
        /// </description></item>
        /// <item><description><para>destinationRegionId: the destination region for remote replication.</para>
        /// </description></item>
        /// <item><description><para>destinationRetention: the retention period of the backup point for remote replication.</para>
        /// </description></item>
        /// <item><description><para>diskIdList: the IDs of the disks that are to be backed up. If this parameter is left empty, all disks are backed up.</para>
        /// </description></item>
        /// <item><description><para>snapshotGroup: specifies whether to use a snapshot-consistent group. This parameter is valid only if all disks of the ECS instance are Enterprise SSDs (ESSDs).</para>
        /// </description></item>
        /// <item><description><para>appConsistent: specifies whether to use the application-consistent backup feature. This parameter must be used with the preScriptPath and postScriptPath parameters.</para>
        /// </description></item>
        /// <item><description><para>preScriptPath: the path to the pre-freeze scripts.</para>
        /// </description></item>
        /// <item><description><para>postScriptPath: the path to the post-thaw scripts.</para>
        /// </description></item>
        /// <item><description><para>enableWriters: This parameter is required only if you set the <b>AppConsistent</b> parameter to <b>true</b>. This parameter specifies whether to create application-consistent snapshots.</para>
        /// <list type="bullet">
        /// <item><description>true: creates application-consistent snapshots.</description></item>
        /// <item><description>false: creates file system-consistent snapshots.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>enableFsFreeze: This parameter is required only if you set the <b>AppConsistent</b> parameter to <b>true</b>. This parameter specifies whether to enable Linux fsfreeze to put file systems into the read-only state before application-consistent snapshots are created. Default value: true.</para>
        /// </description></item>
        /// <item><description><para>timeoutSeconds: This parameter is required only if you set the <b>AppConsistent</b> parameter to <b>true</b>. This parameter specifies the I/O freeze timeout period. Default value: 30. Unit: seconds.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;doCopy&quot;: false,
        ///     &quot;destinationRegionId&quot;: &quot;&quot;,
        ///     &quot;destinationRetention&quot;: null,
        ///     &quot;diskIdList&quot;: [],
        ///     &quot;snapshotGroup&quot;: false,
        ///     &quot;appConsistent&quot;: false,
        ///     &quot;enableWriters&quot;: true,
        ///     &quot;preScriptPath&quot;: &quot;&quot;,
        ///     &quot;postScriptPath&quot;: &quot;&quot;,
        ///     &quot;enableFsFreeze&quot;: true,
        ///     &quot;timeoutInSeconds&quot;: 60
        /// }</para>
        /// </summary>
        [NameInMap("Detail")]
        [Validation(Required=false)]
        public string DetailShrink { get; set; }

        /// <summary>
        /// <para>This parameter does not take effect if you set the <b>SourceType</b> parameter to <b>UDM_ECS</b>. This parameter specifies the paths to the files that are excluded from the backup job. The value can be up to 255 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;/var&quot;, &quot;/proc&quot;]</para>
        /// </summary>
        [NameInMap("Exclude")]
        [Validation(Required=false)]
        public string Exclude { get; set; }

        /// <summary>
        /// <para>This parameter does not take effect if you set the <b>SourceType</b> parameter to <b>UDM_ECS</b>. This parameter specifies the paths to the files that are backed up. The value can be up to 255 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;/home/alice/<em>.pdf&quot;, &quot;/home/bob/</em>.txt&quot;]</para>
        /// </summary>
        [NameInMap("Include")]
        [Validation(Required=false)]
        public string Include { get; set; }

        /// <summary>
        /// <para>false or left empty</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("InitiatedByAck")]
        [Validation(Required=false)]
        public bool? InitiatedByAck { get; set; }

        /// <summary>
        /// <para>This parameter is required only if you set the <b>SourceType</b> parameter to <b>UDM_ECS</b>. This parameter specifies the ID of the ECS instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp1xxxxxxxxxxxxxxysm</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The name of the backup job.</para>
        /// 
        /// <b>Example:</b>
        /// <para>k8s-backup-infra-20220131150046-hbr</para>
        /// </summary>
        [NameInMap("JobName")]
        [Validation(Required=false)]
        public string JobName { get; set; }

        /// <summary>
        /// <para>You do not need to specify this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;UseVSS&quot;:false}</para>
        /// </summary>
        [NameInMap("Options")]
        [Validation(Required=false)]
        public string Options { get; set; }

        /// <summary>
        /// <para>The retention period of the backup data. Unit: days.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("Retention")]
        [Validation(Required=false)]
        public long? Retention { get; set; }

        /// <summary>
        /// <para>The type of the data source. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>UDM_ECS</b>: Elastic Compute Service (ECS) instance</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CONTAINER</para>
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// <para>This parameter does not take effect if you set the <b>SourceType</b> parameter to <b>UDM_ECS</b>. This parameter specifies the throttling rules. Format: <c>{start}|{end}|{bandwidth}</c>. Separate multiple throttling rules with vertical bars (|). A specified time range cannot overlap with another time range.</para>
        /// <list type="bullet">
        /// <item><description><b>start</b>: the start hour.</description></item>
        /// <item><description><b>end</b>: the end hour.</description></item>
        /// <item><description><b>bandwidth</b>: the bandwidth. Unit: KB/s.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0:24:NaN</para>
        /// </summary>
        [NameInMap("SpeedLimit")]
        [Validation(Required=false)]
        public string SpeedLimit { get; set; }

        /// <summary>
        /// <para>The ID of the backup vault. This parameter is not required if you set the SourceType parameter to UDM_ECS.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v-000xxxxxxxxxxxxxxy1v</para>
        /// </summary>
        [NameInMap("VaultId")]
        [Validation(Required=false)]
        public string VaultId { get; set; }

    }

}
