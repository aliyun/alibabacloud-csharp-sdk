// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeRefundPriceRequest : TeaModel {
        [NameInMap("DesktopId")]
        [Validation(Required=false)]
        public List<string> DesktopId { get; set; }

        [NameInMap("RefundParamMap")]
        [Validation(Required=false)]
        public string RefundParamMap { get; set; }

        [NameInMap("RefundType")]
        [Validation(Required=false)]
        public string RefundType { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
