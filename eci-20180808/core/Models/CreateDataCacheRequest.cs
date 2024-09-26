// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eci20180808.Models
{
    public class CreateDataCacheRequest : TeaModel {
        /// <summary>
        /// <para>The bucket in which the data is stored. By default, the default bucket is used. You can use a custom bucket for business grouping and to prevent path conflicts.</para>
        /// <remarks>
        /// <para> eci-system is the reserved bucket of the ECI and cannot be used.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("Bucket")]
        [Validation(Required=false)]
        public string Bucket { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-<b><b>-12d3-</b></b>-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The data source.</para>
        /// </summary>
        [NameInMap("DataSource")]
        [Validation(Required=false)]
        public CreateDataCacheRequestDataSource DataSource { get; set; }
        public class CreateDataCacheRequestDataSource : TeaModel {
            /// <summary>
            /// <para>The parameters that are configured for the data source.</para>
            /// </summary>
            [NameInMap("Options")]
            [Validation(Required=false)]
            public Dictionary<string, string> Options { get; set; }

            /// <summary>
            /// <para>The type of the data source. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>URL</description></item>
            /// <item><description>NAS</description></item>
            /// <item><description>OSS</description></item>
            /// <item><description>SNAPSHOT</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>NAS</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The elastic IP address (EIP) to be created and associated. If no NAT gateway is configured for the virtual private cloud (VPC), you can associate an EIP to pull data from the Internet.</para>
        /// </summary>
        [NameInMap("EipCreateParam")]
        [Validation(Required=false)]
        public CreateDataCacheRequestEipCreateParam EipCreateParam { get; set; }
        public class CreateDataCacheRequestEipCreateParam : TeaModel {
            /// <summary>
            /// <para>The bandwidth of the EIP. Unit: Mbit/s. Default value: 5.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Bandwidth")]
            [Validation(Required=false)]
            public int? Bandwidth { get; set; }

            /// <summary>
            /// <para>The EIP bandwidth plan to be associated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cbwp-2zeukbj916scmj51m****</para>
            /// </summary>
            [NameInMap("CommonBandwidthPackage")]
            [Validation(Required=false)]
            public string CommonBandwidthPackage { get; set; }

            /// <summary>
            /// <para>The line type of the EIP. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>BGP: BGP (Multi-ISP) line</description></item>
            /// <item><description>BGP_PRO: BGP (Multi-ISP) Pro line</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>BGP</para>
            /// </summary>
            [NameInMap("ISP")]
            [Validation(Required=false)]
            public string ISP { get; set; }

            /// <summary>
            /// <para>The metering method of the EIP. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PayByBandwidth: pay-by-bandwidth</description></item>
            /// <item><description>PayByTraffic: pay-by-data-transfer</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PayByTraffic</para>
            /// </summary>
            [NameInMap("InternetChargeType")]
            [Validation(Required=false)]
            public string InternetChargeType { get; set; }

            /// <summary>
            /// <para>The ID of the IP address pool. The EIP is allocated from the IP address pool. You cannot use the IP address pool feature by default. To use this feature, you must apply for the privilege in the Quota Center console.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pippool-2vc4xdtjhwl4t0go5****</para>
            /// </summary>
            [NameInMap("PublicIpAddressPoolId")]
            [Validation(Required=false)]
            public string PublicIpAddressPoolId { get; set; }

        }

        /// <summary>
        /// <para>The existing elastic IP address (EIP) to be associated. If no NAT gateway is configured for the virtual private cloud (VPC), you can associate an EIP to pull data from the Internet.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eip-uf66jeqopgqa9hdn****</para>
        /// </summary>
        [NameInMap("EipInstanceId")]
        [Validation(Required=false)]
        public string EipInstanceId { get; set; }

        /// <summary>
        /// <para>The DataCache name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The storage path of the data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/model/test</para>
        /// </summary>
        [NameInMap("Path")]
        [Validation(Required=false)]
        public string Path { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-2df3isufhi38****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The number of days for which the DataCache is retained. When the retention days end, the DataCache is deleted. By default, DataCaches do not expire.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("RetentionDays")]
        [Validation(Required=false)]
        public int? RetentionDays { get; set; }

        /// <summary>
        /// <para>The ID of the security group to which the generated ECI belongs during the creation of the data cache.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sg-2ze81zoc3yl7a3we****</para>
        /// </summary>
        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// <para>The size of the data cache. Unit: GiB. Default value: 20. Evaluate the required size based on the actual data size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("Size")]
        [Validation(Required=false)]
        public int? Size { get; set; }

        /// <summary>
        /// <para>The tags to be bound to the data cache.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateDataCacheRequestTag> Tag { get; set; }
        public class CreateDataCacheRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of the tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testkey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testvalue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The ID of the vSwitch to which the generated ECI belongs during the creation of the data cache.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp1jrgfqqy54kg5hc****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

    }

}
