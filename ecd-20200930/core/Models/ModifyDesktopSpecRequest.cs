// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class ModifyDesktopSpecRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable automatic payment.</para>
        /// <para>Default value: true. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Automatic payment is enabled. Make sure that your Alibaba Cloud account balance is sufficient. Otherwise, abnormal orders may be generated.</description></item>
        /// <item><description>false: Only an order is generated. Automatic payment is not enabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>The cloud computer ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecd-4543qyik164a4****</para>
        /// </summary>
        [NameInMap("DesktopId")]
        [Validation(Required=false)]
        public string DesktopId { get; set; }

        /// <summary>
        /// <para>The target instance type. You can call <a href="https://help.aliyun.com/document_detail/188882.html">DescribeDesktopTypes</a> to query the instance types supported by cloud computers.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eds.general.2c8g</para>
        /// </summary>
        [NameInMap("DesktopType")]
        [Validation(Required=false)]
        public string DesktopType { get; set; }

        /// <summary>
        /// <para>The promotion ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>500033080110596</para>
        /// </summary>
        [NameInMap("PromotionId")]
        [Validation(Required=false)]
        public string PromotionId { get; set; }

        /// <summary>
        /// <para>The region ID. You can call <a href="https://help.aliyun.com/document_detail/196646.html">DescribeRegions</a> to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The user ID of the resource ownership in the reseller pattern. This parameter is not required in the non-reseller pattern.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1422724566551XXX</para>
        /// </summary>
        [NameInMap("ResellerOwnerUid")]
        [Validation(Required=false)]
        public long? ResellerOwnerUid { get; set; }

        /// <summary>
        /// <para>The resource specification templates.</para>
        /// </summary>
        [NameInMap("ResourceSpecs")]
        [Validation(Required=false)]
        public List<ModifyDesktopSpecRequestResourceSpecs> ResourceSpecs { get; set; }
        public class ModifyDesktopSpecRequestResourceSpecs : TeaModel {
            /// <summary>
            /// <para>The cloud computer ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecd-4543qyik164a4****</para>
            /// </summary>
            [NameInMap("DesktopId")]
            [Validation(Required=false)]
            public string DesktopId { get; set; }

            /// <summary>
            /// <para>The target system cloud disk size. Valid values: 80 to 500 GiB. The value must be a multiple of 10.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("RootDiskSizeGib")]
            [Validation(Required=false)]
            public int? RootDiskSizeGib { get; set; }

            /// <summary>
            /// <para>The target data cloud disk size. Valid values: 80 to 500 GiB. The value must be a multiple of 10.</para>
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
        /// <para>This parameter is not required for non-subscription cloud computers.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>DesktopMonthPackage</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The system cloud disk size after the change. Unit: GiB. Valid values: 80 to 500. The value must be a multiple of 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("RootDiskSizeGib")]
        [Validation(Required=false)]
        public int? RootDiskSizeGib { get; set; }

        /// <summary>
        /// <para>The performance level (PL) of the data cloud disk. Default value: PL0.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PL0</description></item>
        /// <item><description>PL1</description></item>
        /// <item><description>PL2</description></item>
        /// <item><description>PL3</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PL0</para>
        /// </summary>
        [NameInMap("UserDiskPerformanceLevel")]
        [Validation(Required=false)]
        public string UserDiskPerformanceLevel { get; set; }

        /// <summary>
        /// <para>The data cloud disk size after the change. Unit: GiB.</para>
        /// <list type="bullet">
        /// <item><description>For non-graphics cloud computers, valid values: 20 to 1020. The value must be a multiple of 10.</description></item>
        /// <item><description>For graphics cloud computers, valid values: 40 to 1020. The value must be a multiple of 10.</description></item>
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
