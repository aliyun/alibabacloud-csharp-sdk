// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class JobStartParameters : TeaModel {
        /// <summary>
        /// <para>Job ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>737d0921-c5ac-47fc-9ba9-07a1e0b4****</para>
        /// </summary>
        [NameInMap("deploymentId")]
        [Validation(Required=false)]
        public string DeploymentId { get; set; }

        /// <summary>
        /// <para>Job instance ID</para>
        /// </summary>
        [NameInMap("jobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// <para>Job variables</para>
        /// </summary>
        [NameInMap("localVariables")]
        [Validation(Required=false)]
        public List<LocalVariable> LocalVariables { get; set; }

        /// <summary>
        /// <para>Resource queue for job execution</para>
        /// 
        /// <b>Example:</b>
        /// <para>default-queue</para>
        /// </summary>
        [NameInMap("resourceQueueName")]
        [Validation(Required=false)]
        public string ResourceQueueName { get; set; }

        /// <summary>
        /// <para>Job start offset settings</para>
        /// </summary>
        [NameInMap("restoreStrategy")]
        [Validation(Required=false)]
        public DeploymentRestoreStrategy RestoreStrategy { get; set; }

    }

}
