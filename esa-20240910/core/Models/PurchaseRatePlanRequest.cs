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
        /// <para>Specifies whether to enable automatic payment. Set this parameter to true when you directly call the operation.</para>
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
        /// <item><description>true: Enables auto-renewal.</description></item>
        /// <item><description>false: Disables auto-renewal.</description></item>
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
        /// <item><description>PREPAY: Subscription.</description></item>
        /// <item><description>POSTPAY: Pay-as-you-go.
        /// Set this parameter to PREPAY when you directly call the operation.</description></item>
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
        /// <item><description>domestic: The Chinese mainland only.</description></item>
        /// <item><description>global: Global.</description></item>
        /// <item><description>overseas: Global, excluding the Chinese mainland.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>domestic</para>
        /// </summary>
        [NameInMap("Coverage")]
        [Validation(Required=false)]
        public string Coverage { get; set; }

        /// <summary>
        /// <para>The overage policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>limit_speed</para>
        /// </summary>
        [NameInMap("OveragePolicy")]
        [Validation(Required=false)]
        public string OveragePolicy { get; set; }

        /// <summary>
        /// <para>The subscription period. Unit: months. This parameter is required when you directly call the operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// <para>The code of the plan.</para>
        /// <para>China site</para>
        /// <list type="bullet">
        /// <item><description>Free Edition: entranceplan</description></item>
        /// <item><description>Basic Edition: basicplan</description></item>
        /// <item><description>Standard Edition: standardplan</description></item>
        /// <item><description>Advanced Edition: advancedplan</description></item>
        /// </list>
        /// <para>International site</para>
        /// <list type="bullet">
        /// <item><description>Entrance: entranceplan</description></item>
        /// <item><description>Pro: standardplan</description></item>
        /// <item><description>Premium: advancedpla</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>basicplan</para>
        /// </summary>
        [NameInMap("PlanCode")]
        [Validation(Required=false)]
        public string PlanCode { get; set; }

        /// <summary>
        /// <para>The name of the plan.</para>
        /// <para>China site</para>
        /// <list type="bullet">
        /// <item><description>Free Edition: entranceplan</description></item>
        /// <item><description>Basic Edition: basic</description></item>
        /// <item><description>Standard Edition: medium</description></item>
        /// <item><description>Advanced Edition: high</description></item>
        /// </list>
        /// <para>International site</para>
        /// <list type="bullet">
        /// <item><description>Entrance: entranceplan_intl</description></item>
        /// <item><description>Pro: basicplan_intl</description></item>
        /// <item><description>Premium: vipplan_intl</description></item>
        /// </list>
        /// <para>Note: For Enterprise Edition plans, the plan name must be configured in the backend and then provided to the customer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>basic</para>
        /// </summary>
        [NameInMap("PlanName")]
        [Validation(Required=false)]
        public string PlanName { get; set; }

        /// <summary>
        /// <para>The name of the site.</para>
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
