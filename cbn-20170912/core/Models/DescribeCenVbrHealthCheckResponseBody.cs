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
                [NameInMap("CenId")]
                [Validation(Required=false)]
                public string CenId { get; set; }

                [NameInMap("HealthCheckInterval")]
                [Validation(Required=false)]
                public int? HealthCheckInterval { get; set; }

                [NameInMap("HealthCheckOnly")]
                [Validation(Required=false)]
                public bool? HealthCheckOnly { get; set; }

                [NameInMap("HealthCheckSourceIp")]
                [Validation(Required=false)]
                public string HealthCheckSourceIp { get; set; }

                [NameInMap("HealthCheckTargetIp")]
                [Validation(Required=false)]
                public string HealthCheckTargetIp { get; set; }

                [NameInMap("HealthyThreshold")]
                [Validation(Required=false)]
                public int? HealthyThreshold { get; set; }

                [NameInMap("VbrInstanceId")]
                [Validation(Required=false)]
                public string VbrInstanceId { get; set; }

                [NameInMap("VbrInstanceRegionId")]
                [Validation(Required=false)]
                public string VbrInstanceRegionId { get; set; }

            }

        }

    }

}
