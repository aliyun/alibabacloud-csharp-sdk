// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20230930.Models
{
    public class DescribeUserSpnSummaryInfoResponseBody : TeaModel {
        [NameInMap("InstanceFamilyList")]
        [Validation(Required=false)]
        public List<string> InstanceFamilyList { get; set; }

        [NameInMap("RegionList")]
        [Validation(Required=false)]
        public List<DescribeUserSpnSummaryInfoResponseBodyRegionList> RegionList { get; set; }
        public class DescribeUserSpnSummaryInfoResponseBodyRegionList : TeaModel {
            [NameInMap("RegionCode")]
            [Validation(Required=false)]
            public string RegionCode { get; set; }

            [NameInMap("RegionName")]
            [Validation(Required=false)]
            public string RegionName { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SpnCodeAndTypeList")]
        [Validation(Required=false)]
        public List<DescribeUserSpnSummaryInfoResponseBodySpnCodeAndTypeList> SpnCodeAndTypeList { get; set; }
        public class DescribeUserSpnSummaryInfoResponseBodySpnCodeAndTypeList : TeaModel {
            [NameInMap("ProductCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }

            [NameInMap("SpnCommodityCode")]
            [Validation(Required=false)]
            public string SpnCommodityCode { get; set; }

            [NameInMap("SpnType")]
            [Validation(Required=false)]
            public string SpnType { get; set; }

            [NameInMap("SpnTypeName")]
            [Validation(Required=false)]
            public string SpnTypeName { get; set; }

        }

    }

}
