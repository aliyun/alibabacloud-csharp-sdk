// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class UpdatePrometheusGlobalViewRequest : TeaModel {
        /// <summary>
        /// 创建GlobalView时，是否要求所有子实例都校验成功时，才创建GlobalView实例。默认是false，即可以部分成功。
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

        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

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
