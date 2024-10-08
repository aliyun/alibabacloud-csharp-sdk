// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class CreateBackupJobShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The backup type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>COMPLETE</b>: full backup</description></item>
        /// <item><description><b>INCREMENTAL</b>: incremental backup</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>INCREMENTAL</para>
        /// </summary>
        [NameInMap("BackupType")]
        [Validation(Required=false)]
        public string BackupType { get; set; }

        /// <summary>
        /// <para>The ID of the cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cl-00068btz******oku</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The ID of the cluster. This parameter is required only if you set the <b>SourceType</b> parameter to <b>CONTAINER</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cc-000xxxxxxxxxxxxxxi00</para>
        /// </summary>
        [NameInMap("ContainerClusterId")]
        [Validation(Required=false)]
        public string ContainerClusterId { get; set; }

        /// <summary>
        /// <para>The cluster resources. This parameter is required only if you set the <b>SourceType</b> parameter to <b>CONTAINER</b>.</para>
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
        /// <para>This parameter is required only if you set the <b>SourceType</b> parameter to <b>ECS_FILE</b>. This parameter specifies the paths to the files that are excluded from the backup job. The value must be 1 to 255 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;/var&quot;, &quot;/proc&quot;]</para>
        /// </summary>
        [NameInMap("Exclude")]
        [Validation(Required=false)]
        public string Exclude { get; set; }

        /// <summary>
        /// <para>This parameter is required only if you set the <b>SourceType</b> parameter to <b>ECS_FILE</b>. This parameter specifies the paths to the files that you want to back up. The value must be 1 to 255 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;/home/alice/<em>.pdf&quot;, &quot;/home/bob/</em>.txt&quot;]</para>
        /// </summary>
        [NameInMap("Include")]
        [Validation(Required=false)]
        public string Include { get; set; }

        /// <summary>
        /// <para>This parameter specifies whether to initiate the request by using Container Service for Kubernetes (ACK). Default value: false.</para>
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
        /// <para>This parameter is required only if you set the <b>SourceType</b> parameter to <b>ECS_FILE</b>. This parameter specifies whether to use Windows Volume Shadow Copy Service (VSS) to define a source path.</para>
        /// <list type="bullet">
        /// <item><description>This parameter is available only for Windows ECS instances.</description></item>
        /// <item><description>If data changes occur in the backup source, the source data must be the same as the data to be backed up before you can set this parameter to <c>[&quot;UseVSS&quot;:true]</c>.</description></item>
        /// <item><description>If you use VSS, you cannot back up data from multiple directories.</description></item>
        /// </list>
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
        /// <item><description><b>ECS_FILE</b>: Elastic Compute Service (ECS) files</description></item>
        /// <item><description><b>UDM_ECS</b>: ECS instances</description></item>
        /// <item><description><b>CONTAINER</b>: containers</description></item>
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
        /// <para>This parameter is required only if you set the <b>SourceType</b> parameter to <b>ECS_FILE</b>. This parameter specifies the throttling rules. Format: <c>{start}|{end}|{bandwidth}</c>. Separate multiple throttling rules with vertical bars (|). A specified time range cannot overlap with another time range.</para>
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
        /// <para>The ID of the backup vault.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v-000xxxxxxxxxxxxxxy1v</para>
        /// </summary>
        [NameInMap("VaultId")]
        [Validation(Required=false)]
        public string VaultId { get; set; }

    }

}
