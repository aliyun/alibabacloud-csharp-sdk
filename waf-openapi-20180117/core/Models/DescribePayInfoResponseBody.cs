// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20180117.Models
{
    public class DescribePayInfoResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public DescribePayInfoResponseBodyResult Result { get; set; }
        public class DescribePayInfoResponseBodyResult : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }
            [NameInMap("EndDate")]
            [Validation(Required=false)]
            public long? EndDate { get; set; }
            [NameInMap("RemainDay")]
            [Validation(Required=false)]
            public int? RemainDay { get; set; }
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }
            [NameInMap("PayType")]
            [Validation(Required=false)]
            public int? PayType { get; set; }
            [NameInMap("InDebt")]
            [Validation(Required=false)]
            public int? InDebt { get; set; }
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }
            [NameInMap("Trial")]
            [Validation(Required=false)]
            public int? Trial { get; set; }
        };

    }

}
