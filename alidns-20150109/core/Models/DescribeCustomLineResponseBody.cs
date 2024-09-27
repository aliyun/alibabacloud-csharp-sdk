// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeCustomLineResponseBody : TeaModel {
        /// <summary>
        /// <para>The code of the custom line.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hra0yc-597</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

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
        /// <para>The ID of the custom line.</para>
        /// 
        /// <b>Example:</b>
        /// <para>597</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>The CIDR blocks. Separate IP addresses with a hyphen (-). Enter a CIDR block in each row. You can enter 1 to 50 CIDR blocks at a time. If a CIDR block contains only one IP address, enter the IP address in the format of IP1-IP1. Different CIDR blocks cannot be overlapped.</para>
        /// </summary>
        [NameInMap("IpSegmentList")]
        [Validation(Required=false)]
        public List<DescribeCustomLineResponseBodyIpSegmentList> IpSegmentList { get; set; }
        public class DescribeCustomLineResponseBodyIpSegmentList : TeaModel {
            /// <summary>
            /// <para>The end IP address of the CIDR block.</para>
            /// 
            /// <b>Example:</b>
            /// <para>11.1.1.3</para>
            /// </summary>
            [NameInMap("EndIp")]
            [Validation(Required=false)]
            public string EndIp { get; set; }

            /// <summary>
            /// <para>The start IP address of the CIDR block.</para>
            /// 
            /// <b>Example:</b>
            /// <para>11.1.1.2</para>
            /// </summary>
            [NameInMap("StartIp")]
            [Validation(Required=false)]
            public string StartIp { get; set; }

        }

        /// <summary>
        /// <para>The name of the custom line.</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B57C121B-A45F-44D8-A9B2-13E5A5044195</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
