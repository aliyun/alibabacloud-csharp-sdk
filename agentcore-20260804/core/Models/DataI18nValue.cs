// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class DataI18nValue : TeaModel {
        /// <summary>
        /// <para>The description of the MCP service in the language.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MCP service for querying knowledge bases</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The name of the MCP marketplace template in the language.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Knowledge base</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The instructions for the MCP marketplace template in the language.</para>
        /// 
        /// <b>Example:</b>
        /// <h1>Knowledge base\nKnowledge base query service</h1>
        /// </summary>
        [NameInMap("readme")]
        [Validation(Required=false)]
        public string Readme { get; set; }

    }

}
