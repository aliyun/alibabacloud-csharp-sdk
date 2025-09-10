// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class EnableBackupPlanRequest : TeaModel {
        /// <summary>
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
        /// <para>The type of the data source. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ECS_FILE</b>: ECS files</description></item>
        /// <item><description><b>OSS</b>: Object Storage Service (OSS) buckets</description></item>
        /// <item><description><b>NAS</b>: Apsara File Storage NAS (NAS) file systems</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ECS_FILE</para>
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// <para>The ID of the backup vault.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v-*********************</para>
        /// </summary>
        [NameInMap("VaultId")]
        [Validation(Required=false)]
        public string VaultId { get; set; }

    }

}
