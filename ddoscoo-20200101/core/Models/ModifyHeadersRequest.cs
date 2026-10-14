// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class ModifyHeadersRequest : TeaModel {
        /// <summary>
        /// <para>The custom header, specified as a key-value pair. The key is the header name and the value is the header value. You can specify up to 5 key-value pairs. The total length cannot exceed 200 characters.</para>
        /// <para>Important:</para>
        /// <list type="bullet">
        /// <item><description><list type="bullet">
        /// <item><description><para>X-Forwarded-ClientSrcPort: Used by default to retrieve the client port that accesses the Layer 7 engine of Anti-DDoS Pro.</para>
        /// </description></item>
        /// <item><description><para>X-Forwarded-ProxyPort: Used by default to retrieve the listening port of the Layer 7 engine of Anti-DDoS Pro.</para>
        /// </description></item>
        /// <item><description><para>X-Forwarded-For: Used by default to retrieve the client IP address that accesses the Layer 7 engine of Anti-DDoS Pro.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Do not use standard HTTP header fields (such as <c>host</c>, <c>user-agent</c>, <c>connection</c>, and <c>upgrade</c>) or common custom HTTP header fields (such as <c>x-real-ip</c>, <c>x-true-ip</c>, <c>x-client-ip</c>, <c>web-server-type</c>, <c>wl-proxy-client-ip</c>, <c>eagleeye-rpcid</c>, <c>eagleeye-traceid</c>, <c>x-forwarded-cluster</c>, and <c>x-forwarded-proto</c>) as they will overwrite the original header values in requests.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>To use the <c>X-Forwarded-ClientSrcPort</c> key to retrieve the client port that accesses the Layer 7 engine of Anti-DDoS Pro, set the value to <c>&quot;&quot;</c>.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;X-Forwarded-ClientSrcPort&quot;:&quot;&quot;}</para>
        /// </summary>
        [NameInMap("CustomHeaders")]
        [Validation(Required=false)]
        public string CustomHeaders { get; set; }

        /// <summary>
        /// <para>The domain of the website.</para>
        /// <remarks>
        /// <para>A website service forwarding rule must be configured for the domain. You can call the <a href="https://help.aliyun.com/document_detail/91724.html">DescribeDomains</a> operation to query all your domains.</para>
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
        /// <para>The forwarding configuration for request headers. This parameter is a JSON string of key-value pairs where the key is the header field name and the value is a boolean. Set the value to <c>true</c> to enable forwarding or <c>false</c> to disable it.</para>
        /// <para>Field description:</para>
        /// <para><c>X-Client-IP</c>: Forwards the client\&quot;s real IP address.</para>
        /// <para><c>X-True-IP</c>: Forwards the client\&quot;s connection IP address.</para>
        /// <para><c>Web-Server-Type</c>: Informs the back-end server about the type of front-end web server or proxy that is handling the request.</para>
        /// <para><c>WL-Proxy-Client-IP</c>: A request header specific to Oracle WebLogic Server that provides the same functionality as <c>X-Client-IP</c>.</para>
        /// <para><c>X-Forwarded-Proto</c>: Indicates the protocol used for the connection between the client and the first proxy.</para>
        /// <para>Important:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Supported Headers</b>: The configuration supports only the five preset header fields listed above.</para>
        /// </description></item>
        /// <item><description><para><b>Default settings</b>: All the listed header fields are enabled by default. To make changes, you must explicitly set the corresponding value to <c>false</c>.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;X-Client-IP&quot;:true,&quot;X-True-IP&quot;:true,&quot;Web-Server-Type&quot;:true,&quot;WL-Proxy-Client-IP&quot;:true,&quot;X-Forwarded-Proto&quot;:true}</para>
        /// </summary>
        [NameInMap("EmbeddedHeaders")]
        [Validation(Required=false)]
        public string EmbeddedHeaders { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>You can call the <a href="https://help.aliyun.com/document_detail/158855.html">ListResourceGroups</a> operation or use the console to obtain a list of resource group IDs. For more information, see <a href="https://help.aliyun.com/document_detail/151181.html">View basic information about a resource group</a>.</description></item>
        /// </list>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>To find the current resource group of an instance before changing it, call the <a href="https://help.aliyun.com/document_detail/158866.html">ListResources</a> operation.</description></item>
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
