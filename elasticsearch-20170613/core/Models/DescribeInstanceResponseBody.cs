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
        /// <para>The result.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public DescribeInstanceResponseBodyResult Result { get; set; }
        public class DescribeInstanceResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>Indicates whether dedicated master nodes are included. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Included.</description></item>
            /// <item><description>false: Not included.</description></item>
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
            /// <para>The AliWS dictionary configurations.</para>
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
                /// <list type="bullet">
                /// <item><description>OSS: Object Storage Service (OSS). Make sure that the OSS bucket is publicly readable.</description></item>
                /// <item><description>ORIGIN: Open-source Elasticsearch.</description></item>
                /// <item><description>UPLOAD: Uploaded file.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>OSS</para>
                /// </summary>
                [NameInMap("sourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

                /// <summary>
                /// <para>The type of the dictionary file. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>STOP: Stopword dictionary.</description></item>
                /// <item><description>MAIN: Main dictionary.</description></item>
                /// <item><description>SYNONYMS: Synonym dictionary.</description></item>
                /// <item><description>ALI_WS: AliWS dictionary.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ALI_WS</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The deployment mode and architecture type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>exclusive: Basic management and control.</description></item>
            /// <item><description>public: Cloud-native management and control.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>public</para>
            /// </summary>
            [NameInMap("archType")]
            [Validation(Required=false)]
            public string ArchType { get; set; }

            /// <summary>
            /// <para>The client node configuration.</para>
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
                /// <para>The storage type of the node. Only ultra disks (cloud_efficiency) are supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cloud_efficiency</para>
                /// </summary>
                [NameInMap("diskType")]
                [Validation(Required=false)]
                public string DiskType { get; set; }

                /// <summary>
                /// <para>The node specifications. For more information, see <a href="https://help.aliyun.com/document_detail/271718.html">Instance specifications</a>.</para>
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
            /// <para>The name of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>es-cn-abc</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The IK dictionary configurations.</para>
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
                /// <list type="bullet">
                /// <item><description>OSS: Object Storage Service (OSS). Make sure that the OSS bucket is publicly readable.</description></item>
                /// <item><description>ORIGIN: Open-source Elasticsearch.</description></item>
                /// <item><description>UPLOAD: Uploaded file.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ORIGIN</para>
                /// </summary>
                [NameInMap("sourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

                /// <summary>
                /// <para>The type of the dictionary file. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>STOP: Stopword dictionary.</description></item>
                /// <item><description>MAIN: Main dictionary.</description></item>
                /// <item><description>SYNONYMS: Synonym dictionary.</description></item>
                /// <item><description>ALI_WS: AliWS dictionary.</description></item>
                /// </list>
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
            /// <para>The elastic data node configuration.</para>
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
                /// <list type="bullet">
                /// <item><description>true: Enabled.</description></item>
                /// <item><description>false: Disabled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("diskEncryption")]
                [Validation(Required=false)]
                public bool? DiskEncryption { get; set; }

                /// <summary>
                /// <para>The storage type of the node. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>cloud_ssd: Standard SSD.</description></item>
                /// <item><description>cloud_essd: ESSD.</description></item>
                /// <item><description>cloud_efficiency: Ultra disk.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>cloud_ssd</para>
                /// </summary>
                [NameInMap("diskType")]
                [Validation(Required=false)]
                public string DiskType { get; set; }

                /// <summary>
                /// <para>The node specifications. For more information, see <a href="https://help.aliyun.com/document_detail/271718.html">Instance specifications</a>.</para>
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
            /// <para>Indicates whether the public endpoint of the instance is enabled. Valid values:</para>
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
            /// <para>The time when the instance expires. The value is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1715826092044</para>
            /// </summary>
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
            /// <para>The version of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6.3.2_with_X-Pack</para>
            /// </summary>
            [NameInMap("esVersion")]
            [Validation(Required=false)]
            public string EsVersion { get; set; }

            /// <summary>
            /// <para>The array of extended configurations for the instance.</para>
            /// </summary>
            [NameInMap("extendConfigs")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> ExtendConfigs { get; set; }

            /// <summary>
            /// <para>Indicates whether client nodes are included. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Included.</description></item>
            /// <item><description>false: Not included.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("haveClientNode")]
            [Validation(Required=false)]
            public bool? HaveClientNode { get; set; }

            /// <summary>
            /// <para>Indicates whether Kibana nodes are included. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Included.</description></item>
            /// <item><description>false: Not included.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("haveKibana")]
            [Validation(Required=false)]
            public bool? HaveKibana { get; set; }

            /// <summary>
            /// <para>The IK dictionary hot update configurations.</para>
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
                /// <list type="bullet">
                /// <item><description>OSS: OSS.</description></item>
                /// <item><description>ORIGIN: Previously uploaded dictionary.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>OSS</para>
                /// </summary>
                [NameInMap("sourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

                /// <summary>
                /// <para>The type of the dictionary to be updated. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>MAIN: IK main dictionary.</description></item>
                /// <item><description>STOP: IK stopword dictionary.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>MAIN</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The index node information. This parameter is supported only by AI engine instances.</para>
            /// </summary>
            [NameInMap("indexNodeConfiguration")]
            [Validation(Required=false)]
            public IndexNodeConfiguration IndexNodeConfiguration { get; set; }

            /// <summary>
            /// <para>Indicates whether the initialization is complete.</para>
            /// </summary>
            [NameInMap("inited")]
            [Validation(Required=false)]
            public bool? Inited { get; set; }

            /// <summary>
            /// <para>The edition type of the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>x-pack: Commercial Edition.</description></item>
            /// <item><description>advanced/IS: Advanced Edition.</description></item>
            /// <item><description>community: Basic Edition.</description></item>
            /// </list>
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
            /// <para>Indicates whether the new deployment architecture is used.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("isNewDeployment")]
            [Validation(Required=false)]
            public bool? IsNewDeployment { get; set; }

            /// <summary>
            /// <para>The Kibana node configuration.</para>
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
                /// <para>The storage space of a single node. Unit: GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("disk")]
                [Validation(Required=false)]
                public int? Disk { get; set; }

                /// <summary>
                /// <para>The node specifications. For more information, see <a href="https://help.aliyun.com/document_detail/271718.html">Instance specifications</a>.</para>
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
            /// <para>The public network access whitelist for Kibana.</para>
            /// </summary>
            [NameInMap("kibanaIPWhitelist")]
            [Validation(Required=false)]
            public List<string> KibanaIPWhitelist { get; set; }

            /// <summary>
            /// <para>The access port for Kibana.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5601</para>
            /// </summary>
            [NameInMap("kibanaPort")]
            [Validation(Required=false)]
            public int? KibanaPort { get; set; }

            /// <summary>
            /// <para>The private endpoint for Kibana.</para>
            /// 
            /// <b>Example:</b>
            /// <para>es-cn-x0r3*********.elasticsearch.aliyuncs.com</para>
            /// </summary>
            [NameInMap("kibanaPrivateDomain")]
            [Validation(Required=false)]
            public string KibanaPrivateDomain { get; set; }

            /// <summary>
            /// <para>The private network access whitelist for Kibana.</para>
            /// </summary>
            [NameInMap("kibanaPrivateIPWhitelist")]
            [Validation(Required=false)]
            public List<string> KibanaPrivateIPWhitelist { get; set; }

            /// <summary>
            /// <para>The private network port for Kibana.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5601</para>
            /// </summary>
            [NameInMap("kibanaPrivatePort")]
            [Validation(Required=false)]
            public string KibanaPrivatePort { get; set; }

            /// <summary>
            /// <para>The master node configuration.</para>
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
                /// <para>The storage type of the dedicated master node. Only cloud_ssd (standard SSD) is supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cloud_ssd</para>
                /// </summary>
                [NameInMap("diskType")]
                [Validation(Required=false)]
                public string DiskType { get; set; }

                /// <summary>
                /// <para>The node specifications. For more information, see <a href="https://help.aliyun.com/document_detail/271718.html">Instance specifications</a>.</para>
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
                /// <para>The network type. Only VPC (Virtual Private Cloud) is supported.</para>
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
                /// <para>The list of whitelist groups.</para>
                /// </summary>
                [NameInMap("whiteIpGroupList")]
                [Validation(Required=false)]
                public List<DescribeInstanceResponseBodyResultNetworkConfigWhiteIpGroupList> WhiteIpGroupList { get; set; }
                public class DescribeInstanceResponseBodyResultNetworkConfigWhiteIpGroupList : TeaModel {
                    /// <summary>
                    /// <para>The name of the whitelist group. By default, the default group is included.</para>
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
                    /// <list type="bullet">
                    /// <item><description>PRIVATE_ES: Private network of Elasticsearch.</description></item>
                    /// <item><description>PUBLIC_ES: Public network of Elasticsearch.</description></item>
                    /// <item><description>PRIVATE_KIBANA: Private network of Kibana.</description></item>
                    /// <item><description>PUBLIC_KIBANA: Public network of Kibana.</description></item>
                    /// </list>
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
            /// <para>The configuration of the data nodes.</para>
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
                /// <para>Specifies whether cloud disk encryption is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: Enabled.</description></item>
                /// <item><description>false: Disabled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("diskEncryption")]
                [Validation(Required=false)]
                public bool? DiskEncryption { get; set; }

                /// <summary>
                /// <para>The storage preference. Default value: high_availability. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>high_availability: High availability.</description></item>
                /// <item><description>high_cost_performance: High cost-effectiveness.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>high_availability</para>
                /// </summary>
                [NameInMap("diskPreference")]
                [Validation(Required=false)]
                public string DiskPreference { get; set; }

                /// <summary>
                /// <para>The disk type of the node. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>cloud_ssd: Standard SSD.</description></item>
                /// <item><description>cloud_efficiency: Ultra disk.</description></item>
                /// </list>
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
                /// <para>The node specifications. For more information, see <a href="https://help.aliyun.com/document_detail/271718.html">Instance specifications</a>.</para>
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
            /// <para>The billing method of the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>prepaid: Subscription.</description></item>
            /// <item><description>postpaid: Pay-as-you-go.</description></item>
            /// </list>
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
            /// <para>The status of the pay-as-you-go service added to a subscription instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>active: Normal.</description></item>
            /// <item><description>closed: Disabled.</description></item>
            /// <item><description>indebt: Frozen due to an overdue payment.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>active</para>
            /// </summary>
            [NameInMap("postpaidServiceStatus")]
            [Validation(Required=false)]
            public string PostpaidServiceStatus { get; set; }

            /// <summary>
            /// <para>The private network IP address whitelist of the instance.</para>
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
            /// <para>The public network IP address whitelist of the instance.</para>
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
            /// <para>The search node configuration. This feature is only supported by instances with the AI engine.</para>
            /// </summary>
            [NameInMap("searchNodeConfiguration")]
            [Validation(Required=false)]
            public SearchNodeConfiguration SearchNodeConfiguration { get; set; }

            /// <summary>
            /// <para>Specifies whether the VPC is a service VPC.</para>
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
            /// <item><description>activating: Activating.</description></item>
            /// <item><description>inactive: Frozen.</description></item>
            /// <item><description>invalid: Invalid. The cluster does not exist or is inaccessible. In this case, some fields such as domain and kibanaDomain may be missing in the response.</description></item>
            /// <item><description>unknown: Unknown. The cluster does not exist or is inaccessible. In this case, some fields such as domain and kibanaDomain may be missing in the response.</description></item>
            /// </list>
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
                /// <list type="bullet">
                /// <item><description>STOP: Stopword dictionary.</description></item>
                /// <item><description>MAIN: Main dictionary.</description></item>
                /// <item><description>SYNONYMS: Synonym dictionary.</description></item>
                /// <item><description>ALI_WS: Alibaba Cloud dictionary.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>STOP</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The instance labels.</para>
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
            /// <para>Specifies whether warm data nodes are enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Enabled.</description></item>
            /// <item><description>false: Disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("warmNode")]
            [Validation(Required=false)]
            public bool? WarmNode { get; set; }

            /// <summary>
            /// <para>The configuration of the warm data nodes.</para>
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
                /// <para>Specifies whether cloud disk encryption is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: Enabled.</description></item>
                /// <item><description>false: Disabled.</description></item>
                /// </list>
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
                /// <para>The node specifications. For more information, see <a href="https://help.aliyun.com/document_detail/271718.html">Instance specifications</a>.</para>
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
                /// <para>The status of the zone. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>ISOLATION: Offline.</description></item>
                /// <item><description>NORMAL: Normal.</description></item>
                /// </list>
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
