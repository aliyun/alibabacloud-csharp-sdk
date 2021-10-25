// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeSQLPatternAttributeResponseBody : TeaModel {
        [NameInMap("PatternDetail")]
        [Validation(Required=false)]
        public DescribeSQLPatternAttributeResponseBodyPatternDetail PatternDetail { get; set; }
        public class DescribeSQLPatternAttributeResponseBodyPatternDetail : TeaModel {
            [NameInMap("SQLPattern")]
            [Validation(Required=false)]
            public string SQLPattern { get; set; }
            [NameInMap("QueryCount")]
            [Validation(Required=false)]
            public long? QueryCount { get; set; }
            [NameInMap("TotalQueryTime")]
            [Validation(Required=false)]
            public string TotalQueryTime { get; set; }
            [NameInMap("AverageQueryTime")]
            [Validation(Required=false)]
            public string AverageQueryTime { get; set; }
            [NameInMap("AverageMemory")]
            [Validation(Required=false)]
            public string AverageMemory { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
