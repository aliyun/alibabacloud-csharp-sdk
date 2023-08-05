// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DeleteInterceptionRuleRequest : TeaModel {
        /// <summary>
        /// The ID of the cluster that you want to query.
        /// 
        /// > You can call the [DescribeGroupedContainerInstances](~~DescribeGroupedContainerInstances~~) operation to query the IDs of clusters.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// The IDs of the rules that you want to delete.
        /// </summary>
        [NameInMap("RuleIds")]
        [Validation(Required=false)]
        public List<long?> RuleIds { get; set; }

    }

}
