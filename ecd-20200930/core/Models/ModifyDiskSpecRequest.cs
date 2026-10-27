// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class ModifyDiskSpecRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable automatic payment.</para>
        /// <list type="bullet">
        /// <item><description>If you set this parameter to <c>true</c>, make sure that your account balance is sufficient. Otherwise, an abnormal order is generated.</description></item>
        /// <item><description>If you set this parameter to <c>false</c>, you can log on to the console and pay for the order based on the returned order ID on the <b>Expenses and Costs</b> page.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>The cloud desktop ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecd-2yjhqxo1monbf****</para>
        /// </summary>
        [NameInMap("DesktopId")]
        [Validation(Required=false)]
        public string DesktopId { get; set; }

        /// <summary>
        /// <para>The ID of the promotion. You can call the pricing API operation to obtain the list of matched promotion IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>youhuiquan_promotion_option_id_for_blank</para>
        /// </summary>
        [NameInMap("PromotionId")]
        [Validation(Required=false)]
        public string PromotionId { get; set; }

        /// <summary>
        /// <para>The region ID. You can call the <a href="~~DescribeRegions~~">DescribeRegions</a> operation to query the list of regions supported by cloud desktops.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The user ID of the resource owner in the reseller model. This parameter is not required in the non-reseller model.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1422724566551XXX</para>
        /// </summary>
        [NameInMap("ResellerOwnerUid")]
        [Validation(Required=false)]
        public long? ResellerOwnerUid { get; set; }

        /// <summary>
        /// <para>The performance level of the system cloud disk. You can set the disk performance level when the cloud desktop specification is Enterprise Graphics or High-frequency.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PL1</para>
        /// </summary>
        [NameInMap("RootDiskPerformanceLevel")]
        [Validation(Required=false)]
        public string RootDiskPerformanceLevel { get; set; }

        /// <summary>
        /// <para>The performance level of the data cloud disk. You can set the disk performance level when the cloud desktop specification is Enterprise Graphics or High-frequency.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PL1</para>
        /// </summary>
        [NameInMap("UserDiskPerformanceLevel")]
        [Validation(Required=false)]
        public string UserDiskPerformanceLevel { get; set; }

    }

}
