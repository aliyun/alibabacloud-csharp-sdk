// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeExposedRiskNumResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RiskExposedInstanceCount")]
        [Validation(Required=false)]
        public int? RiskExposedInstanceCount { get; set; }

        [NameInMap("ExposedInstanceCount")]
        [Validation(Required=false)]
        public int? ExposedInstanceCount { get; set; }

    }

}
