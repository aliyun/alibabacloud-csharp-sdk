// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class HealthCheckConfiguration : TeaModel {
        /// <summary>
        /// <para>The number of consecutive failed health checks after which the container is considered unhealthy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("failureThreshold")]
        [Validation(Required=false)]
        public int? FailureThreshold { get; set; }

        /// <summary>
        /// <para>The URL path for the HTTP GET health check.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/ready</para>
        /// </summary>
        [NameInMap("httpGetUrl")]
        [Validation(Required=false)]
        public string HttpGetUrl { get; set; }

        /// <summary>
        /// <para>The delay in seconds after the container starts before the first health check runs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("initialDelaySeconds")]
        [Validation(Required=false)]
        public int? InitialDelaySeconds { get; set; }

        /// <summary>
        /// <para>The interval in seconds between health checks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("periodSeconds")]
        [Validation(Required=false)]
        public int? PeriodSeconds { get; set; }

        /// <summary>
        /// <para>The number of consecutive successful health checks after which an unhealthy container is considered healthy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("successThreshold")]
        [Validation(Required=false)]
        public int? SuccessThreshold { get; set; }

        /// <summary>
        /// <para>The duration in seconds before a health check times out.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("timeoutSeconds")]
        [Validation(Required=false)]
        public int? TimeoutSeconds { get; set; }

    }

}
