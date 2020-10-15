// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeEnsNetSaleDistrictResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Code")]
        [Validation(Required=true)]
        public int? Code { get; set; }

        [NameInMap("EnsNetDistricts")]
        [Validation(Required=true)]
        public DescribeEnsNetSaleDistrictResponseEnsNetDistricts EnsNetDistricts { get; set; }
        public class DescribeEnsNetSaleDistrictResponseEnsNetDistricts : TeaModel {
            [NameInMap("EnsNetDistrict")]
            [Validation(Required=true)]
            public List<DescribeEnsNetSaleDistrictResponseEnsNetDistrictsEnsNetDistrict> EnsNetDistrict { get; set; }
            public class DescribeEnsNetSaleDistrictResponseEnsNetDistrictsEnsNetDistrict : TeaModel {
                public string NetDistrictCode { get; set; }
                public string NetDistrictName { get; set; }
                public string EnsRegionIdCount { get; set; }
                public string NetDistrictLevel { get; set; }
                public string NetDistrictFatherCode { get; set; }
                public string NetDistrictEnName { get; set; }
                public string InstanceCount { get; set; }
            }
        };

    }

}
