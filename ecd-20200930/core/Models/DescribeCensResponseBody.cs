// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
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
        public List<DescribeCensResponseBodyCens> Cens { get; set; }
        public class DescribeCensResponseBodyCens : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            [NameInMap("Ipv6Level")]
            [Validation(Required=false)]
            public string Ipv6Level { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("CenId")]
            [Validation(Required=false)]
            public string CenId { get; set; }

            [NameInMap("ProtectionLevel")]
            [Validation(Required=false)]
            public string ProtectionLevel { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<DescribeCensResponseBodyCensTags> Tags { get; set; }
            public class DescribeCensResponseBodyCensTags : TeaModel {
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            [NameInMap("PackageIds")]
            [Validation(Required=false)]
            public List<DescribeCensResponseBodyCensPackageIds> PackageIds { get; set; }
            public class DescribeCensResponseBodyCensPackageIds : TeaModel {
                [NameInMap("PackageId")]
                [Validation(Required=false)]
                public string PackageId { get; set; }

            }

        }

    }

}
