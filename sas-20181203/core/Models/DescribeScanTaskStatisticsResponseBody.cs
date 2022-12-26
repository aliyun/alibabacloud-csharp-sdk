// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeScanTaskStatisticsResponseBody : TeaModel {
        [NameInMap("DealedRiskNum")]
        [Validation(Required=false)]
        public int? DealedRiskNum { get; set; }

        [NameInMap("PersonalTaskNum")]
        [Validation(Required=false)]
        public long? PersonalTaskNum { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalTaskNum")]
        [Validation(Required=false)]
        public long? TotalTaskNum { get; set; }

        [NameInMap("UserNum")]
        [Validation(Required=false)]
        public long? UserNum { get; set; }

    }

}
