// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tablestore20201209.Models
{
    public class DeleteAgentStoragePolicyRequest : TeaModel {
        /// <summary>
        /// <para>The name of the agent storage.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>first-agent</para>
        /// </summary>
        [NameInMap("AgentStorageName")]
        [Validation(Required=false)]
        public string AgentStorageName { get; set; }

        /// <summary>
        /// <para>The version of the access control policy for agent storage.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("PolicyVersion")]
        [Validation(Required=false)]
        public long? PolicyVersion { get; set; }

    }

}
