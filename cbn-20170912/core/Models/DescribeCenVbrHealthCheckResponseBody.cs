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

        /// <summary>
        /// <para>The health check configuration of the VBR.</para>
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
                /// <para>The ID of the CEN instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cen-6hpdgj7ni6pz1k****</para>
                /// </summary>
                [NameInMap("CenId")]
                [Validation(Required=false)]
                public string CenId { get; set; }

                /// <summary>
                /// <para>The description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>healthcheck_description</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The time interval at which probe packets are sent during the health check. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("HealthCheckInterval")]
                [Validation(Required=false)]
                public int? HealthCheckInterval { get; set; }

                /// <summary>
                /// <para>Indicates whether probing is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>true</b>: Probing is enabled.</para>
                /// <pre><c>If you enable probing, the system does not switch to another route if the detected route is not reachable.
                /// </c></pre>
                /// </description></item>
                /// <item><description><para><b>false</b>: Probing is disabled.</para>
                /// <pre><c>  If probing is disabled and a redundant route is specified, the system switches to the redundant route when the detected route is not reachable.
                /// </c></pre>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("HealthCheckOnly")]
                [Validation(Required=false)]
                public bool? HealthCheckOnly { get; set; }

                /// <summary>
                /// <para>The source IP address of the health check.</para>
                /// 
                /// <b>Example:</b>
                /// <para>172.XX.XX.1</para>
                /// </summary>
                [NameInMap("HealthCheckSourceIp")]
                [Validation(Required=false)]
                public string HealthCheckSourceIp { get; set; }

                /// <summary>
                /// <para>The destination IP address of the health check.</para>
                /// 
                /// <b>Example:</b>
                /// <para>192.XX.XX.1</para>
                /// </summary>
                [NameInMap("HealthCheckTargetIp")]
                [Validation(Required=false)]
                public string HealthCheckTargetIp { get; set; }

                /// <summary>
                /// <para>The number of probe packets that are sent during the health check.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8</para>
                /// </summary>
                [NameInMap("HealthyThreshold")]
                [Validation(Required=false)]
                public int? HealthyThreshold { get; set; }

                /// <summary>
                /// <para>The VBR ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vbr-bp1kznorjeembsuhl****</para>
                /// </summary>
                [NameInMap("VbrInstanceId")]
                [Validation(Required=false)]
                public string VbrInstanceId { get; set; }

                /// <summary>
                /// <para>The ID of the region where the VBR is deployed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("VbrInstanceRegionId")]
                [Validation(Required=false)]
                public string VbrInstanceRegionId { get; set; }

            }

        }

    }

}
