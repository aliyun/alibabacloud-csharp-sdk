// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class DescribeInstanceResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public DescribeInstanceResponseBodyResult Result { get; set; }
        public class DescribeInstanceResponseBodyResult : TeaModel {
            [NameInMap("advancedDedicateMaster")]
            [Validation(Required=false)]
            public bool? AdvancedDedicateMaster { get; set; }

            [NameInMap("advancedSetting")]
            [Validation(Required=false)]
            public DescribeInstanceResponseBodyResultAdvancedSetting AdvancedSetting { get; set; }
            public class DescribeInstanceResponseBodyResultAdvancedSetting : TeaModel {
                [NameInMap("gcName")]
                [Validation(Required=false)]
                public string GcName { get; set; }

            }

            [NameInMap("aliwsDicts")]
            [Validation(Required=false)]
            public List<DescribeInstanceResponseBodyResultAliwsDicts> AliwsDicts { get; set; }
            public class DescribeInstanceResponseBodyResultAliwsDicts : TeaModel {
                [NameInMap("fileSize")]
                [Validation(Required=false)]
                public long? FileSize { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("sourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("clientNodeConfiguration")]
            [Validation(Required=false)]
            public DescribeInstanceResponseBodyResultClientNodeConfiguration ClientNodeConfiguration { get; set; }
            public class DescribeInstanceResponseBodyResultClientNodeConfiguration : TeaModel {
                [NameInMap("amount")]
                [Validation(Required=false)]
                public int? Amount { get; set; }

                [NameInMap("disk")]
                [Validation(Required=false)]
                public int? Disk { get; set; }

                [NameInMap("diskType")]
                [Validation(Required=false)]
                public string DiskType { get; set; }

                [NameInMap("spec")]
                [Validation(Required=false)]
                public string Spec { get; set; }

            }

            [NameInMap("createdAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            [NameInMap("dedicateMaster")]
            [Validation(Required=false)]
            public bool? DedicateMaster { get; set; }

            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("dictList")]
            [Validation(Required=false)]
            public List<DescribeInstanceResponseBodyResultDictList> DictList { get; set; }
            public class DescribeInstanceResponseBodyResultDictList : TeaModel {
                [NameInMap("fileSize")]
                [Validation(Required=false)]
                public long? FileSize { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("sourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            [NameInMap("elasticDataNodeConfiguration")]
            [Validation(Required=false)]
            public DescribeInstanceResponseBodyResultElasticDataNodeConfiguration ElasticDataNodeConfiguration { get; set; }
            public class DescribeInstanceResponseBodyResultElasticDataNodeConfiguration : TeaModel {
                [NameInMap("amount")]
                [Validation(Required=false)]
                public int? Amount { get; set; }

                [NameInMap("disk")]
                [Validation(Required=false)]
                public int? Disk { get; set; }

                [NameInMap("diskEncryption")]
                [Validation(Required=false)]
                public bool? DiskEncryption { get; set; }

                [NameInMap("diskType")]
                [Validation(Required=false)]
                public string DiskType { get; set; }

                [NameInMap("spec")]
                [Validation(Required=false)]
                public string Spec { get; set; }

            }

            [NameInMap("enableKibanaPrivateNetwork")]
            [Validation(Required=false)]
            public bool? EnableKibanaPrivateNetwork { get; set; }

            [NameInMap("enableKibanaPublicNetwork")]
            [Validation(Required=false)]
            public bool? EnableKibanaPublicNetwork { get; set; }

            [NameInMap("enablePublic")]
            [Validation(Required=false)]
            public bool? EnablePublic { get; set; }

            [NameInMap("esConfig")]
            [Validation(Required=false)]
            public Dictionary<string, object> EsConfig { get; set; }

            [NameInMap("esIPBlacklist")]
            [Validation(Required=false)]
            public List<string> EsIPBlacklist { get; set; }

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

            [NameInMap("haveKibana")]
            [Validation(Required=false)]
            public bool? HaveKibana { get; set; }

            [NameInMap("ikHotDicts")]
            [Validation(Required=false)]
            public List<DescribeInstanceResponseBodyResultIkHotDicts> IkHotDicts { get; set; }
            public class DescribeInstanceResponseBodyResultIkHotDicts : TeaModel {
                [NameInMap("fileSize")]
                [Validation(Required=false)]
                public int? FileSize { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("sourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("instanceCategory")]
            [Validation(Required=false)]
            public string InstanceCategory { get; set; }

            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("isNewDeployment")]
            [Validation(Required=false)]
            public bool? IsNewDeployment { get; set; }

            [NameInMap("kibanaConfiguration")]
            [Validation(Required=false)]
            public DescribeInstanceResponseBodyResultKibanaConfiguration KibanaConfiguration { get; set; }
            public class DescribeInstanceResponseBodyResultKibanaConfiguration : TeaModel {
                [NameInMap("amount")]
                [Validation(Required=false)]
                public int? Amount { get; set; }

                [NameInMap("disk")]
                [Validation(Required=false)]
                public int? Disk { get; set; }

                [NameInMap("spec")]
                [Validation(Required=false)]
                public string Spec { get; set; }

            }

            [NameInMap("kibanaDomain")]
            [Validation(Required=false)]
            public string KibanaDomain { get; set; }

            [NameInMap("kibanaIPWhitelist")]
            [Validation(Required=false)]
            public List<string> KibanaIPWhitelist { get; set; }

            [NameInMap("kibanaPort")]
            [Validation(Required=false)]
            public int? KibanaPort { get; set; }

            [NameInMap("kibanaPrivateIPWhitelist")]
            [Validation(Required=false)]
            public List<string> KibanaPrivateIPWhitelist { get; set; }

            [NameInMap("masterConfiguration")]
            [Validation(Required=false)]
            public DescribeInstanceResponseBodyResultMasterConfiguration MasterConfiguration { get; set; }
            public class DescribeInstanceResponseBodyResultMasterConfiguration : TeaModel {
                [NameInMap("amount")]
                [Validation(Required=false)]
                public int? Amount { get; set; }

                [NameInMap("disk")]
                [Validation(Required=false)]
                public int? Disk { get; set; }

                [NameInMap("diskType")]
                [Validation(Required=false)]
                public string DiskType { get; set; }

                [NameInMap("spec")]
                [Validation(Required=false)]
                public string Spec { get; set; }

            }

            [NameInMap("networkConfig")]
            [Validation(Required=false)]
            public DescribeInstanceResponseBodyResultNetworkConfig NetworkConfig { get; set; }
            public class DescribeInstanceResponseBodyResultNetworkConfig : TeaModel {
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("vpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                [NameInMap("vsArea")]
                [Validation(Required=false)]
                public string VsArea { get; set; }

                [NameInMap("vswitchId")]
                [Validation(Required=false)]
                public string VswitchId { get; set; }

                [NameInMap("whiteIpGroupList")]
                [Validation(Required=false)]
                public List<DescribeInstanceResponseBodyResultNetworkConfigWhiteIpGroupList> WhiteIpGroupList { get; set; }
                public class DescribeInstanceResponseBodyResultNetworkConfigWhiteIpGroupList : TeaModel {
                    [NameInMap("groupName")]
                    [Validation(Required=false)]
                    public string GroupName { get; set; }

                    [NameInMap("ips")]
                    [Validation(Required=false)]
                    public List<string> Ips { get; set; }

                    [NameInMap("whiteIpType")]
                    [Validation(Required=false)]
                    public string WhiteIpType { get; set; }

                }

            }

            [NameInMap("nodeAmount")]
            [Validation(Required=false)]
            public int? NodeAmount { get; set; }

            [NameInMap("nodeSpec")]
            [Validation(Required=false)]
            public DescribeInstanceResponseBodyResultNodeSpec NodeSpec { get; set; }
            public class DescribeInstanceResponseBodyResultNodeSpec : TeaModel {
                [NameInMap("disk")]
                [Validation(Required=false)]
                public int? Disk { get; set; }

                [NameInMap("diskEncryption")]
                [Validation(Required=false)]
                public bool? DiskEncryption { get; set; }

                [NameInMap("diskType")]
                [Validation(Required=false)]
                public string DiskType { get; set; }

                [NameInMap("performanceLevel")]
                [Validation(Required=false)]
                public string PerformanceLevel { get; set; }

                [NameInMap("spec")]
                [Validation(Required=false)]
                public string Spec { get; set; }

            }

            [NameInMap("paymentType")]
            [Validation(Required=false)]
            public string PaymentType { get; set; }

            [NameInMap("port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

            [NameInMap("postpaidServiceStatus")]
            [Validation(Required=false)]
            public string PostpaidServiceStatus { get; set; }

            [NameInMap("privateNetworkIpWhiteList")]
            [Validation(Required=false)]
            public List<string> PrivateNetworkIpWhiteList { get; set; }

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
            public int? PublicPort { get; set; }

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
            public List<DescribeInstanceResponseBodyResultSynonymsDicts> SynonymsDicts { get; set; }
            public class DescribeInstanceResponseBodyResultSynonymsDicts : TeaModel {
                [NameInMap("fileSize")]
                [Validation(Required=false)]
                public long? FileSize { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("sourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("tags")]
            [Validation(Required=false)]
            public List<DescribeInstanceResponseBodyResultTags> Tags { get; set; }
            public class DescribeInstanceResponseBodyResultTags : TeaModel {
                [NameInMap("tagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                [NameInMap("tagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

            [NameInMap("updatedAt")]
            [Validation(Required=false)]
            public string UpdatedAt { get; set; }

            [NameInMap("vpcInstanceId")]
            [Validation(Required=false)]
            public string VpcInstanceId { get; set; }

            [NameInMap("warmNode")]
            [Validation(Required=false)]
            public bool? WarmNode { get; set; }

            [NameInMap("warmNodeConfiguration")]
            [Validation(Required=false)]
            public DescribeInstanceResponseBodyResultWarmNodeConfiguration WarmNodeConfiguration { get; set; }
            public class DescribeInstanceResponseBodyResultWarmNodeConfiguration : TeaModel {
                [NameInMap("amount")]
                [Validation(Required=false)]
                public int? Amount { get; set; }

                [NameInMap("disk")]
                [Validation(Required=false)]
                public int? Disk { get; set; }

                [NameInMap("diskEncryption")]
                [Validation(Required=false)]
                public bool? DiskEncryption { get; set; }

                [NameInMap("diskType")]
                [Validation(Required=false)]
                public string DiskType { get; set; }

                [NameInMap("spec")]
                [Validation(Required=false)]
                public string Spec { get; set; }

            }

            [NameInMap("zoneCount")]
            [Validation(Required=false)]
            public int? ZoneCount { get; set; }

            [NameInMap("zoneInfos")]
            [Validation(Required=false)]
            public List<DescribeInstanceResponseBodyResultZoneInfos> ZoneInfos { get; set; }
            public class DescribeInstanceResponseBodyResultZoneInfos : TeaModel {
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("zoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

    }

}
