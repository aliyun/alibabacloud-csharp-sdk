// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pvtz20180101.Models
{
    public class DescribeSyncEcsHostTaskResponseBody : TeaModel {
        /// <summary>
        /// The information about regions.
        /// </summary>
        [NameInMap("EcsRegions")]
        [Validation(Required=false)]
        public DescribeSyncEcsHostTaskResponseBodyEcsRegions EcsRegions { get; set; }
        public class DescribeSyncEcsHostTaskResponseBodyEcsRegions : TeaModel {
            [NameInMap("EcsRegion")]
            [Validation(Required=false)]
            public List<DescribeSyncEcsHostTaskResponseBodyEcsRegionsEcsRegion> EcsRegion { get; set; }
            public class DescribeSyncEcsHostTaskResponseBodyEcsRegionsEcsRegion : TeaModel {
                /// <summary>
                /// The region IDs.
                /// </summary>
                [NameInMap("RegionIds")]
                [Validation(Required=false)]
                public DescribeSyncEcsHostTaskResponseBodyEcsRegionsEcsRegionRegionIds RegionIds { get; set; }
                public class DescribeSyncEcsHostTaskResponseBodyEcsRegionsEcsRegionRegionIds : TeaModel {
                    [NameInMap("RegionId")]
                    [Validation(Required=false)]
                    public List<string> RegionId { get; set; }

                }

                /// <summary>
                /// The Alibaba Cloud account to which the region belongs. This parameter is used in cross-account synchronization scenarios.
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public long? UserId { get; set; }

            }

        }

        /// <summary>
        /// The information about the regions within the current account.
        /// </summary>
        [NameInMap("Regions")]
        [Validation(Required=false)]
        public DescribeSyncEcsHostTaskResponseBodyRegions Regions { get; set; }
        public class DescribeSyncEcsHostTaskResponseBodyRegions : TeaModel {
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public List<string> RegionId { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The state of the task. Valid values:
        /// 
        /// *   ON
        /// *   OFF
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// Indicates whether the task was successful. Valid values:
        /// 
        /// *   True
        /// *   False
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The zone ID.
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
