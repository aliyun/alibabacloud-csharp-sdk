// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class ModifyHeadersRequest : TeaModel {
        /// <summary>
        /// <para>The key-value pair of the custom header. The key specifies the header name, and the value specifies the header value. You can specify up to five key-value pairs. The key-value pairs can be up to 200 characters in length.</para>
        /// <para>Take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description><para>Do not use the following default HTTP headers:</para>
        /// <list type="bullet">
        /// <item><description>X-Forwarded-ClientSrcPort: This header is used to obtain the source ports of clients that access Anti-DDoS Proxy (a Layer 7 proxy).</description></item>
        /// <item><description>X-Forwarded-ProxyPort: This header is used to obtain the ports of listeners that access Anti-DDoS Proxy (a Layer 7 proxy).</description></item>
        /// <item><description>X-Forwarded-For: This header is used to obtain the IP addresses of clients that access Anti-DDoS Proxy (a Layer 7 proxy).</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Do not use standard HTTP headers or specific widely used custom HTTP headers. The standard HTTP headers include Host, User-Agent, Connection, and Upgrade, and the widely used custom HTTP headers include X-Real-IP, X-True-IP, X-Client-IP, Web-Server-Type, WL-Proxy-Client-IP, eEagleEye-RpcID, EagleEye-TraceID, X-Forwarded-Cluster, and X-Forwarded-Proto. If the preceding headers are used, the original content of the headers is overwritten.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para> If you specify a key of X-Forwarded-ClientSrcPort, the system obtains the originating ports of clients that access Anti-DDoS Proxy (a Layer 7 proxy). In this case, the value is an empty string.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;X-Forwarded-ClientSrcPort\&quot;:\&quot;\&quot;}</para>
        /// </summary>
        [NameInMap("CustomHeaders")]
        [Validation(Required=false)]
        public string CustomHeaders { get; set; }

        /// <summary>
        /// <para>The domain name of the website.</para>
        /// <remarks>
        /// <para>A forwarding rule must be configured for the domain name. You can call the <a href="https://help.aliyun.com/document_detail/91724.html">DescribeDomains</a> operation to query all domain names.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.aliyundoc.com</para>
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the instance belongs.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>You can query resource group IDs in the Anti-DDoS Pro or Anti-DDoS Premium console or by calling the <a href="https://help.aliyun.com/document_detail/158855.html">ListResourceGroups</a> operation. For more information, see <a href="https://help.aliyun.com/document_detail/151181.html">View basic information of a resource group</a>.</para>
        /// </description></item>
        /// <item><description><para>Before you modify the resource group to which an instance belongs, you can call the <a href="https://help.aliyun.com/document_detail/158866.html">ListResources</a> operation to view the current resource group of the instance.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmz6jbof5****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}
