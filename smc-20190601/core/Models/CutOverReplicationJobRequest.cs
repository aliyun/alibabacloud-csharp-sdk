// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smc20190601.Models
{
    public class CutOverReplicationJobRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the incremental migration job.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>j-bp1fnx5y3djc4cop****</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        /// <summary>
        /// <para>Specifies whether to migrate full data for the last time. Valid Values:</para>
        /// <list type="bullet">
        /// <item><description>true: migrates full data for the last time.</description></item>
        /// <item><description>false: does not migrate full data for the last time.</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("SyncData")]
        [Validation(Required=false)]
        public bool? SyncData { get; set; }

    }

}
