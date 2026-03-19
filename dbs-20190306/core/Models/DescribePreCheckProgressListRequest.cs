// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dbs20190306.Models
{
    public class DescribePreCheckProgressListRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the backup plan.</para>
        /// <remarks>
        /// <para>Specify either BackupPlanId or RestoreTaskId.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>dbsr1l3ro21****</para>
        /// </summary>
        [NameInMap("BackupPlanId")]
        [Validation(Required=false)]
        public string BackupPlanId { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ETnLKlblzczshOTUbOCziJZNwH****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the restore job.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dbasdsa****</para>
        /// </summary>
        [NameInMap("RestoreTaskId")]
        [Validation(Required=false)]
        public string RestoreTaskId { get; set; }

    }

}
