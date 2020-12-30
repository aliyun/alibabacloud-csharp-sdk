// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeRiskListCheckResultResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("List")]
        [Validation(Required=false)]
        public List<DescribeRiskListCheckResultResponseBodyList> List { get; set; }
        public class DescribeRiskListCheckResultResponseBodyList : TeaModel {
            [NameInMap("riskCount")]
            [Validation(Required=false)]
            public long? RiskCount { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

        }

    }

}
