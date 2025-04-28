// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class ModifyDesktopChargeTypeRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable automatic payment if you specify subscription as the new billing method for the cloud desktop.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>The new billing method that you want to apply.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>PostPaid: changes the billing method from subscription to pay-as-you-go.</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>PrePaid: changes the billing method from pay-as-you-go to subscription.</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- --></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PrePaid</para>
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// <para>The IDs of the cloud computers. You can specify 1 to 20 IDs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecd-gx2x1dhsmucyy****</para>
        /// </summary>
        [NameInMap("DesktopId")]
        [Validation(Required=false)]
        public List<string> DesktopId { get; set; }

        /// <summary>
        /// <para>The subscription duration of the cloud computers if you set the ChargeType parameter to PrePaid. The unit is specified by the <c>PeriodUnit</c> parameter. This parameter is valid only when the <c>ChargeType</c> parameter is set to <c>PrePaid</c>. In this case, you must specify this parameter.</para>
        /// <list type="bullet">
        /// <item><description>If the <c>PeriodUnit</c> parameter is set to <c>Week</c>, set the Period parameter to 1.</description></item>
        /// <item><description>If the <c>PeriodUnit</c> parameter is set to <c>Month</c>, the valid values of the Period parameter are 1, 2, 3, and 6.</description></item>
        /// <item><description>If the <c>PeriodUnit</c> parameter is set to <c>Year</c>, the valid values of the Period parameter are 1, 2, 3, 4, and 5.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// <para>The unit of the subscription duration if you specify subscription as the new billing method for the cloud desktop.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("PeriodUnit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

        /// <summary>
        /// <para>The ID of the promotional activity.</para>
        /// 
        /// <b>Example:</b>
        /// <para>500038360030606</para>
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

        [NameInMap("ResellerOwnerUid")]
        [Validation(Required=false)]
        public long? ResellerOwnerUid { get; set; }

        /// <summary>
        /// <remarks>
        /// <para> This parameter is in invitational preview and not publicly available.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>internal only</para>
        /// </summary>
        [NameInMap("UseDuration")]
        [Validation(Required=false)]
        public int? UseDuration { get; set; }

    }

}
