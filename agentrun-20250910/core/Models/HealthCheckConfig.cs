// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class HealthCheckConfig : TeaModel {
        /// <summary>
        /// <para>The number of consecutive failed health checks before the container is considered unhealthy</para>
        /// </summary>
        [NameInMap("failureThreshold")]
        [Validation(Required=false)]
        public int? FailureThreshold { get; set; }

        /// <summary>
        /// <para>The URL address for the HTTP GET request used in health checks</para>
        /// </summary>
        [NameInMap("httpGetUrl")]
        [Validation(Required=false)]
        public string HttpGetUrl { get; set; }

        /// <summary>
        /// <para>The delay time (in seconds) after the container starts before the first health check is executed</para>
        /// </summary>
        [NameInMap("initialDelaySeconds")]
        [Validation(Required=false)]
        public int? InitialDelaySeconds { get; set; }

        /// <summary>
        /// <para>The time interval (in seconds) between health checks</para>
        /// </summary>
        [NameInMap("periodSeconds")]
        [Validation(Required=false)]
        public int? PeriodSeconds { get; set; }

        /// <summary>
        /// <para>The number of consecutive successful health checks required before the container is considered healthy</para>
        /// </summary>
        [NameInMap("successThreshold")]
        [Validation(Required=false)]
        public int? SuccessThreshold { get; set; }

        /// <summary>
        /// <para>The timeout duration (in seconds) for health checks</para>
        /// </summary>
        [NameInMap("timeoutSeconds")]
        [Validation(Required=false)]
        public int? TimeoutSeconds { get; set; }

    }

}
