// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class ItemsI18nValue : TeaModel {
        /// <summary>
        /// <para>The MCP service description in the specified language.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MCP service for querying knowledge bases</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The MCP marketplace template name in the specified language.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Knowledge Base</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The usage instructions for the MCP marketplace template in the specified language.</para>
        /// 
        /// <b>Example:</b>
        /// <h1>Knowledge Base\nKnowledge base query service</h1>
        /// </summary>
        [NameInMap("readme")]
        [Validation(Required=false)]
        public string Readme { get; set; }

    }

}
