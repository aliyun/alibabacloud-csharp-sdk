// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class HTTPGetAction : TeaModel {
        /// <summary>
        /// <para>The hostname to which you want to connect. The default value is the IP address of the pod. You may need to specify Host in HttpHeaders.</para>
        /// 
        /// <b>Example:</b>
        /// <para>172.22.XX.XX</para>
        /// </summary>
        [NameInMap("Host")]
        [Validation(Required=false)]
        public string Host { get; set; }

        /// <summary>
        /// <para>The custom headers that you need to specify in the request. Duplicate headers are allowed in an HTTP request.</para>
        /// </summary>
        [NameInMap("HttpHeaders")]
        [Validation(Required=false)]
        public List<HTTPHeader> HttpHeaders { get; set; }

        /// <summary>
        /// <para>The path of a URL.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/path1</para>
        /// </summary>
        [NameInMap("Path")]
        [Validation(Required=false)]
        public string Path { get; set; }

        /// <summary>
        /// <para>The port range. Valid values: 1 to 65535.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("Port")]
        [Validation(Required=false)]
        public int? Port { get; set; }

        /// <summary>
        /// <para>The scheme that you want to use to connect to the host. Default value: http.</para>
        /// 
        /// <b>Example:</b>
        /// <para>http</para>
        /// </summary>
        [NameInMap("Scheme")]
        [Validation(Required=false)]
        public string Scheme { get; set; }

    }

}
