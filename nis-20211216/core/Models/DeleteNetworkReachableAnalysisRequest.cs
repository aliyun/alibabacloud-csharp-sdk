// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nis20211216.Models
{
    public class DeleteNetworkReachableAnalysisRequest : TeaModel {
        /// <summary>
        /// The IDs of the tasks for analyzing network reachability.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("NetworkReachableAnalysisIds")]
        [Validation(Required=false)]
        public List<string> NetworkReachableAnalysisIds { get; set; }

        /// <summary>
        /// The ID of the region for which you want to delete a task for analyzing network reachability.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
