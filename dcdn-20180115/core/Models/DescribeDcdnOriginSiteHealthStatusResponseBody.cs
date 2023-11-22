// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnOriginSiteHealthStatusResponseBody : TeaModel {
        [NameInMap("OriginSiteStatus")]
        [Validation(Required=false)]
        public List<DescribeDcdnOriginSiteHealthStatusResponseBodyOriginSiteStatus> OriginSiteStatus { get; set; }
        public class DescribeDcdnOriginSiteHealthStatusResponseBodyOriginSiteStatus : TeaModel {
            [NameInMap("HealthStatus")]
            [Validation(Required=false)]
            public string HealthStatus { get; set; }

            [NameInMap("Host")]
            [Validation(Required=false)]
            public string Host { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
