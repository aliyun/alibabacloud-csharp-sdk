// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class DescribeCenVbrHealthCheckResponseBody : TeaModel {
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("VbrHealthChecks")]
        [Validation(Required=false)]
        public DescribeCenVbrHealthCheckResponseBodyVbrHealthChecks VbrHealthChecks { get; set; }
        public class DescribeCenVbrHealthCheckResponseBodyVbrHealthChecks : TeaModel {
            [NameInMap("VbrHealthCheck")]
            [Validation(Required=false)]
            public List<DescribeCenVbrHealthCheckResponseBodyVbrHealthChecksVbrHealthCheck> VbrHealthCheck { get; set; }
            public class DescribeCenVbrHealthCheckResponseBodyVbrHealthChecksVbrHealthCheck : TeaModel {
                public string CenId { get; set; }
                public int? HealthCheckInterval { get; set; }
                public bool? HealthCheckOnly { get; set; }
                public string HealthCheckSourceIp { get; set; }
                public string HealthCheckTargetIp { get; set; }
                public int? HealthyThreshold { get; set; }
                public string VbrInstanceId { get; set; }
                public string VbrInstanceRegionId { get; set; }
            }
        };

    }

}
