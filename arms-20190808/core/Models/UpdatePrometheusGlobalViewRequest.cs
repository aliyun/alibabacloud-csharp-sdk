// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class UpdatePrometheusGlobalViewRequest : TeaModel {
        /// <summary>
        /// To edit a GlobalView aggregated instance, do you require all passed child instances to be verified successfully before creating a GlobalView instance (optional, default to false):
        /// - true
        /// - false
        /// </summary>
        [NameInMap("AllSubClustersSuccess")]
        [Validation(Required=false)]
        public bool? AllSubClustersSuccess { get; set; }

        /// <summary>
        /// The ID of the Prometheus instance.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// The name of the global aggregation instance.
        /// </summary>
        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// The region ID of the global aggregation instance.
        /// </summary>
        [NameInMap("MostRegionId")]
        [Validation(Required=false)]
        public string MostRegionId { get; set; }

        /// <summary>
        /// The ID of the region in which the Prometheus instance resides.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the resource group to which the Prometheus instance belongs.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The data sources of the Prometheus instance for GlobalView.
        /// </summary>
        [NameInMap("SubClustersJson")]
        [Validation(Required=false)]
        public string SubClustersJson { get; set; }

    }

}
