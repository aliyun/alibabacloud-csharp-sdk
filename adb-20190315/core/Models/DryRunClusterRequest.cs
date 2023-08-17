// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DryRunClusterRequest : TeaModel {
        /// <summary>
        /// The specifications of computing resources.
        /// 
        /// > You can call the [DescribeComputeResource](~~469002~~) operation to query the specifications of computing resources.
        /// </summary>
        [NameInMap("ComputeResource")]
        [Validation(Required=false)]
        public string ComputeResource { get; set; }

        /// <summary>
        /// The description of the cluster.
        /// 
        /// *   The description cannot start with `http://` or `https://`.
        /// *   The description must be 2 to 256 characters in length
        /// </summary>
        [NameInMap("DBClusterDescription")]
        [Validation(Required=false)]
        public string DBClusterDescription { get; set; }

        /// <summary>
        /// The ID of the AnalyticDB for MySQL Data Warehouse Edition (V3.0) cluster.
        /// 
        /// *   You can leave this parameter empty when you set Operation to **Buy**.
        /// *   This parameter must be specified when you set Operation to **Modify**.
        /// 
        /// > You can call the [DescribeDBClusters](~~129857~~) operation to query the IDs of all AnalyticDB for MySQL Data Warehouse Edition (V3.0) clusters within a region.
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// The network type of the cluster. Set the value to **VPC**.
        /// </summary>
        [NameInMap("DBClusterNetworkType")]
        [Validation(Required=false)]
        public string DBClusterNetworkType { get; set; }

        /// <summary>
        /// The version of the AnalyticDB for MySQL Data Warehouse Edition cluster. Set the value to **3.0**.
        /// </summary>
        [NameInMap("DBClusterVersion")]
        [Validation(Required=false)]
        public string DBClusterVersion { get; set; }

        /// <summary>
        /// Specifies whether to enable the default resource group.
        /// 
        /// > If you leave this parameter empty, true is used.
        /// </summary>
        [NameInMap("EnableDefaultResourcePool")]
        [Validation(Required=false)]
        public bool? EnableDefaultResourcePool { get; set; }

        /// <summary>
        /// The type of the operation. Valid values:
        /// 
        /// *   **Buy**: purchases a cluster.
        /// *   **Modify**: changes configurations of a cluster.
        /// </summary>
        [NameInMap("Operation")]
        [Validation(Required=false)]
        public string Operation { get; set; }

        /// <summary>
        /// The billing method of the cluster. Valid values:
        /// 
        /// *   **Postpaid**: pay-as-you-go.
        /// *   **Prepaid**: subscription.
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// The subscription type of the subscription cluster. Valid values:
        /// 
        /// *   **Year**: subscription on a yearly basis.
        /// *   **Month**: subscription on a monthly basis.
        /// 
        /// > This parameter must be specified when PayType is set to Prepaid.
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        /// <summary>
        /// The region ID of the cluster.
        /// 
        /// > You can call the [DescribeRegions](~~143074~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The amount of reserved storage resources.
        /// </summary>
        [NameInMap("StorageResource")]
        [Validation(Required=false)]
        public string StorageResource { get; set; }

        /// <summary>
        /// The subscription duration of the subscription cluster.
        /// 
        /// *   Valid values when Period is set to Year: 1, 2, 3, and 5 (integer).
        /// *   Valid values when Period is set to Month: 1 to 11 (integer).
        /// 
        /// > 
        /// 
        /// *   This parameter must be specified when PayType is set to Prepaid.
        /// 
        /// *   Longer subscription durations offer more savings. Purchasing a cluster for one year is more cost-effective than purchasing the cluster for 10 or 11 months.
        /// </summary>
        [NameInMap("UsedTime")]
        [Validation(Required=false)]
        public string UsedTime { get; set; }

        /// <summary>
        /// The virtual private cloud (VPC) ID of the cluster.
        /// </summary>
        [NameInMap("VPCId")]
        [Validation(Required=false)]
        public string VPCId { get; set; }

        /// <summary>
        /// The vSwitch ID of the cluster.
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// The zone ID of the cluster.
        /// 
        /// > You can call the [DescribeRegions](~~143074~~) operation to query the most recent zone list.
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
