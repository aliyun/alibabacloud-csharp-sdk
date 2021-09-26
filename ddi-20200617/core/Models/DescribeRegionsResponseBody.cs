// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddi20200617.Models
{
    public class DescribeRegionsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("BusinessLocations")]
        [Validation(Required=false)]
        public List<DescribeRegionsResponseBodyBusinessLocations> BusinessLocations { get; set; }
        public class DescribeRegionsResponseBodyBusinessLocations : TeaModel {
            [NameInMap("Ordering")]
            [Validation(Required=false)]
            public string Ordering { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("ShowName")]
            [Validation(Required=false)]
            public string ShowName { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("EnDescription")]
            [Validation(Required=false)]
            public string EnDescription { get; set; }

            [NameInMap("EnName")]
            [Validation(Required=false)]
            public string EnName { get; set; }

            [NameInMap("CnName")]
            [Validation(Required=false)]
            public string CnName { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("District")]
            [Validation(Required=false)]
            public DescribeRegionsResponseBodyBusinessLocationsDistrict District { get; set; }
            public class DescribeRegionsResponseBodyBusinessLocationsDistrict : TeaModel {
                [NameInMap("Ordering")]
                [Validation(Required=false)]
                public string Ordering { get; set; }
                [NameInMap("CnName")]
                [Validation(Required=false)]
                public string CnName { get; set; }
                [NameInMap("ShowName")]
                [Validation(Required=false)]
                public string ShowName { get; set; }
                [NameInMap("DistrictId")]
                [Validation(Required=false)]
                public string DistrictId { get; set; }
                [NameInMap("EnName")]
                [Validation(Required=false)]
                public string EnName { get; set; }
            };

        }

    }

}
