// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeClustersRequest : TeaModel {
        /// <summary>
        /// The cluster type.
        /// </summary>
        [NameInMap("clusterType")]
        [Validation(Required=false)]
        public string ClusterType { get; set; }

        /// <summary>
        /// The cluster name based on which the system performs fuzzy searches among the clusters that belong to the current Alibaba Cloud account.
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("resource_group_id")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}
