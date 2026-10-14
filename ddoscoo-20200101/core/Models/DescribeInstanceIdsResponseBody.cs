// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeInstanceIdsResponseBody : TeaModel {
        /// <summary>
        /// <para>The IDs, editions, remarks, and IP types of the Anti-DDoS Pro or Anti-DDoS Premium instances.</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public List<DescribeInstanceIdsResponseBodyInstanceIds> InstanceIds { get; set; }
        public class DescribeInstanceIdsResponseBodyInstanceIds : TeaModel {
            /// <summary>
            /// <para>The edition of the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Anti-DDoS Pro or Anti-DDoS Premium (outside the Chinese mainland) Insurance Edition.</description></item>
            /// <item><description><b>1</b>: Anti-DDoS Pro or Anti-DDoS Premium (outside the Chinese mainland) Unlimited Edition.</description></item>
            /// <item><description><b>2</b>: Anti-DDoS Pro or Anti-DDoS Premium (outside the Chinese mainland) Acceleration Line.</description></item>
            /// <item><description><b>3</b>: Anti-DDoS Pro or Anti-DDoS Premium (outside the Chinese mainland) Secure Acceleration Line.</description></item>
            /// <item><description><b>9</b>: Anti-DDoS Pro or Anti-DDoS Premium (the Chinese mainland) Professional Edition.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>9</para>
            /// </summary>
            [NameInMap("Edition")]
            [Validation(Required=false)]
            public int? Edition { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ddoscoo-cn-zvp2eibz****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The IP forwarding mode of the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>fnat</b>: The IP versions of the origin server and the client are the same. IPv4 client requests are forwarded to the IPv4 origin server, and IPv6 client requests are forwarded to the IPv6 origin server.</description></item>
            /// <item><description><b>v6tov4</b>: Both IPv6 and IPv4 client requests are forwarded to the IPv4 origin server.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>fnat</para>
            /// </summary>
            [NameInMap("IpMode")]
            [Validation(Required=false)]
            public string IpMode { get; set; }

            /// <summary>
            /// <para>The IP protocol version of the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Ipv4</b>: IPv4.</description></item>
            /// <item><description><b>Ipv6</b>: IPv6.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Ipv4</para>
            /// </summary>
            [NameInMap("IpVersion")]
            [Validation(Required=false)]
            public string IpVersion { get; set; }

            /// <summary>
            /// <para>The remark of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>310A41FD-0990-5610-92E0-A6A55D7C6444</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
