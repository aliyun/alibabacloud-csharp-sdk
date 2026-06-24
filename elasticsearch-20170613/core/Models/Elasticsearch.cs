// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class Elasticsearch : TeaModel {
        /// <summary>
        /// <para>Indicates whether the new dedicated master node is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Enabled.</description></item>
        /// <item><description>false: Disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("advancedDedicateMaster")]
        [Validation(Required=false)]
        public bool? AdvancedDedicateMaster { get; set; }

        /// <summary>
        /// <para>The advanced settings.</para>
        /// </summary>
        [NameInMap("advancedSetting")]
        [Validation(Required=false)]
        public ElasticsearchAdvancedSetting AdvancedSetting { get; set; }
        public class ElasticsearchAdvancedSetting : TeaModel {
            /// <summary>
            /// <para>GC垃圾回收器名称。支持CMS和G1。</para>
            /// 
            /// <b>Example:</b>
            /// <para>CMS</para>
            /// </summary>
            [NameInMap("gcName")]
            [Validation(Required=false)]
            public string GcName { get; set; }

        }

        /// <summary>
        /// <para>The Aliws dictionary configuration.</para>
        /// </summary>
        [NameInMap("aliwsDicts")]
        [Validation(Required=false)]
        public List<DictInfo> AliwsDicts { get; set; }

        /// <summary>
        /// <para>The client node configuration.</para>
        /// </summary>
        [NameInMap("clientNodeConfiguration")]
        [Validation(Required=false)]
        public ClientNodeConfiguration ClientNodeConfiguration { get; set; }

        /// <summary>
        /// <para>The time when the instance was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2018-07-13T03:58:07.253Z</para>
        /// </summary>
        [NameInMap("createdAt")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// <para>Indicates whether the instance contains data nodes. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The instance contains data nodes.</description></item>
        /// <item><description>false: The instance does not contain data nodes.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("dataNode")]
        [Validation(Required=false)]
        public bool? DataNode { get; set; }

        /// <summary>
        /// <para>Indicates whether the instance contains legacy dedicated master nodes (deprecated).</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("dedicateMaster")]
        [Validation(Required=false)]
        public bool? DedicateMaster { get; set; }

        /// <summary>
        /// <para>The instance name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>es-cn-abc</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The IK dictionary configuration.</para>
        /// </summary>
        [NameInMap("dictList")]
        [Validation(Required=false)]
        public List<DictInfo> DictList { get; set; }

        /// <summary>
        /// <para>The private network access address of the Elasticsearch instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>es-cn-3h4k3axh33th9****.elasticsearch.aliyuncs.com</para>
        /// </summary>
        [NameInMap("domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// <para>The elastic data node configuration.</para>
        /// </summary>
        [NameInMap("elasticDataNodeConfiguration")]
        [Validation(Required=false)]
        public ElasticDataNodeConfiguration ElasticDataNodeConfiguration { get; set; }

        /// <summary>
        /// <para>Indicates whether private network access to Kibana is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Enabled.</description></item>
        /// <item><description>false: Disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("enableKibanaPrivateNetwork")]
        [Validation(Required=false)]
        public bool? EnableKibanaPrivateNetwork { get; set; }

        /// <summary>
        /// <para>Indicates whether public network access to Kibana is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Enabled.</description></item>
        /// <item><description>false: Disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enableKibanaPublicNetwork")]
        [Validation(Required=false)]
        public bool? EnableKibanaPublicNetwork { get; set; }

        /// <summary>
        /// <para>Indicates whether the public network address of the instance is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Enabled.</description></item>
        /// <item><description>false: Disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enablePublic")]
        [Validation(Required=false)]
        public bool? EnablePublic { get; set; }

        /// <summary>
        /// <para>The time when the instance expires. For pay-as-you-go instances, the default value is 100 years.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The YML file configuration of the instance.</para>
        /// </summary>
        [NameInMap("esConfig")]
        [Validation(Required=false)]
        public Dictionary<string, string> EsConfig { get; set; }

        /// <summary>
        /// <para>The private network access whitelist configuration of the instance (deprecated).</para>
        /// </summary>
        [NameInMap("esIPWhitelist")]
        [Validation(Required=false)]
        public List<string> EsIPWhitelist { get; set; }

        /// <summary>
        /// <para>The instance version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6.3.2_with_X-Pack</para>
        /// </summary>
        [NameInMap("esVersion")]
        [Validation(Required=false)]
        public string EsVersion { get; set; }

        /// <summary>
        /// <para>The extension parameter settings of the instance.</para>
        /// </summary>
        [NameInMap("extendConfigs")]
        [Validation(Required=false)]
        public List<Dictionary<string, object>> ExtendConfigs { get; set; }

        /// <summary>
        /// <para>Indicates whether client nodes are enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Enabled.</description></item>
        /// <item><description>false: Disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("haveClientNode")]
        [Validation(Required=false)]
        public bool? HaveClientNode { get; set; }

        /// <summary>
        /// <para>Indicates whether elastic data nodes are enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Enabled.</description></item>
        /// <item><description>false: Disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("haveElasticDataNode")]
        [Validation(Required=false)]
        public bool? HaveElasticDataNode { get; set; }

        /// <summary>
        /// <para>Indicates whether the instance contains Kibana nodes. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The instance contains Kibana nodes.</description></item>
        /// <item><description>false: The instance does not contain Kibana nodes.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("haveKibana")]
        [Validation(Required=false)]
        public bool? HaveKibana { get; set; }

        /// <summary>
        /// <para>The IK hot dictionary configuration.</para>
        /// </summary>
        [NameInMap("ikHotDicts")]
        [Validation(Required=false)]
        public List<DictInfo> IkHotDicts { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>es-cn-3h4k3axh33th9****</para>
        /// </summary>
        [NameInMap("instanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The Kibana node configuration.</para>
        /// </summary>
        [NameInMap("kibanaConfiguration")]
        [Validation(Required=false)]
        public KibanaNodeConfiguration KibanaConfiguration { get; set; }

        /// <summary>
        /// <para>The public network access address of Kibana.</para>
        /// 
        /// <b>Example:</b>
        /// <para>es-cn-3h4k3axh33th9****.kibana.elasticsearch.aliyuncs.com</para>
        /// </summary>
        [NameInMap("kibanaDomain")]
        [Validation(Required=false)]
        public string KibanaDomain { get; set; }

        /// <summary>
        /// <para>The public network access whitelist configuration of Kibana.</para>
        /// </summary>
        [NameInMap("kibanaIPWhitelist")]
        [Validation(Required=false)]
        public List<string> KibanaIPWhitelist { get; set; }

        /// <summary>
        /// <para>The public network access port of Kibana.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5601</para>
        /// </summary>
        [NameInMap("kibanaPort")]
        [Validation(Required=false)]
        public long? KibanaPort { get; set; }

        /// <summary>
        /// <para>The private network access address of Kibana.</para>
        /// 
        /// <b>Example:</b>
        /// <para>es-cn-tl329rbpc0001****-kibana.internal.elasticsearch.aliyuncs.com</para>
        /// </summary>
        [NameInMap("kibanaPrivateDomain")]
        [Validation(Required=false)]
        public string KibanaPrivateDomain { get; set; }

        /// <summary>
        /// <para>The IP whitelist configuration for private network access to Kibana.</para>
        /// </summary>
        [NameInMap("kibanaPrivateIPWhitelist")]
        [Validation(Required=false)]
        public List<string> KibanaPrivateIPWhitelist { get; set; }

        /// <summary>
        /// <para>The private network access port of Kibana.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5601</para>
        /// </summary>
        [NameInMap("kibanaPrivatePort")]
        [Validation(Required=false)]
        public long? KibanaPrivatePort { get; set; }

        /// <summary>
        /// <para>The access protocol for Kibana. Valid values: HTTP and HTTPS.</para>
        /// 
        /// <b>Example:</b>
        /// <para>HTTPS</para>
        /// </summary>
        [NameInMap("kibanaProtocol")]
        [Validation(Required=false)]
        public string KibanaProtocol { get; set; }

        /// <summary>
        /// <para>The dedicated master node configuration.</para>
        /// </summary>
        [NameInMap("masterConfiguration")]
        [Validation(Required=false)]
        public MasterNodeConfiguration MasterConfiguration { get; set; }

        /// <summary>
        /// <para>The network configuration of the instance.</para>
        /// </summary>
        [NameInMap("networkConfig")]
        [Validation(Required=false)]
        public NetworkConfig NetworkConfig { get; set; }

        /// <summary>
        /// <para>The number of data nodes in the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("nodeAmount")]
        [Validation(Required=false)]
        public long? NodeAmount { get; set; }

        /// <summary>
        /// <para>The data node configuration.</para>
        /// </summary>
        [NameInMap("nodeSpec")]
        [Validation(Required=false)]
        public NodeSpec NodeSpec { get; set; }

        /// <summary>
        /// <para>The billing method of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>prepaid: subscription.</description></item>
        /// <item><description>postpaid: pay-as-you-go.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>prepaid</para>
        /// </summary>
        [NameInMap("paymentType")]
        [Validation(Required=false)]
        public string PaymentType { get; set; }

        /// <summary>
        /// <para>The private network access port of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9200</para>
        /// </summary>
        [NameInMap("port")]
        [Validation(Required=false)]
        public long? Port { get; set; }

        /// <summary>
        /// <para>The private network address access whitelist configuration of the instance.</para>
        /// </summary>
        [NameInMap("privateNetworkIpWhiteList")]
        [Validation(Required=false)]
        public List<string> PrivateNetworkIpWhiteList { get; set; }

        /// <summary>
        /// <para>The instance edition. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>logEnhancement: Advanced Edition.</description></item>
        /// <item><description>generalBusiness: general commercial edition.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>generalBusiness</para>
        /// </summary>
        [NameInMap("productType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

        /// <summary>
        /// <para>The access protocol of the instance. Valid values: HTTP and HTTPS.</para>
        /// 
        /// <b>Example:</b>
        /// <para>HTTP</para>
        /// </summary>
        [NameInMap("protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

        /// <summary>
        /// <para>The public network access address of the Elasticsearch instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>es-cn-3h4k3axh33th9****.elasticsearch.aliyuncs.com</para>
        /// </summary>
        [NameInMap("publicDomain")]
        [Validation(Required=false)]
        public string PublicDomain { get; set; }

        /// <summary>
        /// <para>The public network access whitelist configuration of the instance.</para>
        /// </summary>
        [NameInMap("publicIpWhitelist")]
        [Validation(Required=false)]
        public List<string> PublicIpWhitelist { get; set; }

        /// <summary>
        /// <para>The public network access port of the Elasticsearch instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9200</para>
        /// </summary>
        [NameInMap("publicPort")]
        [Validation(Required=false)]
        public long? PublicPort { get; set; }

        /// <summary>
        /// <para>The high availability configuration of the instance.</para>
        /// </summary>
        [NameInMap("readWritePolicy")]
        [Validation(Required=false)]
        public ReadWritePolicy ReadWritePolicy { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the instance belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aekzvowej3i****</para>
        /// </summary>
        [NameInMap("resourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>Indicates whether the instance is in the Elasticsearch service VPC. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The instance is in the service VPC.</description></item>
        /// <item><description>false: The instance is not in the service VPC.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("serviceVpc")]
        [Validation(Required=false)]
        public bool? ServiceVpc { get; set; }

        /// <summary>
        /// <para>The status of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>active: Normal.</description></item>
        /// <item><description>activating: Taking effect.</description></item>
        /// <item><description>inactive: Frozen.</description></item>
        /// <item><description>invalid: Expired.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>active</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The synonym dictionary configuration of the instance.</para>
        /// </summary>
        [NameInMap("synonymsDicts")]
        [Validation(Required=false)]
        public List<DictInfo> SynonymsDicts { get; set; }

        /// <summary>
        /// <para>The instance tags.</para>
        /// </summary>
        [NameInMap("tags")]
        [Validation(Required=false)]
        public List<Tag> Tags { get; set; }

        /// <summary>
        /// <para>The time when the instance was last updated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2018-07-13T03:58:07.253Z</para>
        /// </summary>
        [NameInMap("updatedAt")]
        [Validation(Required=false)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// <para>Indicates whether warm data nodes are enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Enabled.</description></item>
        /// <item><description>false: Disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("warmNode")]
        [Validation(Required=false)]
        public bool? WarmNode { get; set; }

        /// <summary>
        /// <para>The warm data node configuration.</para>
        /// </summary>
        [NameInMap("warmNodeConfiguration")]
        [Validation(Required=false)]
        public WarmNodeConfiguration WarmNodeConfiguration { get; set; }

        /// <summary>
        /// <para>The number of zones for the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("zoneCount")]
        [Validation(Required=false)]
        public long? ZoneCount { get; set; }

        /// <summary>
        /// <para>The zone information of the instance.</para>
        /// </summary>
        [NameInMap("zoneInfos")]
        [Validation(Required=false)]
        public List<ZoneInfo> ZoneInfos { get; set; }

    }

}
