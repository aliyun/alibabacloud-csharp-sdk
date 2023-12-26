// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class DescribeCenVbrHealthCheckResponseBody : TeaModel {
        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// The health check configuration of the VBR.
        /// </summary>
        [NameInMap("VbrHealthChecks")]
        [Validation(Required=false)]
        public DescribeCenVbrHealthCheckResponseBodyVbrHealthChecks VbrHealthChecks { get; set; }
        public class DescribeCenVbrHealthCheckResponseBodyVbrHealthChecks : TeaModel {
            [NameInMap("VbrHealthCheck")]
            [Validation(Required=false)]
            public List<DescribeCenVbrHealthCheckResponseBodyVbrHealthChecksVbrHealthCheck> VbrHealthCheck { get; set; }
            public class DescribeCenVbrHealthCheckResponseBodyVbrHealthChecksVbrHealthCheck : TeaModel {
                /// <summary>
                /// The ID of the CEN instance.
                /// </summary>
                [NameInMap("CenId")]
                [Validation(Required=false)]
                public string CenId { get; set; }

                /// <summary>
                /// The description of the health check.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The time interval at which probe packets are sent during the health check. Unit: seconds.
                /// </summary>
                [NameInMap("HealthCheckInterval")]
                [Validation(Required=false)]
                public int? HealthCheckInterval { get; set; }

                /// <summary>
                /// Indicates whether probing is enabled. Valid values:
                /// 
                /// *   **true**: yes
                /// 
                ///     If probing is enabled, the system does not switch to another route when the detected route is not reachable.
                /// 
                /// *   **false**: no
                /// 
                ///     If probing is disabled and a redundant route is specified, the system switches to the redundant route when the detected route is not reachable.
                /// </summary>
                [NameInMap("HealthCheckOnly")]
                [Validation(Required=false)]
                public bool? HealthCheckOnly { get; set; }

                /// <summary>
                /// The source IP address of the health check.
                /// </summary>
                [NameInMap("HealthCheckSourceIp")]
                [Validation(Required=false)]
                public string HealthCheckSourceIp { get; set; }

                /// <summary>
                /// The destination IP address of the health check.
                /// </summary>
                [NameInMap("HealthCheckTargetIp")]
                [Validation(Required=false)]
                public string HealthCheckTargetIp { get; set; }

                /// <summary>
                /// The number of probe packets that are sent during the health check.
                /// </summary>
                [NameInMap("HealthyThreshold")]
                [Validation(Required=false)]
                public int? HealthyThreshold { get; set; }

                /// <summary>
                /// The ID of the VBR.
                /// </summary>
                [NameInMap("VbrInstanceId")]
                [Validation(Required=false)]
                public string VbrInstanceId { get; set; }

                /// <summary>
                /// The ID of the region where the VBR is deployed.
                /// </summary>
                [NameInMap("VbrInstanceRegionId")]
                [Validation(Required=false)]
                public string VbrInstanceRegionId { get; set; }

            }

        }

    }

}
