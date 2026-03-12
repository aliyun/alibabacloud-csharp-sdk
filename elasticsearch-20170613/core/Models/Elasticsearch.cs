// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class Elasticsearch : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("advancedDedicateMaster")]
        [Validation(Required=false)]
        public bool? AdvancedDedicateMaster { get; set; }

        [NameInMap("advancedSetting")]
        [Validation(Required=false)]
        public ElasticsearchAdvancedSetting AdvancedSetting { get; set; }
        public class ElasticsearchAdvancedSetting : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>CMS</para>
            /// </summary>
            [NameInMap("gcName")]
            [Validation(Required=false)]
            public string GcName { get; set; }

        }

        [NameInMap("aliwsDicts")]
        [Validation(Required=false)]
        public List<DictInfo> AliwsDicts { get; set; }

        [NameInMap("clientNodeConfiguration")]
        [Validation(Required=false)]
        public ClientNodeConfiguration ClientNodeConfiguration { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2018-07-13T03:58:07.253Z</para>
        /// </summary>
        [NameInMap("createdAt")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("dataNode")]
        [Validation(Required=false)]
        public bool? DataNode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("dedicateMaster")]
        [Validation(Required=false)]
        public bool? DedicateMaster { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>es-cn-abc</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("dictList")]
        [Validation(Required=false)]
        public List<DictInfo> DictList { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>es-cn-3h4k3axh33th9****.elasticsearch.aliyuncs.com</para>
        /// </summary>
        [NameInMap("domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        [NameInMap("elasticDataNodeConfiguration")]
        [Validation(Required=false)]
        public ElasticDataNodeConfiguration ElasticDataNodeConfiguration { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("enableKibanaPrivateNetwork")]
        [Validation(Required=false)]
        public bool? EnableKibanaPrivateNetwork { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enableKibanaPublicNetwork")]
        [Validation(Required=false)]
        public bool? EnableKibanaPublicNetwork { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enablePublic")]
        [Validation(Required=false)]
        public bool? EnablePublic { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        [NameInMap("esConfig")]
        [Validation(Required=false)]
        public Dictionary<string, string> EsConfig { get; set; }

        [NameInMap("esIPWhitelist")]
        [Validation(Required=false)]
        public List<string> EsIPWhitelist { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>6.3.2_with_X-Pack</para>
        /// </summary>
        [NameInMap("esVersion")]
        [Validation(Required=false)]
        public string EsVersion { get; set; }

        [NameInMap("extendConfigs")]
        [Validation(Required=false)]
        public List<Dictionary<string, object>> ExtendConfigs { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("haveClientNode")]
        [Validation(Required=false)]
        public bool? HaveClientNode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("haveElasticDataNode")]
        [Validation(Required=false)]
        public bool? HaveElasticDataNode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("haveKibana")]
        [Validation(Required=false)]
        public bool? HaveKibana { get; set; }

        [NameInMap("ikHotDicts")]
        [Validation(Required=false)]
        public List<DictInfo> IkHotDicts { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>es-cn-3h4k3axh33th9****</para>
        /// </summary>
        [NameInMap("instanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("kibanaConfiguration")]
        [Validation(Required=false)]
        public KibanaNodeConfiguration KibanaConfiguration { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>es-cn-3h4k3axh33th9****.kibana.elasticsearch.aliyuncs.com</para>
        /// </summary>
        [NameInMap("kibanaDomain")]
        [Validation(Required=false)]
        public string KibanaDomain { get; set; }

        [NameInMap("kibanaIPWhitelist")]
        [Validation(Required=false)]
        public List<string> KibanaIPWhitelist { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5601</para>
        /// </summary>
        [NameInMap("kibanaPort")]
        [Validation(Required=false)]
        public long? KibanaPort { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>es-cn-tl329rbpc0001****-kibana.internal.elasticsearch.aliyuncs.com</para>
        /// </summary>
        [NameInMap("kibanaPrivateDomain")]
        [Validation(Required=false)]
        public string KibanaPrivateDomain { get; set; }

        [NameInMap("kibanaPrivateIPWhitelist")]
        [Validation(Required=false)]
        public List<string> KibanaPrivateIPWhitelist { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5601</para>
        /// </summary>
        [NameInMap("kibanaPrivatePort")]
        [Validation(Required=false)]
        public long? KibanaPrivatePort { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>HTTPS</para>
        /// </summary>
        [NameInMap("kibanaProtocol")]
        [Validation(Required=false)]
        public string KibanaProtocol { get; set; }

        [NameInMap("masterConfiguration")]
        [Validation(Required=false)]
        public MasterNodeConfiguration MasterConfiguration { get; set; }

        [NameInMap("networkConfig")]
        [Validation(Required=false)]
        public NetworkConfig NetworkConfig { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("nodeAmount")]
        [Validation(Required=false)]
        public long? NodeAmount { get; set; }

        [NameInMap("nodeSpec")]
        [Validation(Required=false)]
        public NodeSpec NodeSpec { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>prepaid</para>
        /// </summary>
        [NameInMap("paymentType")]
        [Validation(Required=false)]
        public string PaymentType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>9200</para>
        /// </summary>
        [NameInMap("port")]
        [Validation(Required=false)]
        public long? Port { get; set; }

        [NameInMap("privateNetworkIpWhiteList")]
        [Validation(Required=false)]
        public List<string> PrivateNetworkIpWhiteList { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>generalBusiness</para>
        /// </summary>
        [NameInMap("productType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>HTTP</para>
        /// </summary>
        [NameInMap("protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>es-cn-3h4k3axh33th9****.elasticsearch.aliyuncs.com</para>
        /// </summary>
        [NameInMap("publicDomain")]
        [Validation(Required=false)]
        public string PublicDomain { get; set; }

        [NameInMap("publicIpWhitelist")]
        [Validation(Required=false)]
        public List<string> PublicIpWhitelist { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>9200</para>
        /// </summary>
        [NameInMap("publicPort")]
        [Validation(Required=false)]
        public long? PublicPort { get; set; }

        [NameInMap("readWritePolicy")]
        [Validation(Required=false)]
        public ReadWritePolicy ReadWritePolicy { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>rg-aekzvowej3i****</para>
        /// </summary>
        [NameInMap("resourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("serviceVpc")]
        [Validation(Required=false)]
        public bool? ServiceVpc { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>active</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("synonymsDicts")]
        [Validation(Required=false)]
        public List<DictInfo> SynonymsDicts { get; set; }

        [NameInMap("tags")]
        [Validation(Required=false)]
        public List<Tag> Tags { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2018-07-13T03:58:07.253Z</para>
        /// </summary>
        [NameInMap("updatedAt")]
        [Validation(Required=false)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("warmNode")]
        [Validation(Required=false)]
        public bool? WarmNode { get; set; }

        [NameInMap("warmNodeConfiguration")]
        [Validation(Required=false)]
        public WarmNodeConfiguration WarmNodeConfiguration { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("zoneCount")]
        [Validation(Required=false)]
        public long? ZoneCount { get; set; }

        [NameInMap("zoneInfos")]
        [Validation(Required=false)]
        public List<ZoneInfo> ZoneInfos { get; set; }

    }

}
