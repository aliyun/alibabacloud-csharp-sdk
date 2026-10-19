// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class CreateNetworkRequest : TeaModel {
        /// <summary>
        /// <para>The CIDR block of the network. You can use one of the following CIDR blocks or their subsets as the CIDR block of the network:</para>
        /// <list type="bullet">
        /// <item><description>10.0.0.0/8 (default).</description></item>
        /// <item><description>172.16.0.0/12.</description></item>
        /// <item><description>192.168.0.0/16.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.0.0/24</para>
        /// </summary>
        [NameInMap("CidrBlock")]
        [Validation(Required=false)]
        public string CidrBlock { get; set; }

        /// <summary>
        /// <para>The description of the network.</para>
        /// <para>The description must be 2 to 256 characters in length, and must start with a letter or a Chinese character. It cannot start with http:// or https://.</para>
        /// 
        /// <b>Example:</b>
        /// <para>this is my first network</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable IPv6. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>false (default): disables IPv6.</description></item>
        /// <item><description>true: enables IPv6.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableIpv6")]
        [Validation(Required=false)]
        public bool? EnableIpv6 { get; set; }

        /// <summary>
        /// <para>The ID of the ENS edge zone.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing-telecom</para>
        /// </summary>
        [NameInMap("EnsRegionId")]
        [Validation(Required=false)]
        public string EnsRegionId { get; set; }

        /// <summary>
        /// <para>The ISP of the IPv6 address. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>cmcc</description></item>
        /// <item><description>telecom</description></item>
        /// <item><description>unicom</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>telecom</para>
        /// </summary>
        [NameInMap("Ipv6Isp")]
        [Validation(Required=false)]
        public string Ipv6Isp { get; set; }

        /// <summary>
        /// <para>The name of the network. The name must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description>The name must be 2 to 128 characters in length.</description></item>
        /// <item><description>The name must start with a letter or a Chinese character, and cannot start with http:// or https://.</description></item>
        /// <item><description>The name can contain digits, colons (:), underscores (_), and hyphens (-).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>abc</para>
        /// </summary>
        [NameInMap("NetworkName")]
        [Validation(Required=false)]
        public string NetworkName { get; set; }

        /// <summary>
        /// <para>The resource tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateNetworkRequestTag> Tag { get; set; }
        public class CreateNetworkRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of tag N of the instance. Valid values of N: <b>1</b> to <b>20</b>.</para>
            /// <list type="bullet">
            /// <item><description>The key cannot start with <c>aliyun</c>, <c>acs:</c>, <c>http://</c>, or <c>https://</c>.</description></item>
            /// <item><description>The key can be up to 64 characters in length.</description></item>
            /// <item><description>The key cannot be an empty string.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>key1</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of tag N of the resource. Valid values of N: 1 to 20. The value can be an empty string. The value can be up to 128 characters in length, and cannot start with acs: or contain http:// or https://.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tagValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
