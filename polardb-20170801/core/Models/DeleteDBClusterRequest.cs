// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DeleteDBClusterRequest : TeaModel {
        /// <summary>
        /// <para>The retention policy applied to the backup sets when the cluster is released. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ALL</b>: permanently retains all backup sets.</description></item>
        /// <item><description><b>LATEST</b>: permanently retains the most recent backup set that is automatically created before the cluster is released.</description></item>
        /// <item><description><b>NONE</b>: does not retain backup sets.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>NONE</para>
        /// </summary>
        [NameInMap("BackupRetentionPolicyOnClusterDeletion")]
        [Validation(Required=false)]
        public string BackupRetentionPolicyOnClusterDeletion { get; set; }

        [NameInMap("CloudProvider")]
        [Validation(Required=false)]
        public string CloudProvider { get; set; }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-**************</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
