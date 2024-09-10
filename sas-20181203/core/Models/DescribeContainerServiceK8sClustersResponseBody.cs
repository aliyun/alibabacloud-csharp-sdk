// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeContainerServiceK8sClustersResponseBody : TeaModel {
        /// <summary>
        /// The information about the clusters.
        /// </summary>
        [NameInMap("K8sClusters")]
        [Validation(Required=false)]
        public List<DescribeContainerServiceK8sClustersResponseBodyK8sClusters> K8sClusters { get; set; }
        public class DescribeContainerServiceK8sClustersResponseBodyK8sClusters : TeaModel {
            /// <summary>
            /// The ID of the cluster.
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// The name of the cluster.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
