// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CreateOpaClusterPluginRequest : TeaModel {
        /// <summary>
        /// The cluster IDs.
        /// 
        /// >  You can call the [DescribeGroupedContainerInstances](~~DescribeGroupedContainerInstances~~) operation to query the IDs of clusters.
        /// </summary>
        [NameInMap("ClusterIds")]
        [Validation(Required=false)]
        public List<string> ClusterIds { get; set; }

    }

}
