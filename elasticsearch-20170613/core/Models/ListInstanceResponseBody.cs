// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ListInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The status of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>active: normal</description></item>
        /// <item><description>activating: taking effect</description></item>
        /// <item><description>inactive: frozen</description></item>
        /// <item><description>invalid: invalid</description></item>
        /// </list>
        /// </summary>
        [NameInMap("Headers")]
        [Validation(Required=false)]
        public ListInstanceResponseBodyHeaders Headers { get; set; }
        public class ListInstanceResponseBodyHeaders : TeaModel {
            /// <summary>
            /// <para>Specifies whether to include dedicated master nodes (obsolete). Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: The files contain data that is dumped to the IA storage medium.</description></item>
            /// <item><description>false: The files do not contain data that is dumped to the IA storage medium.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("X-Total-Count")]
            [Validation(Required=false)]
            public int? XTotalCount { get; set; }

        }

        /// <summary>
        /// <para>The time when the node is created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5FFD9ED4-C2EC-4E89-B22B-1ACB6FE1****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether it is a service VPC.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListInstanceResponseBodyResult> Result { get; set; }
        public class ListInstanceResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The billing method of the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>prepaid</b>: subscription</description></item>
            /// <item><description><b>postpaid</b>: pay-as-you-go</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("advancedDedicateMaster")]
            [Validation(Required=false)]
            public bool? AdvancedDedicateMaster { get; set; }

            [NameInMap("archType")]
            [Validation(Required=false)]
            public string ArchType { get; set; }

            /// <summary>
            /// <para>The instance type of the node. For more information, see <a href="https://help.aliyun.com/document_detail/271718.html">Specifications</a>.</para>
            /// </summary>
            [NameInMap("clientNodeConfiguration")]
            [Validation(Required=false)]
            public ListInstanceResponseBodyResultClientNodeConfiguration ClientNodeConfiguration { get; set; }
            public class ListInstanceResponseBodyResultClientNodeConfiguration : TeaModel {
                /// <summary>
                /// <para>The size of the node storage space. Unit: GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("amount")]
                [Validation(Required=false)]
                public int? Amount { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable disk encryption for the node. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: enables instant image cache.</description></item>
                /// <item><description>false: disables reuse of image cache layers.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("disk")]
                [Validation(Required=false)]
                public int? Disk { get; set; }

                /// <summary>
                /// <para>The storage type of the node. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>cloud_ssd: SSD.</description></item>
                /// <item><description>cloud_essd: ESSD.</description></item>
                /// <item><description>cloud_efficiency: ultra disk</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>cloud_efficiency</para>
                /// </summary>
                [NameInMap("diskType")]
                [Validation(Required=false)]
                public string DiskType { get; set; }

                /// <summary>
                /// <para>The number of nodes.</para>
                /// 
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
            /// <para>The status of the pay-as-you-go service that is overlaid on a subscription instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>active</b>: normal</description></item>
            /// <item><description><b>closed</b>: Close</description></item>
            /// <item><description><b>indebt</b>: Overdue payments are frozen</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2018-07-13T03:58:07.253Z</para>
            /// </summary>
            [NameInMap("createdAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            /// <summary>
            /// <para>The edition of the dedicated KMS instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("dedicateMaster")]
            [Validation(Required=false)]
            public bool? DedicateMaster { get; set; }

            /// <summary>
            /// <para>The key of the tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>es-cn-abc</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// <para>The configuration of Kibana nodes.</para>
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
                /// <para>The size of the node storage space. Unit: GB.</para>
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
                /// <para>true</para>
                /// </summary>
                [NameInMap("diskEncryption")]
                [Validation(Required=false)]
                public bool? DiskEncryption { get; set; }

                /// <summary>
                /// <para>The configuration of dedicated master nodes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cloud_ssd</para>
                /// </summary>
                [NameInMap("diskType")]
                [Validation(Required=false)]
                public string DiskType { get; set; }

                /// <summary>
                /// <para>The instance type of the node. For more information, see <a href="https://help.aliyun.com/document_detail/271718.html">Specifications</a>.</para>
                /// 
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

            [NameInMap("endTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <para>The value of the tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6.7_with_X-Pack</para>
            /// </summary>
            [NameInMap("esVersion")]
            [Validation(Required=false)]
            public string EsVersion { get; set; }

            /// <summary>
            /// <para>The configurations of elastic data nodes.</para>
            /// </summary>
            [NameInMap("extendConfigs")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> ExtendConfigs { get; set; }

            /// <summary>
            /// <para>The instance type of the node. For more information, see <a href="https://help.aliyun.com/document_detail/271718.html">Specifications</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>es-cn-v641a0ta3000g****</para>
            /// </summary>
            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The configuration of cluster extension parameters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("isNewDeployment")]
            [Validation(Required=false)]
            public string IsNewDeployment { get; set; }

            /// <summary>
            /// <para>The instance type of the node. For more information, see <a href="https://help.aliyun.com/document_detail/271718.html">Specifications</a>.</para>
            /// </summary>
            [NameInMap("kibanaConfiguration")]
            [Validation(Required=false)]
            public ListInstanceResponseBodyResultKibanaConfiguration KibanaConfiguration { get; set; }
            public class ListInstanceResponseBodyResultKibanaConfiguration : TeaModel {
                /// <summary>
                /// <para>The size of the node storage space. Unit: GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("amount")]
                [Validation(Required=false)]
                public int? Amount { get; set; }

                /// <summary>
                /// <para>The storage type of the node. Only cloud_ssd(SSD cloud disk) is supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("disk")]
                [Validation(Required=false)]
                public int? Disk { get; set; }

                /// <summary>
                /// <para>The network configurations.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cloud_ssd</para>
                /// </summary>
                [NameInMap("diskType")]
                [Validation(Required=false)]
                public string DiskType { get; set; }

                /// <summary>
                /// <para>The number of nodes.</para>
                /// 
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

            [NameInMap("kibanaIPWhitelist")]
            [Validation(Required=false)]
            public List<string> KibanaIPWhitelist { get; set; }

            [NameInMap("kibanaPrivateIPWhitelist")]
            [Validation(Required=false)]
            public List<string> KibanaPrivateIPWhitelist { get; set; }

            /// <summary>
            /// <para>The VPC ID of the cluster.</para>
            /// </summary>
            [NameInMap("masterConfiguration")]
            [Validation(Required=false)]
            public ListInstanceResponseBodyResultMasterConfiguration MasterConfiguration { get; set; }
            public class ListInstanceResponseBodyResultMasterConfiguration : TeaModel {
                /// <summary>
                /// <para>The network type. Only Virtual Private Cloud (VPC) is supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("amount")]
                [Validation(Required=false)]
                public int? Amount { get; set; }

                /// <summary>
                /// <para>The vSwitch ID of the cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("disk")]
                [Validation(Required=false)]
                public int? Disk { get; set; }

                /// <summary>
                /// <para>The configuration of data nodes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cloud_ssd</para>
                /// </summary>
                [NameInMap("diskType")]
                [Validation(Required=false)]
                public string DiskType { get; set; }

                /// <summary>
                /// <para>The zone where the cluster resides.</para>
                /// 
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
            /// <para>The instance type of the node. For more information, see <a href="https://help.aliyun.com/document_detail/271718.html">Specifications</a>.</para>
            /// </summary>
            [NameInMap("networkConfig")]
            [Validation(Required=false)]
            public ListInstanceResponseBodyResultNetworkConfig NetworkConfig { get; set; }
            public class ListInstanceResponseBodyResultNetworkConfig : TeaModel {
                /// <summary>
                /// <para>The storage type of the node. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>cloud_ssd: standard SSD</description></item>
                /// <item><description>cloud_efficiency: ultra disk</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>vpc</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The storage space of the node. Unit: GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-abc</para>
                /// </summary>
                [NameInMap("vpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                /// <summary>
                /// <para>Specifies whether to use disk encryption. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true</description></item>
                /// <item><description>false</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou-e</para>
                /// </summary>
                [NameInMap("vsArea")]
                [Validation(Required=false)]
                public string VsArea { get; set; }

                /// <summary>
                /// <para>The performance level of the ESSD. This parameter is required when the diskType parameter is set to cloud_essd. Valid values: PL1, PL2, and PL3.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-def</para>
                /// </summary>
                [NameInMap("vswitchId")]
                [Validation(Required=false)]
                public string VswitchId { get; set; }

                [NameInMap("whiteIpGroupList")]
                [Validation(Required=false)]
                public List<ListInstanceResponseBodyResultNetworkConfigWhiteIpGroupList> WhiteIpGroupList { get; set; }
                public class ListInstanceResponseBodyResultNetworkConfigWhiteIpGroupList : TeaModel {
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
                    /// <para>PUBLIC_KIBANA</para>
                    /// </summary>
                    [NameInMap("whiteIpType")]
                    [Validation(Required=false)]
                    public string WhiteIpType { get; set; }

                }

            }

            /// <summary>
            /// <para>The ID of the resource group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("nodeAmount")]
            [Validation(Required=false)]
            public int? NodeAmount { get; set; }

            /// <summary>
            /// <para>The VPC ID of the cluster.</para>
            /// </summary>
            [NameInMap("nodeSpec")]
            [Validation(Required=false)]
            public ListInstanceResponseBodyResultNodeSpec NodeSpec { get; set; }
            public class ListInstanceResponseBodyResultNodeSpec : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("disk")]
                [Validation(Required=false)]
                public int? Disk { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
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
            /// <para>The time when the instance was last updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>postpaid</para>
            /// </summary>
            [NameInMap("paymentType")]
            [Validation(Required=false)]
            public string PaymentType { get; set; }

            [NameInMap("port")]
            [Validation(Required=false)]
            public string Port { get; set; }

            /// <summary>
            /// <para>The tags of the instance. Each tag is a key-value pair.</para>
            /// 
            /// <b>Example:</b>
            /// <para>active</para>
            /// </summary>
            [NameInMap("postpaidServiceStatus")]
            [Validation(Required=false)]
            public string PostpaidServiceStatus { get; set; }

            [NameInMap("privateNetworkIpWhiteList")]
            [Validation(Required=false)]
            public List<string> PrivateNetworkIpWhiteList { get; set; }

            [NameInMap("protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            [NameInMap("publicIpWhitelist")]
            [Validation(Required=false)]
            public List<string> PublicIpWhitelist { get; set; }

            /// <summary>
            /// <para>The ID of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-aekzvowej3i****</para>
            /// </summary>
            [NameInMap("resourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>Specifies whether to deploy the new architecture.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("serviceVpc")]
            [Validation(Required=false)]
            public bool? ServiceVpc { get; set; }

            /// <summary>
            /// <para>The name of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>active</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The number of nodes.</para>
            /// </summary>
            [NameInMap("tags")]
            [Validation(Required=false)]
            public List<ListInstanceResponseBodyResultTags> Tags { get; set; }
            public class ListInstanceResponseBodyResultTags : TeaModel {
                /// <summary>
                /// <para>The size of the node storage space. Unit: GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>env</para>
                /// </summary>
                [NameInMap("tagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                /// <summary>
                /// <para>The storage type of the node. Only ultra disks (cloud_efficiency) are supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dev</para>
                /// </summary>
                [NameInMap("tagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

            /// <summary>
            /// <para>Coordination node configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2018-07-18T10:10:04.484Z</para>
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

        }

    }

}
