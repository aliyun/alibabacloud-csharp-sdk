// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListPostpaidSitePlansResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 20. Maximum value: 500. Valid values: any integer from 1 to 500.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The details of the pay-as-you-go plan.</para>
        /// </summary>
        [NameInMap("PlanInfo")]
        [Validation(Required=false)]
        public List<ListPostpaidSitePlansResponseBodyPlanInfo> PlanInfo { get; set; }
        public class ListPostpaidSitePlansResponseBodyPlanInfo : TeaModel {
            /// <summary>
            /// <para>The billable methods of the plan. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>dps_month95: Monthly 95th percentile billing.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>dps_month95</para>
            /// </summary>
            [NameInMap("BillingMethod")]
            [Validation(Required=false)]
            public string BillingMethod { get; set; }

            /// <summary>
            /// <para>The payment type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PREPAY: Subscription.</description></item>
            /// <item><description>POSTPAY: Pay-as-you-go.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PREPAY</para>
            /// </summary>
            [NameInMap("BillingMode")]
            [Validation(Required=false)]
            public string BillingMode { get; set; }

            /// <summary>
            /// <para>The acceleration regions for sites that can be added to the plan. Separate multiple values with commas (,). Valid values:</para>
            /// <list type="bullet">
            /// <item><description>domestic: The Chinese mainland.</description></item>
            /// <item><description>overseas: Global (excluding the Chinese mainland).</description></item>
            /// <item><description>global: Global (including the Chinese mainland).</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>domestic</para>
            /// </summary>
            [NameInMap("Coverages")]
            [Validation(Required=false)]
            public string Coverages { get; set; }

            /// <summary>
            /// <para>The name of the plan, which is uniquely identified in English.</para>
            /// 
            /// <b>Example:</b>
            /// <para>basic</para>
            /// </summary>
            [NameInMap("PlanName")]
            [Validation(Required=false)]
            public string PlanName { get; set; }

            /// <summary>
            /// <para>The description of the plan.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Beta plan</para>
            /// </summary>
            [NameInMap("PlanNameCn")]
            [Validation(Required=false)]
            public string PlanNameCn { get; set; }

            /// <summary>
            /// <para>The plan type of the plan instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>normal: Fixed plan.</description></item>
            /// <item><description>enterprise: Enterprise plan.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>normal</para>
            /// </summary>
            [NameInMap("PlanType")]
            [Validation(Required=false)]
            public string PlanType { get; set; }

            /// <summary>
            /// <para>The sales status of the plan. For Enterprise plans, valid values are:</para>
            /// <list type="bullet">
            /// <item><description>saled: Sold.</description></item>
            /// <item><description>upgrading: Upgrading or downgrading.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>saled</para>
            /// </summary>
            [NameInMap("SaleStatus")]
            [Validation(Required=false)]
            public string SaleStatus { get; set; }

            /// <summary>
            /// <para>The quota for the number of sites.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SiteQuota")]
            [Validation(Required=false)]
            public string SiteQuota { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8CD541DB-CD83-5D0C-BE94-21B794074249</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>The total number of pages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalPage")]
        [Validation(Required=false)]
        public int? TotalPage { get; set; }

    }

}
