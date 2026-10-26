// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RocketMQ20220801.Models
{
    public class UpdateAgentConversationShareScopeRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tenant_viewer</para>
        /// </summary>
        [NameInMap("shareScope")]
        [Validation(Required=false)]
        public string ShareScope { get; set; }

    }

}
