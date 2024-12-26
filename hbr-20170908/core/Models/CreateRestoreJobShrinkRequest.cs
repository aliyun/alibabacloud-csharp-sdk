// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class CreateRestoreJobShrinkRequest : TeaModel {
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
        /// <para>158975xxxxx4625</para>
        /// </summary>
        [NameInMap("CrossAccountUserId")]
        [Validation(Required=false)]
        public long? CrossAccountUserId { get; set; }

        /// <summary>
        /// <para>The paths to the files that you do not want to restore. No files in the specified paths are restored. The value must be 1 to 255 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;/var&quot;, &quot;/proc&quot;]</para>
        /// </summary>
        [NameInMap("Exclude")]
        [Validation(Required=false)]
        public string Exclude { get; set; }

        /// <summary>
        /// <para>Details of restoration to local.</para>
        /// </summary>
        [NameInMap("FailbackDetail")]
        [Validation(Required=false)]
        public string FailbackDetailShrink { get; set; }

        /// <summary>
        /// <para>The paths to the files that you want to restore. All files in the specified paths are restored. The value must be 1 to 255 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;/home/alice/<em>.pdf&quot;, &quot;/home/bob/</em>.txt&quot;]</para>
        /// </summary>
        [NameInMap("Include")]
        [Validation(Required=false)]
        public string Include { get; set; }

        /// <summary>
        /// <para>Specifies whether to initiate the request by using Container Service for Kubernetes (ACK). Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("InitiatedByAck")]
        [Validation(Required=false)]
        public bool? InitiatedByAck { get; set; }

        /// <summary>
        /// <para>Parameters for restoring a task</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;includes\&quot;:[],\&quot;excludes\&quot;:[],\&quot;conflictPolicy\&quot;:\&quot;OVERWRITE_EXISTING\&quot;}</para>
        /// </summary>
        [NameInMap("Options")]
        [Validation(Required=false)]
        public string Options { get; set; }

        /// <summary>
        /// <para>The details about the Tablestore instance.</para>
        /// </summary>
        [NameInMap("OtsDetail")]
        [Validation(Required=false)]
        public string OtsDetailShrink { get; set; }

        /// <summary>
        /// <para>The type of the restore destination. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ECS_FILE</b>: restores data to Elastic Compute Service (ECS) files.</description></item>
        /// <item><description><b>OSS</b>: restores data to Object Storage Service (OSS) buckets.</description></item>
        /// <item><description><b>NAS</b>: restores data to Apsara File Storage NAS file systems.</description></item>
        /// <item><description><b>OTS_TABLE</b>: restores data to Tablestore instances.</description></item>
        /// <item><description><b>UDM_ECS_ROLLBACK</b>: restores data to ECS instances.</description></item>
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
        /// <para>The type of the data source. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ECS_FILE</b>: ECS files</description></item>
        /// <item><description><b>OSS</b>: OSS buckets</description></item>
        /// <item><description><b>NAS</b>: NAS file systems</description></item>
        /// <item><description><b>OTS_TABLE</b>: Tablestore instances</description></item>
        /// <item><description><b>UDM_ECS</b>: ECS instances</description></item>
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
        /// <para>This parameter is required only if the <b>RestoreType</b> parameter is set to <b>OSS</b>. This parameter specifies the name of the OSS bucket to which you want to restore data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hbr-backup-oss</para>
        /// </summary>
        [NameInMap("TargetBucket")]
        [Validation(Required=false)]
        public string TargetBucket { get; set; }

        /// <summary>
        /// <para>The details about the container to which you want to restore data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;host\&quot;:\&quot;k8s-node1\&quot;,\&quot;hostPrefix\&quot;:\&quot;/var/lib/kubelet/pods/4acb31fe-8577-40ff-bc8c-eccabd835f73/volumes/kubernetes.io~csi/pvc-b050b00e-ef17-4792-aab1-1642355cf1f4/mount\&quot;,\&quot;pvPath\&quot;:\&quot;/\&quot;}</para>
        /// </summary>
        [NameInMap("TargetContainer")]
        [Validation(Required=false)]
        public string TargetContainer { get; set; }

        /// <summary>
        /// <para>The ID of the container cluster to which you want to restore data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cc-000amjsc7o1h9506oob7</para>
        /// </summary>
        [NameInMap("TargetContainerClusterId")]
        [Validation(Required=false)]
        public string TargetContainerClusterId { get; set; }

        /// <summary>
        /// <para>This parameter is required only if the <b>RestoreType</b> parameter is set to <b>NAS</b>. This parameter specifies the time when the file system is created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1554347313</para>
        /// </summary>
        [NameInMap("TargetCreateTime")]
        [Validation(Required=false)]
        public long? TargetCreateTime { get; set; }

        /// <summary>
        /// <para>This parameter is required only if the <b>RestoreType</b> parameter is set to <b>NAS</b>. This parameter specifies the ID of the file system to which you want to restore data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>005494</para>
        /// </summary>
        [NameInMap("TargetFileSystemId")]
        [Validation(Required=false)]
        public string TargetFileSystemId { get; set; }

        /// <summary>
        /// <para>This parameter is required only if the <b>RestoreType</b> parameter is set to <b>ECS_FILE</b>. This parameter specifies the ID of the ECS instance to which you want to restore data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-*********************</para>
        /// </summary>
        [NameInMap("TargetInstanceId")]
        [Validation(Required=false)]
        public string TargetInstanceId { get; set; }

        /// <summary>
        /// <para>The name of the Tablestore instance to which you want to restore data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>instancename</para>
        /// </summary>
        [NameInMap("TargetInstanceName")]
        [Validation(Required=false)]
        public string TargetInstanceName { get; set; }

        /// <summary>
        /// <para>This parameter is required only if the <b>RestoreType</b> parameter is set to <b>ECS_FILE</b>. This parameter specifies the destination file path.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C:\</para>
        /// </summary>
        [NameInMap("TargetPath")]
        [Validation(Required=false)]
        public string TargetPath { get; set; }

        /// <summary>
        /// <para>This parameter is required only if the <b>RestoreType</b> parameter is set to <b>OSS</b>. This parameter specifies the prefix of objects that you want to restore.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hbr</para>
        /// </summary>
        [NameInMap("TargetPrefix")]
        [Validation(Required=false)]
        public string TargetPrefix { get; set; }

        /// <summary>
        /// <para>The name of the table that stores the restored data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tablename</para>
        /// </summary>
        [NameInMap("TargetTableName")]
        [Validation(Required=false)]
        public string TargetTableName { get; set; }

        /// <summary>
        /// <para>The time when data is restored to the Tablestore instance. The value must be a UNIX timestamp. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1642496881</para>
        /// </summary>
        [NameInMap("TargetTime")]
        [Validation(Required=false)]
        public long? TargetTime { get; set; }

        /// <summary>
        /// <para>The details of ECS instance backup.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;sourceInstanceId\&quot;:\&quot;i-uf62te6pm3iwsyxyz66q\&quot;,\&quot;bootAfterRestore\&quot;:false}</para>
        /// </summary>
        [NameInMap("UdmDetail")]
        [Validation(Required=false)]
        public string UdmDetailShrink { get; set; }

        /// <summary>
        /// <para>This parameter is required only if you set the <b>SourceType</b> parameter to <b>UDM_ECS</b>. This parameter specifies the region to which you want to restore data.</para>
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
