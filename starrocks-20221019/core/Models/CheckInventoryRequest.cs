// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Starrocks20221019.Models
{
    public class CheckInventoryRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;clusterType&quot;: &quot;sr&quot;,
        ///   &quot;regionId&quot;: &quot;cn-hangzhou&quot;,
        ///   &quot;packageType&quot;: &quot;official&quot;,
        ///   &quot;runMode&quot;: &quot;shared_data&quot;,
        ///   &quot;beResourceSpec&quot;: {
        ///     &quot;cu&quot;: 8,
        ///     &quot;storageSize&quot;: 200,
        ///     &quot;nodeNumber&quot;: 3,
        ///     &quot;diskNumber&quot;: 1,
        ///     &quot;storagePerformanceLevel&quot;: &quot;pl1&quot;,
        ///     &quot;diskType&quot;: &quot;essd&quot;,
        ///     &quot;specType&quot;: &quot;standard&quot;
        ///   },
        ///   &quot;feResourceSpec&quot;: {
        ///     &quot;cu&quot;: 8,
        ///     &quot;storageSize&quot;: 100,
        ///     &quot;nodeNumber&quot;: 3,
        ///     &quot;specType&quot;: &quot;standard&quot;
        ///   }
        /// }</para>
        /// </summary>
        [NameInMap("ClusterInfo")]
        [Validation(Required=false)]
        public string ClusterInfo { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-hangzhou-h</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
