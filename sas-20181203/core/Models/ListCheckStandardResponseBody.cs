// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListCheckStandardResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Standards")]
        [Validation(Required=false)]
        public List<ListCheckStandardResponseBodyStandards> Standards { get; set; }
        public class ListCheckStandardResponseBodyStandards : TeaModel {
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("Requirements")]
            [Validation(Required=false)]
            public List<ListCheckStandardResponseBodyStandardsRequirements> Requirements { get; set; }
            public class ListCheckStandardResponseBodyStandardsRequirements : TeaModel {
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("RiskCheckCount")]
                [Validation(Required=false)]
                public long? RiskCheckCount { get; set; }

                [NameInMap("ShowName")]
                [Validation(Required=false)]
                public string ShowName { get; set; }

            }

            [NameInMap("ShowName")]
            [Validation(Required=false)]
            public string ShowName { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
