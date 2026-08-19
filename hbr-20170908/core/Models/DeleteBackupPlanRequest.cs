// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class DeleteBackupPlanRequest : TeaModel {
        /// <summary>
        /// <para>The edition type. Valid values are BASIC and STANDARD. The default value is STANDARD.</para>
        /// 
        /// <b>Example:</b>
        /// <para>STANDARD</para>
        /// </summary>
        [NameInMap("Edition")]
        [Validation(Required=false)]
        public string Edition { get; set; }

        /// <summary>
        /// <para>The ID of the backup plan.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>plan-*********************</para>
        /// </summary>
        [NameInMap("PlanId")]
        [Validation(Required=false)]
        public string PlanId { get; set; }

        /// <summary>
        /// <para>Specifies whether to prevent the deletion of the backup plan if backup jobs are running.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("RequireNoRunningJobs")]
        [Validation(Required=false)]
        public bool? RequireNoRunningJobs { get; set; }

        /// <summary>
        /// <para>The type of the data source. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>ECS_FILE</b>: Backs up Elastic Compute Service (ECS) files.</para>
        /// </description></item>
        /// <item><description><para><b>OSS</b>: Backs up Object Storage Service (OSS) buckets.</para>
        /// </description></item>
        /// <item><description><para><b>NAS</b>: Backs up Network Attached Storage (NAS) file systems.</para>
        /// </description></item>
        /// <item><description><para><b>UDM_ECS</b>: Backs up entire ECS instances.</para>
        /// </description></item>
        /// <item><description><para><b>OTS</b>: Backs up Tablestore instances.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ECS_FILE</para>
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// <para>The ID of the backup vault. This parameter is required if the SourceType parameter is not set to UDM_ECS.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v-*********************</para>
        /// </summary>
        [NameInMap("VaultId")]
        [Validation(Required=false)]
        public string VaultId { get; set; }

    }

}
