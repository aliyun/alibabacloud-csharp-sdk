// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeUserIPSWhitelistResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of IPv6 whitelists for the IPS on the Internet Border.</para>
        /// </summary>
        [NameInMap("Ipv6Whitelists")]
        [Validation(Required=false)]
        public List<DescribeUserIPSWhitelistResponseBodyIpv6Whitelists> Ipv6Whitelists { get; set; }
        public class DescribeUserIPSWhitelistResponseBodyIpv6Whitelists : TeaModel {
            /// <summary>
            /// <para>The direction of IPv6 traffic on the Internet Border.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Direction")]
            [Validation(Required=false)]
            public long? Direction { get; set; }

            /// <summary>
            /// <para>The type of address in the IPv6 whitelist for the Internet.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ListType")]
            [Validation(Required=false)]
            public long? ListType { get; set; }

            /// <summary>
            /// <para>The value of the IPv6 whitelist on the Internet Border.</para>
            /// <list type="bullet">
            /// <item><description><para>If the whitelist type is <c>custom input</c>: the name of the address book.</para>
            /// </description></item>
            /// <item><description><para>If the whitelist type is <c>address book reference</c>: an IPv6 address.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2408:400a:81a:7900:a77d:ea36:fcbf:de40/128</para>
            /// </summary>
            [NameInMap("ListValue")]
            [Validation(Required=false)]
            public string ListValue { get; set; }

            /// <summary>
            /// <para>The list of IPv6 whitelists for the Internet.</para>
            /// </summary>
            [NameInMap("WhiteListValue")]
            [Validation(Required=false)]
            public List<string> WhiteListValue { get; set; }

            /// <summary>
            /// <para>The type of source or destination for which the IPv6 whitelist on the Internet Border takes effect.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("WhiteType")]
            [Validation(Required=false)]
            public long? WhiteType { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>04F788A5-6A47-5EA9-AC30-CA4DB98AD520</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of IPv4 whitelists for the IPS on the Internet Border.</para>
        /// </summary>
        [NameInMap("Whitelists")]
        [Validation(Required=false)]
        public List<DescribeUserIPSWhitelistResponseBodyWhitelists> Whitelists { get; set; }
        public class DescribeUserIPSWhitelistResponseBodyWhitelists : TeaModel {
            /// <summary>
            /// <para>The direction of IPv4 traffic on the Internet Border.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Direction")]
            [Validation(Required=false)]
            public long? Direction { get; set; }

            /// <summary>
            /// <para>The type of address in the IPv4 whitelist for the Internet.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ListType")]
            [Validation(Required=false)]
            public long? ListType { get; set; }

            /// <summary>
            /// <para>The value of the IPv4 whitelist on the Internet Border.</para>
            /// <list type="bullet">
            /// <item><description><para>If the whitelist type is <c>custom input</c>: the name of the address book.</para>
            /// </description></item>
            /// <item><description><para>If the whitelist type is <c>address book reference</c>: an IPv4 address.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>10.10.200.4/32,10.10.200.25/32</para>
            /// </summary>
            [NameInMap("ListValue")]
            [Validation(Required=false)]
            public string ListValue { get; set; }

            /// <summary>
            /// <para>The list of IPv4 whitelists for the Internet.</para>
            /// </summary>
            [NameInMap("WhiteListValue")]
            [Validation(Required=false)]
            public List<string> WhiteListValue { get; set; }

            /// <summary>
            /// <para>The type of source or destination for which the IPv4 whitelist on the Internet Border takes effect.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("WhiteType")]
            [Validation(Required=false)]
            public long? WhiteType { get; set; }

        }

    }

}
