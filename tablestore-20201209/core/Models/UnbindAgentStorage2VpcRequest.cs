// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tablestore20201209.Models
{
    public class UnbindAgentStorage2VpcRequest : TeaModel {
        /// <summary>
        /// <para>The agent storage name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>agent-test</para>
        /// </summary>
        [NameInMap("AgentStorageName")]
        [Validation(Required=false)]
        public string AgentStorageName { get; set; }

        /// <summary>
        /// <para>The VPC name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>remua</para>
        /// </summary>
        [NameInMap("AgentStorageVpcName")]
        [Validation(Required=false)]
        public string AgentStorageVpcName { get; set; }

    }

}
