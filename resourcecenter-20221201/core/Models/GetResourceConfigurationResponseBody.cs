// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceCenter20221201.Models
{
    public class GetResourceConfigurationResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the Alibaba Cloud account to which the resource belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>151266687691****</para>
        /// </summary>
        [NameInMap("AccountId")]
        [Validation(Required=false)]
        public string AccountId { get; set; }

        /// <summary>
        /// <para>The configurations of the resource.</para>
        /// </summary>
        [NameInMap("Configuration")]
        [Validation(Required=false)]
        public Dictionary<string, object> Configuration { get; set; }

        /// <summary>
        /// <para>The time when the resource was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-06-30T09:20:08Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The time when the resource expires.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-07-30T09:20:08Z</para>
        /// </summary>
        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public string ExpireTime { get; set; }

        /// <summary>
        /// <para>The attributes of the IP address.</para>
        /// </summary>
        [NameInMap("IpAddressAttributes")]
        [Validation(Required=false)]
        public List<GetResourceConfigurationResponseBodyIpAddressAttributes> IpAddressAttributes { get; set; }
        public class GetResourceConfigurationResponseBodyIpAddressAttributes : TeaModel {
            /// <summary>
            /// <para>The IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.1.2</para>
            /// </summary>
            [NameInMap("IpAddress")]
            [Validation(Required=false)]
            public string IpAddress { get; set; }

            /// <summary>
            /// <para>The network type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Public</b>: the Internet</description></item>
            /// <item><description><b>Private</b>: internal network</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Public</para>
            /// </summary>
            [NameInMap("NetworkType")]
            [Validation(Required=false)]
            public string NetworkType { get; set; }

            /// <summary>
            /// <para>The version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Ipv4</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// <para>The IP addresses.</para>
        /// <remarks>
        /// <para>Whether this parameter is returned is determined by the Alibaba Cloud service to which the resource belongs.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("IpAddresses")]
        [Validation(Required=false)]
        public List<string> IpAddresses { get; set; }

        /// <summary>
        /// <para>The region ID of the resource.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F1CE0D52-32DA-531A-87A4-B9A5B68D5D8E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the resource belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmv4k****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The ID of the resource.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vtb-uf6978gdqbi****</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        /// <summary>
        /// <para>The name of the resource.</para>
        /// 
        /// <b>Example:</b>
        /// <para>group1</para>
        /// </summary>
        [NameInMap("ResourceName")]
        [Validation(Required=false)]
        public string ResourceName { get; set; }

        /// <summary>
        /// <para>The type of the resource.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ACS::VPC::VSwitch</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The tags of the resource.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<GetResourceConfigurationResponseBodyTags> Tags { get; set; }
        public class GetResourceConfigurationResponseBodyTags : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-key</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-value</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The zone ID of the resource.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-k</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
