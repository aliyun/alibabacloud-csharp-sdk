// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeCommonTargetResultListResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TargetConfig")]
        [Validation(Required=false)]
        public DescribeCommonTargetResultListResponseBodyTargetConfig TargetConfig { get; set; }
        public class DescribeCommonTargetResultListResponseBodyTargetConfig : TeaModel {
            [NameInMap("Flag")]
            [Validation(Required=false)]
            public string Flag { get; set; }

            [NameInMap("TargetDefault")]
            [Validation(Required=false)]
            public string TargetDefault { get; set; }

            [NameInMap("TargetList")]
            [Validation(Required=false)]
            public List<string> TargetList { get; set; }

            [NameInMap("TargetType")]
            [Validation(Required=false)]
            public string TargetType { get; set; }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public string TotalCount { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
