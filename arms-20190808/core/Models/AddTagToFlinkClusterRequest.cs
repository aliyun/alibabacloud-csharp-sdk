// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class AddTagToFlinkClusterRequest : TeaModel {
        /// <summary>
        /// The ID of the Prometheus instance.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// The ID of the Flink workspace.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("FlinkWorkSpaceId")]
        [Validation(Required=false)]
        public string FlinkWorkSpaceId { get; set; }

        /// <summary>
        /// The name of the Flink workspace.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("FlinkWorkSpaceName")]
        [Validation(Required=false)]
        public string FlinkWorkSpaceName { get; set; }

        /// <summary>
        /// The region ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the resource group.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The ID of the Alibaba Cloud account to which the Flink workspace belongs.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TargetUserId")]
        [Validation(Required=false)]
        public string TargetUserId { get; set; }

    }

}
