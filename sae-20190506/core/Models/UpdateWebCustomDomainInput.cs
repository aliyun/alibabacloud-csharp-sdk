// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class UpdateWebCustomDomainInput : TeaModel {
        /// <summary>
        /// <para>The name of the application to which data is forwarded by the domain name by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>demo-app</para>
        /// </summary>
        [NameInMap("DefaultForwardingAppName")]
        [Validation(Required=false)]
        public string DefaultForwardingAppName { get; set; }

        /// <summary>
        /// <para>The protocol type that is supported by the custom domain name. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>HTTP</b>: Only HTTP is supported.</description></item>
        /// <item><description><b>HTTPS</b>: Only HTTPS is supported.</description></item>
        /// <item><description><b>HTTP,HTTPS</b>: Both HTTP and HTTPS are supported.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>HTTP</para>
        /// </summary>
        [NameInMap("Protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

        /// <summary>
        /// <para>The route configuration.</para>
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
        /// <para>The Web Application Firewall (WAF) configurations.</para>
        /// </summary>
        [NameInMap("WebWAFConfig")]
        [Validation(Required=false)]
        public WebWAFConfig WebWAFConfig { get; set; }

    }

}
