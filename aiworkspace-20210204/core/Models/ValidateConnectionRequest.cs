// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class ValidateConnectionRequest : TeaModel {
        /// <summary>
        /// <para>The configuration information of the connection. The information is configured in key-value pairs. The keys in the configuration vary based on the connection type. For more information, see the supplementary description of request parameters for the CreateConnection operation.</para>
        /// </summary>
        [NameInMap("Configs")]
        [Validation(Required=false)]
        public Dictionary<string, string> Configs { get; set; }

        /// <summary>
        /// <para>The connection ID. For more information about how to obtain the connection ID, see <a href="~~ListConnections~~">ListConnections</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>conn-x2wz5zvvbyf2420fi9</para>
        /// </summary>
        [NameInMap("ConnectionId")]
        [Validation(Required=false)]
        public string ConnectionId { get; set; }

        /// <summary>
        /// <para>The type of the connection. You can specify a connection type that supports public network access. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>DashScopeConnection: The Model Studio connection.</description></item>
        /// <item><description>DeepSeekConnection: The DeepSeek connection.</description></item>
        /// <item><description>FunctionAIMCPConnection: The Function AI MCP connection.</description></item>
        /// <item><description>CustomMCPConnection: The custom MCP connection.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>DashScopeConnection</para>
        /// </summary>
        [NameInMap("ConnectionType")]
        [Validation(Required=false)]
        public string ConnectionType { get; set; }

        /// <summary>
        /// <para>The key-value configurations that require encryption, such as the database logon password and the key for the model connection.</para>
        /// </summary>
        [NameInMap("Secrets")]
        [Validation(Required=false)]
        public Dictionary<string, string> Secrets { get; set; }

        /// <summary>
        /// <para>The validation type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Connectivity: The connectivity test.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Connectivity</para>
        /// </summary>
        [NameInMap("ValidateType")]
        [Validation(Required=false)]
        public string ValidateType { get; set; }

        /// <summary>
        /// <para>The workspace ID. You can obtain the workspace ID by calling the <a href="https://help.aliyun.com/document_detail/449124.html">ListWorkspaces</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
