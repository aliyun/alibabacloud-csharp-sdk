// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dbs20190306.Models
{
    public class StopBackupPlanRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the backup plan.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dbstooi01XXXX</para>
        /// </summary>
        [NameInMap("BackupPlanId")]
        [Validation(Required=false)]
        public string BackupPlanId { get; set; }

        /// <summary>
        /// <para>A client token to ensure the idempotence of the request. This prevents the same request from being sent repeatedly.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ETnLKlblzczshOTUbOCzxxxxxxx</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        /// <summary>
        /// <para>The method used to pause the backup plan. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>ALL: Pauses the backup schedule, full data backup jobs, incremental log backup jobs, and restore jobs.</para>
        /// </description></item>
        /// <item><description><para>PLAN: Pauses only the backup schedule.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ALL</para>
        /// </summary>
        [NameInMap("StopMethod")]
        [Validation(Required=false)]
        public string StopMethod { get; set; }

    }

}
