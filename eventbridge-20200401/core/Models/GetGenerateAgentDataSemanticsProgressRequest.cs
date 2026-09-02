// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class GetGenerateAgentDataSemanticsProgressRequest : TeaModel {
        /// <summary>
        /// <para>The name of the agent.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bakehouse_agent</para>
        /// </summary>
        [NameInMap("AgentName")]
        [Validation(Required=false)]
        public string AgentName { get; set; }

    }

}
