// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeEnsNetDistrictResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Code")]
        [Validation(Required=true)]
        public int? Code { get; set; }

        [NameInMap("EnsNetDistricts")]
        [Validation(Required=true)]
        public DescribeEnsNetDistrictResponseEnsNetDistricts EnsNetDistricts { get; set; }
        public class DescribeEnsNetDistrictResponseEnsNetDistricts : TeaModel {
            [NameInMap("EnsNetDistrict")]
            [Validation(Required=true)]
            public List<DescribeEnsNetDistrictResponseEnsNetDistrictsEnsNetDistrict> EnsNetDistrict { get; set; }
            public class DescribeEnsNetDistrictResponseEnsNetDistrictsEnsNetDistrict : TeaModel {
                public string NetDistrictCode { get; set; }
                public string NetDistrictName { get; set; }
                public string NetDistrictFatherCode { get; set; }
                public string EnsRegionIdCount { get; set; }
                public string NetDistrictLevel { get; set; }
                public string NetDistrictEnName { get; set; }
            }
        };

    }

}
