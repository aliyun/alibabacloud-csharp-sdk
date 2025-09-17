// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeHybridCloudUnsupportPortsResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP ports. The value is a string. If multiple ports are returned, the value is in the <b>port1,port2,port3</b> format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80,8080</para>
        /// </summary>
        [NameInMap("HttpPorts")]
        [Validation(Required=false)]
        public string HttpPorts { get; set; }

        /// <summary>
        /// <para>The HTTPS ports. The value is a string. If multiple ports are returned, the value is in the <b>port1,port2,port3</b> format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>443,8443,8021,3443,2443,9011</para>
        /// </summary>
        [NameInMap("HttpsPorts")]
        [Validation(Required=false)]
        public string HttpsPorts { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C2E97B3F-1623-4CDF-A7E2-FD9D****027A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
