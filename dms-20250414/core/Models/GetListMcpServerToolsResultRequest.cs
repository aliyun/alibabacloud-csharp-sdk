// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class GetListMcpServerToolsResultRequest : TeaModel {
        /// <summary>
        /// <para>The DMS unit identifier. This value is typically the same as the DMSUnit used in the request that started the tool detection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("DMSUnit")]
        [Validation(Required=false)]
        public string DMSUnit { get; set; }

        /// <summary>
        /// <para>The MCP Server ID used when the detection was started. This value must match the detection record associated with the SessionId.</para>
        /// 
        /// <b>Example:</b>
        /// <para>44lg***z65</para>
        /// </summary>
        [NameInMap("McpServerUuid")]
        [Validation(Required=false)]
        public string McpServerUuid { get; set; }

        /// <summary>
        /// <para>The temporary session ID returned by StartListMcpServerTools. This ID is used to locate the connectivity detection task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1vwe***6wr</para>
        /// </summary>
        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

    }

}
