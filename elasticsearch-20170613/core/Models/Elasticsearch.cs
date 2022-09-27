// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class Elasticsearch : TeaModel {
        [NameInMap("advancedDedicateMaster")]
        [Validation(Required=false)]
        public bool? AdvancedDedicateMaster { get; set; }

        [NameInMap("advancedSetting")]
        [Validation(Required=false)]
        public ElasticsearchAdvancedSetting AdvancedSetting { get; set; }
        public class ElasticsearchAdvancedSetting : TeaModel {
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

        [NameInMap("createdAt")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

        [NameInMap("dataNode")]
        [Validation(Required=false)]
        public bool? DataNode { get; set; }

        [NameInMap("dedicateMaster")]
        [Validation(Required=false)]
        public bool? DedicateMaster { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("dictList")]
        [Validation(Required=false)]
        public List<DictInfo> DictList { get; set; }

        [NameInMap("domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        [NameInMap("elasticDataNodeConfiguration")]
        [Validation(Required=false)]
        public ElasticDataNodeConfiguration ElasticDataNodeConfiguration { get; set; }

        [NameInMap("enableKibanaPrivateNetwork")]
        [Validation(Required=false)]
        public bool? EnableKibanaPrivateNetwork { get; set; }

        [NameInMap("enableKibanaPublicNetwork")]
        [Validation(Required=false)]
        public bool? EnableKibanaPublicNetwork { get; set; }

        [NameInMap("enablePublic")]
        [Validation(Required=false)]
        public bool? EnablePublic { get; set; }

        [NameInMap("endTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        [NameInMap("esConfig")]
        [Validation(Required=false)]
        public Dictionary<string, string> EsConfig { get; set; }

        [NameInMap("esIPWhitelist")]
        [Validation(Required=false)]
        public List<string> EsIPWhitelist { get; set; }

        [NameInMap("esVersion")]
        [Validation(Required=false)]
        public string EsVersion { get; set; }

        [NameInMap("extendConfigs")]
        [Validation(Required=false)]
        public List<Dictionary<string, object>> ExtendConfigs { get; set; }

        [NameInMap("haveClientNode")]
        [Validation(Required=false)]
        public bool? HaveClientNode { get; set; }

        [NameInMap("haveElasticDataNode")]
        [Validation(Required=false)]
        public bool? HaveElasticDataNode { get; set; }

        [NameInMap("haveKibana")]
        [Validation(Required=false)]
        public bool? HaveKibana { get; set; }

        [NameInMap("ikHotDicts")]
        [Validation(Required=false)]
        public List<DictInfo> IkHotDicts { get; set; }

        [NameInMap("instanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("kibanaConfiguration")]
        [Validation(Required=false)]
        public KibanaNodeConfiguration KibanaConfiguration { get; set; }

        [NameInMap("kibanaDomain")]
        [Validation(Required=false)]
        public string KibanaDomain { get; set; }

        [NameInMap("kibanaIPWhitelist")]
        [Validation(Required=false)]
        public List<string> KibanaIPWhitelist { get; set; }

        [NameInMap("kibanaPort")]
        [Validation(Required=false)]
        public long? KibanaPort { get; set; }

        [NameInMap("kibanaPrivateDomain")]
        [Validation(Required=false)]
        public string KibanaPrivateDomain { get; set; }

        [NameInMap("kibanaPrivateIPWhitelist")]
        [Validation(Required=false)]
        public List<string> KibanaPrivateIPWhitelist { get; set; }

        [NameInMap("kibanaPrivatePort")]
        [Validation(Required=false)]
        public long? KibanaPrivatePort { get; set; }

        [NameInMap("kibanaProtocol")]
        [Validation(Required=false)]
        public string KibanaProtocol { get; set; }

        [NameInMap("masterConfiguration")]
        [Validation(Required=false)]
        public MasterNodeConfiguration MasterConfiguration { get; set; }

        [NameInMap("networkConfig")]
        [Validation(Required=false)]
        public NetworkConfig NetworkConfig { get; set; }

        [NameInMap("nodeAmount")]
        [Validation(Required=false)]
        public long? NodeAmount { get; set; }

        [NameInMap("nodeSpec")]
        [Validation(Required=false)]
        public NodeSpec NodeSpec { get; set; }

        [NameInMap("paymentType")]
        [Validation(Required=false)]
        public string PaymentType { get; set; }

        [NameInMap("port")]
        [Validation(Required=false)]
        public long? Port { get; set; }

        [NameInMap("privateNetworkIpWhiteList")]
        [Validation(Required=false)]
        public List<string> PrivateNetworkIpWhiteList { get; set; }

        [NameInMap("productType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

        [NameInMap("protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

        [NameInMap("publicDomain")]
        [Validation(Required=false)]
        public string PublicDomain { get; set; }

        [NameInMap("publicIpWhitelist")]
        [Validation(Required=false)]
        public List<string> PublicIpWhitelist { get; set; }

        [NameInMap("publicPort")]
        [Validation(Required=false)]
        public long? PublicPort { get; set; }

        [NameInMap("readWritePolicy")]
        [Validation(Required=false)]
        public ReadWritePolicy ReadWritePolicy { get; set; }

        [NameInMap("resourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("serviceVpc")]
        [Validation(Required=false)]
        public bool? ServiceVpc { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("synonymsDicts")]
        [Validation(Required=false)]
        public List<DictInfo> SynonymsDicts { get; set; }

        [NameInMap("tags")]
        [Validation(Required=false)]
        public List<Tag> Tags { get; set; }

        [NameInMap("updatedAt")]
        [Validation(Required=false)]
        public string UpdatedAt { get; set; }

        [NameInMap("warmNode")]
        [Validation(Required=false)]
        public bool? WarmNode { get; set; }

        [NameInMap("warmNodeConfiguration")]
        [Validation(Required=false)]
        public WarmNodeConfiguration WarmNodeConfiguration { get; set; }

        [NameInMap("zoneCount")]
        [Validation(Required=false)]
        public long? ZoneCount { get; set; }

        [NameInMap("zoneInfos")]
        [Validation(Required=false)]
        public List<ZoneInfo> ZoneInfos { get; set; }

    }

}
