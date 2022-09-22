// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeEnsNetDistrictResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("EnsNetDistricts")]
        [Validation(Required=false)]
        public DescribeEnsNetDistrictResponseBodyEnsNetDistricts EnsNetDistricts { get; set; }
        public class DescribeEnsNetDistrictResponseBodyEnsNetDistricts : TeaModel {
            [NameInMap("EnsNetDistrict")]
            [Validation(Required=false)]
            public List<DescribeEnsNetDistrictResponseBodyEnsNetDistrictsEnsNetDistrict> EnsNetDistrict { get; set; }
            public class DescribeEnsNetDistrictResponseBodyEnsNetDistrictsEnsNetDistrict : TeaModel {
                [NameInMap("EnsRegionIdCount")]
                [Validation(Required=false)]
                public string EnsRegionIdCount { get; set; }

                [NameInMap("NetDistrictCode")]
                [Validation(Required=false)]
                public string NetDistrictCode { get; set; }

                [NameInMap("NetDistrictEnName")]
                [Validation(Required=false)]
                public string NetDistrictEnName { get; set; }

                [NameInMap("NetDistrictFatherCode")]
                [Validation(Required=false)]
                public string NetDistrictFatherCode { get; set; }

                [NameInMap("NetDistrictLevel")]
                [Validation(Required=false)]
                public string NetDistrictLevel { get; set; }

                [NameInMap("NetDistrictName")]
                [Validation(Required=false)]
                public string NetDistrictName { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
