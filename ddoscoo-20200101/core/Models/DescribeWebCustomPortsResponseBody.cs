// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeWebCustomPortsResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0bcf28g5-d57c-11e7-9bs0-d89d6717dxbc</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>An array consisting of information about supported custom ports that are used by a website.</para>
        /// </summary>
        [NameInMap("WebCustomPorts")]
        [Validation(Required=false)]
        public List<DescribeWebCustomPortsResponseBodyWebCustomPorts> WebCustomPorts { get; set; }
        public class DescribeWebCustomPortsResponseBodyWebCustomPorts : TeaModel {
            /// <summary>
            /// <para>An array that consists of supported custom ports.</para>
            /// </summary>
            [NameInMap("ProxyPorts")]
            [Validation(Required=false)]
            public List<string> ProxyPorts { get; set; }

            /// <summary>
            /// <para>The type of the protocol. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>http</b></description></item>
            /// <item><description><b>https</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>http</para>
            /// </summary>
            [NameInMap("ProxyType")]
            [Validation(Required=false)]
            public string ProxyType { get; set; }

        }

    }

}
