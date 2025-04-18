// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nis20211216.Models
{
    public class DeleteNetworkReachableAnalysisShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of the tasks for analyzing network reachability.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("NetworkReachableAnalysisIds")]
        [Validation(Required=false)]
        public string NetworkReachableAnalysisIdsShrink { get; set; }

        /// <summary>
        /// <para>The ID of the region for which you want to delete a task for analyzing network reachability.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
