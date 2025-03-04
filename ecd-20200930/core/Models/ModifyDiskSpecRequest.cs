// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class ModifyDiskSpecRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable the automatic payment feature.</para>
        /// <list type="bullet">
        /// <item><description>If you set the value to <c>true</c>, ensure your account has sufficient balance to avoid generating abnormal orders.</description></item>
        /// <item><description>If you set the value to <c>false</c>, go to the <b>Expenses and Costs</b> page to complete the payment based on the order number.</description></item>
        /// </list>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true (default): enables the automatic payment feature.</description></item>
        /// <item><description>false: generates the order and manually complete the payment.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>The ID of the cloud computer.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecd-2yjhqxo1monxxxxxx</para>
        /// </summary>
        [NameInMap("DesktopId")]
        [Validation(Required=false)]
        public string DesktopId { get; set; }

        /// <summary>
        /// <para>The ID of the sales promotion activity. You can call the DescribePrice operation to obtain the IDs of matching sales promotion activities.</para>
        /// 
        /// <b>Example:</b>
        /// <para>youhuiquan_promotion_option_id_for_blank</para>
        /// </summary>
        [NameInMap("PromotionId")]
        [Validation(Required=false)]
        public string PromotionId { get; set; }

        /// <summary>
        /// <para>The ID of the region. You can call the <a href="~~DescribeRegions~~">DescribeRegions</a> operation to query the list of regions where Elastic Desktop Service (EDS) Enterprise is available.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResellerOwnerUid")]
        [Validation(Required=false)]
        public long? ResellerOwnerUid { get; set; }

        /// <summary>
        /// <para>The PL of the system disk. Only Enterprise Graphics or High Frequency cloud computers support disk PL adjustments.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PL1</description></item>
        /// <item><description>PL0</description></item>
        /// <item><description>PL3</description></item>
        /// <item><description>PL2</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PL1</para>
        /// </summary>
        [NameInMap("RootDiskPerformanceLevel")]
        [Validation(Required=false)]
        public string RootDiskPerformanceLevel { get; set; }

        /// <summary>
        /// <para>The PL of the data disk. Only Enterprise Graphics or High Frequency cloud computers support disk PL adjustments.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PL1</description></item>
        /// <item><description>PL0</description></item>
        /// <item><description>PL3</description></item>
        /// <item><description>PL2</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PL1</para>
        /// </summary>
        [NameInMap("UserDiskPerformanceLevel")]
        [Validation(Required=false)]
        public string UserDiskPerformanceLevel { get; set; }

    }

}
