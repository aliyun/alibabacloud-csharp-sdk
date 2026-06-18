// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListUserRatePlanInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>An array of plan instances that meet the specified criteria.</para>
        /// </summary>
        [NameInMap("InstanceInfo")]
        [Validation(Required=false)]
        public List<ListUserRatePlanInstancesResponseBodyInstanceInfo> InstanceInfo { get; set; }
        public class ListUserRatePlanInstancesResponseBodyInstanceInfo : TeaModel {
            /// <summary>
            /// <para>The billing method. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>PREPAY</b>: subscription.</para>
            /// </description></item>
            /// <item><description><para><b>POSTPAY</b>: pay-as-you-go.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PREPAY</para>
            /// </summary>
            [NameInMap("BillingMode")]
            [Validation(Required=false)]
            public string BillingMode { get; set; }

            [NameInMap("BotInstanceLevel")]
            [Validation(Required=false)]
            public string BotInstanceLevel { get; set; }

            [NameInMap("BotRequest")]
            [Validation(Required=false)]
            public string BotRequest { get; set; }

            /// <summary>
            /// <para>The acceleration regions covered by the plan instance. Multiple values are separated by commas (,). Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>domestic</b>: The Chinese mainland.</para>
            /// </description></item>
            /// <item><description><para><b>overseas</b>: Regions outside the Chinese mainland.</para>
            /// </description></item>
            /// <item><description><para><b>global</b>: Global (including the Chinese mainland).</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>domestic,overseas</para>
            /// </summary>
            [NameInMap("Coverages")]
            [Validation(Required=false)]
            public string Coverages { get; set; }

            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>YYYY-MM-DDThh:mm:ssZ</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("CrossborderTraffic")]
            [Validation(Required=false)]
            public string CrossborderTraffic { get; set; }

            [NameInMap("DdosBurstableDomesticProtection")]
            [Validation(Required=false)]
            public string DdosBurstableDomesticProtection { get; set; }

            [NameInMap("DdosBurstableOverseasProtection")]
            [Validation(Required=false)]
            public string DdosBurstableOverseasProtection { get; set; }

            [NameInMap("DdosInstanceLevel")]
            [Validation(Required=false)]
            public string DdosInstanceLevel { get; set; }

            /// <summary>
            /// <para>The duration in months.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public int? Duration { get; set; }

            [NameInMap("EdgeRoutineRquest")]
            [Validation(Required=false)]
            public string EdgeRoutineRquest { get; set; }

            [NameInMap("EdgeWafRequest")]
            [Validation(Required=false)]
            public string EdgeWafRequest { get; set; }

            /// <summary>
            /// <para>The expiration time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>YYYY-MM-DDThh:mm:ssZ</para>
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }

            /// <summary>
            /// <para>The plan instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sp-xcdn-96wblslz****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("Layer4Traffic")]
            [Validation(Required=false)]
            public string Layer4Traffic { get; set; }

            [NameInMap("Layer4TrafficIntl")]
            [Validation(Required=false)]
            public string Layer4TrafficIntl { get; set; }

            /// <summary>
            /// <para>The plan name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>basic</para>
            /// </summary>
            [NameInMap("PlanName")]
            [Validation(Required=false)]
            public string PlanName { get; set; }

            [NameInMap("PlanTraffic")]
            [Validation(Required=false)]
            public string PlanTraffic { get; set; }

            /// <summary>
            /// <para>The plan type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>normal</b>: The normal plan.</para>
            /// </description></item>
            /// <item><description><para><b>enterprise</b>: The enterprise plan.</para>
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
            /// <b>Example:</b>
            /// <para>6</para>
            /// </summary>
            [NameInMap("RenewalDuration")]
            [Validation(Required=false)]
            public long? RenewalDuration { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>nomal</para>
            /// </summary>
            [NameInMap("RenewalStatus")]
            [Validation(Required=false)]
            public string RenewalStatus { get; set; }

            /// <summary>
            /// <para>The site quota.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SiteQuota")]
            [Validation(Required=false)]
            public string SiteQuota { get; set; }

            /// <summary>
            /// <para>The sites associated with this plan instance.</para>
            /// </summary>
            [NameInMap("Sites")]
            [Validation(Required=false)]
            public List<ListUserRatePlanInstancesResponseBodyInstanceInfoSites> Sites { get; set; }
            public class ListUserRatePlanInstancesResponseBodyInstanceInfoSites : TeaModel {
                /// <summary>
                /// <para>The site ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123456****</para>
                /// </summary>
                [NameInMap("SiteId")]
                [Validation(Required=false)]
                public long? SiteId { get; set; }

                /// <summary>
                /// <para>The site name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example.com</para>
                /// </summary>
                [NameInMap("SiteName")]
                [Validation(Required=false)]
                public string SiteName { get; set; }

                /// <summary>
                /// <para>The site status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>pending</b>: The site is pending configuration.</para>
                /// </description></item>
                /// <item><description><para><b>active</b>: The site is active.</para>
                /// </description></item>
                /// <item><description><para><b>offline</b>: The site is offline.</para>
                /// </description></item>
                /// <item><description><para><b>moved</b>: The site has been replaced.</para>
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

            [NameInMap("SmartRoutingRequest")]
            [Validation(Required=false)]
            public string SmartRoutingRequest { get; set; }

            [NameInMap("StaticRequest")]
            [Validation(Required=false)]
            public string StaticRequest { get; set; }

            /// <summary>
            /// <para>The instance status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>online</b>: The plan instance is active.</para>
            /// </description></item>
            /// <item><description><para><b>offline</b>: The plan instance is unavailable because it has expired but is still within the grace period.</para>
            /// </description></item>
            /// <item><description><para><b>disable</b>: The plan instance is released.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>online</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("SubscribeType")]
            [Validation(Required=false)]
            public string SubscribeType { get; set; }

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
        /// <para>The page size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CB1A380B-09F0-41BB-3C82-72F8FD6DA2FE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total count of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>68</para>
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
