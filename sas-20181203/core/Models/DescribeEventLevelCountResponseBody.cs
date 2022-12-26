// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeEventLevelCountResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("EventLevels")]
        [Validation(Required=false)]
        public DescribeEventLevelCountResponseBodyEventLevels EventLevels { get; set; }
        public class DescribeEventLevelCountResponseBodyEventLevels : TeaModel {
            [NameInMap("Remind")]
            [Validation(Required=false)]
            public int? Remind { get; set; }

            [NameInMap("Serious")]
            [Validation(Required=false)]
            public int? Serious { get; set; }

            [NameInMap("Suspicious")]
            [Validation(Required=false)]
            public int? Suspicious { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
