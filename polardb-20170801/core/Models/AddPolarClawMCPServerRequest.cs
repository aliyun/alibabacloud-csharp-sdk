// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class AddPolarClawMCPServerRequest : TeaModel {
        /// <summary>
        /// <para>The application ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pa-**************</para>
        /// </summary>
        [NameInMap("ApplicationId")]
        [Validation(Required=false)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// <para>The configuration object for the MCP server.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;command&quot;: &quot;node&quot;,
        ///     &quot;args&quot;: [
        ///         &quot;-y&quot;,
        ///         &quot;@polarclaw/mcp-dev&quot;
        ///     ]
        /// }</para>
        /// </summary>
        [NameInMap("ServerConfig")]
        [Validation(Required=false)]
        public Dictionary<string, object> ServerConfig { get; set; }

        /// <summary>
        /// <para>The unique identifier for the MCP server.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-v1</para>
        /// </summary>
        [NameInMap("ServerName")]
        [Validation(Required=false)]
        public string ServerName { get; set; }

    }

}
