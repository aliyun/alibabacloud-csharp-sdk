// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeEnsNetSaleDistrictResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("EnsNetDistricts")]
        [Validation(Required=false)]
        public DescribeEnsNetSaleDistrictResponseBodyEnsNetDistricts EnsNetDistricts { get; set; }
        public class DescribeEnsNetSaleDistrictResponseBodyEnsNetDistricts : TeaModel {
            [NameInMap("EnsNetDistrict")]
            [Validation(Required=false)]
            public List<DescribeEnsNetSaleDistrictResponseBodyEnsNetDistrictsEnsNetDistrict> EnsNetDistrict { get; set; }
            public class DescribeEnsNetSaleDistrictResponseBodyEnsNetDistrictsEnsNetDistrict : TeaModel {
                public string EnsRegionIdCount { get; set; }
                public string InstanceCount { get; set; }
                public string NetDistrictCode { get; set; }
                public string NetDistrictEnName { get; set; }
                public string NetDistrictFatherCode { get; set; }
                public string NetDistrictLevel { get; set; }
                public string NetDistrictName { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
