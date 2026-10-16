// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentIdentity20250901.Models
{
    public class GetUserPoolSyncJobRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the synchronization task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>syncjob_8d713b14a63b4a559753492ab51c31f3</para>
        /// </summary>
        [NameInMap("SynchronizationJobId")]
        [Validation(Required=false)]
        public string SynchronizationJobId { get; set; }

        /// <summary>
        /// <para>The name of the user pool.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UserpoolName</para>
        /// </summary>
        [NameInMap("UserPoolName")]
        [Validation(Required=false)]
        public string UserPoolName { get; set; }

    }

}
