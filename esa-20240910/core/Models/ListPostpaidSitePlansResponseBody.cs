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
        /// <para>The page size. Default value: 20. Maximum value: 500. Valid values: any integer from 1 to 500.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The pay-as-you-go plan details.</para>
        /// </summary>
        [NameInMap("PlanInfo")]
        [Validation(Required=false)]
        public List<ListPostpaidSitePlansResponseBodyPlanInfo> PlanInfo { get; set; }
        public class ListPostpaidSitePlansResponseBodyPlanInfo : TeaModel {
            /// <summary>
            /// <para>The billable methods of the plan. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>dps_month95: monthly 95th percentile billing method.</description></item>
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
            /// <item><description>PREPAY: subscription.</description></item>
            /// <item><description>POSTPAY: pay-as-you-go.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PREPAY</para>
            /// </summary>
            [NameInMap("BillingMode")]
            [Validation(Required=false)]
            public string BillingMode { get; set; }

            /// <summary>
            /// <para>The acceleration regions to which sites can be added under the plan. Multiple values are separated by commas (,). Valid values:</para>
            /// <list type="bullet">
            /// <item><description>domestic: the Chinese mainland.</description></item>
            /// <item><description>overseas: global (excluding the Chinese mainland).</description></item>
            /// <item><description>global: global (including the Chinese mainland).</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>domestic</para>
            /// </summary>
            [NameInMap("Coverages")]
            [Validation(Required=false)]
            public string Coverages { get; set; }

            /// <summary>
            /// <para>The name of the plan, which serves as a unique identifier in English.</para>
            /// 
            /// <b>Example:</b>
            /// <para>basic</para>
            /// </summary>
            [NameInMap("PlanName")]
            [Validation(Required=false)]
            public string PlanName { get; set; }

            /// <summary>
            /// <para>The plan description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>测试版套餐</para>
            /// </summary>
            [NameInMap("PlanNameCn")]
            [Validation(Required=false)]
            public string PlanNameCn { get; set; }

            /// <summary>
            /// <para>The plan type of the plan instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>normal: fixed edition plan.</description></item>
            /// <item><description>enterprise: enterprise edition plan.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>normal</para>
            /// </summary>
            [NameInMap("PlanType")]
            [Validation(Required=false)]
            public string PlanType { get; set; }

            /// <summary>
            /// <para>The sale status of the plan. Valid values for enterprise edition plans:</para>
            /// <list type="bullet">
            /// <item><description>saled: sold.</description></item>
            /// <item><description>upgrading: specification change in progress.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>saled</para>
            /// </summary>
            [NameInMap("SaleStatus")]
            [Validation(Required=false)]
            public string SaleStatus { get; set; }

            /// <summary>
            /// <para>The site quantity quota.</para>
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
