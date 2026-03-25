// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class DescribeCenVbrHealthCheckResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B8C9702E-304A-4E18-AC89-BE2D91C2C176</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
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

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

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
