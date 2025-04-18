// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nis20211216.Models
{
    public class GetNetworkReachableAnalysisRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the task for analyzing network reachability. You can call the <b>CreateNetworkRearchableAnalysis</b> operation to obtain the ID of the task for analyzing network reachability.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nra-90eef36a9e6e4662****</para>
        /// </summary>
        [NameInMap("NetworkReachableAnalysisId")]
        [Validation(Required=false)]
        public string NetworkReachableAnalysisId { get; set; }

        /// <summary>
        /// <para>The ID of the region for which you want to obtain the result of network reachability analysis.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
