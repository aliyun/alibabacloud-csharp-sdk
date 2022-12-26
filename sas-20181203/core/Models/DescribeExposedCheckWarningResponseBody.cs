// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeExposedCheckWarningResponseBody : TeaModel {
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("WarningList")]
        [Validation(Required=false)]
        public List<DescribeExposedCheckWarningResponseBodyWarningList> WarningList { get; set; }
        public class DescribeExposedCheckWarningResponseBodyWarningList : TeaModel {
            [NameInMap("RiskId")]
            [Validation(Required=false)]
            public long? RiskId { get; set; }

            [NameInMap("RiskName")]
            [Validation(Required=false)]
            public string RiskName { get; set; }

            [NameInMap("SubTypeAlias")]
            [Validation(Required=false)]
            public string SubTypeAlias { get; set; }

            [NameInMap("TypeAlias")]
            [Validation(Required=false)]
            public string TypeAlias { get; set; }

            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

    }

}
