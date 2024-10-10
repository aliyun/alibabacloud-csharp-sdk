// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class WebCustomDomain : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>2023-03-30T08:02:19Z</para>
        /// </summary>
        [NameInMap("CreatedTime")]
        [Validation(Required=false)]
        public string CreatedTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>appxxxxx</para>
        /// </summary>
        [NameInMap("DefaultForwardingAppName")]
        [Validation(Required=false)]
        public string DefaultForwardingAppName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2023-03-30T08:02:19Z</para>
        /// </summary>
        [NameInMap("LastModifiedTime")]
        [Validation(Required=false)]
        public string LastModifiedTime { get; set; }

        [NameInMap("NamespaceId")]
        [Validation(Required=false)]
        public string NamespaceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>HTTP</para>
        /// </summary>
        [NameInMap("Protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

        [NameInMap("RouteConfig")]
        [Validation(Required=false)]
        public RouteConfig RouteConfig { get; set; }

        [NameInMap("WebCertConfig")]
        [Validation(Required=false)]
        public WebCertConfig WebCertConfig { get; set; }

        [NameInMap("WebTLSConfig")]
        [Validation(Required=false)]
        public WebTLSConfig WebTLSConfig { get; set; }

        [NameInMap("WebWAFConfig")]
        [Validation(Required=false)]
        public WebWAFConfig WebWAFConfig { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>123xxxxxx</para>
        /// </summary>
        [NameInMap("accountId")]
        [Validation(Required=false)]
        public string AccountId { get; set; }

    }

}
