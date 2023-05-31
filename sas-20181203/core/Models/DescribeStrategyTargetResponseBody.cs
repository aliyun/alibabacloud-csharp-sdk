// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeStrategyTargetResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// An array consisting of the assets to which the baseline check policy is applied.
        /// </summary>
        [NameInMap("StrategyTargets")]
        [Validation(Required=false)]
        public List<DescribeStrategyTargetResponseBodyStrategyTargets> StrategyTargets { get; set; }
        public class DescribeStrategyTargetResponseBodyStrategyTargets : TeaModel {
            /// <summary>
            /// The number of the assets that belong to the asset group.
            /// </summary>
            [NameInMap("BindUuidCount")]
            [Validation(Required=false)]
            public int? BindUuidCount { get; set; }

            /// <summary>
            /// Indicates whether the baseline check policy is applied to the asset group. Valid values:
            /// 
            /// *   **add**: yes
            /// *   **del**: no
            /// </summary>
            [NameInMap("Flag")]
            [Validation(Required=false)]
            public string Flag { get; set; }

            /// <summary>
            /// The ID of the asset group to which the assets belong or the UUID of the asset.
            /// </summary>
            [NameInMap("Target")]
            [Validation(Required=false)]
            public string Target { get; set; }

            /// <summary>
            /// The method that is used to add the assets to the baseline check policy. Valid values:
            /// 
            /// *   **groupId**: the ID of the asset group
            /// *   **uuid**: the UUID of the asset
            /// </summary>
            [NameInMap("TargetType")]
            [Validation(Required=false)]
            public string TargetType { get; set; }

        }

    }

}
