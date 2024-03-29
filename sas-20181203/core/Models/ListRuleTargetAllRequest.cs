// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListRuleTargetAllRequest : TeaModel {
        /// <summary>
        /// The ID of the container cluster.
        /// 
        /// > You can call the [DescribeGroupedContainerInstances](~~182997~~) operation to query the IDs of container clusters.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

    }

}
