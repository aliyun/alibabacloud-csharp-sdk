// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class DescribeInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5FFD9ED4-C2EC-4E89-B22B-1ACB6FE1****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The returned result.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public DescribeInstanceResponseBodyResult Result { get; set; }
        public class DescribeInstanceResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>Indicates whether the instance contains dedicated master nodes. Valid values:</para>
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
            public DescribeInstanceResponseBodyResultAdvancedSetting AdvancedSetting { get; set; }
            public class DescribeInstanceResponseBodyResultAdvancedSetting : TeaModel {
                /// <summary>
                /// <para>The name of the garbage collector. Valid values: CMS and G1.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CMS</para>
                /// </summary>
                [NameInMap("gcName")]
                [Validation(Required=false)]
                public string GcName { get; set; }

            }

            /// <summary>
            /// <para>The Alibaba Cloud tokenizer dictionary configuration.</para>
            /// </summary>
            [NameInMap("aliwsDicts")]
            [Validation(Required=false)]
            public List<DescribeInstanceResponseBodyResultAliwsDicts> AliwsDicts { get; set; }
            public class DescribeInstanceResponseBodyResultAliwsDicts : TeaModel {
                /// <summary>
                /// <para>The size of the dictionary file. Unit: bytes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2782602</para>
                /// </summary>
                [NameInMap("fileSize")]
                [Validation(Required=false)]
                public long? FileSize { get; set; }

                /// <summary>
                /// <para>The name of the dictionary file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>aliws_ext_dict.txt</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The source type of the dictionary file. Valid values:</para>
                /// 
                /// <b>Example:</b>
                /// <para>OSS</para>
                /// </summary>
                [NameInMap("sourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

                /// <summary>
                /// <para>The type of the dictionary file. Valid values:</para>
                /// 
                /// <b>Example:</b>
                /// <para>ALI_WS</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The deployment mode. Architecture type:</para>
            /// 
            /// <b>Example:</b>
            /// <para>public</para>
            /// </summary>
            [NameInMap("archType")]
            [Validation(Required=false)]
            public string ArchType { get; set; }

            /// <summary>
            /// <para>The configuration information of the client node.</para>
            /// </summary>
            [NameInMap("clientNodeConfiguration")]
            [Validation(Required=false)]
            public DescribeInstanceResponseBodyResultClientNodeConfiguration ClientNodeConfiguration { get; set; }
            public class DescribeInstanceResponseBodyResultClientNodeConfiguration : TeaModel {
                /// <summary>
                /// <para>The number of nodes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("amount")]
                [Validation(Required=false)]
                public int? Amount { get; set; }

                /// <summary>
                /// <para>The storage space of the node. Unit: GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>40</para>
                /// </summary>
                [NameInMap("disk")]
                [Validation(Required=false)]
                public int? Disk { get; set; }

                /// <summary>
                /// <para>The storage type of the node. Only cloud_efficiency (ultra disk) is supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cloud_efficiency</para>
                /// </summary>
                [NameInMap("diskType")]
                [Validation(Required=false)]
                public string DiskType { get; set; }

                /// <summary>
                /// <para>The node specifications. For more information about specifications, see <a href="https://help.aliyun.com/document_detail/271718.html">Product specifications</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>elasticsearch.n4.small</para>
                /// </summary>
                [NameInMap("spec")]
                [Validation(Required=false)]
                public string Spec { get; set; }

                /// <summary>
                /// <para>The description of the node specifications.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1C 2G</para>
                /// </summary>
                [NameInMap("specInfo")]
                [Validation(Required=false)]
                public string SpecInfo { get; set; }

            }

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
            /// <para><b>[Deprecated]</b> The dedicated master node.</para>
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
            public List<DescribeInstanceResponseBodyResultDictList> DictList { get; set; }
            public class DescribeInstanceResponseBodyResultDictList : TeaModel {
                /// <summary>
                /// <para>The size of the dictionary file. Unit: bytes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2782602</para>
                /// </summary>
                [NameInMap("fileSize")]
                [Validation(Required=false)]
                public long? FileSize { get; set; }

                /// <summary>
                /// <para>The name of the dictionary file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SYSTEM_MAIN.dic</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The source type of the dictionary file. Valid values:</para>
                /// 
                /// <b>Example:</b>
                /// <para>ORIGIN</para>
                /// </summary>
                [NameInMap("sourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

                /// <summary>
                /// <para>The type of the dictionary file. Valid values:</para>
                /// 
                /// <b>Example:</b>
                /// <para>MAIN</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The internal endpoint of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>es-cn-3h4k3axh33th9****.elasticsearch.aliyuncs.com</para>
            /// </summary>
            [NameInMap("domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// <para>The configuration of the elastic data node.</para>
            /// </summary>
            [NameInMap("elasticDataNodeConfiguration")]
            [Validation(Required=false)]
            public DescribeInstanceResponseBodyResultElasticDataNodeConfiguration ElasticDataNodeConfiguration { get; set; }
            public class DescribeInstanceResponseBodyResultElasticDataNodeConfiguration : TeaModel {
                /// <summary>
                /// <para>The number of nodes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("amount")]
                [Validation(Required=false)]
                public int? Amount { get; set; }

                /// <summary>
                /// <para>The storage space of the node. Unit: GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("disk")]
                [Validation(Required=false)]
                public int? Disk { get; set; }

                /// <summary>
                /// <para>Indicates whether cloud disk encryption is enabled for the node. Valid values:</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("diskEncryption")]
                [Validation(Required=false)]
                public bool? DiskEncryption { get; set; }

                /// <summary>
                /// <para>The storage type of the node. Valid values:</para>
                /// 
                /// <b>Example:</b>
                /// <para>cloud_ssd</para>
                /// </summary>
                [NameInMap("diskType")]
                [Validation(Required=false)]
                public string DiskType { get; set; }

                /// <summary>
                /// <para>The node specifications. For more information about specifications, see <a href="https://help.aliyun.com/document_detail/271718.html">Product specifications</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>elasticsearch.sn2ne.large</para>
                /// </summary>
                [NameInMap("spec")]
                [Validation(Required=false)]
                public string Spec { get; set; }

                /// <summary>
                /// <para>The description of the node specifications.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1C 2G</para>
                /// </summary>
                [NameInMap("specInfo")]
                [Validation(Required=false)]
                public string SpecInfo { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether private network access to Kibana is enabled. Valid values:</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("enableKibanaPrivateNetwork")]
            [Validation(Required=false)]
            public bool? EnableKibanaPrivateNetwork { get; set; }

            /// <summary>
            /// <para>Indicates whether public network access to Kibana is enabled. Valid values:</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("enableKibanaPublicNetwork")]
            [Validation(Required=false)]
            public bool? EnableKibanaPublicNetwork { get; set; }

            /// <summary>
            /// <para>Indicates whether the public endpoint of the instance is enabled. Valid values:</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("enablePublic")]
            [Validation(Required=false)]
            public bool? EnablePublic { get; set; }

            [NameInMap("endTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <para>The private domain names for each zone of an HP_ALILB multi-zone instance.</para>
            /// </summary>
            [NameInMap("endpoints")]
            [Validation(Required=false)]
            public List<DescribeInstanceResponseBodyResultEndpoints> Endpoints { get; set; }
            public class DescribeInstanceResponseBodyResultEndpoints : TeaModel {
                /// <summary>
                /// <para>The private endpoint of the zone.</para>
                /// 
                /// <b>Example:</b>
                /// <para>es-cn-xx-cn-hangzhou-h.elasticsearch.aliyuncs.com</para>
                /// </summary>
                [NameInMap("endpoint")]
                [Validation(Required=false)]
                public string Endpoint { get; set; }

                /// <summary>
                /// <para>vswitchId</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-xxx</para>
                /// </summary>
                [NameInMap("vswitchId")]
                [Validation(Required=false)]
                public string VswitchId { get; set; }

                /// <summary>
                /// <para>The zone ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou-i</para>
                /// </summary>
                [NameInMap("zoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

            /// <summary>
            /// <para>The YML file configuration of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;http.cors.allow-credentials&quot;:&quot;false&quot;}</para>
            /// </summary>
            [NameInMap("esConfig")]
            [Validation(Required=false)]
            public Dictionary<string, object> EsConfig { get; set; }

            /// <summary>
            /// <para><b>[Deprecated]</b> The private network access blacklist.</para>
            /// </summary>
            [NameInMap("esIPBlacklist")]
            [Validation(Required=false)]
            public List<string> EsIPBlacklist { get; set; }

            /// <summary>
            /// <para><b>[Deprecated]</b> The private network access whitelist.</para>
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
            /// <para>The extended configuration array of the instance.</para>
            /// </summary>
            [NameInMap("extendConfigs")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> ExtendConfigs { get; set; }

            /// <summary>
            /// <para>Indicates whether the instance contains client nodes. Valid values:</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("haveClientNode")]
            [Validation(Required=false)]
            public bool? HaveClientNode { get; set; }

            /// <summary>
            /// <para>Indicates whether the instance contains Kibana nodes. Valid values:</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("haveKibana")]
            [Validation(Required=false)]
            public bool? HaveKibana { get; set; }

            /// <summary>
            /// <para>The IK dictionary hot update configuration.</para>
            /// </summary>
            [NameInMap("ikHotDicts")]
            [Validation(Required=false)]
            public List<DescribeInstanceResponseBodyResultIkHotDicts> IkHotDicts { get; set; }
            public class DescribeInstanceResponseBodyResultIkHotDicts : TeaModel {
                /// <summary>
                /// <para>The size of the dictionary file. Unit: bytes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>6</para>
                /// </summary>
                [NameInMap("fileSize")]
                [Validation(Required=false)]
                public int? FileSize { get; set; }

                /// <summary>
                /// <para>The name of the dictionary file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>deploy_0.dic</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The source type of the dictionary file. Valid values:</para>
                /// 
                /// <b>Example:</b>
                /// <para>OSS</para>
                /// </summary>
                [NameInMap("sourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

                /// <summary>
                /// <para>The type of the dictionary to update. Valid values:</para>
                /// 
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
            /// <para>The edition type of the instance. Valid values:</para>
            /// 
            /// <b>Example:</b>
            /// <para>advanced</para>
            /// </summary>
            [NameInMap("instanceCategory")]
            [Validation(Required=false)]
            public string InstanceCategory { get; set; }

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
            /// <para>Indicates whether the instance uses the new deployment architecture.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("isNewDeployment")]
            [Validation(Required=false)]
            public bool? IsNewDeployment { get; set; }

            /// <summary>
            /// <para>The configuration information of the Kibana node.</para>
            /// </summary>
            [NameInMap("kibanaConfiguration")]
            [Validation(Required=false)]
            public DescribeInstanceResponseBodyResultKibanaConfiguration KibanaConfiguration { get; set; }
            public class DescribeInstanceResponseBodyResultKibanaConfiguration : TeaModel {
                /// <summary>
                /// <para>The number of nodes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("amount")]
                [Validation(Required=false)]
                public int? Amount { get; set; }

                /// <summary>
                /// <para>The storage size of a single node. Unit: GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("disk")]
                [Validation(Required=false)]
                public int? Disk { get; set; }

                /// <summary>
                /// <para>The node specifications. For more information about specifications, see <a href="https://help.aliyun.com/document_detail/271718.html">Product specifications</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>elasticsearch.n4.small</para>
                /// </summary>
                [NameInMap("spec")]
                [Validation(Required=false)]
                public string Spec { get; set; }

                /// <summary>
                /// <para>The description of the node specifications.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1C 2G</para>
                /// </summary>
                [NameInMap("specInfo")]
                [Validation(Required=false)]
                public string SpecInfo { get; set; }

            }

            /// <summary>
            /// <para>The Kibana endpoint.</para>
            /// 
            /// <b>Example:</b>
            /// <para>es-cn-3h4k3axh33th9****.kibana.elasticsearch.aliyuncs.com</para>
            /// </summary>
            [NameInMap("kibanaDomain")]
            [Validation(Required=false)]
            public string KibanaDomain { get; set; }

            /// <summary>
            /// <para>The Kibana public endpoint access whitelist.</para>
            /// </summary>
            [NameInMap("kibanaIPWhitelist")]
            [Validation(Required=false)]
            public List<string> KibanaIPWhitelist { get; set; }

            /// <summary>
            /// <para>The access port of Kibana.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5601</para>
            /// </summary>
            [NameInMap("kibanaPort")]
            [Validation(Required=false)]
            public int? KibanaPort { get; set; }

            /// <summary>
            /// <para>The private endpoint of Kibana for private network access.</para>
            /// 
            /// <b>Example:</b>
            /// <para>es-cn-x0r3*********.elasticsearch.aliyuncs.com</para>
            /// </summary>
            [NameInMap("kibanaPrivateDomain")]
            [Validation(Required=false)]
            public string KibanaPrivateDomain { get; set; }

            /// <summary>
            /// <para>The Kibana private endpoint access whitelist.</para>
            /// </summary>
            [NameInMap("kibanaPrivateIPWhitelist")]
            [Validation(Required=false)]
            public List<string> KibanaPrivateIPWhitelist { get; set; }

            /// <summary>
            /// <para>The private port of Kibana.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5601</para>
            /// </summary>
            [NameInMap("kibanaPrivatePort")]
            [Validation(Required=false)]
            public string KibanaPrivatePort { get; set; }

            /// <summary>
            /// <para>The configuration of the dedicated master node.</para>
            /// </summary>
            [NameInMap("masterConfiguration")]
            [Validation(Required=false)]
            public DescribeInstanceResponseBodyResultMasterConfiguration MasterConfiguration { get; set; }
            public class DescribeInstanceResponseBodyResultMasterConfiguration : TeaModel {
                /// <summary>
                /// <para>The number of nodes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("amount")]
                [Validation(Required=false)]
                public int? Amount { get; set; }

                /// <summary>
                /// <para>The storage space of the node. Unit: GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>40</para>
                /// </summary>
                [NameInMap("disk")]
                [Validation(Required=false)]
                public int? Disk { get; set; }

                /// <summary>
                /// <para>The storage type of the node. Only cloud_ssd (standard SSD) is supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cloud_ssd</para>
                /// </summary>
                [NameInMap("diskType")]
                [Validation(Required=false)]
                public string DiskType { get; set; }

                /// <summary>
                /// <para>The node specifications. For more information about specifications, see <a href="https://help.aliyun.com/document_detail/271718.html">Product specifications</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>elasticsearch.n4.small</para>
                /// </summary>
                [NameInMap("spec")]
                [Validation(Required=false)]
                public string Spec { get; set; }

                /// <summary>
                /// <para>The description of the node specifications.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1C 2G</para>
                /// </summary>
                [NameInMap("specInfo")]
                [Validation(Required=false)]
                public string SpecInfo { get; set; }

            }

            /// <summary>
            /// <para>The network configuration.</para>
            /// </summary>
            [NameInMap("networkConfig")]
            [Validation(Required=false)]
            public DescribeInstanceResponseBodyResultNetworkConfig NetworkConfig { get; set; }
            public class DescribeInstanceResponseBodyResultNetworkConfig : TeaModel {
                /// <summary>
                /// <para>The network type. Only Virtual Private Cloud (VPC) is supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The VPC ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-abc</para>
                /// </summary>
                [NameInMap("vpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                /// <summary>
                /// <para>The zone where the instance resides.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou-b</para>
                /// </summary>
                [NameInMap("vsArea")]
                [Validation(Required=false)]
                public string VsArea { get; set; }

                /// <summary>
                /// <para>The vSwitch ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-abc</para>
                /// </summary>
                [NameInMap("vswitchId")]
                [Validation(Required=false)]
                public string VswitchId { get; set; }

                /// <summary>
                /// <para>The whitelist group list.</para>
                /// </summary>
                [NameInMap("whiteIpGroupList")]
                [Validation(Required=false)]
                public List<DescribeInstanceResponseBodyResultNetworkConfigWhiteIpGroupList> WhiteIpGroupList { get; set; }
                public class DescribeInstanceResponseBodyResultNetworkConfigWhiteIpGroupList : TeaModel {
                    /// <summary>
                    /// <para>The name of the whitelist group. The default group is included by default.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>default</para>
                    /// </summary>
                    [NameInMap("groupName")]
                    [Validation(Required=false)]
                    public string GroupName { get; set; }

                    /// <summary>
                    /// <para>The list of IP addresses in the whitelist group.</para>
                    /// </summary>
                    [NameInMap("ips")]
                    [Validation(Required=false)]
                    public List<string> Ips { get; set; }

                    /// <summary>
                    /// <para>The whitelist type. Valid values:</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>PRIVATE_ES</para>
                    /// </summary>
                    [NameInMap("whiteIpType")]
                    [Validation(Required=false)]
                    public string WhiteIpType { get; set; }

                }

            }

            /// <summary>
            /// <para>The number of data nodes in the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("nodeAmount")]
            [Validation(Required=false)]
            public int? NodeAmount { get; set; }

            /// <summary>
            /// <para>The configuration of data nodes.</para>
            /// </summary>
            [NameInMap("nodeSpec")]
            [Validation(Required=false)]
            public DescribeInstanceResponseBodyResultNodeSpec NodeSpec { get; set; }
            public class DescribeInstanceResponseBodyResultNodeSpec : TeaModel {
                /// <summary>
                /// <para>The storage space of the node. Unit: GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("disk")]
                [Validation(Required=false)]
                public int? Disk { get; set; }

                /// <summary>
                /// <para>Indicates whether cloud disk encryption is enabled. Valid values:</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("diskEncryption")]
                [Validation(Required=false)]
                public bool? DiskEncryption { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>high_availability</para>
                /// </summary>
                [NameInMap("diskPreference")]
                [Validation(Required=false)]
                public string DiskPreference { get; set; }

                /// <summary>
                /// <para>The disk type of the node. Valid values:</para>
                /// 
                /// <b>Example:</b>
                /// <para>cloud_ssd</para>
                /// </summary>
                [NameInMap("diskType")]
                [Validation(Required=false)]
                public string DiskType { get; set; }

                /// <summary>
                /// <para>The performance level (PL) of the ESSD. This parameter is required when diskType is set to cloud_essd. Valid values: PL1, PL2, and PL3.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PL1</para>
                /// </summary>
                [NameInMap("performanceLevel")]
                [Validation(Required=false)]
                public string PerformanceLevel { get; set; }

                /// <summary>
                /// <para>The node specifications. For more information about specifications, see <a href="https://help.aliyun.com/document_detail/271718.html">Product specifications</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>elasticsearch.n4.small</para>
                /// </summary>
                [NameInMap("spec")]
                [Validation(Required=false)]
                public string Spec { get; set; }

                /// <summary>
                /// <para>The node specifications description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1C 2G</para>
                /// </summary>
                [NameInMap("specInfo")]
                [Validation(Required=false)]
                public string SpecInfo { get; set; }

            }

            /// <summary>
            /// <para>The billing method of the instance. Valid values:</para>
            /// 
            /// <b>Example:</b>
            /// <para>postpaid</para>
            /// </summary>
            [NameInMap("paymentType")]
            [Validation(Required=false)]
            public string PaymentType { get; set; }

            /// <summary>
            /// <para>The access port of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9200</para>
            /// </summary>
            [NameInMap("port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

            /// <summary>
            /// <para>The status of the pay-as-you-go service that is overlaid on the subscription instance. Valid values:</para>
            /// 
            /// <b>Example:</b>
            /// <para>active</para>
            /// </summary>
            [NameInMap("postpaidServiceStatus")]
            [Validation(Required=false)]
            public string PostpaidServiceStatus { get; set; }

            /// <summary>
            /// <para>The private endpoint access whitelist of the instance.</para>
            /// </summary>
            [NameInMap("privateNetworkIpWhiteList")]
            [Validation(Required=false)]
            public List<string> PrivateNetworkIpWhiteList { get; set; }

            /// <summary>
            /// <para>The access protocol. Valid values: HTTP and HTTPS.</para>
            /// 
            /// <b>Example:</b>
            /// <para>HTTP</para>
            /// </summary>
            [NameInMap("protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            /// <summary>
            /// <para>The public endpoint of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>es-cn-3h4k3axh33th9****.elasticsearch.aliyuncs.com</para>
            /// </summary>
            [NameInMap("publicDomain")]
            [Validation(Required=false)]
            public string PublicDomain { get; set; }

            /// <summary>
            /// <para>The public endpoint access whitelist of the instance.</para>
            /// </summary>
            [NameInMap("publicIpWhitelist")]
            [Validation(Required=false)]
            public List<string> PublicIpWhitelist { get; set; }

            /// <summary>
            /// <para>The public network access port of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9200</para>
            /// </summary>
            [NameInMap("publicPort")]
            [Validation(Required=false)]
            public int? PublicPort { get; set; }

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
            /// <para>Indicates whether the instance is a service VPC instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("serviceVpc")]
            [Validation(Required=false)]
            public bool? ServiceVpc { get; set; }

            /// <summary>
            /// <para>The status of the instance. Valid values:</para>
            /// 
            /// <b>Example:</b>
            /// <para>active</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The synonym dictionary configuration.</para>
            /// </summary>
            [NameInMap("synonymsDicts")]
            [Validation(Required=false)]
            public List<DescribeInstanceResponseBodyResultSynonymsDicts> SynonymsDicts { get; set; }
            public class DescribeInstanceResponseBodyResultSynonymsDicts : TeaModel {
                /// <summary>
                /// <para>The size of the dictionary file. Unit: bytes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2782602</para>
                /// </summary>
                [NameInMap("fileSize")]
                [Validation(Required=false)]
                public long? FileSize { get; set; }

                /// <summary>
                /// <para>The name of the dictionary file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SYSTEM_MAIN.dic</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The source type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ORIGIN</para>
                /// </summary>
                [NameInMap("sourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

                /// <summary>
                /// <para>The dictionary type. Valid values:</para>
                /// 
                /// <b>Example:</b>
                /// <para>STOP</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The instance tags.</para>
            /// </summary>
            [NameInMap("tags")]
            [Validation(Required=false)]
            public List<DescribeInstanceResponseBodyResultTags> Tags { get; set; }
            public class DescribeInstanceResponseBodyResultTags : TeaModel {
                /// <summary>
                /// <para>The tag key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>env</para>
                /// </summary>
                [NameInMap("tagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                /// <summary>
                /// <para>The tag value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dev</para>
                /// </summary>
                [NameInMap("tagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

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
            /// <para>The VPC ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-bp1uag5jj38c****</para>
            /// </summary>
            [NameInMap("vpcInstanceId")]
            [Validation(Required=false)]
            public string VpcInstanceId { get; set; }

            /// <summary>
            /// <para>Indicates whether warm data nodes is enabled. Valid values:</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("warmNode")]
            [Validation(Required=false)]
            public bool? WarmNode { get; set; }

            /// <summary>
            /// <para>The configuration information of the warm data node.</para>
            /// </summary>
            [NameInMap("warmNodeConfiguration")]
            [Validation(Required=false)]
            public DescribeInstanceResponseBodyResultWarmNodeConfiguration WarmNodeConfiguration { get; set; }
            public class DescribeInstanceResponseBodyResultWarmNodeConfiguration : TeaModel {
                /// <summary>
                /// <para>The number of nodes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>6</para>
                /// </summary>
                [NameInMap("amount")]
                [Validation(Required=false)]
                public int? Amount { get; set; }

                /// <summary>
                /// <para>The storage space of the node. Unit: GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>500</para>
                /// </summary>
                [NameInMap("disk")]
                [Validation(Required=false)]
                public int? Disk { get; set; }

                /// <summary>
                /// <para>Indicates whether cloud disk encryption is enabled. Valid values:</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("diskEncryption")]
                [Validation(Required=false)]
                public bool? DiskEncryption { get; set; }

                /// <summary>
                /// <para>The storage type of the node. Only cloud_efficiency (ultra disk) is supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cloud_efficiency</para>
                /// </summary>
                [NameInMap("diskType")]
                [Validation(Required=false)]
                public string DiskType { get; set; }

                /// <summary>
                /// <para>The node specifications. For more information about specifications, see <a href="https://help.aliyun.com/document_detail/271718.html">Product specifications</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>elasticsearch.n4.small</para>
                /// </summary>
                [NameInMap("spec")]
                [Validation(Required=false)]
                public string Spec { get; set; }

                /// <summary>
                /// <para>The description of the node specifications.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1C 2G</para>
                /// </summary>
                [NameInMap("specInfo")]
                [Validation(Required=false)]
                public string SpecInfo { get; set; }

            }

            /// <summary>
            /// <para>The number of zones for the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("zoneCount")]
            [Validation(Required=false)]
            public int? ZoneCount { get; set; }

            /// <summary>
            /// <para>The zone information.</para>
            /// </summary>
            [NameInMap("zoneInfos")]
            [Validation(Required=false)]
            public List<DescribeInstanceResponseBodyResultZoneInfos> ZoneInfos { get; set; }
            public class DescribeInstanceResponseBodyResultZoneInfos : TeaModel {
                /// <summary>
                /// <para>The zone status. Valid values:</para>
                /// 
                /// <b>Example:</b>
                /// <para>NORMAL</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The zone ID.</para>
                /// 
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
