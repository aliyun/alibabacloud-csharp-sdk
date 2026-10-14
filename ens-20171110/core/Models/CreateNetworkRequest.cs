// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class CreateNetworkRequest : TeaModel {
        /// <summary>
        /// <para>The CIDR block of the network. You can use one of the following CIDR blocks or their subsets:</para>
        /// <list type="bullet">
        /// <item><description><para>10.0.0.0/8 (default).</para>
        /// </description></item>
        /// <item><description><para>172.16.0.0/12.</para>
        /// </description></item>
        /// <item><description><para>192.168.0.0/16.</para>
        /// </description></item>
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
        /// <para>A description of the network.</para>
        /// <para>Must be 2 to 256 characters long, start with a letter or a Chinese character, and cannot start with http\:// or https\://.</para>
        /// 
        /// <b>Example:</b>
        /// <para>this is my first network</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("EnableIpv6")]
        [Validation(Required=false)]
        public bool? EnableIpv6 { get; set; }

        /// <summary>
        /// <para>The node ID of ENS.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing-telecom</para>
        /// </summary>
        [NameInMap("EnsRegionId")]
        [Validation(Required=false)]
        public string EnsRegionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>telecom</para>
        /// </summary>
        [NameInMap("Ipv6Isp")]
        [Validation(Required=false)]
        public string Ipv6Isp { get; set; }

        /// <summary>
        /// <para>The network name. Follow these naming rules:</para>
        /// <list type="bullet">
        /// <item><description><para>Must be 2 to 128 characters long, using English or Chinese characters.</para>
        /// </description></item>
        /// <item><description><para>Must start with a letter or a Chinese character. Cannot start with http\:// or https\://.</para>
        /// </description></item>
        /// <item><description><para>Can contain digits, colons (:), underscores (_), or hyphens (-).</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>abc</para>
        /// </summary>
        [NameInMap("NetworkName")]
        [Validation(Required=false)]
        public string NetworkName { get; set; }

        /// <summary>
        /// <para>Resource tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateNetworkRequestTag> Tag { get; set; }
        public class CreateNetworkRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key for the instance. N ranges from <b>1</b> to <b>20</b>.</para>
            /// <list type="bullet">
            /// <item><description><para>Cannot start with <c>aliyun</c>, <c>acs:</c>, <c>http://</c>, or <c>https://</c>.</para>
            /// </description></item>
            /// <item><description><para>Supports up to 64 characters.</para>
            /// </description></item>
            /// <item><description><para>Cannot be an empty string.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>key1</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value for the resource. N ranges from 1 to 20. This value can be an empty string once provided. It supports up to 128 characters, cannot start with acs:, and cannot contain http\:// or https\://.</para>
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
