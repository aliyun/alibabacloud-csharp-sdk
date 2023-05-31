// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeCommonTargetConfigResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// An array that consists of the details of the configuration items.
        /// </summary>
        [NameInMap("TargetList")]
        [Validation(Required=false)]
        public List<DescribeCommonTargetConfigResponseBodyTargetList> TargetList { get; set; }
        public class DescribeCommonTargetConfigResponseBodyTargetList : TeaModel {
            /// <summary>
            /// The mode in which the configuration takes effect. Valid values:
            /// 
            /// *   **add**: In this mode, the configuration takes effect on the assets.
            /// *   **del**: In this mode, the configuration does not take effect on the assets.
            /// </summary>
            [NameInMap("Flag")]
            [Validation(Required=false)]
            public string Flag { get; set; }

            /// <summary>
            /// The ID of the asset on which the configuration takes effect.
            /// 
            /// > 
            /// 
            /// *   When you set the **TargetType** parameter to **uuid**, the value of this parameter indicates the UUID of an asset.
            /// 
            /// *   When you set the **TargetType** parameter to **Cluster**, the value of this parameter indicates the ID of a cluster.
            /// 
            /// *   When you set the **TargetType** parameter to **image_repo**, the value of this parameter indicates the ID of an image repository.
            /// </summary>
            [NameInMap("Target")]
            [Validation(Required=false)]
            public string Target { get; set; }

            /// <summary>
            /// The dimension from on which the feature was configured. Valid values:
            /// 
            /// *   **uuid**: the UUID of the asset
            /// *   **Cluster**: the ID of the cluster
            /// *   **image_repo**: the ID of the image repository
            /// </summary>
            [NameInMap("TargetType")]
            [Validation(Required=false)]
            public string TargetType { get; set; }

        }

    }

}
