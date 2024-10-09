// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class JobStartParameters : TeaModel {
        [NameInMap("deploymentId")]
        [Validation(Required=false)]
        public string DeploymentId { get; set; }

        [NameInMap("jobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        [NameInMap("localVariables")]
        [Validation(Required=false)]
        public List<LocalVariable> LocalVariables { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>default-queue</para>
        /// </summary>
        [NameInMap("resourceQueueName")]
        [Validation(Required=false)]
        public string ResourceQueueName { get; set; }

        [NameInMap("restoreStrategy")]
        [Validation(Required=false)]
        public DeploymentRestoreStrategy RestoreStrategy { get; set; }

    }

}
