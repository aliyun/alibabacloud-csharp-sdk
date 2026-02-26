// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceCenter20221201.Models
{
    public class GetMultiAccountResourceConfigurationResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the management account or member.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1619302****</para>
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
        /// <para>2023-02-14T03:12:11Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The time when the resource expires.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-09-18T07:04:21Z</para>
        /// </summary>
        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public string ExpireTime { get; set; }

        /// <summary>
        /// <para>The properties of the IP addresses.</para>
        /// </summary>
        [NameInMap("IpAddressAttributes")]
        [Validation(Required=false)]
        public List<GetMultiAccountResourceConfigurationResponseBodyIpAddressAttributes> IpAddressAttributes { get; set; }
        public class GetMultiAccountResourceConfigurationResponseBodyIpAddressAttributes : TeaModel {
            /// <summary>
            /// <para>The IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>172.27.199.42</para>
            /// </summary>
            [NameInMap("IpAddress")]
            [Validation(Required=false)]
            public string IpAddress { get; set; }

            /// <summary>
            /// <para>The network type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Public</b>: Internet</para>
            /// </description></item>
            /// <item><description><para><b>Private</b>: internal network</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Public</para>
            /// </summary>
            [NameInMap("NetworkType")]
            [Validation(Required=false)]
            public string NetworkType { get; set; }

            /// <summary>
            /// <para>The version of the IP address.</para>
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
        /// <para>The ID of the region where the resource resides.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B2DCC08B-C12A-5705-879C-5A1450016156</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of your Alibaba Cloud resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmzy6d****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The resource ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>m-eb3hji****</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        /// <summary>
        /// <para>The resource name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_resource</para>
        /// </summary>
        [NameInMap("ResourceName")]
        [Validation(Required=false)]
        public string ResourceName { get; set; }

        /// <summary>
        /// <para>The resource type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ACS::VPC::RouteTable</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The tags.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<GetMultiAccountResourceConfigurationResponseBodyTags> Tags { get; set; }
        public class GetMultiAccountResourceConfigurationResponseBodyTags : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tag-key</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tag-value</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The zone ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai-a</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
