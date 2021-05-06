// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class DescribeCensResponseBody : TeaModel {
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("Cens")]
        [Validation(Required=false)]
        public DescribeCensResponseBodyCens Cens { get; set; }
        public class DescribeCensResponseBodyCens : TeaModel {
            [NameInMap("Cen")]
            [Validation(Required=false)]
            public List<DescribeCensResponseBodyCensCen> Cen { get; set; }
            public class DescribeCensResponseBodyCensCen : TeaModel {
                public string Status { get; set; }
                public string CreationTime { get; set; }
                public string Description { get; set; }
                public string CenId { get; set; }
                public string ProtectionLevel { get; set; }
                public string Name { get; set; }
                public DescribeCensResponseBodyCensCenTags Tags { get; set; }
                public class DescribeCensResponseBodyCensCenTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeCensResponseBodyCensCenTagsTag> Tag { get; set; }
                    public class DescribeCensResponseBodyCensCenTagsTag : TeaModel {
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }
                public DescribeCensResponseBodyCensCenCenBandwidthPackageIds CenBandwidthPackageIds { get; set; }
                public class DescribeCensResponseBodyCensCenCenBandwidthPackageIds : TeaModel {
                    [NameInMap("CenBandwidthPackageId")]
                    [Validation(Required=false)]
                    public List<string> CenBandwidthPackageId { get; set; }

                }
            }
        };

    }

}
