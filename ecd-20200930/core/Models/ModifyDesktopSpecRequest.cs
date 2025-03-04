// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class ModifyDesktopSpecRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable the auto-payment feature.</para>
        /// <para>Default value: true. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: enables the auto-payment feature.</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <para>Make sure that you have sufficient balance in your Alibaba Cloud account. Otherwise, an exception occurs on your order.</para>
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>false: disables the auto-payment feature. In this case, an order is generated, and no payment is automatically made.</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <para>You can log on to the Elastic Desktop Service console and complete the payment based on the order ID on the Orders page.</para>
        /// <!-- --></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>The ID of a cloud computer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecd-4543qyik164a4****</para>
        /// </summary>
        [NameInMap("DesktopId")]
        [Validation(Required=false)]
        public string DesktopId { get; set; }

        /// <summary>
        /// <para>The destination instance type. You can call the <a href="https://help.aliyun.com/document_detail/188882.html">DescribeDesktopTypes</a> operation to query the instance types supported by cloud computers.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eds.general.2c8g</para>
        /// </summary>
        [NameInMap("DesktopType")]
        [Validation(Required=false)]
        public string DesktopType { get; set; }

        /// <summary>
        /// <para>The ID of the promotional activity.</para>
        /// 
        /// <b>Example:</b>
        /// <para>500033080110596</para>
        /// </summary>
        [NameInMap("PromotionId")]
        [Validation(Required=false)]
        public string PromotionId { get; set; }

        /// <summary>
        /// <para>The region ID. You can call the <a href="https://help.aliyun.com/document_detail/196646.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The array of resource specification templates.</para>
        /// </summary>
        [NameInMap("ResourceSpecs")]
        [Validation(Required=false)]
        public List<ModifyDesktopSpecRequestResourceSpecs> ResourceSpecs { get; set; }
        public class ModifyDesktopSpecRequestResourceSpecs : TeaModel {
            /// <summary>
            /// <para>The ID of the cloud computer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecd-4543qyik164a4****</para>
            /// </summary>
            [NameInMap("DesktopId")]
            [Validation(Required=false)]
            public string DesktopId { get; set; }

            /// <summary>
            /// <para>The target size of the system disk. Valid values: 80-500 GiB. The value must be a multiple of 10.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("RootDiskSizeGib")]
            [Validation(Required=false)]
            public int? RootDiskSizeGib { get; set; }

            /// <summary>
            /// <para>The target size of the data disk. Valid values: 80-500 GiB. The value must be a multiple of 10.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("UserDiskSizeGib")]
            [Validation(Required=false)]
            public int? UserDiskSizeGib { get; set; }

        }

        /// <summary>
        /// <para>The resource type.</para>
        /// <remarks>
        /// <para>This parameter is optional for non-subscribed cloud computers.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>DesktopMonthPackage</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The size of the new system disk. Unit: GiB. Valid values: 80 to 500 GiB. The value must be a multiple of 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("RootDiskSizeGib")]
        [Validation(Required=false)]
        public int? RootDiskSizeGib { get; set; }

        /// <summary>
        /// <para>The performance level (PL) of the data disk. Default value: PL0.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>PL1</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>PL0</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>PL3</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>PL2</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- --></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PL0</para>
        /// </summary>
        [NameInMap("UserDiskPerformanceLevel")]
        [Validation(Required=false)]
        public string UserDiskPerformanceLevel { get; set; }

        /// <summary>
        /// <para>The destination data disk size. Unit: GiB.</para>
        /// <list type="bullet">
        /// <item><description>The data disk size of a non-graphical cloud computer ranges from 20 to 1020 GiB and must be a multiple of 10.</description></item>
        /// <item><description>The data disk size of a graphical cloud computer ranges from 40 to 1020 GiB and must be a multiple of 10.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("UserDiskSizeGib")]
        [Validation(Required=false)]
        public int? UserDiskSizeGib { get; set; }

    }

}
