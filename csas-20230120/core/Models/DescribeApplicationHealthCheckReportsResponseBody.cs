// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class DescribeApplicationHealthCheckReportsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of health check reports.</para>
        /// </summary>
        [NameInMap("Reports")]
        [Validation(Required=false)]
        public List<DescribeApplicationHealthCheckReportsResponseBodyReports> Reports { get; set; }
        public class DescribeApplicationHealthCheckReportsResponseBodyReports : TeaModel {
            /// <summary>
            /// <para>The ID of the internal-facing application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pa-application-e12860ef6c48****</para>
            /// </summary>
            [NameInMap("ApplicationId")]
            [Validation(Required=false)]
            public string ApplicationId { get; set; }

            /// <summary>
            /// <para>The list of addresses where health checks failed.</para>
            /// </summary>
            [NameInMap("FailedAddresses")]
            [Validation(Required=false)]
            public List<string> FailedAddresses { get; set; }

            /// <summary>
            /// <para>The list of regions where health checks failed.</para>
            /// </summary>
            [NameInMap("FailedRegions")]
            [Validation(Required=false)]
            public List<string> FailedRegions { get; set; }

            /// <summary>
            /// <para>The number of failed health checks within the query time range.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("FailureCount")]
            [Validation(Required=false)]
            public long? FailureCount { get; set; }

            /// <summary>
            /// <para>The list of reasons for health check failures.</para>
            /// </summary>
            [NameInMap("FailureReasons")]
            [Validation(Required=false)]
            public List<string> FailureReasons { get; set; }

            /// <summary>
            /// <para>The status calculated based on the latest check result. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>normal: The success rate of the latest check is greater than or equal to 95%.</description></item>
            /// <item><description>partialError: The success rate of the latest check is greater than 0 and less than 95%.</description></item>
            /// <item><description>error: The success rate of the latest check is 0.</description></item>
            /// <item><description>uncompleted: No check results are available.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>normal</para>
            /// </summary>
            [NameInMap("HealthCheckStatus")]
            [Validation(Required=false)]
            public string HealthCheckStatus { get; set; }

            /// <summary>
            /// <para>The health check mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>OnAccess: on-access check</description></item>
            /// <item><description>Continuous: continuous check</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>OnAccess</para>
            /// </summary>
            [NameInMap("Mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

            /// <summary>
            /// <para>The number of successful health checks within the query time range.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("SuccessCount")]
            [Validation(Required=false)]
            public long? SuccessCount { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>748CFDC7-1EB6-5B8B-9405-DA76ED5BB60D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
