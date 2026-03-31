// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeWafSourceIpSegmentResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9087ADDC-9047-4D02-82A7-33021B58083C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The back-to-origin CIDR blocks that are used by the protection cluster.</para>
        /// </summary>
        [NameInMap("WafSourceIp")]
        [Validation(Required=false)]
        public DescribeWafSourceIpSegmentResponseBodyWafSourceIp WafSourceIp { get; set; }
        public class DescribeWafSourceIpSegmentResponseBodyWafSourceIp : TeaModel {
            /// <summary>
            /// <para>An array of back-to-origin IPv4 CIDR blocks.</para>
            /// </summary>
            [NameInMap("IPv4")]
            [Validation(Required=false)]
            public List<string> IPv4 { get; set; }

            /// <summary>
            /// <para>An array of back-to-origin IPv6 CIDR blocks.</para>
            /// </summary>
            [NameInMap("IPv6")]
            [Validation(Required=false)]
            public List<string> IPv6 { get; set; }

        }

    }

}
