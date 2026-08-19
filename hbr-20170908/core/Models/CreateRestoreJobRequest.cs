// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class CreateRestoreJobRequest : TeaModel {
        /// <summary>
        /// <para>The name of the RAM role created in the source account for cross-account backup managed by the current account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BackupRole</para>
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
        /// <para>SELF_ACCOUNT</para>
        /// </summary>
        [NameInMap("CrossAccountType")]
        [Validation(Required=false)]
        public string CrossAccountType { get; set; }

        /// <summary>
        /// <para>The ID of the source account for cross-account backup managed by the current account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>158975xxxxx4625</para>
        /// </summary>
        [NameInMap("CrossAccountUserId")]
        [Validation(Required=false)]
        public long? CrossAccountUserId { get; set; }

        /// <summary>
        /// <para>The Cloud Backup feature edition. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>STANDARD</b>: Standard Edition. This is the default value.</description></item>
        /// <item><description><b>BASIC</b>: Essential Edition. Currently, only ECS File Backup Essential Edition is supported.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>STANDARD</para>
        /// </summary>
        [NameInMap("Edition")]
        [Validation(Required=false)]
        public string Edition { get; set; }

        /// <summary>
        /// <para>The path to exclude from restoration. All files under this path are not restored. Maximum length: 255 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;/var&quot;, &quot;/proc&quot;]</para>
        /// </summary>
        [NameInMap("Exclude")]
        [Validation(Required=false)]
        public string Exclude { get; set; }

        /// <summary>
        /// <para>The details of the restoration to the local host.</para>
        /// </summary>
        [NameInMap("FailbackDetail")]
        [Validation(Required=false)]
        public Dictionary<string, object> FailbackDetail { get; set; }

        /// <summary>
        /// <para>The path to restore. All files under this path are restored. Maximum length: 255 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;/home/alice/<em>.pdf&quot;, &quot;/home/bob/</em>.txt&quot;]</para>
        /// </summary>
        [NameInMap("Include")]
        [Validation(Required=false)]
        public string Include { get; set; }

        /// <summary>
        /// <para>Specifies whether the operation is invoked by Container Service. Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("InitiatedByAck")]
        [Validation(Required=false)]
        public bool? InitiatedByAck { get; set; }

        /// <summary>
        /// <para>The restore job parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;includes\&quot;:[],\&quot;excludes\&quot;:[],\&quot;conflictPolicy\&quot;:\&quot;OVERWRITE_EXISTING\&quot;}</para>
        /// </summary>
        [NameInMap("Options")]
        [Validation(Required=false)]
        public string Options { get; set; }

        /// <summary>
        /// <para>The details of the Tablestore instance.</para>
        /// </summary>
        [NameInMap("OtsDetail")]
        [Validation(Required=false)]
        public OtsTableRestoreDetail OtsDetail { get; set; }

        /// <summary>
        /// <para>The data source type of the restore destination. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ECS_FILE</b>: restores to an ECS file.</description></item>
        /// <item><description><b>OSS</b>: restores to Alibaba Cloud OSS.</description></item>
        /// <item><description><b>NAS</b>: restores to Alibaba Cloud NAS.</description></item>
        /// <item><description><b>COMMON_FILE_SYSTEM</b>: restores to CPFS.</description></item>
        /// <item><description><b>OTS_TABLE</b>: restores to Alibaba Cloud OTS.</description></item>
        /// <item><description><b>UDM_ECS_ROLLBACK</b>: restores to an Alibaba Cloud ECS instance (full-copy migration).</description></item>
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
        /// <para>The hash value of the backup snapshot.</para>
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
        /// <para>The data source type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ECS_FILE</b>: restores ECS files.</description></item>
        /// <item><description><b>OSS</b>: restores Alibaba Cloud OSS.</description></item>
        /// <item><description><b>NAS</b>: restores Alibaba Cloud NAS.</description></item>
        /// <item><description><b>COMMON_FILE_SYSTEM</b>: restores to CPFS.</description></item>
        /// <item><description><b>OTS_TABLE</b>: restores to Alibaba Cloud OTS.</description></item>
        /// <item><description><b>UDM_ECS</b>: restores to an Alibaba Cloud ECS instance (full-copy migration).</description></item>
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
        /// <para>This parameter is valid only when <b>RestoreType</b> is set to <b>OSS</b>. The name of the destination OSS bucket.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hbr-backup-oss</para>
        /// </summary>
        [NameInMap("TargetBucket")]
        [Validation(Required=false)]
        public string TargetBucket { get; set; }

        /// <summary>
        /// <para>The details of the target container for restoration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;host\&quot;:\&quot;k8s-node1\&quot;,\&quot;hostPrefix\&quot;:\&quot;/var/lib/kubelet/pods/4acb31fe-8577-40ff-bc8c-eccabd835f73/volumes/kubernetes.io~csi/pvc-b050b00e-ef17-4792-aab1-1642355cf1f4/mount\&quot;,\&quot;pvPath\&quot;:\&quot;/\&quot;}</para>
        /// </summary>
        [NameInMap("TargetContainer")]
        [Validation(Required=false)]
        public string TargetContainer { get; set; }

        /// <summary>
        /// <para>The ID of the target container cluster for restoration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cc-000amjsc7o1h9506oob7</para>
        /// </summary>
        [NameInMap("TargetContainerClusterId")]
        [Validation(Required=false)]
        public string TargetContainerClusterId { get; set; }

        /// <summary>
        /// <para>This parameter is valid only when <b>RestoreType</b> is set to <b>NAS</b>. The creation time of the destination file system. This value is a UNIX timestamp. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1554347313</para>
        /// </summary>
        [NameInMap("TargetCreateTime")]
        [Validation(Required=false)]
        public long? TargetCreateTime { get; set; }

        /// <summary>
        /// <para>This parameter is valid only when <b>RestoreType</b> is set to <b>NAS</b>. The file system ID of the restore destination.</para>
        /// 
        /// <b>Example:</b>
        /// <para>005494</para>
        /// </summary>
        [NameInMap("TargetFileSystemId")]
        [Validation(Required=false)]
        public string TargetFileSystemId { get; set; }

        /// <summary>
        /// <para>This parameter is valid only when <b>RestoreType</b> is set to <b>ECS_FILE</b>. The ECS instance ID of the restore destination.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-*********************</para>
        /// </summary>
        [NameInMap("TargetInstanceId")]
        [Validation(Required=false)]
        public string TargetInstanceId { get; set; }

        /// <summary>
        /// <para>The name of the target Tablestore instance for restoration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>instancename</para>
        /// </summary>
        [NameInMap("TargetInstanceName")]
        [Validation(Required=false)]
        public string TargetInstanceName { get; set; }

        /// <summary>
        /// <para>This parameter is valid only when <b>RestoreType</b> is set to <b>ECS_FILE</b>. The file path of the restore destination.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C:\</para>
        /// </summary>
        [NameInMap("TargetPath")]
        [Validation(Required=false)]
        public string TargetPath { get; set; }

        /// <summary>
        /// <para>This parameter is valid only when <b>RestoreType</b> is set to <b>OSS</b>. The object prefix of the restore destination.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hbr</para>
        /// </summary>
        [NameInMap("TargetPrefix")]
        [Validation(Required=false)]
        public string TargetPrefix { get; set; }

        /// <summary>
        /// <para>The name of the target data table in Tablestore for restoration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tablename</para>
        /// </summary>
        [NameInMap("TargetTableName")]
        [Validation(Required=false)]
        public string TargetTableName { get; set; }

        /// <summary>
        /// <para>The point in time to which the Tablestore data is restored. This value is a UNIX timestamp. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1642496881</para>
        /// </summary>
        [NameInMap("TargetTime")]
        [Validation(Required=false)]
        public long? TargetTime { get; set; }

        /// <summary>
        /// <para>This parameter is valid only when SourceType is set to UDM_ECS. The details of the full-copy migration backup. This parameter is a JSON string. The details vary depending on the value of RestoreType:</para>
        /// <list type="bullet">
        /// <item><description><b>UDM_ECS_DISK</b>: ECS cloud disk clone.<list type="bullet">
        /// <item><description><b>targetInstanceId</b>: string type, required. Instance ID of the target ECS instance to which the cloned cloud disk is attached.</description></item>
        /// <item><description><b>diskCategory</b>: string type, required. The type of the target cloud disk.</description></item>
        /// <item><description><b>diskPerformanceLevel</b>: string type. If diskCategory is set to essd, this parameter specifies the performance level (PL) of the cloud disk. Valid values: PL0, PL1, PL2, and PL3. Default value: PL1.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><b>UDM_ECS_DISK_ROLLBACK</b>: ECS cloud disk restoration.<list type="bullet">
        /// <item><description><b>sourceInstanceId</b>: string type, required. Instance ID of the source ECS instance.</description></item>
        /// <item><description><b>foreceRestore</b>: bool type. Default value: false. Specifies whether to forcibly restore. If foreceRestore is set to true, the restore job still restores the cloud disk even if the backed-up cloud disk has been unmounted from the original ECS instance or attached to a new ECS instance. Proceed with caution.</description></item>
        /// <item><description><b>bootAfterRestore</b>: bool type. Default value: false. Specifies whether to start the ECS instance after restoration.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><b>UDM_ECS</b>: ECS full-copy clone.<list type="bullet">
        /// <item><description><b>bootAfterRestore</b>: bool type. Default value: false. Specifies whether to start the ECS instance after restoration.</description></item>
        /// <item><description><b>diskCategory</b>: string type, required. The type of the target cloud disk.</description></item>
        /// <item><description><b>diskPerformanceLevel</b>: string type. If diskCategory is set to essd, this parameter specifies the performance level (PL) of the cloud disk. Valid values: PL0, PL1, PL2, and PL3. Default value: PL1.</description></item>
        /// <item><description><b>instanceType</b>: string type, required. The instance type of the target ECS instance.</description></item>
        /// <item><description><b>restoredNetwork</b>: string type, required. The vSwitch ID of the target ECS instance.</description></item>
        /// <item><description><b>securityGroup</b>: string type, required. The security group ID of the target ECS instance.</description></item>
        /// <item><description><b>restoredName</b>: string type, required. The instance name of the target ECS instance.</description></item>
        /// <item><description><b>restoredHostName</b>: string type, required. The hostname of the target ECS instance.</description></item>
        /// <item><description><b>allocatePublicIp</b>: bool type. Default value: false. Specifies whether to assign a public IP address to the target ECS instance.</description></item>
        /// <item><description><b>privateIpAddress</b>: string type. The internal IP address of the target ECS instance. If this parameter is not specified, DHCP is used to randomly assign an IP address.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><b>UDM_ECS_ROLLBACK</b>: ECS full-copy restoration.<list type="bullet">
        /// <item><description><b>sourceInstanceId</b>: string type, required. Instance ID of the source ECS instance.</description></item>
        /// <item><description><b>forceRestore</b>: bool type. Default value: false. Specifies whether to forcibly restore. If foreceRestore is set to true, the restore job still restores the cloud disk even if the backed-up cloud disk has been unmounted from the original ECS instance or attached to a new ECS instance. Proceed with caution.</description></item>
        /// <item><description><b>bootAfterRestore</b>: bool type. Default value: false. Specifies whether to start the ECS instance after restoration.</description></item>
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
        /// <para>This parameter is valid only when <b>SourceType</b> is set to <b>UDM_ECS</b>. The destination region for restoration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("UdmRegionId")]
        [Validation(Required=false)]
        public string UdmRegionId { get; set; }

        /// <summary>
        /// <para>The ID of the backup vault to which the backup snapshot belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v-*********************</para>
        /// </summary>
        [NameInMap("VaultId")]
        [Validation(Required=false)]
        public string VaultId { get; set; }

    }

}
