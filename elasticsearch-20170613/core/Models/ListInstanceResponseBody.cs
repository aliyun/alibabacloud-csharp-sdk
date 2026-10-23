// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ListInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The response headers.</para>
        /// </summary>
        [NameInMap("Headers")]
        [Validation(Required=false)]
        public ListInstanceResponseBodyHeaders Headers { get; set; }
        public class ListInstanceResponseBodyHeaders : TeaModel {
            /// <summary>
            /// <para>The total number of instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("X-Total-Count")]
            [Validation(Required=false)]
            public int? XTotalCount { get; set; }

        }

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
        /// <para>The response result.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListInstanceResponseBodyResult> Result { get; set; }
        public class ListInstanceResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>Indicates whether dedicated master nodes are included. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Included.</description></item>
            /// <item><description>false: Not included.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("advancedDedicateMaster")]
            [Validation(Required=false)]
            public bool? AdvancedDedicateMaster { get; set; }

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
            public ListInstanceResponseBodyResultClientNodeConfiguration ClientNodeConfiguration { get; set; }
            public class ListInstanceResponseBodyResultClientNodeConfiguration : TeaModel {
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
                /// <para>The storage type of the node. Only ultra disks (cloud_efficiency) are supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cloud_efficiency</para>
                /// </summary>
                [NameInMap("diskType")]
                [Validation(Required=false)]
                public string DiskType { get; set; }

                /// <summary>
                /// <para>The node specifications. For more information, see <a href="https://help.aliyun.com/document_detail/271718.html">Product specifications</a>.</para>
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
            /// <para>The time when the instance was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2018-07-13T03:58:07.253Z</para>
            /// </summary>
            [NameInMap("createdAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            /// <summary>
            /// <para><b>[Deprecated]</b> Indicates whether dedicated master nodes are included. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Included.</description></item>
            /// <item><description>false: Not included.</description></item>
            /// </list>
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
            /// <para>The internal network address of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>es-cn-nif1q8auz0005****.elasticsearch.aliyuncs.com</para>
            /// </summary>
            [NameInMap("domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// <para>The elastic data node configuration.</para>
            /// </summary>
            [NameInMap("elasticDataNodeConfiguration")]
            [Validation(Required=false)]
            public ListInstanceResponseBodyResultElasticDataNodeConfiguration ElasticDataNodeConfiguration { get; set; }
            public class ListInstanceResponseBodyResultElasticDataNodeConfiguration : TeaModel {
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
                /// <para>The node specifications. For more information, see <a href="https://help.aliyun.com/document_detail/271718.html">Product specifications</a>.</para>
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
            /// <para>The time when the instance expires.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1715826092044</para>
            /// </summary>
            [NameInMap("endTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <para>The Elasticsearch version of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6.7_with_X-Pack</para>
            /// </summary>
            [NameInMap("esVersion")]
            [Validation(Required=false)]
            public string EsVersion { get; set; }

            /// <summary>
            /// <para>The extension parameter settings of the cluster.</para>
            /// </summary>
            [NameInMap("extendConfigs")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> ExtendConfigs { get; set; }

            /// <summary>
            /// <para>The index node information. This is supported only by AI engine instances.</para>
            /// </summary>
            [NameInMap("indexNodeConfiguration")]
            [Validation(Required=false)]
            public IndexNodeConfiguration IndexNodeConfiguration { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>es-cn-v641a0ta3000g****</para>
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
            public string IsNewDeployment { get; set; }

            /// <summary>
            /// <para>The Kibana node configuration.</para>
            /// </summary>
            [NameInMap("kibanaConfiguration")]
            [Validation(Required=false)]
            public ListInstanceResponseBodyResultKibanaConfiguration KibanaConfiguration { get; set; }
            public class ListInstanceResponseBodyResultKibanaConfiguration : TeaModel {
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
                /// <para>The storage space of the node. Unit: GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("disk")]
                [Validation(Required=false)]
                public int? Disk { get; set; }

                /// <summary>
                /// <para>The storage type of the node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cloud_ssd</para>
                /// </summary>
                [NameInMap("diskType")]
                [Validation(Required=false)]
                public string DiskType { get; set; }

                /// <summary>
                /// <para>The node specifications. For more information, see <a href="https://help.aliyun.com/document_detail/271718.html">Product specifications</a>.</para>
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
            /// <para>The public network access whitelist for the Kibana node of the cluster.</para>
            /// </summary>
            [NameInMap("kibanaIPWhitelist")]
            [Validation(Required=false)]
            public List<string> KibanaIPWhitelist { get; set; }

            /// <summary>
            /// <para>The private network access whitelist for the Kibana node of the cluster.</para>
            /// </summary>
            [NameInMap("kibanaPrivateIPWhitelist")]
            [Validation(Required=false)]
            public List<string> KibanaPrivateIPWhitelist { get; set; }

            /// <summary>
            /// <para>The master node configuration.</para>
            /// </summary>
            [NameInMap("masterConfiguration")]
            [Validation(Required=false)]
            public ListInstanceResponseBodyResultMasterConfiguration MasterConfiguration { get; set; }
            public class ListInstanceResponseBodyResultMasterConfiguration : TeaModel {
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
                /// <para>The storage type of the node. Only standard SSDs (cloud_ssd) are supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cloud_ssd</para>
                /// </summary>
                [NameInMap("diskType")]
                [Validation(Required=false)]
                public string DiskType { get; set; }

                /// <summary>
                /// <para>The node specifications. For more information, see <a href="https://help.aliyun.com/document_detail/271718.html">Product specifications</a>.</para>
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
            /// <para>The network configurations.</para>
            /// </summary>
            [NameInMap("networkConfig")]
            [Validation(Required=false)]
            public ListInstanceResponseBodyResultNetworkConfig NetworkConfig { get; set; }
            public class ListInstanceResponseBodyResultNetworkConfig : TeaModel {
                /// <summary>
                /// <para>The network type. Only virtual private clouds (VPCs) are supported.</para>
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
                /// <para>cn-hangzhou-e</para>
                /// </summary>
                [NameInMap("vsArea")]
                [Validation(Required=false)]
                public string VsArea { get; set; }

                /// <summary>
                /// <para>The vSwitch ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-def</para>
                /// </summary>
                [NameInMap("vswitchId")]
                [Validation(Required=false)]
                public string VswitchId { get; set; }

                /// <summary>
                /// <para>The public and private network whitelist group settings for the cluster.</para>
                /// </summary>
                [NameInMap("whiteIpGroupList")]
                [Validation(Required=false)]
                public List<ListInstanceResponseBodyResultNetworkConfigWhiteIpGroupList> WhiteIpGroupList { get; set; }
                public class ListInstanceResponseBodyResultNetworkConfigWhiteIpGroupList : TeaModel {
                    /// <summary>
                    /// <para>The name of the group.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>default</para>
                    /// </summary>
                    [NameInMap("groupName")]
                    [Validation(Required=false)]
                    public string GroupName { get; set; }

                    /// <summary>
                    /// <para>The network whitelist.</para>
                    /// </summary>
                    [NameInMap("ips")]
                    [Validation(Required=false)]
                    public List<string> Ips { get; set; }

                    /// <summary>
                    /// <para>The network type. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>PRIVATE_ES: Elasticsearch private network.</description></item>
                    /// <item><description>PUBLIC_KIBANA: Kibana public network.</description></item>
                    /// <item><description>PUBLIC_ES: Elasticsearch public network.</description></item>
                    /// <item><description>PRIVATE_KIBANA: Kibana private network.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>PUBLIC_KIBANA</para>
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
            /// <para>The data node configurations.</para>
            /// </summary>
            [NameInMap("nodeSpec")]
            [Validation(Required=false)]
            public ListInstanceResponseBodyResultNodeSpec NodeSpec { get; set; }
            public class ListInstanceResponseBodyResultNodeSpec : TeaModel {
                /// <summary>
                /// <para>The storage space of the node. Unit: GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("disk")]
                [Validation(Required=false)]
                public int? Disk { get; set; }

                /// <summary>
                /// <para>Indicates whether disk encryption is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: Enabled.</description></item>
                /// <item><description>false: Disabled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
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
                /// <para>The storage type of the node. Valid values:</para>
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
                /// <para>The performance level (PL) of the ESSD cloud disk. This parameter is required when diskType is set to cloud_essd, and does not apply to a standard SSD. Valid values: PL1, PL2, and PL3.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PL1</para>
                /// </summary>
                [NameInMap("performanceLevel")]
                [Validation(Required=false)]
                public string PerformanceLevel { get; set; }

                /// <summary>
                /// <para>The node specifications. For more information, see <a href="https://help.aliyun.com/document_detail/271718.html">Product specifications</a>.</para>
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
            /// <item><description><b>prepaid</b>: Subscription.</description></item>
            /// <item><description><b>postpaid</b>: Pay-as-you-go.</description></item>
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
            /// <remarks>
            /// <para>Notice: If the instance is being created or is in an abnormal state, this value may be null or 0.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>9200</para>
            /// </summary>
            [NameInMap("port")]
            [Validation(Required=false)]
            public string Port { get; set; }

            /// <summary>
            /// <para>The status of the pay-as-you-go service attached to a subscription instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>active</b>: Normal.</description></item>
            /// <item><description><b>closed</b>: Disabled.</description></item>
            /// <item><description><b>indebt</b>: Frozen due to overdue payments.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>active</para>
            /// </summary>
            [NameInMap("postpaidServiceStatus")]
            [Validation(Required=false)]
            public string PostpaidServiceStatus { get; set; }

            /// <summary>
            /// <para>The private network access whitelist for the Elasticsearch cluster.</para>
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
            /// <para>The public access whitelist for the Elasticsearch cluster.</para>
            /// </summary>
            [NameInMap("publicIpWhitelist")]
            [Validation(Required=false)]
            public List<string> PublicIpWhitelist { get; set; }

            /// <summary>
            /// <para>The resource group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-aekzvowej3i****</para>
            /// </summary>
            [NameInMap("resourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The search node configuration. This is supported only by AI engine instances.</para>
            /// </summary>
            [NameInMap("searchNodeConfiguration")]
            [Validation(Required=false)]
            public SearchNodeConfiguration SearchNodeConfiguration { get; set; }

            /// <summary>
            /// <para>Indicates whether the VPC is a service VPC.</para>
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
            /// <item><description>invalid: Invalid. The cluster does not exist or is inaccessible. In this case, some fields such as domain and kibanaDomain may be missing from the response.</description></item>
            /// <item><description>unknown: Unknown. The cluster does not exist or is inaccessible. In this case, some fields such as domain and kibanaDomain may be missing from the response.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>active</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The instance tags.</para>
            /// </summary>
            [NameInMap("tags")]
            [Validation(Required=false)]
            public List<ListInstanceResponseBodyResultTags> Tags { get; set; }
            public class ListInstanceResponseBodyResultTags : TeaModel {
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
            /// <para>2018-07-18T10:10:04.484Z</para>
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
            /// <para>The number of zones.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("zoneCount")]
            [Validation(Required=false)]
            public int? ZoneCount { get; set; }

            /// <summary>
            /// <para>The zone information.</para>
            /// </summary>
            [NameInMap("zoneInfos")]
            [Validation(Required=false)]
            public List<ListInstanceResponseBodyResultZoneInfos> ZoneInfos { get; set; }
            public class ListInstanceResponseBodyResultZoneInfos : TeaModel {
                /// <summary>
                /// <para>The status of the zone. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>NORMAL: Normal.</description></item>
                /// <item><description>ISOLATION: Isolated.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>NORMAL</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The zone ID, such as cn-hangzhou-i.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou-i</para>
                /// </summary>
                [NameInMap("zoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

    }

}
