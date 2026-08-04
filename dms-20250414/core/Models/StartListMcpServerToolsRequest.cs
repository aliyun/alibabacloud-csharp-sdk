// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class StartListMcpServerToolsRequest : TeaModel {
        /// <summary>
        /// <para>The identifier of the Data Management unit that runs the Data Agent resources.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("DMSUnit")]
        [Validation(Required=false)]
        public string DMSUnit { get; set; }

        /// <summary>
        /// <para>The language used for the detection session.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CHINESE</para>
        /// </summary>
        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        /// <summary>
        /// <para>The ID of the MCP Server for which to detect connectivity and query the tool list. Only the service creator can trigger the detection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>44lg***z65</para>
        /// </summary>
        [NameInMap("McpServerUuid")]
        [Validation(Required=false)]
        public string McpServerUuid { get; set; }

    }

}
