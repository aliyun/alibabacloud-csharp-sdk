// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class JobFailure : TeaModel {
        /// <summary>
        /// <para>The time when the deployment fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1660120062</para>
        /// </summary>
        [NameInMap("failedAt")]
        [Validation(Required=false)]
        public long? FailedAt { get; set; }

        /// <summary>
        /// <para>The details of the failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Kubernetes deployment resource with name job-8b7db913-5b1f-4ac5-a332-8d50f342**** is not progressing.</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The reason for the failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>KubernetesDeploymentNotProgressing</para>
        /// </summary>
        [NameInMap("reason")]
        [Validation(Required=false)]
        public string Reason { get; set; }

    }

}
