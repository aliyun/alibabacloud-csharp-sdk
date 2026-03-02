// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class JobStartParameters : TeaModel {
        /// <summary>
        /// <para>The deployment ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>737d0921-c5ac-47fc-9ba9-07a1e0b4****</para>
        /// </summary>
        [NameInMap("deploymentId")]
        [Validation(Required=false)]
        public string DeploymentId { get; set; }

        [NameInMap("jobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// <para>The variables.</para>
        /// </summary>
        [NameInMap("localVariables")]
        [Validation(Required=false)]
        public List<LocalVariable> LocalVariables { get; set; }

        /// <summary>
        /// <para>The queue in which the deployment is running.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default-queue</para>
        /// </summary>
        [NameInMap("resourceQueueName")]
        [Validation(Required=false)]
        public string ResourceQueueName { get; set; }

        /// <summary>
        /// <para>The configuration of the start offset of the deployment.</para>
        /// </summary>
        [NameInMap("restoreStrategy")]
        [Validation(Required=false)]
        public DeploymentRestoreStrategy RestoreStrategy { get; set; }

    }

}
