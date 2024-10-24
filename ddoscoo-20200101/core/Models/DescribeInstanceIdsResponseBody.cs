// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeInstanceIdsResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID, type, description, and IP version of the instance.</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public List<DescribeInstanceIdsResponseBodyInstanceIds> InstanceIds { get; set; }
        public class DescribeInstanceIdsResponseBodyInstanceIds : TeaModel {
            /// <summary>
            /// <para>The type of the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Anti-DDoS Proxy (Outside Chinese Mainland) instance of the Insurance mitigation plan</description></item>
            /// <item><description><b>1</b>: Anti-DDoS Proxy (Outside Chinese Mainland) instance of the Unlimited mitigation plan</description></item>
            /// <item><description><b>2</b>: Anti-DDoS Proxy (Outside Chinese Mainland) instance of the CMA mitigation plan</description></item>
            /// <item><description><b>3</b>: Anti-DDoS Proxy (Outside Chinese Mainland) instance of the Sec-CMA mitigation plan</description></item>
            /// <item><description><b>9</b>: Anti-DDoS Proxy (Chinese Mainland) instance of the Profession mitigation plan</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>9</para>
            /// </summary>
            [NameInMap("Edition")]
            [Validation(Required=false)]
            public int? Edition { get; set; }

            /// <summary>
            /// <para>The ID of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ddoscoo-cn-zvp2eibz****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The IP address-based forwarding mode of the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>fnat</b>: Requests from IPv4 addresses are forwarded to origin servers that use IPv4 addresses and requests from IPv6 addresses are forwarded to origin servers that use IPv6 addresses.</description></item>
            /// <item><description><b>v6tov4</b>: All requests are forwarded to origin servers that use IPv4 addresses.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>fnat</para>
            /// </summary>
            [NameInMap("IpMode")]
            [Validation(Required=false)]
            public string IpMode { get; set; }

            /// <summary>
            /// <para>The IP version of the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Ipv4</b></description></item>
            /// <item><description><b>Ipv6</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Ipv4</para>
            /// </summary>
            [NameInMap("IpVersion")]
            [Validation(Required=false)]
            public string IpVersion { get; set; }

            /// <summary>
            /// <para>The description of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>310A41FD-0990-5610-92E0-A6A55D7C6444</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
