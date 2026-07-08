// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeHybridCloudUnsupportPortsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of ports for the HTTP protocol. The value is a string. Multiple ports are returned in the <b>port1,port2,port3</b> format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80,8080</para>
        /// </summary>
        [NameInMap("HttpPorts")]
        [Validation(Required=false)]
        public string HttpPorts { get; set; }

        /// <summary>
        /// <para>The list of ports for the HTTPS protocol. The value is a string. Multiple ports are returned in the <b>port1,port2,port3</b> format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>443,8443,8021,3443,2443,9011</para>
        /// </summary>
        [NameInMap("HttpsPorts")]
        [Validation(Required=false)]
        public string HttpsPorts { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C2E97B3F-1623-4CDF-A7E2-FD9D****027A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
