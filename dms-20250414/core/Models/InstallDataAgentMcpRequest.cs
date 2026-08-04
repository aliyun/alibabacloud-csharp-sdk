// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class InstallDataAgentMcpRequest : TeaModel {
        /// <summary>
        /// <para>The brief description of the artifact. This parameter can be empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>query user information by user ID</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The endpoint of the MCP instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>http://***.com/mcp</para>
        /// </summary>
        [NameInMap("Endpoint")]
        [Validation(Required=false)]
        public string Endpoint { get; set; }

        /// <summary>
        /// <para>The JSON used to create the MCP.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;mcpServers&quot;: {
        ///     &quot;sse-server-name&quot;: {
        ///       &quot;description&quot;: &quot;describe sse mcp server&quot;,
        ///       &quot;type&quot;: &quot;sse&quot;,
        ///       &quot;netType&quot;: &quot;vpc&quot;,
        ///       &quot;vpcId&quot;: &quot;vpc-xxxx&quot;,
        ///       &quot;url&quot;: &quot;<a href="http://sse-in-vpc.com/sse">http://sse-in-vpc.com/sse</a>&quot;,
        ///       &quot;needUidInHeader&quot;: true,
        ///       &quot;headers&quot;: {
        ///         &quot;Authorization&quot;: &quot;Bearer <token>&quot;
        ///       }
        ///     }
        ///   }
        /// }</para>
        /// </summary>
        [NameInMap("FromJson")]
        [Validation(Required=false)]
        public string FromJson { get; set; }

        /// <summary>
        /// <para>The request header settings.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Authorization&quot;:&quot;Bearer ***&quot;}</para>
        /// </summary>
        [NameInMap("Headers")]
        [Validation(Required=false)]
        public string Headers { get; set; }

        /// <summary>
        /// <para>The MCP name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>query_tool</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>Specifies whether to include the Alibaba Cloud UID in the request header.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("NeedUidInHeader")]
        [Validation(Required=false)]
        public bool? NeedUidInHeader { get; set; }

        /// <summary>
        /// <para>The network type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>vpc</c>: virtual private cloud.</description></item>
        /// <item><description><c>public</c>: public network.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>public</para>
        /// </summary>
        [NameInMap("NetType")]
        [Validation(Required=false)]
        public string NetType { get; set; }

        /// <summary>
        /// <para>The transport channel type. Valid values: streamablehttp and sse.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sse</para>
        /// </summary>
        [NameInMap("TransportType")]
        [Validation(Required=false)]
        public string TransportType { get; set; }

        /// <summary>
        /// <para>VPC ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-uf63***o5</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <para>The vSwitch ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-8vb5j***6h</para>
        /// </summary>
        [NameInMap("VswId")]
        [Validation(Required=false)]
        public string VswId { get; set; }

        /// <summary>
        /// <para>The workspace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20923*****7291</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
