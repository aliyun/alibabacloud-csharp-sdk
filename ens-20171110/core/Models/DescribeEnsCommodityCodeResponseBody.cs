// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeEnsCommodityCodeResponseBody : TeaModel {
        [NameInMap("CommodityCodeInfo")]
        [Validation(Required=false)]
        public List<DescribeEnsCommodityCodeResponseBodyCommodityCodeInfo> CommodityCodeInfo { get; set; }
        public class DescribeEnsCommodityCodeResponseBodyCommodityCodeInfo : TeaModel {
            [NameInMap("CommodityCode")]
            [Validation(Required=false)]
            public string CommodityCode { get; set; }

            [NameInMap("CommodityName")]
            [Validation(Required=false)]
            public string CommodityName { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
