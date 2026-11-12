// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DeleteAIDBClusterTaskRequest : TeaModel {
        /// <summary>
        /// <para>The task ID. Note: This parameter specifies the ID of the model operator task instance created by calling CreateAIDBClusterTask, which is prefixed with pm-<em>. It does not refer to the PolarDB cluster ID, which is prefixed with pc-</em>. You can obtain the task ID by calling DescribeAIDBClusterTasks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pm-2ze9***</para>
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

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The PolarDB database instance ID for AI model services. Note: When you invoke this operation, this parameter is practically required. If it is not provided, a valid DBClusterId will result in an InvalidDBClusterId.Malformed (400) error. This parameter specifies the parent PolarDB AI cluster (prefixed with pc-*) to which the task belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-2zejpr***</para>
        /// </summary>
        [NameInMap("RelativeDBClusterId")]
        [Validation(Required=false)]
        public string RelativeDBClusterId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
