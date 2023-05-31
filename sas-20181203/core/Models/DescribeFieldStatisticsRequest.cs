// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeFieldStatisticsRequest : TeaModel {
        /// <summary>
        /// The type of the asset to query. If no asset types are specified, all types of assets are returned. Valid values:
        /// 
        /// *   **ecs**: server
        /// *   **cloud_product**: Alibaba Cloud service
        /// </summary>
        [NameInMap("MachineTypes")]
        [Validation(Required=false)]
        public string MachineTypes { get; set; }

        /// <summary>
        /// The ID of the region in which the asset resides.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
