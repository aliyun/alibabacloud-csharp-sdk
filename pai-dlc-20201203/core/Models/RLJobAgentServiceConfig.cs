// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class RLJobAgentServiceConfig : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable the companion AgentService for the job. Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        /// <summary>
        /// <para>The list of name-value environment variables for AgentService. You cannot overwrite platform-reserved variables. The GetRLJob operation returns an asterisk (*) for the values of E2B_API_KEY and platform-specified credentials, and keeps other values unchanged. Automatic masking is not guaranteed for all custom sensitive values.</para>
        /// </summary>
        [NameInMap("Env")]
        [Validation(Required=false)]
        public List<RLJobAgentServiceEnvVar> Env { get; set; }

    }

}
