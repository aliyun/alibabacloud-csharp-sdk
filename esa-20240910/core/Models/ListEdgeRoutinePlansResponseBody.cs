// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListEdgeRoutinePlansResponseBody : TeaModel {
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
        /// <para>The number of entries per page. Valid values: 1 to 500.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The plans.</para>
        /// </summary>
        [NameInMap("PlanInfo")]
        [Validation(Required=false)]
        public List<ListEdgeRoutinePlansResponseBodyPlanInfo> PlanInfo { get; set; }
        public class ListEdgeRoutinePlansResponseBodyPlanInfo : TeaModel {
            /// <summary>
            /// <para>The billing method. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PREPAY: subscription.</description></item>
            /// <item><description>POSTPAY: pay-as-you-go.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>POSTPAY</para>
            /// </summary>
            [NameInMap("BillingMode")]
            [Validation(Required=false)]
            public string BillingMode { get; set; }

            /// <summary>
            /// <para>The maximum number of versions that each routine supports.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("ErRoutineCodeVersionQuota")]
            [Validation(Required=false)]
            public string ErRoutineCodeVersionQuota { get; set; }

            /// <summary>
            /// <para>The maximum of routines that can be created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("ErRoutineQuota")]
            [Validation(Required=false)]
            public string ErRoutineQuota { get; set; }

            /// <summary>
            /// <para>The maximum number of websites with which each routine can be associated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("ErRoutineRouteSiteCountQuota")]
            [Validation(Required=false)]
            public string ErRoutineRouteSiteCountQuota { get; set; }

            /// <summary>
            /// <para>The payment method. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>er_free</description></item>
            /// <item><description>er_pay</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>er_free</para>
            /// </summary>
            [NameInMap("PaymentMethod")]
            [Validation(Required=false)]
            public string PaymentMethod { get; set; }

            /// <summary>
            /// <para>The plan name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test_plan</para>
            /// </summary>
            [NameInMap("PlanName")]
            [Validation(Required=false)]
            public string PlanName { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0AEDAF20-4DDF-4165-8750-47FF9C1929C9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>The total number of pages returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalPage")]
        [Validation(Required=false)]
        public int? TotalPage { get; set; }

    }

}
