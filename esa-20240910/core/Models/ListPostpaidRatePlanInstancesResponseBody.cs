// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListPostpaidRatePlanInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of instances.</para>
        /// </summary>
        [NameInMap("InstanceInfo")]
        [Validation(Required=false)]
        public List<ListPostpaidRatePlanInstancesResponseBodyInstanceInfo> InstanceInfo { get; set; }
        public class ListPostpaidRatePlanInstancesResponseBodyInstanceInfo : TeaModel {
            /// <summary>
            /// <para>The billing method. Valid value:</para>
            /// <list type="bullet">
            /// <item><description><c>dps_month95</c>: Monthly 95th percentile.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SUBSCRIBE</para>
            /// </summary>
            [NameInMap("BillingMethod")]
            [Validation(Required=false)]
            public string BillingMethod { get; set; }

            /// <summary>
            /// <para>The billing mode. Valid value:</para>
            /// <list type="bullet">
            /// <item><description><c>POSTPAY</c>: pay-as-you-go.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>POSTPAY</para>
            /// </summary>
            [NameInMap("BillingMode")]
            [Validation(Required=false)]
            public string BillingMode { get; set; }

            /// <summary>
            /// <para>The coverage area of the instance. Only sites within this area can be bound to the instance. If multiple areas are supported, they are separated by a comma (<c>,</c>). Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>domestic</c>: Chinese mainland.</para>
            /// </description></item>
            /// <item><description><para><c>overseas</c>: Regions outside the Chinese mainland.</para>
            /// </description></item>
            /// <item><description><para><c>global</c>: Global (including the Chinese mainland).</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>domestic</para>
            /// </summary>
            [NameInMap("Coverages")]
            [Validation(Required=false)]
            public string Coverages { get; set; }

            /// <summary>
            /// <para>The time when the instance was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>YYYY-MM-DDThh:mm:ssZ</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The time of a scheduled configuration change.</para>
            /// 
            /// <b>Example:</b>
            /// <para>YYYY-MM-DDThh:mm:ssZ</para>
            /// </summary>
            [NameInMap("ExpectedUpdateTime")]
            [Validation(Required=false)]
            public string ExpectedUpdateTime { get; set; }

            /// <summary>
            /// <para>The ID of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sp-xcdn-96wblslz****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The plan name in English.</para>
            /// 
            /// <b>Example:</b>
            /// <para>basic</para>
            /// </summary>
            [NameInMap("PlanName")]
            [Validation(Required=false)]
            public string PlanName { get; set; }

            /// <summary>
            /// <para>The plan name in Chinese.</para>
            /// 
            /// <b>Example:</b>
            /// <para>测试套餐</para>
            /// </summary>
            [NameInMap("PlanNameCn")]
            [Validation(Required=false)]
            public string PlanNameCn { get; set; }

            /// <summary>
            /// <para>The type of the plan. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>normal</c>: Normal plan.</para>
            /// </description></item>
            /// <item><description><para><c>enterprise</c>: Enterprise plan.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>normal</para>
            /// </summary>
            [NameInMap("PlanType")]
            [Validation(Required=false)]
            public string PlanType { get; set; }

            /// <summary>
            /// <para>The maximum number of sites that can be bound to the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SiteQuota")]
            [Validation(Required=false)]
            public string SiteQuota { get; set; }

            /// <summary>
            /// <para>A list of sites bound to the instance.</para>
            /// </summary>
            [NameInMap("Sites")]
            [Validation(Required=false)]
            public List<ListPostpaidRatePlanInstancesResponseBodyInstanceInfoSites> Sites { get; set; }
            public class ListPostpaidRatePlanInstancesResponseBodyInstanceInfoSites : TeaModel {
                /// <summary>
                /// <para>The ID of the site.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123456****</para>
                /// </summary>
                [NameInMap("SiteId")]
                [Validation(Required=false)]
                public long? SiteId { get; set; }

                /// <summary>
                /// <para>The name of the site.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example.com</para>
                /// </summary>
                [NameInMap("SiteName")]
                [Validation(Required=false)]
                public string SiteName { get; set; }

                /// <summary>
                /// <para>The status of the site. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>pending</c>: The site is awaiting configuration.</para>
                /// </description></item>
                /// <item><description><para><c>active</c>: The site is active.</para>
                /// </description></item>
                /// <item><description><para><c>offline</c>: The site is offline.</para>
                /// </description></item>
                /// <item><description><para><c>moved</c>: The site has been replaced.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>pending</para>
                /// </summary>
                [NameInMap("SiteStatus")]
                [Validation(Required=false)]
                public string SiteStatus { get; set; }

            }

            /// <summary>
            /// <para>The status of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>online</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID, used for troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15C66C7B-671A-4297-9187-2C4477247A123425345</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>The total number of pages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalPage")]
        [Validation(Required=false)]
        public int? TotalPage { get; set; }

    }

}
