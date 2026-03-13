// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class CustomHealthCheckConfig : TeaModel {
        /// <summary>
        /// <para>The threshold for health check failures. When this value is reached, the system considers the health check failed. Valid values: 1 to 120. Default value: 3.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("failureThreshold")]
        [Validation(Required=false)]
        public int? FailureThreshold { get; set; }

        /// <summary>
        /// <para>The health check URL of the custom container. The URL can be up to 2,048 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/ready</para>
        /// </summary>
        [NameInMap("httpGetUrl")]
        [Validation(Required=false)]
        public string HttpGetUrl { get; set; }

        /// <summary>
        /// <para>The delay between the container startup and the health check. Valid values: 0 to 120. Default value: 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("initialDelaySeconds")]
        [Validation(Required=false)]
        public int? InitialDelaySeconds { get; set; }

        /// <summary>
        /// <para>The health check period. Valid values: 1 to 120. Default value: 3.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("periodSeconds")]
        [Validation(Required=false)]
        public int? PeriodSeconds { get; set; }

        /// <summary>
        /// <para>The threshold for health check successes. When this value is reached, the system considers the health check successful. Valid values: 1 to 120. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("successThreshold")]
        [Validation(Required=false)]
        public int? SuccessThreshold { get; set; }

        /// <summary>
        /// <para>The timeout period of the health check. Unit: seconds. Valid values: 1 to 3. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("timeoutSeconds")]
        [Validation(Required=false)]
        public int? TimeoutSeconds { get; set; }

    }

}
