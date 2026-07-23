// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class DeployTrafficControlTaskCodeRequest : TeaModel {
        /// <summary>
        /// <para>The deployment environment. Valid values: Daily (daily environment), Pre (pre-production environment), and Prod (production environment).</para>
        /// 
        /// <b>Example:</b>
        /// <para>Daily</para>
        /// </summary>
        [NameInMap("Environment")]
        [Validation(Required=false)]
        public string Environment { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pairec-test1</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Specifies whether to automatically retry a failed deployment.</para>
        /// </summary>
        [NameInMap("RetryDeploy")]
        [Validation(Required=false)]
        public bool? RetryDeploy { get; set; }

    }

}
