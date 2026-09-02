// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class GenerateAgentDataSemanticsRequest : TeaModel {
        /// <summary>
        /// <para>The agent name. If no current official version exists or all four knowledge categories are empty, a first-time generation is performed. If at least one knowledge category is non-empty, only Text is regenerated while existing Metrics, Joins, and Examples are retained. The caller cannot specify the generation mode.</para>
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
