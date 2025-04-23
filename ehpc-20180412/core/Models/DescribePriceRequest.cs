// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class DescribePriceRequest : TeaModel {
        /// <summary>
        /// <para>The billing method of the ECS instances. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PostPaid: pay-as-you-go</description></item>
        /// <item><description>PrePaid: subscription</description></item>
        /// </list>
        /// <para>Default value: PostPaid.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PostPaid</para>
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// <para>The information about the service.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Commodities")]
        [Validation(Required=false)]
        public List<DescribePriceRequestCommodities> Commodities { get; set; }
        public class DescribePriceRequestCommodities : TeaModel {
            /// <summary>
            /// <para>The node quantity of the type. Valid values: 1 to 1000.</para>
            /// <para>Default value: 1.</para>
            /// <para>Valid values of N: 1 to 10</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Amount")]
            [Validation(Required=false)]
            public int? Amount { get; set; }

            /// <summary>
            /// <para>The list of data disks.</para>
            /// </summary>
            [NameInMap("DataDisks")]
            [Validation(Required=false)]
            public List<DescribePriceRequestCommoditiesDataDisks> DataDisks { get; set; }
            public class DescribePriceRequestCommoditiesDataDisks : TeaModel {
                /// <summary>
                /// <para>The type of the data disk. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>cloud_efficiency: ultra disk</description></item>
                /// <item><description>cloud_ssd: standard SSD</description></item>
                /// <item><description>cloud_essd: ESSD</description></item>
                /// <item><description>cloud: basic disk</description></item>
                /// </list>
                /// <para>Default value: cloud_efficiency.</para>
                /// <para>Valid values of N: 0 to 4.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cloud_efficiency</para>
                /// </summary>
                [NameInMap("category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// <para>Specifies whether the data disk is released when the node is released. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true</description></item>
                /// <item><description>false</description></item>
                /// </list>
                /// <para>Default value: true.</para>
                /// <para>Valid values of N: 0 to 4.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("deleteWithInstance")]
                [Validation(Required=false)]
                public bool? DeleteWithInstance { get; set; }

                /// <summary>
                /// <para>Specifies whether to encrypt the data disk. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: encrypts the data disk.</description></item>
                /// <item><description>false: does not encrypt the data disk.</description></item>
                /// </list>
                /// <para>Default value: false.</para>
                /// <para>Valid values of N: 0 to 4.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("encrypted")]
                [Validation(Required=false)]
                public bool? Encrypted { get; set; }

                /// <summary>
                /// <para>The performance level of the ESSD used as the data disk. This parameter takes effect only when the Commodities.N.DataDisks.N.category parameter is set to cloud_essd. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>PL0: A single ESSD can deliver up to 10,000 random read/write IOPS.</description></item>
                /// <item><description>PL1: A single ESSD can deliver up to 50,000 IOPS of random read/write.</description></item>
                /// <item><description>PL2: A single ESSD can deliver up to 100,000 random read/write IOPS.</description></item>
                /// <item><description>PL3: A single ESSD can deliver up to 1,000,000 random read/write IOPS.</description></item>
                /// </list>
                /// <para>Default value: PL1.</para>
                /// <para>Valid values of N: 0 to 4.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PL1</para>
                /// </summary>
                [NameInMap("performanceLevel")]
                [Validation(Required=false)]
                public string PerformanceLevel { get; set; }

                /// <summary>
                /// <para>The size of the data disk. Unit: GB.</para>
                /// <para>Valid values: 40 to 500.</para>
                /// <para>Default value: 40.</para>
                /// <para>Valid values of N: 0 to 4.</para>
                /// 
                /// <b>Example:</b>
                /// <para>40</para>
                /// </summary>
                [NameInMap("size")]
                [Validation(Required=false)]
                public int? Size { get; set; }

            }

            /// <summary>
            /// <para>The instance type of the node.</para>
            /// <para>Valid values of N: 1 to 10.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecs.n1.tiny</para>
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// <para>The EIP billing method of the node. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PayByBandwidth: pay-by-bandwidth</description></item>
            /// <item><description>PayByTraffic: pay-by-traffic</description></item>
            /// </list>
            /// <para>Valid values of N: 1 to 10.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PayByBandwidth</para>
            /// </summary>
            [NameInMap("InternetChargeType")]
            [Validation(Required=false)]
            public string InternetChargeType { get; set; }

            /// <summary>
            /// <para>The maximum outbound public bandwidth of the node. Unit: Mbit/s.</para>
            /// <para>Valid values: 0 to 100.</para>
            /// <para>Default value: 0.</para>
            /// <para>Valid values of N: 1 to 10.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("InternetMaxBandWidthOut")]
            [Validation(Required=false)]
            public int? InternetMaxBandWidthOut { get; set; }

            /// <summary>
            /// <para>The network type of the node. Valid value: VPC.</para>
            /// <para>Valid values of N: 1 to 10.</para>
            /// 
            /// <b>Example:</b>
            /// <para>VPC</para>
            /// </summary>
            [NameInMap("NetworkType")]
            [Validation(Required=false)]
            public string NetworkType { get; set; }

            /// <summary>
            /// <para>The type of the node. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Compute: compute node</description></item>
            /// <item><description>Manager: management node</description></item>
            /// <item><description>Login: logon node</description></item>
            /// </list>
            /// <para>Valid values of N: 1 to 10.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Compute</para>
            /// </summary>
            [NameInMap("NodeType")]
            [Validation(Required=false)]
            public string NodeType { get; set; }

            /// <summary>
            /// <para>The subscription duration of the node. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>If PriceUnit is set to Year, the valid values of the Period parameter are 1, 2, and 3.</description></item>
            /// <item><description>If PriceUnit is set to Month, the valid values of the Period parameter are 1, 2, 3, 4, 5, 6, 7, 8, and 9.</description></item>
            /// <item><description>If PriceUnit is set to Hour, the valid value of the Period parameter is 1.</description></item>
            /// </list>
            /// <para>Default value: 1.</para>
            /// <para>Valid values of N: 1 to 10.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Period")]
            [Validation(Required=false)]
            public int? Period { get; set; }

            /// <summary>
            /// <para>The system disk type of the node. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>cloud_efficiency: ultra disk</description></item>
            /// <item><description>cloud_ssd: standard SSD</description></item>
            /// <item><description>cloud_essd: ESSD</description></item>
            /// <item><description>cloud: basic disk</description></item>
            /// </list>
            /// <para>Default value: cloud_efficiency</para>
            /// <para>Valid values of N: 1 to 10.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_ssd</para>
            /// </summary>
            [NameInMap("SystemDiskCategory")]
            [Validation(Required=false)]
            public string SystemDiskCategory { get; set; }

            /// <summary>
            /// <para>The performance level of the ESSD used as the system disk. This parameter takes effect only when the Commodities.N.SystemDiskCategory parameter is set to cloud_essd. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PL0: A single ESSD can deliver up to 10,000 random read/write IOPS.</description></item>
            /// <item><description>PL1: A single ESSD can deliver up to 50,000 IOPS of random read/write.</description></item>
            /// <item><description>PL2: A single ESSD can deliver up to 100,000 random read/write IOPS.</description></item>
            /// <item><description>PL3: A single ESSD can deliver up to 1,000,000 random read/write IOPS.</description></item>
            /// </list>
            /// <para>Default value: PL1.</para>
            /// <para>Valid values of N: 1 to 10</para>
            /// 
            /// <b>Example:</b>
            /// <para>PL1</para>
            /// </summary>
            [NameInMap("SystemDiskPerformanceLevel")]
            [Validation(Required=false)]
            public string SystemDiskPerformanceLevel { get; set; }

            /// <summary>
            /// <para>The system disk size of the node. Unit: GB.</para>
            /// <para>Valid values: 40 to 500.</para>
            /// <para>Default value: 40.</para>
            /// <para>Valid values of N: 1 to 10.</para>
            /// 
            /// <b>Example:</b>
            /// <para>40</para>
            /// </summary>
            [NameInMap("SystemDiskSize")]
            [Validation(Required=false)]
            public int? SystemDiskSize { get; set; }

        }

        /// <summary>
        /// <para>The type of the order. The order can be set only as a purchase order. Valid value: INSTANCE-BUY.</para>
        /// 
        /// <b>Example:</b>
        /// <para>INSTANCE-BUY</para>
        /// </summary>
        [NameInMap("OrderType")]
        [Validation(Required=false)]
        public string OrderType { get; set; }

        /// <summary>
        /// <para>The billing cycle of the Elastic Compute Service (ECS) instances. This parameter takes effect only when the ChargeType parameter is set to PrePaid. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Month: pay-by-month</description></item>
        /// <item><description>Year: pay-by-year</description></item>
        /// <item><description>Hour: pay-by-hour</description></item>
        /// </list>
        /// <para>Default value: Hour.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Hour</para>
        /// </summary>
        [NameInMap("PriceUnit")]
        [Validation(Required=false)]
        public string PriceUnit { get; set; }

    }

}
