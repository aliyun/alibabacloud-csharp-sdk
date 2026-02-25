// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class WebCustomDomain : TeaModel {
        /// <summary>
        /// <para>The time when the custom domain name was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-03-30T08:02:19Z</para>
        /// </summary>
        [NameInMap("CreatedTime")]
        [Validation(Required=false)]
        public string CreatedTime { get; set; }

        /// <summary>
        /// <para>The name of the application that is forwarded by the domain name by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>appxxxxx</para>
        /// </summary>
        [NameInMap("DefaultForwardingAppName")]
        [Validation(Required=false)]
        public string DefaultForwardingAppName { get; set; }

        /// <summary>
        /// <para>The domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The time when the custom domain name was last updated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-03-30T08:02:19Z</para>
        /// </summary>
        [NameInMap("LastModifiedTime")]
        [Validation(Required=false)]
        public string LastModifiedTime { get; set; }

        /// <summary>
        /// <para>The ID of the namespace to which the domain name belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-chengdu</para>
        /// </summary>
        [NameInMap("NamespaceId")]
        [Validation(Required=false)]
        public string NamespaceId { get; set; }

        /// <summary>
        /// <para>The protocol type that is supported by the custom domain name. HTTP: Only HTTP is supported. HTTPS: Only HTTPS is supported. HTTP, HTTPS: Both HTTP and HTTPS are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>HTTP</para>
        /// </summary>
        [NameInMap("Protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

        /// <summary>
        /// <para>The route configurations.</para>
        /// </summary>
        [NameInMap("RouteConfig")]
        [Validation(Required=false)]
        public RouteConfig RouteConfig { get; set; }

        /// <summary>
        /// <para>The information about the HTTPS certificate.</para>
        /// </summary>
        [NameInMap("WebCertConfig")]
        [Validation(Required=false)]
        public WebCertConfig WebCertConfig { get; set; }

        /// <summary>
        /// <para>The Transport Layer Security (TLS) configurations.</para>
        /// </summary>
        [NameInMap("WebTLSConfig")]
        [Validation(Required=false)]
        public WebTLSConfig WebTLSConfig { get; set; }

        /// <summary>
        /// <para>The WAF configurations.</para>
        /// </summary>
        [NameInMap("WebWAFConfig")]
        [Validation(Required=false)]
        public WebWAFConfig WebWAFConfig { get; set; }

        /// <summary>
        /// <para>The ID of your Alibaba Cloud account</para>
        /// 
        /// <b>Example:</b>
        /// <para>123xxxxxx</para>
        /// </summary>
        [NameInMap("accountId")]
        [Validation(Required=false)]
        public string AccountId { get; set; }

    }

}
