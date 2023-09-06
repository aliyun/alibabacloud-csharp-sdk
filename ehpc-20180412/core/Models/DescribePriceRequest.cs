// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class DescribePriceRequest : TeaModel {
        /// <summary>
        /// The billing method of the ECS instances. Valid values:
        /// 
        /// *   PostPaid: pay-as-you-go
        /// *   PrePaid: subscription
        /// 
        /// Default value: PostPaid.
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// The information about the service.
        /// </summary>
        [NameInMap("Commodities")]
        [Validation(Required=false)]
        public List<DescribePriceRequestCommodities> Commodities { get; set; }
        public class DescribePriceRequestCommodities : TeaModel {
            /// <summary>
            /// The node quantity of the type. Valid values: 1 to 1000.
            /// 
            /// Default value: 1.
            /// 
            /// Valid values of N: 1 to 10
            /// </summary>
            [NameInMap("Amount")]
            [Validation(Required=false)]
            public int? Amount { get; set; }

            /// <summary>
            /// The list of data disks.
            /// </summary>
            [NameInMap("DataDisks")]
            [Validation(Required=false)]
            public List<DescribePriceRequestCommoditiesDataDisks> DataDisks { get; set; }
            public class DescribePriceRequestCommoditiesDataDisks : TeaModel {
                /// <summary>
                /// The type of the data disk. Valid values:
                /// 
                /// *   cloud_efficiency: ultra disk
                /// *   cloud_ssd: standard SSD
                /// *   cloud_essd: ESSD
                /// *   cloud: basic disk
                /// 
                /// Default value: cloud_efficiency.
                /// 
                /// Valid values of N: 0 to 4.
                /// </summary>
                [NameInMap("category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// Specifies whether the data disk is released when the node is released. Valid values:
                /// 
                /// *   true
                /// *   false
                /// 
                /// Default value: true.
                /// 
                /// Valid values of N: 0 to 4.
                /// </summary>
                [NameInMap("deleteWithInstance")]
                [Validation(Required=false)]
                public bool? DeleteWithInstance { get; set; }

                /// <summary>
                /// Specifies whether to encrypt the data disk. Valid values:
                /// 
                /// *   true: encrypts the data disk.
                /// *   false: does not encrypt the data disk.
                /// 
                /// Default value: false.
                /// 
                /// Valid values of N: 0 to 4.
                /// </summary>
                [NameInMap("encrypted")]
                [Validation(Required=false)]
                public bool? Encrypted { get; set; }

                /// <summary>
                /// The performance level of the ESSD used as the data disk. This parameter takes effect only when the Commodities.N.DataDisks.N.category parameter is set to cloud_essd. Valid values:
                /// 
                /// *   PL0: A single ESSD can deliver up to 10,000 random read/write IOPS.
                /// *   PL1: A single ESSD can deliver up to 50,000 IOPS of random read/write.
                /// *   PL2: A single ESSD can deliver up to 100,000 random read/write IOPS.
                /// *   PL3: A single ESSD can deliver up to 1,000,000 random read/write IOPS.
                /// 
                /// Default value: PL1.
                /// 
                /// Valid values of N: 0 to 4.
                /// </summary>
                [NameInMap("performanceLevel")]
                [Validation(Required=false)]
                public string PerformanceLevel { get; set; }

                /// <summary>
                /// The size of the data disk. Unit: GB.
                /// 
                /// Valid values: 40 to 500.
                /// 
                /// Default value: 40.
                /// 
                /// Valid values of N: 0 to 4.
                /// </summary>
                [NameInMap("size")]
                [Validation(Required=false)]
                public int? Size { get; set; }

            }

            /// <summary>
            /// The instance type of the node.
            /// 
            /// Valid values of N: 1 to 10.
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// The EIP billing method of the node. Valid values:
            /// 
            /// *   PayByBandwidth: pay-by-bandwidth
            /// *   PayByTraffic: pay-by-traffic
            /// 
            /// Valid values of N: 1 to 10.
            /// </summary>
            [NameInMap("InternetChargeType")]
            [Validation(Required=false)]
            public string InternetChargeType { get; set; }

            /// <summary>
            /// The maximum outbound public bandwidth of the node. Unit: Mbit/s.
            /// 
            /// Valid values: 0 to 100.
            /// 
            /// Default value: 0.
            /// 
            /// Valid values of N: 1 to 10.
            /// </summary>
            [NameInMap("InternetMaxBandWidthOut")]
            [Validation(Required=false)]
            public int? InternetMaxBandWidthOut { get; set; }

            /// <summary>
            /// The network type of the node. Valid value: VPC.
            /// 
            /// Valid values of N: 1 to 10.
            /// </summary>
            [NameInMap("NetworkType")]
            [Validation(Required=false)]
            public string NetworkType { get; set; }

            /// <summary>
            /// The type of the node. Valid values:
            /// 
            /// *   Compute: compute node
            /// *   Manager: management node
            /// *   Login: logon node
            /// 
            /// Valid values of N: 1 to 10.
            /// </summary>
            [NameInMap("NodeType")]
            [Validation(Required=false)]
            public string NodeType { get; set; }

            /// <summary>
            /// The subscription duration of the node. Valid values:
            /// 
            /// *   If PriceUnit is set to Year, the valid values of the Period parameter are 1, 2, and 3.
            /// *   If PriceUnit is set to Month, the valid values of the Period parameter are 1, 2, 3, 4, 5, 6, 7, 8, and 9.
            /// *   If PriceUnit is set to Hour, the valid value of the Period parameter is 1.
            /// 
            /// Default value: 1.
            /// 
            /// Valid values of N: 1 to 10.
            /// </summary>
            [NameInMap("Period")]
            [Validation(Required=false)]
            public int? Period { get; set; }

            /// <summary>
            /// The system disk type of the node. Valid values:
            /// 
            /// *   cloud_efficiency: ultra disk
            /// *   cloud_ssd: standard SSD
            /// *   cloud_essd: ESSD
            /// *   cloud: basic disk
            /// 
            /// Default value: cloud_efficiency
            /// 
            /// Valid values of N: 1 to 10.
            /// </summary>
            [NameInMap("SystemDiskCategory")]
            [Validation(Required=false)]
            public string SystemDiskCategory { get; set; }

            /// <summary>
            /// The performance level of the ESSD used as the system disk. This parameter takes effect only when the Commodities.N.SystemDiskCategory parameter is set to cloud_essd. Valid values:
            /// 
            /// *   PL0: A single ESSD can deliver up to 10,000 random read/write IOPS.
            /// *   PL1: A single ESSD can deliver up to 50,000 IOPS of random read/write.
            /// *   PL2: A single ESSD can deliver up to 100,000 random read/write IOPS.
            /// *   PL3: A single ESSD can deliver up to 1,000,000 random read/write IOPS.
            /// 
            /// Default value: PL1.
            /// 
            /// Valid values of N: 1 to 10
            /// </summary>
            [NameInMap("SystemDiskPerformanceLevel")]
            [Validation(Required=false)]
            public string SystemDiskPerformanceLevel { get; set; }

            /// <summary>
            /// The system disk size of the node. Unit: GB.
            /// 
            /// Valid values: 40 to 500.
            /// 
            /// Default value: 40.
            /// 
            /// Valid values of N: 1 to 10.
            /// </summary>
            [NameInMap("SystemDiskSize")]
            [Validation(Required=false)]
            public int? SystemDiskSize { get; set; }

        }

        /// <summary>
        /// The type of the order. The order can be set only as a purchase order. Valid value: INSTANCE-BUY.
        /// </summary>
        [NameInMap("OrderType")]
        [Validation(Required=false)]
        public string OrderType { get; set; }

        /// <summary>
        /// The billing cycle of the Elastic Compute Service (ECS) instances. This parameter takes effect only when the ChargeType parameter is set to PrePaid. Valid values:
        /// 
        /// *   Month: pay-by-month
        /// *   Year: pay-by-year
        /// *   Hour: pay-by-hour
        /// 
        /// Default value: Hour.
        /// </summary>
        [NameInMap("PriceUnit")]
        [Validation(Required=false)]
        public string PriceUnit { get; set; }

    }

}
