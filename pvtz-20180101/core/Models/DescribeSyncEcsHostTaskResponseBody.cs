// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pvtz20180101.Models
{
    public class DescribeSyncEcsHostTaskResponseBody : TeaModel {
        [NameInMap("EcsRegions")]
        [Validation(Required=false)]
        public DescribeSyncEcsHostTaskResponseBodyEcsRegions EcsRegions { get; set; }
        public class DescribeSyncEcsHostTaskResponseBodyEcsRegions : TeaModel {
            [NameInMap("EcsRegion")]
            [Validation(Required=false)]
            public List<DescribeSyncEcsHostTaskResponseBodyEcsRegionsEcsRegion> EcsRegion { get; set; }
            public class DescribeSyncEcsHostTaskResponseBodyEcsRegionsEcsRegion : TeaModel {
                [NameInMap("RegionIds")]
                [Validation(Required=false)]
                public DescribeSyncEcsHostTaskResponseBodyEcsRegionsEcsRegionRegionIds RegionIds { get; set; }
                public class DescribeSyncEcsHostTaskResponseBodyEcsRegionsEcsRegionRegionIds : TeaModel {
                    [NameInMap("RegionId")]
                    [Validation(Required=false)]
                    public List<string> RegionId { get; set; }

                }

                [NameInMap("UserId")]
                [Validation(Required=false)]
                public long? UserId { get; set; }

            }

        }

        [NameInMap("Regions")]
        [Validation(Required=false)]
        public DescribeSyncEcsHostTaskResponseBodyRegions Regions { get; set; }
        public class DescribeSyncEcsHostTaskResponseBodyRegions : TeaModel {
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public List<string> RegionId { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
