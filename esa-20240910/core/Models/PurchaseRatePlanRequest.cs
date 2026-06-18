// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class PurchaseRatePlanRequest : TeaModel {
        /// <summary>
        /// <para>The number of plans to purchase.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Amount")]
        [Validation(Required=false)]
        public int? Amount { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable automatic payment.
        /// Set this parameter to true when you directly call this operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable auto-renewal. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Auto-renewal is enabled.</description></item>
        /// <item><description>false: Auto-renewal is disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// <para>The channel field.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxWodkxxx</para>
        /// </summary>
        [NameInMap("Channel")]
        [Validation(Required=false)]
        public string Channel { get; set; }

        /// <summary>
        /// <para>The billing method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PREPAY: subscription.</description></item>
        /// <item><description>POSTPAY: pay-as-you-go.
        /// Set this parameter to PREPAY when you directly call this operation.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PREPAY</para>
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// <para>The acceleration region. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>domestic: the Chinese mainland only.</description></item>
        /// <item><description>global: global.</description></item>
        /// <item><description>overseas: global (excluding the Chinese mainland).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>domestic</para>
        /// </summary>
        [NameInMap("Coverage")]
        [Validation(Required=false)]
        public string Coverage { get; set; }

        /// <summary>
        /// <para>The purchase period, in months.
        /// This parameter is required when you directly call this operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// <para>The plan code.</para>
        /// <para>China site</para>
        /// <list type="bullet">
        /// <item><description>Free Edition: entranceplan</description></item>
        /// <item><description>Basic: basicplan</description></item>
        /// <item><description>Standard: standardplan</description></item>
        /// <item><description>Premium: advancedplan</description></item>
        /// </list>
        /// <para>International site</para>
        /// <list type="bullet">
        /// <item><description>Entrance: entranceplan</description></item>
        /// <item><description>Pro: standardplan</description></item>
        /// <item><description>Premium: advancedpla.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>basicplan</para>
        /// </summary>
        [NameInMap("PlanCode")]
        [Validation(Required=false)]
        public string PlanCode { get; set; }

        /// <summary>
        /// <para>The plan name.</para>
        /// <para>China site</para>
        /// <list type="bullet">
        /// <item><description>Free Edition: entranceplan</description></item>
        /// <item><description>Basic: basic</description></item>
        /// <item><description>Standard: medium</description></item>
        /// <item><description>Premium: high</description></item>
        /// </list>
        /// <para>International site</para>
        /// <list type="bullet">
        /// <item><description>Entrance: entranceplan_intl</description></item>
        /// <item><description>Pro: basicplan_intl</description></item>
        /// <item><description>Premium: vipplan_intl</description></item>
        /// </list>
        /// <remarks>
        /// <para>Note: For Enterprise Edition plans, the plan name is provided after backend configuration.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>basic</para>
        /// </summary>
        [NameInMap("PlanName")]
        [Validation(Required=false)]
        public string PlanName { get; set; }

        /// <summary>
        /// <para>The site name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test.com</para>
        /// </summary>
        [NameInMap("SiteName")]
        [Validation(Required=false)]
        public string SiteName { get; set; }

        /// <summary>
        /// <para>The site access type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>NS: NS access.</description></item>
        /// <item><description>CNAME: CNAME access.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CNAME</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
