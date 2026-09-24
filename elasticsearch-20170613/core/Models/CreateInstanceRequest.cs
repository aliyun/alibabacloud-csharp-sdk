// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class CreateInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The client node configuration.</para>
        /// </summary>
        [NameInMap("clientNodeConfiguration")]
        [Validation(Required=false)]
        public ClientNodeConfiguration ClientNodeConfiguration { get; set; }

        /// <summary>
        /// <para>The instance name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>es</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The elastic node configuration.</para>
        /// </summary>
        [NameInMap("elasticDataNodeConfiguration")]
        [Validation(Required=false)]
        public ElasticDataNodeConfiguration ElasticDataNodeConfiguration { get; set; }

        /// <summary>
        /// <para>The access password of the instance. The password must contain at least three of the following character types: uppercase letters, lowercase letters, digits, and special characters (!@#$%^&amp;*()_+-=). The password must be 8 to 32 characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Es_password</para>
        /// </summary>
        [NameInMap("esAdminPassword")]
        [Validation(Required=false)]
        public string EsAdminPassword { get; set; }

        /// <summary>
        /// <para>The instance version. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>8.5.1_with_X-Pack</description></item>
        /// <item><description>7.10_with_X-Pack</description></item>
        /// <item><description>6.7_with_X-Pack</description></item>
        /// <item><description>7.7_with_X-Pack</description></item>
        /// <item><description>6.8_with_X-Pack</description></item>
        /// <item><description>6.3_with_X-Pack</description></item>
        /// <item><description>5.6_with_X-Pack</description></item>
        /// <item><description>5.5.3_with_X-Pack</description></item>
        /// </list>
        /// <remarks>
        /// <para>The versions listed above may not include all versions supported by Elasticsearch instances. Call the <a href="https://help.aliyun.com/document_detail/254099.html">GetRegionConfiguration</a> operation to view the actual supported versions.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5.5.3_with_X-Pack</para>
        /// </summary>
        [NameInMap("esVersion")]
        [Validation(Required=false)]
        public string EsVersion { get; set; }

        /// <summary>
        /// <para>The edition type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>x-pack: Creates a commercial edition instance, or a kernel-enhanced edition instance without Indexing Service or OpenStore enabled.</description></item>
        /// <item><description>IS: Creates a kernel-enhanced edition instance with Indexing Service or OpenStore enabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>advanced</para>
        /// </summary>
        [NameInMap("instanceCategory")]
        [Validation(Required=false)]
        public string InstanceCategory { get; set; }

        /// <summary>
        /// <para>The Kibana node configuration.</para>
        /// <remarks>
        /// <para>We strongly recommend that you enable Kibana nodes.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("kibanaConfiguration")]
        [Validation(Required=false)]
        public KibanaNodeConfiguration KibanaConfiguration { get; set; }

        /// <summary>
        /// <para>The dedicated master node configuration.</para>
        /// <remarks>
        /// <para>In the Beijing, Shanghai, Hangzhou, and Shenzhen regions, when you call createInstance to create an instance with next-generation cloud disk-based dedicated master nodes, specify the instance family followed by the <c>.new</c> suffix. For example, elasticsearch.sn1ne.large.new.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("masterConfiguration")]
        [Validation(Required=false)]
        public MasterNodeConfiguration MasterConfiguration { get; set; }

        /// <summary>
        /// <para>The network configuration.</para>
        /// <remarks>
        /// <para>You cannot specify an IP whitelist when creating an instance.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("networkConfig")]
        [Validation(Required=false)]
        public NetworkConfig NetworkConfig { get; set; }

        /// <summary>
        /// <para>The number of data nodes. Valid values: 2 to 50.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("nodeAmount")]
        [Validation(Required=false)]
        public int? NodeAmount { get; set; }

        /// <summary>
        /// <para>The data node configuration.</para>
        /// <remarks>
        /// <para>In the Beijing, Shanghai, Hangzhou, and Shenzhen regions, when you call createInstance to create an instance with next-generation cloud disk-based data nodes, specify the instance family followed by the <c>.new</c> suffix. For example, elasticsearch.sn1ne.large.new.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("nodeSpec")]
        [Validation(Required=false)]
        public NodeSpec NodeSpec { get; set; }

        /// <summary>
        /// <para>The billing details of the subscription instance. This parameter is required when you create a subscription instance.</para>
        /// </summary>
        [NameInMap("paymentInfo")]
        [Validation(Required=false)]
        public PaymentInfo PaymentInfo { get; set; }

        /// <summary>
        /// <para>The billing method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>postpaid: pay-as-you-go billing method</description></item>
        /// <item><description>prepaid: subscription</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>postpaid</para>
        /// </summary>
        [NameInMap("paymentType")]
        [Validation(Required=false)]
        public string PaymentType { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the instance belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aekzu7tsu4n****</para>
        /// </summary>
        [NameInMap("resourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The instance tags.</para>
        /// </summary>
        [NameInMap("tags")]
        [Validation(Required=false)]
        public List<CreateInstanceRequestTags> Tags { get; set; }
        public class CreateInstanceRequestTags : TeaModel {
            /// <summary>
            /// <para>The tag key of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>KeyTest</para>
            /// </summary>
            [NameInMap("tagKey")]
            [Validation(Required=false)]
            public string TagKey { get; set; }

            /// <summary>
            /// <para>The tag value of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>KeyValue</para>
            /// </summary>
            [NameInMap("tagValue")]
            [Validation(Required=false)]
            public string TagValue { get; set; }

        }

        /// <summary>
        /// <para>The cold data node configuration.</para>
        /// </summary>
        [NameInMap("warmNodeConfiguration")]
        [Validation(Required=false)]
        public WarmNodeConfiguration WarmNodeConfiguration { get; set; }

        /// <summary>
        /// <para>The number of zones for the instance. Valid values: 1, 2, and 3. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("zoneCount")]
        [Validation(Required=false)]
        public int? ZoneCount { get; set; }

        /// <summary>
        /// <para>A client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5A2CFF0E-5718-45B5-9D4D-70B3FF****</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
