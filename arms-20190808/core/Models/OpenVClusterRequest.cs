// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class OpenVClusterRequest : TeaModel {
        /// <summary>
        /// The type of the cluster. For cloud services, set this parameter to `cloud-product-prometheus`.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ClusterType")]
        [Validation(Required=false)]
        public string ClusterType { get; set; }

        /// <summary>
        /// The length of the cluster ID. Default value: 10.
        /// </summary>
        [NameInMap("Length")]
        [Validation(Required=false)]
        public int? Length { get; set; }

        /// <summary>
        /// The name of the cloud service. This parameter is required if you set ClusterType to `cloud-product-prometheus`. Valid values: influxdb, mongodb, and DLA. You cannot specify multiple service names.
        /// </summary>
        [NameInMap("Product")]
        [Validation(Required=false)]
        public string Product { get; set; }

        /// <summary>
        /// Specifies whether to create or query a virtual cluster. This parameter provides backward compatibility.
        /// </summary>
        [NameInMap("RecreateSwitch")]
        [Validation(Required=false)]
        public bool? RecreateSwitch { get; set; }

        /// <summary>
        /// The region ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
