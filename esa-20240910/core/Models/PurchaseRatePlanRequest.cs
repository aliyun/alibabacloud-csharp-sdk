// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class PurchaseRatePlanRequest : TeaModel {
        [NameInMap("Amount")]
        [Validation(Required=false)]
        public int? Amount { get; set; }

        /// <summary>
        /// <para>Automatic payment.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>Auto-renewal:</para>
        /// <list type="bullet">
        /// <item><description>true: Enable auto-renewal.</description></item>
        /// <item><description>false: Disable auto-renewal.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// <para>Billing type</para>
        /// <list type="bullet">
        /// <item><description>PREPAY: Prepaid.</description></item>
        /// <item><description>POSTPAY: Postpaid.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PREPAY</para>
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// <para>Acceleration area:</para>
        /// <list type="bullet">
        /// <item><description>domestic: Mainland China only.</description></item>
        /// <item><description>global: Worldwide.</description></item>
        /// <item><description>overseas: Global (excluding Mainland China).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>domestic</para>
        /// </summary>
        [NameInMap("Coverage")]
        [Validation(Required=false)]
        public string Coverage { get; set; }

        /// <summary>
        /// <para>Subscription period (in months).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// <para>Package code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>entranceplan</para>
        /// </summary>
        [NameInMap("PlanCode")]
        [Validation(Required=false)]
        public string PlanCode { get; set; }

        /// <summary>
        /// <para>Package name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>basic</para>
        /// </summary>
        [NameInMap("PlanName")]
        [Validation(Required=false)]
        public string PlanName { get; set; }

        /// <summary>
        /// <para>Site name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test.com</para>
        /// </summary>
        [NameInMap("SiteName")]
        [Validation(Required=false)]
        public string SiteName { get; set; }

        /// <summary>
        /// <para>Site access type:</para>
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
