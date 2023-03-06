// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ListInstanceResponseBody : TeaModel {
        /// <summary>
        /// The header of the response.
        /// </summary>
        [NameInMap("Headers")]
        [Validation(Required=false)]
        public ListInstanceResponseBodyHeaders Headers { get; set; }
        public class ListInstanceResponseBodyHeaders : TeaModel {
            /// <summary>
            /// The number of entries returned per page.
            /// </summary>
            [NameInMap("X-Total-Count")]
            [Validation(Required=false)]
            public int? XTotalCount { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The returned data.
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListInstanceResponseBodyResult> Result { get; set; }
        public class ListInstanceResponseBodyResult : TeaModel {
            /// <summary>
            /// Specifies whether to include dedicated master nodes. Valid values:
            /// 
            /// *   true: The files contain data that is dumped to the IA storage medium.
            /// *   false: The files do not contain data that is dumped to the IA storage medium.
            /// </summary>
            [NameInMap("advancedDedicateMaster")]
            [Validation(Required=false)]
            public bool? AdvancedDedicateMaster { get; set; }

            /// <summary>
            /// Coordination node configuration.
            /// </summary>
            [NameInMap("clientNodeConfiguration")]
            [Validation(Required=false)]
            public ListInstanceResponseBodyResultClientNodeConfiguration ClientNodeConfiguration { get; set; }
            public class ListInstanceResponseBodyResultClientNodeConfiguration : TeaModel {
                /// <summary>
                /// The number of nodes.
                /// </summary>
                [NameInMap("amount")]
                [Validation(Required=false)]
                public int? Amount { get; set; }

                /// <summary>
                /// The size of the node storage space. Unit: GB.
                /// </summary>
                [NameInMap("disk")]
                [Validation(Required=false)]
                public int? Disk { get; set; }

                /// <summary>
                /// The storage type of the node. Only ultra disks (cloud_efficiency) are supported.
                /// </summary>
                [NameInMap("diskType")]
                [Validation(Required=false)]
                public string DiskType { get; set; }

                /// <summary>
                /// The instance type of the node. For more information, see [Specifications](~~271718~~).
                /// </summary>
                [NameInMap("spec")]
                [Validation(Required=false)]
                public string Spec { get; set; }

            }

            /// <summary>
            /// The time when the node is created.
            /// </summary>
            [NameInMap("createdAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            /// <summary>
            /// Specifies whether to include dedicated master nodes (obsolete). Valid values:
            /// 
            /// *   true: The files contain data that is dumped to the IA storage medium.
            /// *   false: The files do not contain data that is dumped to the IA storage medium.
            /// </summary>
            [NameInMap("dedicateMaster")]
            [Validation(Required=false)]
            public bool? DedicateMaster { get; set; }

            /// <summary>
            /// The name of the instance.
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The configurations of elastic data nodes.
            /// </summary>
            [NameInMap("elasticDataNodeConfiguration")]
            [Validation(Required=false)]
            public ListInstanceResponseBodyResultElasticDataNodeConfiguration ElasticDataNodeConfiguration { get; set; }
            public class ListInstanceResponseBodyResultElasticDataNodeConfiguration : TeaModel {
                /// <summary>
                /// The number of nodes.
                /// </summary>
                [NameInMap("amount")]
                [Validation(Required=false)]
                public int? Amount { get; set; }

                /// <summary>
                /// The size of the node storage space. Unit: GB.
                /// </summary>
                [NameInMap("disk")]
                [Validation(Required=false)]
                public int? Disk { get; set; }

                /// <summary>
                /// Specifies whether to enable disk encryption for the node. Valid values:
                /// 
                /// *   true: enables instant image cache.
                /// *   false: disables reuse of image cache layers.
                /// </summary>
                [NameInMap("diskEncryption")]
                [Validation(Required=false)]
                public bool? DiskEncryption { get; set; }

                /// <summary>
                /// The storage type of the node. Valid values:
                /// 
                /// *   cloud_ssd: SSD.
                /// *   cloud_essd: ESSD.
                /// *   cloud_efficiency: ultra disk
                /// </summary>
                [NameInMap("diskType")]
                [Validation(Required=false)]
                public string DiskType { get; set; }

                /// <summary>
                /// The instance type of the node. For more information, see [Specifications](~~271718~~).
                /// </summary>
                [NameInMap("spec")]
                [Validation(Required=false)]
                public string Spec { get; set; }

            }

            /// <summary>
            /// The edition of the dedicated KMS instance.
            /// </summary>
            [NameInMap("esVersion")]
            [Validation(Required=false)]
            public string EsVersion { get; set; }

            /// <summary>
            /// The configuration of cluster extension parameters.
            /// </summary>
            [NameInMap("extendConfigs")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> ExtendConfigs { get; set; }

            /// <summary>
            /// The ID of the instance.
            /// </summary>
            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// Specifies whether to deploy the new architecture.
            /// </summary>
            [NameInMap("isNewDeployment")]
            [Validation(Required=false)]
            public string IsNewDeployment { get; set; }

            /// <summary>
            /// The configuration of Kibana nodes.
            /// </summary>
            [NameInMap("kibanaConfiguration")]
            [Validation(Required=false)]
            public ListInstanceResponseBodyResultKibanaConfiguration KibanaConfiguration { get; set; }
            public class ListInstanceResponseBodyResultKibanaConfiguration : TeaModel {
                /// <summary>
                /// The number of nodes.
                /// </summary>
                [NameInMap("amount")]
                [Validation(Required=false)]
                public int? Amount { get; set; }

                /// <summary>
                /// The size of the node storage space. Unit: GB.
                /// </summary>
                [NameInMap("disk")]
                [Validation(Required=false)]
                public int? Disk { get; set; }

                /// <summary>
                /// The storage type of the node.
                /// </summary>
                [NameInMap("diskType")]
                [Validation(Required=false)]
                public string DiskType { get; set; }

                /// <summary>
                /// The instance type of the node. For more information, see [Specifications](~~271718~~).
                /// </summary>
                [NameInMap("spec")]
                [Validation(Required=false)]
                public string Spec { get; set; }

            }

            [NameInMap("kibanaIPWhitelist")]
            [Validation(Required=false)]
            public List<string> KibanaIPWhitelist { get; set; }

            [NameInMap("kibanaPrivateIPWhitelist")]
            [Validation(Required=false)]
            public List<string> KibanaPrivateIPWhitelist { get; set; }

            /// <summary>
            /// The configuration of dedicated master nodes.
            /// </summary>
            [NameInMap("masterConfiguration")]
            [Validation(Required=false)]
            public ListInstanceResponseBodyResultMasterConfiguration MasterConfiguration { get; set; }
            public class ListInstanceResponseBodyResultMasterConfiguration : TeaModel {
                /// <summary>
                /// The number of nodes.
                /// </summary>
                [NameInMap("amount")]
                [Validation(Required=false)]
                public int? Amount { get; set; }

                /// <summary>
                /// The size of the node storage space. Unit: GB.
                /// </summary>
                [NameInMap("disk")]
                [Validation(Required=false)]
                public int? Disk { get; set; }

                /// <summary>
                /// The storage type of the node. Only cloud_ssd(SSD cloud disk) is supported.
                /// </summary>
                [NameInMap("diskType")]
                [Validation(Required=false)]
                public string DiskType { get; set; }

                /// <summary>
                /// The instance type of the node. For more information, see [Specifications](~~271718~~).
                /// </summary>
                [NameInMap("spec")]
                [Validation(Required=false)]
                public string Spec { get; set; }

            }

            /// <summary>
            /// The network configurations.
            /// </summary>
            [NameInMap("networkConfig")]
            [Validation(Required=false)]
            public ListInstanceResponseBodyResultNetworkConfig NetworkConfig { get; set; }
            public class ListInstanceResponseBodyResultNetworkConfig : TeaModel {
                /// <summary>
                /// The network type. Only Virtual Private Cloud (VPC) is supported.
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// The VPC ID of the cluster.
                /// </summary>
                [NameInMap("vpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                /// <summary>
                /// The zone where the cluster resides.
                /// </summary>
                [NameInMap("vsArea")]
                [Validation(Required=false)]
                public string VsArea { get; set; }

                /// <summary>
                /// The vSwitch ID of the cluster.
                /// </summary>
                [NameInMap("vswitchId")]
                [Validation(Required=false)]
                public string VswitchId { get; set; }

                [NameInMap("whiteIpGroupList")]
                [Validation(Required=false)]
                public List<ListInstanceResponseBodyResultNetworkConfigWhiteIpGroupList> WhiteIpGroupList { get; set; }
                public class ListInstanceResponseBodyResultNetworkConfigWhiteIpGroupList : TeaModel {
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

            /// <summary>
            /// The number of data nodes.
            /// </summary>
            [NameInMap("nodeAmount")]
            [Validation(Required=false)]
            public int? NodeAmount { get; set; }

            /// <summary>
            /// The configuration of data nodes.
            /// </summary>
            [NameInMap("nodeSpec")]
            [Validation(Required=false)]
            public ListInstanceResponseBodyResultNodeSpec NodeSpec { get; set; }
            public class ListInstanceResponseBodyResultNodeSpec : TeaModel {
                /// <summary>
                /// The storage space of the node. Unit: GB.
                /// </summary>
                [NameInMap("disk")]
                [Validation(Required=false)]
                public int? Disk { get; set; }

                /// <summary>
                /// Specifies whether to use disk encryption. Valid values:
                /// 
                /// *   true
                /// *   false
                /// </summary>
                [NameInMap("diskEncryption")]
                [Validation(Required=false)]
                public bool? DiskEncryption { get; set; }

                /// <summary>
                /// The storage type of the node. Valid values:
                /// 
                /// *   cloud_ssd: standard SSD
                /// *   cloud_efficiency: ultra disk
                /// </summary>
                [NameInMap("diskType")]
                [Validation(Required=false)]
                public string DiskType { get; set; }

                /// <summary>
                /// The performance level of the ESSD. This parameter is required when the diskType parameter is set to cloud_essd. Valid values: PL1, PL2, and PL3.
                /// </summary>
                [NameInMap("performanceLevel")]
                [Validation(Required=false)]
                public string PerformanceLevel { get; set; }

                /// <summary>
                /// The instance type of the node. For more information, see [Specifications](~~271718~~).
                /// </summary>
                [NameInMap("spec")]
                [Validation(Required=false)]
                public string Spec { get; set; }

            }

            /// <summary>
            /// The billing method of the instance. Valid values:
            /// 
            /// *   **prepaid**: subscription
            /// *   **postpaid**: pay-as-you-go
            /// </summary>
            [NameInMap("paymentType")]
            [Validation(Required=false)]
            public string PaymentType { get; set; }

            /// <summary>
            /// The status of the pay-as-you-go service that is overlaid on a subscription instance. Valid values:
            /// 
            /// *   **active**: normal
            /// *   **closed**: Close
            /// *   **indebt**: Overdue payments are frozen
            /// </summary>
            [NameInMap("postpaidServiceStatus")]
            [Validation(Required=false)]
            public string PostpaidServiceStatus { get; set; }

            [NameInMap("privateNetworkIpWhiteList")]
            [Validation(Required=false)]
            public List<string> PrivateNetworkIpWhiteList { get; set; }

            [NameInMap("publicIpWhitelist")]
            [Validation(Required=false)]
            public List<string> PublicIpWhitelist { get; set; }

            /// <summary>
            /// The ID of the resource group.
            /// </summary>
            [NameInMap("resourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// Indicates whether it is a service VPC.
            /// </summary>
            [NameInMap("serviceVpc")]
            [Validation(Required=false)]
            public bool? ServiceVpc { get; set; }

            /// <summary>
            /// The status of the instance. Valid values:
            /// 
            /// *   active: normal
            /// *   activating: taking effect
            /// *   inactive: frozen
            /// *   invalid: invalid
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The tags of the instance. Each tag is a key-value pair.
            /// </summary>
            [NameInMap("tags")]
            [Validation(Required=false)]
            public List<ListInstanceResponseBodyResultTags> Tags { get; set; }
            public class ListInstanceResponseBodyResultTags : TeaModel {
                /// <summary>
                /// The key of the tag.
                /// </summary>
                [NameInMap("tagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                /// <summary>
                /// The value of the tag.
                /// </summary>
                [NameInMap("tagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

            /// <summary>
            /// The time when the instance was last updated.
            /// </summary>
            [NameInMap("updatedAt")]
            [Validation(Required=false)]
            public string UpdatedAt { get; set; }

            /// <summary>
            /// The VPC ID of the cluster.
            /// </summary>
            [NameInMap("vpcInstanceId")]
            [Validation(Required=false)]
            public string VpcInstanceId { get; set; }

        }

    }

}
