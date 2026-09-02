// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class SaveAgentDataSemanticsRequest : TeaModel {
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

        /// <summary>
        /// <para>The SQL example knowledge. If this parameter is specified, the current content is saved. If this parameter is not specified, the existing content is cleared. A maximum of 50 entries are supported, and the maximum size of each knowledge category is 16 KB.</para>
        /// </summary>
        [NameInMap("Examples")]
        [Validation(Required=false)]
        public List<AgentDataSemanticsExample> Examples { get; set; }

        /// <summary>
        /// <para>The data association knowledge. If this parameter is specified, the current content is saved. If this parameter is not specified, the existing content is cleared. A maximum of 100 entries are supported, and the maximum size of each knowledge category is 16 KB.</para>
        /// </summary>
        [NameInMap("Joins")]
        [Validation(Required=false)]
        public List<AgentDataSemanticsJoin> Joins { get; set; }

        /// <summary>
        /// <para>The SQL expression knowledge. If this parameter is specified, the current content is saved. If this parameter is not specified, the existing content is cleared. A maximum of 100 entries are supported, and the maximum size of each knowledge category is 16 KB.</para>
        /// </summary>
        [NameInMap("Metrics")]
        [Validation(Required=false)]
        public List<AgentDataSemanticsMetric> Metrics { get; set; }

        /// <summary>
        /// <para>The text knowledge in Markdown format. If this parameter is specified, the current content is saved. If this parameter is not specified, the existing content is cleared. The maximum size of each knowledge category is 16 KB.</para>
        /// </summary>
        [NameInMap("Text")]
        [Validation(Required=false)]
        public AgentDataSemanticsText Text { get; set; }

    }

}
