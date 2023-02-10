// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeSecurityCheckScheduleConfigResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RiskCheckJobConfig")]
        [Validation(Required=false)]
        public DescribeSecurityCheckScheduleConfigResponseBodyRiskCheckJobConfig RiskCheckJobConfig { get; set; }
        public class DescribeSecurityCheckScheduleConfigResponseBodyRiskCheckJobConfig : TeaModel {
            [NameInMap("DaysOfWeek")]
            [Validation(Required=false)]
            public string DaysOfWeek { get; set; }

            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public int? EndTime { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public int? StartTime { get; set; }

        }

    }

}
