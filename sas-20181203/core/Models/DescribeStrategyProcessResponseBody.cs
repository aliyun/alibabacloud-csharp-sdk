// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeStrategyProcessResponseBody : TeaModel {
        [NameInMap("ExecStatus")]
        [Validation(Required=false)]
        public int? ExecStatus { get; set; }

        [NameInMap("ProcessRate")]
        [Validation(Required=false)]
        public int? ProcessRate { get; set; }

        [NameInMap("StrategyId")]
        [Validation(Required=false)]
        public long? StrategyId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PassRate")]
        [Validation(Required=false)]
        public string PassRate { get; set; }

    }

}
