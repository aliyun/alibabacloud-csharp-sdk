// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeClusterBasicInfoRequest : TeaModel {
        /// <summary>
        /// The ID of the cluster that you want to query.
        /// 
        /// > You can call the [DescribeGroupedContainerInstances](~~DescribeGroupedContainerInstances~~) operation to query the IDs of clusters.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// The dimension from which you want to configure the feature. Valid values:
        /// 
        /// *   **Cluster**: the ID of the cluster
        /// </summary>
        [NameInMap("TargetType")]
        [Validation(Required=false)]
        public string TargetType { get; set; }

        /// <summary>
        /// The type of the feature. Valid values:
        /// 
        /// *   **containerNetwork**: container network topology
        /// *   **interceptionSwitch**: cluster microsegmentation
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
