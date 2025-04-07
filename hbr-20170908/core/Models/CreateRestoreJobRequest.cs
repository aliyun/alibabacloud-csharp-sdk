// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class CreateRestoreJobRequest : TeaModel {
        /// <summary>
        /// <para>The name of the role created in the RAM of the original account for cross-account backup managed by the current account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BackupRole</para>
        /// </summary>
        [NameInMap("CrossAccountRoleName")]
        [Validation(Required=false)]
        public string CrossAccountRoleName { get; set; }

        /// <summary>
        /// <para>Cross-account backup type. Supported values:</para>
        /// <list type="bullet">
        /// <item><description>SELF_ACCOUNT: Backup within the same account</description></item>
        /// <item><description>CROSS_ACCOUNT: Cross-account backup</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SELF_ACCOUNT</para>
        /// </summary>
        [NameInMap("CrossAccountType")]
        [Validation(Required=false)]
        public string CrossAccountType { get; set; }

        /// <summary>
        /// <para>The original account ID managed by the current account for cross-account backup.</para>
        /// 
        /// <b>Example:</b>
        /// <para>158975xxxxx4625</para>
        /// </summary>
        [NameInMap("CrossAccountUserId")]
        [Validation(Required=false)]
        public long? CrossAccountUserId { get; set; }

        /// <summary>
        /// <para>The path not to be restored. All documents under this path will not be restored. Maximum length is 255 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;/var&quot;, &quot;/proc&quot;]</para>
        /// </summary>
        [NameInMap("Exclude")]
        [Validation(Required=false)]
        public string Exclude { get; set; }

        /// <summary>
        /// <para>Details of restoring to the local environment.</para>
        /// </summary>
        [NameInMap("FailbackDetail")]
        [Validation(Required=false)]
        public Dictionary<string, object> FailbackDetail { get; set; }

        /// <summary>
        /// <para>The path to be restored. All documents under this path will be restored. Maximum length is 255 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;/home/alice/<em>.pdf&quot;, &quot;/home/bob/</em>.txt&quot;]</para>
        /// </summary>
        [NameInMap("Include")]
        [Validation(Required=false)]
        public string Include { get; set; }

        /// <summary>
        /// <para>Indicates whether it is called by the container service. Default is false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("InitiatedByAck")]
        [Validation(Required=false)]
        public bool? InitiatedByAck { get; set; }

        /// <summary>
        /// <para>Parameters for the restore job.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;includes\&quot;:[],\&quot;excludes\&quot;:[],\&quot;conflictPolicy\&quot;:\&quot;OVERWRITE_EXISTING\&quot;}</para>
        /// </summary>
        [NameInMap("Options")]
        [Validation(Required=false)]
        public string Options { get; set; }

        /// <summary>
        /// <para>Details of the Table Store instance.</para>
        /// </summary>
        [NameInMap("OtsDetail")]
        [Validation(Required=false)]
        public OtsTableRestoreDetail OtsDetail { get; set; }

        /// <summary>
        /// <para>The type of the restore destination data source. Possible values:</para>
        /// <list type="bullet">
        /// <item><description><b>ECS_FILE</b>: Restore to ECS file.</description></item>
        /// <item><description><b>OSS</b>: Restore to Alibaba Cloud OSS.</description></item>
        /// <item><description><b>NAS</b>: Restore to Alibaba Cloud NAS.</description></item>
        /// <item><description><b>OTS_TABLE</b>: Restore to Alibaba Cloud OTS.</description></item>
        /// <item><description><b>UDM_ECS_ROLLBACK</b>: Restore to Alibaba Cloud ECS whole machine.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ECS_FILE</para>
        /// </summary>
        [NameInMap("RestoreType")]
        [Validation(Required=false)]
        public string RestoreType { get; set; }

        /// <summary>
        /// <para>The HASH value of the backup snapshot.</para>
        /// 
        /// <b>Example:</b>
        /// <para>f2fe...</para>
        /// </summary>
        [NameInMap("SnapshotHash")]
        [Validation(Required=false)]
        public string SnapshotHash { get; set; }

        /// <summary>
        /// <para>The ID of the backup snapshot.</para>
        /// 
        /// <b>Example:</b>
        /// <para>s-********************</para>
        /// </summary>
        [NameInMap("SnapshotId")]
        [Validation(Required=false)]
        public string SnapshotId { get; set; }

        /// <summary>
        /// <para>The type of the data source. Possible values:</para>
        /// <list type="bullet">
        /// <item><description><b>ECS_FILE</b>: Restore ECS file.</description></item>
        /// <item><description><b>OSS</b>: Restore Alibaba Cloud OSS.</description></item>
        /// <item><description><b>NAS</b>: Restore Alibaba Cloud NAS.</description></item>
        /// <item><description><b>OTS_TABLE</b>: Restore to Alibaba Cloud OTS.</description></item>
        /// <item><description><b>UDM_ECS</b>: Restore to Alibaba Cloud ECS whole machine.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ECS_FILE</para>
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// <para>Valid only when <b>RestoreType</b> is <b>OSS</b>. Indicates the name of the OSS bucket at the restore destination.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hbr-backup-oss</para>
        /// </summary>
        [NameInMap("TargetBucket")]
        [Validation(Required=false)]
        public string TargetBucket { get; set; }

        /// <summary>
        /// <para>Details of the target container.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;host\&quot;:\&quot;k8s-node1\&quot;,\&quot;hostPrefix\&quot;:\&quot;/var/lib/kubelet/pods/4acb31fe-8577-40ff-bc8c-eccabd835f73/volumes/kubernetes.io~csi/pvc-b050b00e-ef17-4792-aab1-1642355cf1f4/mount\&quot;,\&quot;pvPath\&quot;:\&quot;/\&quot;}</para>
        /// </summary>
        [NameInMap("TargetContainer")]
        [Validation(Required=false)]
        public string TargetContainer { get; set; }

        /// <summary>
        /// <para>The ID of the target container cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cc-000amjsc7o1h9506oob7</para>
        /// </summary>
        [NameInMap("TargetContainerClusterId")]
        [Validation(Required=false)]
        public string TargetContainerClusterId { get; set; }

        /// <summary>
        /// <para>Valid only when <b>RestoreType</b> is <b>NAS</b>. Indicates the creation time of the file system at the restore destination.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1554347313</para>
        /// </summary>
        [NameInMap("TargetCreateTime")]
        [Validation(Required=false)]
        public long? TargetCreateTime { get; set; }

        /// <summary>
        /// <para>Valid only when <b>RestoreType</b> is <b>NAS</b>. Indicates the ID of the file system at the restore destination.</para>
        /// 
        /// <b>Example:</b>
        /// <para>005494</para>
        /// </summary>
        [NameInMap("TargetFileSystemId")]
        [Validation(Required=false)]
        public string TargetFileSystemId { get; set; }

        /// <summary>
        /// <para>Valid only when <b>RestoreType</b> is <b>ECS_FILE</b>. Indicates the ECS instance ID at the restore destination.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-*********************</para>
        /// </summary>
        [NameInMap("TargetInstanceId")]
        [Validation(Required=false)]
        public string TargetInstanceId { get; set; }

        /// <summary>
        /// <para>The name of the target Table Store instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>instancename</para>
        /// </summary>
        [NameInMap("TargetInstanceName")]
        [Validation(Required=false)]
        public string TargetInstanceName { get; set; }

        /// <summary>
        /// <para>Valid only when <b>RestoreType</b> is <b>ECS_FILE</b>. Indicates the file path at the restore destination.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C:\</para>
        /// </summary>
        [NameInMap("TargetPath")]
        [Validation(Required=false)]
        public string TargetPath { get; set; }

        /// <summary>
        /// <para>Valid only when <b>RestoreType</b> is <b>OSS</b>. Indicates the object prefix at the restore destination.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hbr</para>
        /// </summary>
        [NameInMap("TargetPrefix")]
        [Validation(Required=false)]
        public string TargetPrefix { get; set; }

        /// <summary>
        /// <para>The name of the data table in the target Table Store.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tablename</para>
        /// </summary>
        [NameInMap("TargetTableName")]
        [Validation(Required=false)]
        public string TargetTableName { get; set; }

        /// <summary>
        /// <para>The time of the Table Store to be restored. UNIX timestamp, in seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1642496881</para>
        /// </summary>
        [NameInMap("TargetTime")]
        [Validation(Required=false)]
        public long? TargetTime { get; set; }

        /// <summary>
        /// <para>The parameter is valid only when the SourceType is set to UDM_ECS. It represents the details of the entire machine backup and is a JSON string. Depending on the value of RestoreType, different details must be passed as follows:</para>
        /// <list type="bullet">
        /// <item><description><b>UDM_ECS_DISK</b>: ECS disk cloning.<list type="bullet">
        /// <item><description><b>targetInstanceId</b>: string (required). Specifies the target ECS instance ID to which the cloned disk will be attached.</description></item>
        /// <item><description><b>diskCategory</b>: string (required). Specifies the type of the target disk.</description></item>
        /// <item><description><b>diskPerformanceLevel</b>: string. When diskCategory is &quot;essd&quot;, this indicates the disk performance level, supporting PL0, PL1, PL2, and PL3, with PL1 as the default.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><b>UDM_ECS_DISK_ROLLBACK</b>: ECS disk rollback.<list type="bullet">
        /// <item><description><b>sourceInstanceId</b>: string (required). Specifies the source ECS instance ID.</description></item>
        /// <item><description><b>forceRestore</b>: bool (default: false). Indicates whether to force restore. NOTE: If forceRestore is set to true, the disk restoration will proceed even if the backup disk has been unmounted from the original ECS instance or mounted to another instance. Exercise caution when using this option.</description></item>
        /// <item><description><b>bootAfterRestore</b>: bool (default: false). Indicates whether to start the ECS instance after restoration.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><b>UDM_ECS</b>: Full ECS cloning.<list type="bullet">
        /// <item><description><b>bootAfterRestore</b>: bool (default: false). Indicates whether to start the ECS instance after restoration.</description></item>
        /// <item><description><b>diskCategory</b>: string (required). Specifies the type of the target disk.</description></item>
        /// <item><description><b>diskPerformanceLevel</b>: string. When diskCategory is &quot;essd&quot;, this indicates the disk performance level (PL0/PL1/PL2/PL3), defaulting to PL1.</description></item>
        /// <item><description><b>instanceType</b>: string (required). Specifies the specification of the target ECS instance.</description></item>
        /// <item><description><b>restoredNetwork</b>: string (required). Specifies the vSwitch ID for the target ECS instance.</description></item>
        /// <item><description><b>securityGroup</b>: string (required). Specifies the security group ID for the target ECS instance.</description></item>
        /// <item><description><b>restoredName:</b> string (required). Specifies the instance name of the target ECS instance.</description></item>
        /// <item><description><b>restoredHostName</b>: string (required). Specifies the host name of the target ECS instance.</description></item>
        /// <item><description><b>allocatePublicIp</b>: bool (default: false). Indicates whether to assign a public IP to the target ECS instance.</description></item>
        /// <item><description><b>privateIpAddress</b>: string. Specifies the internal IP address of the target ECS instance. If not specified, an IP will be assigned via DHCP.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><b>UDM_ECS_ROLLBACK</b>: Full ECS rollback.<list type="bullet">
        /// <item><description><b>sourceInstanceId</b>: string (required). Specifies the source ECS instance ID.</description></item>
        /// <item><description><b>forceRestore</b>: bool (default: false). Indicates whether to force restore. NOTE: If forceRestore is set to true, the disk restoration will proceed even if the backup disk has been unmounted from the original ECS instance or mounted to another instance. Exercise caution when using this option.</description></item>
        /// <item><description><b>bootAfterRestore</b>: bool (default: false). Indicates whether to start the ECS instance after restoration.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;sourceInstanceId\&quot;:\&quot;i-uf62te6pm3iwsyxyz66q\&quot;,\&quot;bootAfterRestore\&quot;:false}</para>
        /// </summary>
        [NameInMap("UdmDetail")]
        [Validation(Required=false)]
        public Dictionary<string, object> UdmDetail { get; set; }

        /// <summary>
        /// <para>Valid only when <b>SourceType</b> is <b>UDM_ECS</b>. Indicates the target region for the restore.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("UdmRegionId")]
        [Validation(Required=false)]
        public string UdmRegionId { get; set; }

        /// <summary>
        /// <para>The ID of the backup vault that the snapshot belongs to.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v-*********************</para>
        /// </summary>
        [NameInMap("VaultId")]
        [Validation(Required=false)]
        public string VaultId { get; set; }

    }

}
