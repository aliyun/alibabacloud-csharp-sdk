// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class StartupProbe : TeaModel {
        /// <summary>
        /// <para>The minimum number of consecutive failures that is considered a failure after a successful probe. Default value: 3. Minimum value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("FailureThreshold")]
        [Validation(Required=false)]
        public int? FailureThreshold { get; set; }

        /// <summary>
        /// <para>The duration after the container is started before health checks are initiated. For more information, see <a href="https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes">Probes</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("InitialDelaySeconds")]
        [Validation(Required=false)]
        public int? InitialDelaySeconds { get; set; }

        /// <summary>
        /// <para>The health check interval. Default value: 10. Unit: seconds. Minimum value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PeriodSeconds")]
        [Validation(Required=false)]
        public int? PeriodSeconds { get; set; }

        /// <summary>
        /// <para>The operation to determine the health of the container.</para>
        /// </summary>
        [NameInMap("ProbeHandler")]
        [Validation(Required=false)]
        public ProbeHandler ProbeHandler { get; set; }

        /// <summary>
        /// <para>The timeout period of a health check. Default value: 1. Minimum value: 1. For more information, see <a href="https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes">Container probes</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TimeoutSeconds")]
        [Validation(Required=false)]
        public int? TimeoutSeconds { get; set; }

    }

}
