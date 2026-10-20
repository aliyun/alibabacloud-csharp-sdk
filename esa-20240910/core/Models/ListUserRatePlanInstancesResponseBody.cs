// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListUserRatePlanInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>The plan instances that meet the query conditions under the user.</para>
        /// </summary>
        [NameInMap("InstanceInfo")]
        [Validation(Required=false)]
        public List<ListUserRatePlanInstancesResponseBodyInstanceInfo> InstanceInfo { get; set; }
        public class ListUserRatePlanInstancesResponseBodyInstanceInfo : TeaModel {
            /// <summary>
            /// <para>The billing method. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>PREPAY</b>: Subscription.</description></item>
            /// <item><description><b>POSTPAY</b>: Pay-as-you-go.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PREPAY</para>
            /// </summary>
            [NameInMap("BillingMode")]
            [Validation(Required=false)]
            public string BillingMode { get; set; }

            /// <summary>
            /// <para>If this parameter is empty, no bot protection instance is purchased for the plan. If a value is returned, a bot protection instance is purchased for the plan. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>enterprise_bot: Web edition.</para>
            /// </description></item>
            /// <item><description><para>enterprise_bot_with_app: App edition.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>enterprise_bot</para>
            /// </summary>
            [NameInMap("BotInstanceLevel")]
            [Validation(Required=false)]
            public string BotInstanceLevel { get; set; }

            /// <summary>
            /// <para>The prepaid number of bot requests in the plan. Unit: 10,000 requests.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("BotRequest")]
            [Validation(Required=false)]
            public string BotRequest { get; set; }

            /// <summary>
            /// <para>The acceleration regions where the site can be bound. Multiple regions are separated by commas (,). Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>domestic</b>: Chinese mainland.</description></item>
            /// <item><description><b>overseas</b>: Global (excluding the Chinese mainland).</description></item>
            /// <item><description><b>global</b>: Global (including the Chinese mainland).</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>domestic,overseas</para>
            /// </summary>
            [NameInMap("Coverages")]
            [Validation(Required=false)]
            public string Coverages { get; set; }

            /// <summary>
            /// <para>The creation time of the plan instance. The time is displayed in UTC and formatted as yyyy-MM-ddTHH:mm:ssZ in accordance with ISO 8601.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-04-19T11:15:20Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The prepaid China network acceleration traffic in the plan. Unit: GB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("CrossborderTraffic")]
            [Validation(Required=false)]
            public string CrossborderTraffic { get; set; }

            /// <summary>
            /// <para>The specifications of the Anti-DDoS instance in the plan for the Chinese mainland.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn_300</para>
            /// </summary>
            [NameInMap("DdosBurstableDomesticProtection")]
            [Validation(Required=false)]
            public string DdosBurstableDomesticProtection { get; set; }

            /// <summary>
            /// <para>The specifications of the Anti-DDoS instance in the plan for regions outside the Chinese mainland.</para>
            /// 
            /// <b>Example:</b>
            /// <para>overseas_300</para>
            /// </summary>
            [NameInMap("DdosBurstableOverseasProtection")]
            [Validation(Required=false)]
            public string DdosBurstableOverseasProtection { get; set; }

            /// <summary>
            /// <para>If this parameter is empty, no Anti-DDoS instance is purchased for the plan. If a value is returned, an Anti-DDoS instance is purchased for the plan, and the value is <c>esa_ddos_instance</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>esa_ddos_instance</para>
            /// </summary>
            [NameInMap("DdosInstanceLevel")]
            [Validation(Required=false)]
            public string DdosInstanceLevel { get; set; }

            /// <summary>
            /// <para>The subscription duration of the plan instance. Unit: months.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public int? Duration { get; set; }

            /// <summary>
            /// <para>The prepaid number of Edge Routine (ER) requests in the plan. Unit: 10,000 requests.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("EdgeRoutineRquest")]
            [Validation(Required=false)]
            public string EdgeRoutineRquest { get; set; }

            /// <summary>
            /// <para>The prepaid number of Web Application Firewall (WAF) requests in the plan. Unit: 10,000 requests.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("EdgeWafRequest")]
            [Validation(Required=false)]
            public string EdgeWafRequest { get; set; }

            /// <summary>
            /// <para>The expiration time of the plan instance. The time is displayed in UTC and formatted as yyyy-MM-ddTHH:mm:ssZ in accordance with ISO 8601.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-04-19T11:15:20Z</para>
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sp-xcdn-96wblslz****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The prepaid Layer 4 proxy traffic in the plan for the Chinese mainland. Unit: GB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Layer4Traffic")]
            [Validation(Required=false)]
            public string Layer4Traffic { get; set; }

            /// <summary>
            /// <para>The prepaid Layer 4 proxy traffic in the plan for regions outside the Chinese mainland. Unit: GB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Layer4TrafficIntl")]
            [Validation(Required=false)]
            public string Layer4TrafficIntl { get; set; }

            [NameInMap("OwnerId")]
            [Validation(Required=false)]
            public string OwnerId { get; set; }

            /// <summary>
            /// <para>The name of the plan corresponding to the plan instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>basic</para>
            /// </summary>
            [NameInMap("PlanName")]
            [Validation(Required=false)]
            public string PlanName { get; set; }

            /// <summary>
            /// <para>The prepaid Layer 7 acceleration traffic in the plan. Unit: GB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("PlanTraffic")]
            [Validation(Required=false)]
            public string PlanTraffic { get; set; }

            /// <summary>
            /// <para>The type of the plan corresponding to the plan instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>normal</b>: Fixed plan.</description></item>
            /// <item><description><b>enterprise</b>: Enterprise plan.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>normal</para>
            /// </summary>
            [NameInMap("PlanType")]
            [Validation(Required=false)]
            public string PlanType { get; set; }

            /// <summary>
            /// <para>The auto-renewal cycle. Unit: months.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6</para>
            /// </summary>
            [NameInMap("RenewalDuration")]
            [Validation(Required=false)]
            public long? RenewalDuration { get; set; }

            /// <summary>
            /// <para>The auto-renewal status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>nomal: Normal.</description></item>
            /// <item><description>auto_renewal: Auto-renewal.</description></item>
            /// <item><description>not_renewal: Non-renewal.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>nomal</para>
            /// </summary>
            [NameInMap("RenewalStatus")]
            [Validation(Required=false)]
            public string RenewalStatus { get; set; }

            [NameInMap("ResourceOwner")]
            [Validation(Required=false)]
            public long? ResourceOwner { get; set; }

            [NameInMap("ShareType")]
            [Validation(Required=false)]
            public string ShareType { get; set; }

            /// <summary>
            /// <para>The quota for the number of sites under the plan instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SiteQuota")]
            [Validation(Required=false)]
            public string SiteQuota { get; set; }

            /// <summary>
            /// <para>The list of sites bound to the current plan instance.</para>
            /// </summary>
            [NameInMap("Sites")]
            [Validation(Required=false)]
            public List<ListUserRatePlanInstancesResponseBodyInstanceInfoSites> Sites { get; set; }
            public class ListUserRatePlanInstancesResponseBodyInstanceInfoSites : TeaModel {
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
                /// <item><description><b>pending</b>: The site is pending configuration.</description></item>
                /// <item><description><b>active</b>: The site is activated.</description></item>
                /// <item><description><b>offline</b>: The site is offline.</description></item>
                /// <item><description><b>moved</b>: The site is replaced.</description></item>
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
            /// <para>The prepaid number of smart routing requests in the plan. Unit: 10,000 requests.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("SmartRoutingRequest")]
            [Validation(Required=false)]
            public string SmartRoutingRequest { get; set; }

            /// <summary>
            /// <para>The prepaid number of HTTP requests in the plan. Unit: 10,000 requests.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("StaticRequest")]
            [Validation(Required=false)]
            public string StaticRequest { get; set; }

            /// <summary>
            /// <para>The instance status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>online</b>: The instance is in normal service status.</description></item>
            /// <item><description><b>offline</b>: The instance has expired but is not overdue, and is in an inactive state.</description></item>
            /// <item><description><b>disable</b>: The instance is released.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>online</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The subscription type of the plan. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>entranceplan: Free Edition (Chinese mainland).</description></item>
            /// <item><description>entranceplan_intl: Free Edition (International).</description></item>
            /// <item><description>basicplan: Basic Edition.</description></item>
            /// <item><description>standardplan: Standard Edition.</description></item>
            /// <item><description>advancedplan: Advanced Edition.</description></item>
            /// <item><description>enterpriseplan: Enterprise Edition.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>basicplan</para>
            /// </summary>
            [NameInMap("SubscribeType")]
            [Validation(Required=false)]
            public string SubscribeType { get; set; }

        }

        /// <summary>
        /// <para>The current page number, which is the same as the PageNumber request parameter.</para>
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
        /// <para>The total number of entries.</para>
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
