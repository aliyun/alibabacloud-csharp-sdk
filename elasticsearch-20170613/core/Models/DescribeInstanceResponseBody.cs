// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class DescribeInstanceResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>5FFD9ED4-C2EC-4E89-B22B-1ACB6FE1****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public DescribeInstanceResponseBodyResult Result { get; set; }
        public class DescribeInstanceResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("advancedDedicateMaster")]
            [Validation(Required=false)]
            public bool? AdvancedDedicateMaster { get; set; }

            [NameInMap("advancedSetting")]
            [Validation(Required=false)]
            public DescribeInstanceResponseBodyResultAdvancedSetting AdvancedSetting { get; set; }
            public class DescribeInstanceResponseBodyResultAdvancedSetting : TeaModel {
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
            public List<DescribeInstanceResponseBodyResultAliwsDicts> AliwsDicts { get; set; }
            public class DescribeInstanceResponseBodyResultAliwsDicts : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2782602</para>
                /// </summary>
                [NameInMap("fileSize")]
                [Validation(Required=false)]
                public long? FileSize { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>aliws_ext_dict.txt</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>OSS</para>
                /// </summary>
                [NameInMap("sourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ALI_WS</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("archType")]
            [Validation(Required=false)]
            public string ArchType { get; set; }

            [NameInMap("clientNodeConfiguration")]
            [Validation(Required=false)]
            public DescribeInstanceResponseBodyResultClientNodeConfiguration ClientNodeConfiguration { get; set; }
            public class DescribeInstanceResponseBodyResultClientNodeConfiguration : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("amount")]
                [Validation(Required=false)]
                public int? Amount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>40</para>
                /// </summary>
                [NameInMap("disk")]
                [Validation(Required=false)]
                public int? Disk { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cloud_efficiency</para>
                /// </summary>
                [NameInMap("diskType")]
                [Validation(Required=false)]
                public string DiskType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>elasticsearch.n4.small</para>
                /// </summary>
                [NameInMap("spec")]
                [Validation(Required=false)]
                public string Spec { get; set; }

                [NameInMap("specInfo")]
                [Validation(Required=false)]
                public string SpecInfo { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2018-07-13T03:58:07.253Z</para>
            /// </summary>
            [NameInMap("createdAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

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
            public List<DescribeInstanceResponseBodyResultDictList> DictList { get; set; }
            public class DescribeInstanceResponseBodyResultDictList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2782602</para>
                /// </summary>
                [NameInMap("fileSize")]
                [Validation(Required=false)]
                public long? FileSize { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>SYSTEM_MAIN.dic</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ORIGIN</para>
                /// </summary>
                [NameInMap("sourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>MAIN</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>es-cn-3h4k3axh33th9****.elasticsearch.aliyuncs.com</para>
            /// </summary>
            [NameInMap("domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            [NameInMap("elasticDataNodeConfiguration")]
            [Validation(Required=false)]
            public DescribeInstanceResponseBodyResultElasticDataNodeConfiguration ElasticDataNodeConfiguration { get; set; }
            public class DescribeInstanceResponseBodyResultElasticDataNodeConfiguration : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("amount")]
                [Validation(Required=false)]
                public int? Amount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("disk")]
                [Validation(Required=false)]
                public int? Disk { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("diskEncryption")]
                [Validation(Required=false)]
                public bool? DiskEncryption { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cloud_ssd</para>
                /// </summary>
                [NameInMap("diskType")]
                [Validation(Required=false)]
                public string DiskType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>elasticsearch.sn2ne.large</para>
                /// </summary>
                [NameInMap("spec")]
                [Validation(Required=false)]
                public string Spec { get; set; }

                [NameInMap("specInfo")]
                [Validation(Required=false)]
                public string SpecInfo { get; set; }

            }

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

            [NameInMap("endTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            [NameInMap("endpoints")]
            [Validation(Required=false)]
            public List<DescribeInstanceResponseBodyResultEndpoints> Endpoints { get; set; }
            public class DescribeInstanceResponseBodyResultEndpoints : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>es-cn-xx-cn-hangzhou-h.elasticsearch.aliyuncs.com</para>
                /// </summary>
                [NameInMap("endpoint")]
                [Validation(Required=false)]
                public string Endpoint { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>vsw-xxx</para>
                /// </summary>
                [NameInMap("vswitchId")]
                [Validation(Required=false)]
                public string VswitchId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cn-hangzhou-i</para>
                /// </summary>
                [NameInMap("zoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;http.cors.allow-credentials&quot;:&quot;false&quot;}</para>
            /// </summary>
            [NameInMap("esConfig")]
            [Validation(Required=false)]
            public Dictionary<string, object> EsConfig { get; set; }

            [NameInMap("esIPBlacklist")]
            [Validation(Required=false)]
            public List<string> EsIPBlacklist { get; set; }

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
            /// <para>true</para>
            /// </summary>
            [NameInMap("haveClientNode")]
            [Validation(Required=false)]
            public bool? HaveClientNode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("haveKibana")]
            [Validation(Required=false)]
            public bool? HaveKibana { get; set; }

            [NameInMap("ikHotDicts")]
            [Validation(Required=false)]
            public List<DescribeInstanceResponseBodyResultIkHotDicts> IkHotDicts { get; set; }
            public class DescribeInstanceResponseBodyResultIkHotDicts : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>6</para>
                /// </summary>
                [NameInMap("fileSize")]
                [Validation(Required=false)]
                public int? FileSize { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>deploy_0.dic</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>OSS</para>
                /// </summary>
                [NameInMap("sourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>MAIN</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("inited")]
            [Validation(Required=false)]
            public bool? Inited { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>advanced</para>
            /// </summary>
            [NameInMap("instanceCategory")]
            [Validation(Required=false)]
            public string InstanceCategory { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>es-cn-3h4k3axh33th9****</para>
            /// </summary>
            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("isNewDeployment")]
            [Validation(Required=false)]
            public bool? IsNewDeployment { get; set; }

            [NameInMap("kibanaConfiguration")]
            [Validation(Required=false)]
            public DescribeInstanceResponseBodyResultKibanaConfiguration KibanaConfiguration { get; set; }
            public class DescribeInstanceResponseBodyResultKibanaConfiguration : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("amount")]
                [Validation(Required=false)]
                public int? Amount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("disk")]
                [Validation(Required=false)]
                public int? Disk { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>elasticsearch.n4.small</para>
                /// </summary>
                [NameInMap("spec")]
                [Validation(Required=false)]
                public string Spec { get; set; }

                [NameInMap("specInfo")]
                [Validation(Required=false)]
                public string SpecInfo { get; set; }

            }

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
            public int? KibanaPort { get; set; }

            [NameInMap("kibanaPrivateDomain")]
            [Validation(Required=false)]
            public string KibanaPrivateDomain { get; set; }

            [NameInMap("kibanaPrivateIPWhitelist")]
            [Validation(Required=false)]
            public List<string> KibanaPrivateIPWhitelist { get; set; }

            [NameInMap("kibanaPrivatePort")]
            [Validation(Required=false)]
            public string KibanaPrivatePort { get; set; }

            [NameInMap("masterConfiguration")]
            [Validation(Required=false)]
            public DescribeInstanceResponseBodyResultMasterConfiguration MasterConfiguration { get; set; }
            public class DescribeInstanceResponseBodyResultMasterConfiguration : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("amount")]
                [Validation(Required=false)]
                public int? Amount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>40</para>
                /// </summary>
                [NameInMap("disk")]
                [Validation(Required=false)]
                public int? Disk { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cloud_ssd</para>
                /// </summary>
                [NameInMap("diskType")]
                [Validation(Required=false)]
                public string DiskType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>elasticsearch.n4.small</para>
                /// </summary>
                [NameInMap("spec")]
                [Validation(Required=false)]
                public string Spec { get; set; }

                [NameInMap("specInfo")]
                [Validation(Required=false)]
                public string SpecInfo { get; set; }

            }

            [NameInMap("networkConfig")]
            [Validation(Required=false)]
            public DescribeInstanceResponseBodyResultNetworkConfig NetworkConfig { get; set; }
            public class DescribeInstanceResponseBodyResultNetworkConfig : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>vpc</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>vpc-abc</para>
                /// </summary>
                [NameInMap("vpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cn-hangzhou-b</para>
                /// </summary>
                [NameInMap("vsArea")]
                [Validation(Required=false)]
                public string VsArea { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>vsw-abc</para>
                /// </summary>
                [NameInMap("vswitchId")]
                [Validation(Required=false)]
                public string VswitchId { get; set; }

                [NameInMap("whiteIpGroupList")]
                [Validation(Required=false)]
                public List<DescribeInstanceResponseBodyResultNetworkConfigWhiteIpGroupList> WhiteIpGroupList { get; set; }
                public class DescribeInstanceResponseBodyResultNetworkConfigWhiteIpGroupList : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>default</para>
                    /// </summary>
                    [NameInMap("groupName")]
                    [Validation(Required=false)]
                    public string GroupName { get; set; }

                    [NameInMap("ips")]
                    [Validation(Required=false)]
                    public List<string> Ips { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>PRIVATE_ES</para>
                    /// </summary>
                    [NameInMap("whiteIpType")]
                    [Validation(Required=false)]
                    public string WhiteIpType { get; set; }

                }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("nodeAmount")]
            [Validation(Required=false)]
            public int? NodeAmount { get; set; }

            [NameInMap("nodeSpec")]
            [Validation(Required=false)]
            public DescribeInstanceResponseBodyResultNodeSpec NodeSpec { get; set; }
            public class DescribeInstanceResponseBodyResultNodeSpec : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("disk")]
                [Validation(Required=false)]
                public int? Disk { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("diskEncryption")]
                [Validation(Required=false)]
                public bool? DiskEncryption { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cloud_ssd</para>
                /// </summary>
                [NameInMap("diskType")]
                [Validation(Required=false)]
                public string DiskType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>PL1</para>
                /// </summary>
                [NameInMap("performanceLevel")]
                [Validation(Required=false)]
                public string PerformanceLevel { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>elasticsearch.n4.small</para>
                /// </summary>
                [NameInMap("spec")]
                [Validation(Required=false)]
                public string Spec { get; set; }

                [NameInMap("specInfo")]
                [Validation(Required=false)]
                public string SpecInfo { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>postpaid</para>
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
            public int? Port { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>active</para>
            /// </summary>
            [NameInMap("postpaidServiceStatus")]
            [Validation(Required=false)]
            public string PostpaidServiceStatus { get; set; }

            [NameInMap("privateNetworkIpWhiteList")]
            [Validation(Required=false)]
            public List<string> PrivateNetworkIpWhiteList { get; set; }

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
            public int? PublicPort { get; set; }

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
            public List<DescribeInstanceResponseBodyResultSynonymsDicts> SynonymsDicts { get; set; }
            public class DescribeInstanceResponseBodyResultSynonymsDicts : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2782602</para>
                /// </summary>
                [NameInMap("fileSize")]
                [Validation(Required=false)]
                public long? FileSize { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>SYSTEM_MAIN.dic</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ORIGIN</para>
                /// </summary>
                [NameInMap("sourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>STOP</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("tags")]
            [Validation(Required=false)]
            public List<DescribeInstanceResponseBodyResultTags> Tags { get; set; }
            public class DescribeInstanceResponseBodyResultTags : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>env</para>
                /// </summary>
                [NameInMap("tagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>dev</para>
                /// </summary>
                [NameInMap("tagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2018-07-13T03:58:07.253Z</para>
            /// </summary>
            [NameInMap("updatedAt")]
            [Validation(Required=false)]
            public string UpdatedAt { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>vpc-bp1uag5jj38c****</para>
            /// </summary>
            [NameInMap("vpcInstanceId")]
            [Validation(Required=false)]
            public string VpcInstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("warmNode")]
            [Validation(Required=false)]
            public bool? WarmNode { get; set; }

            [NameInMap("warmNodeConfiguration")]
            [Validation(Required=false)]
            public DescribeInstanceResponseBodyResultWarmNodeConfiguration WarmNodeConfiguration { get; set; }
            public class DescribeInstanceResponseBodyResultWarmNodeConfiguration : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>6</para>
                /// </summary>
                [NameInMap("amount")]
                [Validation(Required=false)]
                public int? Amount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>500</para>
                /// </summary>
                [NameInMap("disk")]
                [Validation(Required=false)]
                public int? Disk { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("diskEncryption")]
                [Validation(Required=false)]
                public bool? DiskEncryption { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cloud_efficiency</para>
                /// </summary>
                [NameInMap("diskType")]
                [Validation(Required=false)]
                public string DiskType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>elasticsearch.n4.small</para>
                /// </summary>
                [NameInMap("spec")]
                [Validation(Required=false)]
                public string Spec { get; set; }

                [NameInMap("specInfo")]
                [Validation(Required=false)]
                public string SpecInfo { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("zoneCount")]
            [Validation(Required=false)]
            public int? ZoneCount { get; set; }

            [NameInMap("zoneInfos")]
            [Validation(Required=false)]
            public List<DescribeInstanceResponseBodyResultZoneInfos> ZoneInfos { get; set; }
            public class DescribeInstanceResponseBodyResultZoneInfos : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>NORMAL</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cn-hangzhou-b</para>
                /// </summary>
                [NameInMap("zoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

    }

}
