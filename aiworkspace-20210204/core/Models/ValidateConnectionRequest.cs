// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class ValidateConnectionRequest : TeaModel {
        /// <summary>
        /// <para>The configuration of the connection, specified as key-value pairs. The configuration keys vary by connection type. For more information, see the supplementary information about the request parameters of the CreateConnection operation.</para>
        /// </summary>
        [NameInMap("Configs")]
        [Validation(Required=false)]
        public Dictionary<string, string> Configs { get; set; }

        /// <summary>
        /// <para>The connection ID. For more information about how to obtain the connection ID, see <a href="url">ListConnections</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>conn-x2wz5zvvbyf2420fi9</para>
        /// </summary>
        [NameInMap("ConnectionId")]
        [Validation(Required=false)]
        public string ConnectionId { get; set; }

        /// <summary>
        /// <para>The connection type. Only connection types that support public network access are available. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>DashScopeConnection: a service connection for Alibaba Cloud Model Studio.</para>
        /// </description></item>
        /// <item><description><para>DeepSeekConnection: a service connection for DeepSeek.</para>
        /// </description></item>
        /// <item><description><para>FunctionAIMCPConnection: a connection for Function AI MCP.</para>
        /// </description></item>
        /// <item><description><para>CustomMCPConnection: a custom MCP connection.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>DashScopeConnection</para>
        /// </summary>
        [NameInMap("ConnectionType")]
        [Validation(Required=false)]
        public string ConnectionType { get; set; }

        /// <summary>
        /// <para>The key-value pairs to encrypt, such as a database logon password or a model connection key.</para>
        /// </summary>
        [NameInMap("Secrets")]
        [Validation(Required=false)]
        public Dictionary<string, string> Secrets { get; set; }

        /// <summary>
        /// <para>The validation type. Set the value to:</para>
        /// <list type="bullet">
        /// <item><description>Connectivity: a connectivity test</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Connectivity</para>
        /// </summary>
        [NameInMap("ValidateType")]
        [Validation(Required=false)]
        public string ValidateType { get; set; }

        /// <summary>
        /// <para>The workspace ID. For more information about how to obtain the workspace ID, see <a href="https://help.aliyun.com/document_detail/449124.html">ListWorkspaces</a>.</para>
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
