// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeDomainMax95BpsDataResponseBody : TeaModel {
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        [NameInMap("DomesticMax95Bps")]
        [Validation(Required=false)]
        public string DomesticMax95Bps { get; set; }

        [NameInMap("Max95Bps")]
        [Validation(Required=false)]
        public string Max95Bps { get; set; }

        [NameInMap("OverseasMax95Bps")]
        [Validation(Required=false)]
        public string OverseasMax95Bps { get; set; }

    }

}
