// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeEnsNetSaleDistrictResponseBody : TeaModel {
        /// <summary>
        /// The returned service code. A value of 0 indicates that the operation was successful.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The information about the ISPs in the area.
        /// </summary>
        [NameInMap("EnsNetDistricts")]
        [Validation(Required=false)]
        public DescribeEnsNetSaleDistrictResponseBodyEnsNetDistricts EnsNetDistricts { get; set; }
        public class DescribeEnsNetSaleDistrictResponseBodyEnsNetDistricts : TeaModel {
            [NameInMap("EnsNetDistrict")]
            [Validation(Required=false)]
            public List<DescribeEnsNetSaleDistrictResponseBodyEnsNetDistrictsEnsNetDistrict> EnsNetDistrict { get; set; }
            public class DescribeEnsNetSaleDistrictResponseBodyEnsNetDistrictsEnsNetDistrict : TeaModel {
                /// <summary>
                /// The information about the ISP.
                /// </summary>
                [NameInMap("EnsRegionIdCount")]
                [Validation(Required=false)]
                public string EnsRegionIdCount { get; set; }

                /// <summary>
                /// The information about the instance.
                /// </summary>
                [NameInMap("InstanceCount")]
                [Validation(Required=false)]
                public string InstanceCount { get; set; }

                /// <summary>
                /// The region code.
                /// </summary>
                [NameInMap("NetDistrictCode")]
                [Validation(Required=false)]
                public string NetDistrictCode { get; set; }

                /// <summary>
                /// The name of the region.
                /// </summary>
                [NameInMap("NetDistrictEnName")]
                [Validation(Required=false)]
                public string NetDistrictEnName { get; set; }

                /// <summary>
                /// The parent code of the region.
                /// </summary>
                [NameInMap("NetDistrictFatherCode")]
                [Validation(Required=false)]
                public string NetDistrictFatherCode { get; set; }

                /// <summary>
                /// The region level. Valid values:
                /// 
                /// *   **Big**: area
                /// *   **Middle**: province
                /// *   **Small**: city
                /// </summary>
                [NameInMap("NetDistrictLevel")]
                [Validation(Required=false)]
                public string NetDistrictLevel { get; set; }

                /// <summary>
                /// The Chinese name of the region.
                /// </summary>
                [NameInMap("NetDistrictName")]
                [Validation(Required=false)]
                public string NetDistrictName { get; set; }

            }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
