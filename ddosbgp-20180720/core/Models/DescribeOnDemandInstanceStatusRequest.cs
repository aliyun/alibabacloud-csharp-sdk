// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20180720.Models
{
    public class DescribeOnDemandInstanceStatusRequest : TeaModel {
        /// <summary>
        /// The mode used to start the on-demand instance. Valid values:
        /// 
        /// *   **manual**: The instance is manually started.
        /// *   **netflow-auto**: The instance is automatically started by using NetFlow that monitors network traffic.
        /// </summary>
        [NameInMap("InstanceIdList")]
        [Validation(Required=false)]
        public List<string> InstanceIdList { get; set; }

        /// <summary>
        /// The details of the on-demand instance.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
