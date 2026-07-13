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
        /// <para>hra0yc-*********</para>
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
        /// <para>5*******</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>The list of IP address segments. Use a hyphen (-) to separate the start and end IP addresses. Each line represents one segment. You can specify from 1 to 50 segments. For a single IP address, use the format IP1-IP1. IP address segments cannot overlap.</para>
        /// </summary>
        [NameInMap("IpSegmentList")]
        [Validation(Required=false)]
        public List<DescribeCustomLineResponseBodyIpSegmentList> IpSegmentList { get; set; }
        public class DescribeCustomLineResponseBodyIpSegmentList : TeaModel {
            /// <summary>
            /// <para>The end IP address of the segment.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.1.XX.XX</para>
            /// </summary>
            [NameInMap("EndIp")]
            [Validation(Required=false)]
            public string EndIp { get; set; }

            /// <summary>
            /// <para>The start IP address of the segment.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.2.XX.XX</para>
            /// </summary>
            [NameInMap("StartIp")]
            [Validation(Required=false)]
            public string StartIp { get; set; }

        }

        /// <summary>
        /// <para>The name of the custom line.</para>
        /// 
        /// <b>Example:</b>
        /// <para>测试线路</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The unique request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B57C121B-A45F-44D8-A9B2-13E5A5044195</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
