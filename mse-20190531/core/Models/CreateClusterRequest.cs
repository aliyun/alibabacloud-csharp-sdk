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
        /// The engine specifications. Valid values:
        /// 
        /// \[Professional Edition]
        /// 
        /// *   `MSE_SC_2_4_60_c`: 2 CPU cores and 4 GB of memory
        /// *   `MSE_SC_1_2_60_c`: 1 CPU core and 2 GB of memory
        /// *   `MSE_SC_4_8_60_c`: 4 CPU cores and 8 GB of memory
        /// *   `MSE_SC_8_16_60_c`: 8 CPU cores and 16 GB of memory
        /// *   `MSE_SC_16_32_60_c`: 16 CPU cores and 32 GB of memory
        /// 
        /// \[Developer Edition]
        /// 
        /// *   `MSE_SC_1_2_60_c`: 1 CPU core and 2 GB of memory
        /// *   `MSE_SC_2_4_60_c`: 2 CPU cores and 4 GB of memory
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
        /// \[Professional version]
        /// 
        /// *   `NACOS_2_0_0`: Nacos 2.0.0
        /// *   `ZooKeeper_3_8_0`: ZooKeeper 3.8.0
        /// 
        /// \[Developer Edition]
        /// 
        /// *   `NACOS_2_0_0`: Nacos 2.0.0
        /// *   `ZooKeeper_3_8_0`: ZooKeeper 3.8.0
        /// </summary>
        [NameInMap("ClusterVersion")]
        [Validation(Required=false)]
        public string ClusterVersion { get; set; }

        /// <summary>
        /// The network connection type. Valid values:
        /// 
        /// *   slb
        /// *   eni
        /// </summary>
        [NameInMap("ConnectionType")]
        [Validation(Required=false)]
        public string ConnectionType { get; set; }

        /// <summary>
        /// The disk type of the MSE instance. Valid values:
        /// 
        /// *   alicloud-disk-ssd
        /// *   alicloud-disk-essd-pl1
        /// </summary>
        [NameInMap("DiskType")]
        [Validation(Required=false)]
        public string DiskType { get; set; }

        /// <summary>
        /// The number of nodes in the instance. Valid values: 1 to 9.
        /// 
        /// \[Professional Edition]
        /// 
        /// *   The number of nodes in an instance is greater than or equal to 3 and must be an odd number.
        /// 
        /// \[Developer Edition]
        /// 
        /// *   Only one node can be deployed for an instance.
        /// </summary>
        [NameInMap("InstanceCount")]
        [Validation(Required=false)]
        public int? InstanceCount { get; set; }

        /// <summary>
        /// The name of the MSE instance.
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// Configure this parameter unless otherwise specified. Valid values:
        /// 
        /// *   `mse_pro`: Professional Edition
        /// *   `mse_dev`: Developer Edition
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
        /// The specifications of the internal-facing SLB instance. Valid values:
        /// 
        /// *   `slb.s1.small`
        /// *   `slb.s3.medium`
        /// </summary>
        [NameInMap("PrivateSlbSpecification")]
        [Validation(Required=false)]
        public string PrivateSlbSpecification { get; set; }

        /// <summary>
        /// The public bandwidth. Unit: Mbit/s.\
        /// Valid values: 0 to 5000. The value 0 indicates no access to the Internet.
        /// </summary>
        [NameInMap("PubNetworkFlow")]
        [Validation(Required=false)]
        public string PubNetworkFlow { get; set; }

        /// <summary>
        /// The specifications of the Internet-facing Server Load Balancer (SLB) instance. Valid values:
        /// 
        /// *   `slb.s1.small`
        /// *   `slb.s3.medium`
        /// </summary>
        [NameInMap("PubSlbSpecification")]
        [Validation(Required=false)]
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
        /// The ID of the resource group. For more information, see [View basic information of a resource group](~~457230~~).
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The list of the tags that you want to add.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateClusterRequestTag> Tag { get; set; }
        public class CreateClusterRequestTag : TeaModel {
            /// <summary>
            /// The key of a tag.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of a tag.
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
