// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DeleteDBClusterRequest : TeaModel {
        /// <summary>
        /// <para>The retention policy for backup sets when the cluster is deleted. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>ALL</b>: permanently retains all backup sets.</para>
        /// </description></item>
        /// <item><description><para><b>LATEST</b>: permanently retains the last backup set. The system automatically creates a new backup before the cluster is deleted.</para>
        /// </description></item>
        /// <item><description><para><b>NONE</b>: does not retain any backup sets after the cluster is deleted.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>NONE</para>
        /// </summary>
        [NameInMap("BackupRetentionPolicyOnClusterDeletion")]
        [Validation(Required=false)]
        public string BackupRetentionPolicyOnClusterDeletion { get; set; }

        /// <summary>
        /// <para>The cloud service provider of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ENS</para>
        /// </summary>
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
