// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListClusterInterceptionConfigRequest : TeaModel {
        /// <summary>
        /// The status of the container firewall feature. Valid values:
        /// 
        /// *   **-1**: unknown
        /// *   **0**: abnormal
        /// *   **1**: normal
        /// *   **2**: normal to be confirmed
        /// </summary>
        [NameInMap("ClusterCNNFStatus")]
        [Validation(Required=false)]
        public int? ClusterCNNFStatus { get; set; }

        /// <summary>
        /// The ID of the cluster.
        /// 
        /// > You can call the [DescribeContainerInstances](~~DescribeContainerInstances~~) operation to query the IDs of clusters.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// The name of the cluster.
        /// </summary>
        [NameInMap("ClusterName")]
        [Validation(Required=false)]
        public string ClusterName { get; set; }

        /// <summary>
        /// The number of the page to return. Default value: 1.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Default value: 20.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
