// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeWebCustomPortsResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0bcf28g5-d57c-11e7-9bs0-d89d6717dxbc</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The custom port information for website services.</para>
        /// </summary>
        [NameInMap("WebCustomPorts")]
        [Validation(Required=false)]
        public List<DescribeWebCustomPortsResponseBodyWebCustomPorts> WebCustomPorts { get; set; }
        public class DescribeWebCustomPortsResponseBodyWebCustomPorts : TeaModel {
            /// <summary>
            /// <para>The available port range.</para>
            /// </summary>
            [NameInMap("ProxyPorts")]
            [Validation(Required=false)]
            public List<string> ProxyPorts { get; set; }

            /// <summary>
            /// <para>The Protocol Type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>http</b></para>
            /// </description></item>
            /// <item><description><para><b>https</b></para>
            /// </description></item>
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
