// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class CreateClusterRequest : TeaModel {
        /// <summary>
        /// The language of the response. Valid values:
        /// 
        /// *   zh: Chinese
        /// *   en: English
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// The billing method. Valid values: PREPAY and POSTPAY.
        /// 
        /// Ignore this parameter for serverless instances.
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// The engine specifications. Valid values:
        /// 
        /// \[Professional Edition]
        /// 
        /// *   `MSE_SC_2_4_60_c`: 2 vCPUs and 4 GB of memory
        /// *   `MSE_SC_1_2_60_c`: 1 vCPU and 2 GB of memory
        /// *   `MSE_SC_4_8_60_c`: 4 vCPUs and 8 GB of memory
        /// *   `MSE_SC_8_16_60_c`: 8 vCPUs and 16 GB of memory
        /// *   `MSE_SC_16_32_60_c`: 16 vCPUs and 32 GB of memory
        /// 
        /// \[Developer Edition]
        /// 
        /// *   `MSE_SC_1_2_60_c`: 1 vCPU and 2 GB of memory
        /// *   `MSE_SC_2_4_60_c`: 2 vCPUs and 4 GB of memory
        /// 
        /// \[Serverless Edition]
        /// 
        /// Ignore this parameter or set this parameter to `MSE_SC_SERVERLESS`.
        /// </summary>
        [NameInMap("ClusterSpecification")]
        [Validation(Required=false)]
        public string ClusterSpecification { get; set; }

        /// <summary>
        /// The type of the instance. Valid values: ZooKeeper and Nacos-Ans.
        /// </summary>
        [NameInMap("ClusterType")]
        [Validation(Required=false)]
        public string ClusterType { get; set; }

        /// <summary>
        /// The engine version of the instance. Valid values:
        /// 
        /// \[Professional Edition]
        /// 
        /// *   `NACOS_2_0_0`
        /// *   `ZooKeeper_3_8_0`
        /// 
        /// \[Developer Edition]
        /// 
        /// *   `NACOS_2_0_0`
        /// *   `ZooKeeper_3_8_0`
        /// 
        /// \[Serverless Edition]
        /// 
        /// *   `NACOS_2_0_0`
        /// *   `ZooKeeper_3_8_0`
        /// </summary>
        [NameInMap("ClusterVersion")]
        [Validation(Required=false)]
        public string ClusterVersion { get; set; }

        /// <summary>
        /// The network connection type. Valid values: `slb` or `single_eni`. For instances of the Developer Edition in some regions, only the value `single_eni` is supported.
        /// </summary>
        [NameInMap("ConnectionType")]
        [Validation(Required=false)]
        public string ConnectionType { get; set; }

        /// <summary>
        /// This parameter is obsolete.
        /// </summary>
        [NameInMap("DiskType")]
        [Validation(Required=false)]
        [Obsolete]
        public string DiskType { get; set; }

        /// <summary>
        /// Specifies whether to enable Internet access (Elastic IP Address) if ConnectionType is set to `single_eni`.
        /// 
        /// Valid values:
        /// 
        /// *   true
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        /// *   false
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// </summary>
        [NameInMap("EipEnabled")]
        [Validation(Required=false)]
        public bool? EipEnabled { get; set; }

        /// <summary>
        /// The number of nodes in the instance. Valid values: 1 to 9.
        /// 
        /// \[Professional Edition]
        /// 
        /// *   The value must be greater than or equal to 3 and must be an odd number.
        /// 
        /// \[Developer Edition]
        /// 
        /// *   The value must be 1.
        /// 
        /// \[Serverless Edition]
        /// 
        /// Ignore this parameter.
        /// </summary>
        [NameInMap("InstanceCount")]
        [Validation(Required=false)]
        public int? InstanceCount { get; set; }

        /// <summary>
        /// The custom name of the instance.
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// Configure this parameter unless otherwise specified. Valid values:
        /// 
        /// *   `mse_pro`: Professional Edition
        /// *   `mse_dev`: Developer Edition
        /// *   `mse_dev`: Serverless Edition
        /// </summary>
        [NameInMap("MseVersion")]
        [Validation(Required=false)]
        public string MseVersion { get; set; }

        /// <summary>
        /// The network type of the MSE instance. Valid values:
        /// 
        /// *   `privatenet`: VPC
        /// *   `pubnet`: Internet
        /// </summary>
        [NameInMap("NetType")]
        [Validation(Required=false)]
        public string NetType { get; set; }

        /// <summary>
        /// This parameter is obsolete.
        /// </summary>
        [NameInMap("PrivateSlbSpecification")]
        [Validation(Required=false)]
        [Obsolete]
        public string PrivateSlbSpecification { get; set; }

        /// <summary>
        /// This parameter is valid only if the ConnectionType parameter is set to `slb`. The value 0 indicates that the Server Load Balancer (SLB) instance is not connected over the Internet. A value greater than 1 indicates the fixed bandwidth that is used to access the SLB instance over the Internet. Unit: Mbit/s.
        /// 
        /// Valid values: 0 to 5000.
        /// </summary>
        [NameInMap("PubNetworkFlow")]
        [Validation(Required=false)]
        public string PubNetworkFlow { get; set; }

        /// <summary>
        /// This parameter is obsolete.
        /// </summary>
        [NameInMap("PubSlbSpecification")]
        [Validation(Required=false)]
        [Obsolete]
        public string PubSlbSpecification { get; set; }

        /// <summary>
        /// The region where the instance resides. Examples:
        /// 
        /// *   `cn-hangzhou`: China (Hangzhou)
        /// *   `cn-beijing`: China (Beijing)
        /// *   `cn-shanghai`: China (Shanghai)
        /// *   `cn-zhangjiakou`: China (Zhangjiakou)
        /// *   `cn-shenzhen`: China (Shenzhen)
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// The extended request parameters in the JSON format.
        /// </summary>
        [NameInMap("RequestPars")]
        [Validation(Required=false)]
        public string RequestPars { get; set; }

        /// <summary>
        /// The ID of the resource group. For the details of resource groups, see [View basic information of a resource group](~~457230~~).
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The type of the security group to which the instance belongs. This parameter is valid only if the ConnectionType parameter is set to `single_eni`.
        /// 
        /// Valid values:
        /// 
        /// *   enterprise
        /// *   normal
        /// </summary>
        [NameInMap("SecurityGroupType")]
        [Validation(Required=false)]
        public string SecurityGroupType { get; set; }

        /// <summary>
        /// The tags to add to the resource. You can specify up to 20 tags.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateClusterRequestTag> Tag { get; set; }
        public class CreateClusterRequestTag : TeaModel {
            /// <summary>
            /// The key of tag N to add to the resource.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of tag N to add to the resource.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The ID of the vSwitch.
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// The ID of the virtual private cloud (VPC).
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
