// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class DeleteBackupPlanRequest : TeaModel {
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
        /// <para>Specifies whether no running jobs are required.</para>
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
        /// <item><description><b>ECS_FILE</b>: Elastic Compute Service (ECS) files</description></item>
        /// <item><description><b>OSS</b>: Object Storage Service (OSS) buckets</description></item>
        /// <item><description><b>NAS</b>: Apsara File Storage NAS file systems</description></item>
        /// <item><description><b>UDM_ECS</b>: ECS instances</description></item>
        /// <item><description><b>OTS</b>: Tablestore instances</description></item>
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
