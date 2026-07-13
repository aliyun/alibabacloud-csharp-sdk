// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDnsGtmInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of Global Traffic Manager (GTM) instances.</para>
        /// </summary>
        [NameInMap("GtmInstances")]
        [Validation(Required=false)]
        public List<DescribeDnsGtmInstancesResponseBodyGtmInstances> GtmInstances { get; set; }
        public class DescribeDnsGtmInstancesResponseBodyGtmInstances : TeaModel {
            /// <summary>
            /// <para>The configuration of the instance.</para>
            /// </summary>
            [NameInMap("Config")]
            [Validation(Required=false)]
            public DescribeDnsGtmInstancesResponseBodyGtmInstancesConfig Config { get; set; }
            public class DescribeDnsGtmInstancesResponseBodyGtmInstancesConfig : TeaModel {
                /// <summary>
                /// <para>The alert notification methods.</para>
                /// </summary>
                [NameInMap("AlertConfig")]
                [Validation(Required=false)]
                public List<DescribeDnsGtmInstancesResponseBodyGtmInstancesConfigAlertConfig> AlertConfig { get; set; }
                public class DescribeDnsGtmInstancesResponseBodyGtmInstancesConfigAlertConfig : TeaModel {
                    /// <summary>
                    /// <para>Indicates whether DingTalk notifications are configured. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para>true: configured</para>
                    /// </description></item>
                    /// <item><description><para>false or null: not configured</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("DingtalkNotice")]
                    [Validation(Required=false)]
                    public string DingtalkNotice { get; set; }

                    /// <summary>
                    /// <para>Indicates whether email notifications are configured. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para>true: configured</para>
                    /// </description></item>
                    /// <item><description><para>false or null: not configured</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("EmailNotice")]
                    [Validation(Required=false)]
                    public string EmailNotice { get; set; }

                    /// <summary>
                    /// <para>The type of the alert event. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para>ADDR_ALERT: The address is unavailable.</para>
                    /// </description></item>
                    /// <item><description><para>ADDR_RESUME: The address is restored.</para>
                    /// </description></item>
                    /// <item><description><para>ADDR_POOL_GROUP_UNAVAILABLE: The address pool collection is unavailable.</para>
                    /// </description></item>
                    /// <item><description><para>ADDR_POOL_GROUP_AVAILABLE: The address pool collection is restored.</para>
                    /// </description></item>
                    /// <item><description><para>ACCESS_STRATEGY_POOL_GROUP_SWITCH: A switchover occurs between the primary and secondary address pools.</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ADDR_ALERT</para>
                    /// </summary>
                    [NameInMap("NoticeType")]
                    [Validation(Required=false)]
                    public string NoticeType { get; set; }

                    /// <summary>
                    /// <para>Indicates whether text message notifications are configured. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para>true: configured</para>
                    /// </description></item>
                    /// <item><description><para>false or null: not configured</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("SmsNotice")]
                    [Validation(Required=false)]
                    public string SmsNotice { get; set; }

                }

                /// <summary>
                /// <para>The alert contact group. The value is a JSON-formatted list of strings.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[&quot;test1&quot;,&quot;test2&quot;]</para>
                /// </summary>
                [NameInMap("AlertGroup")]
                [Validation(Required=false)]
                public string AlertGroup { get; set; }

                /// <summary>
                /// <para>The type of the CNAME domain name used for access. Valid value:</para>
                /// <list type="bullet">
                /// <item><description>PUBLIC: for Internet access</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>PUBLIC</para>
                /// </summary>
                [NameInMap("CnameType")]
                [Validation(Required=false)]
                public string CnameType { get; set; }

                /// <summary>
                /// <para>The name of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>instanceTest</para>
                /// </summary>
                [NameInMap("InstanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

                /// <summary>
                /// <para>The method to access the instance over the Internet using a CNAME record. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>CUSTOM: custom</para>
                /// </description></item>
                /// <item><description><para>SYSTEM_ASSIGN: system-assigned (This feature is disabled.)</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>CUSTOM</para>
                /// </summary>
                [NameInMap("PublicCnameMode")]
                [Validation(Required=false)]
                public string PublicCnameMode { get; set; }

                /// <summary>
                /// <para>The hostname for Internet access.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test.rr</para>
                /// </summary>
                [NameInMap("PublicRr")]
                [Validation(Required=false)]
                public string PublicRr { get; set; }

                /// <summary>
                /// <para>The user\&quot;s service domain name that is accessible over the Internet.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dns-example.top</para>
                /// </summary>
                [NameInMap("PublicUserDomainName")]
                [Validation(Required=false)]
                public string PublicUserDomainName { get; set; }

                /// <summary>
                /// <para>The domain name used for Internet access.</para>
                /// 
                /// <b>Example:</b>
                /// <para>gtm-cn-wwo3a3hbz**.dns-example.top</para>
                /// </summary>
                [NameInMap("PublicZoneName")]
                [Validation(Required=false)]
                public string PublicZoneName { get; set; }

                /// <summary>
                /// <para>The mode of the access policy. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>LATENCY: latency-based</para>
                /// </description></item>
                /// <item><description><para>GEO: geography-based</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>GEO</para>
                /// </summary>
                [NameInMap("StrategyMode")]
                [Validation(Required=false)]
                public string StrategyMode { get; set; }

                /// <summary>
                /// <para>The global TTL.</para>
                /// 
                /// <b>Example:</b>
                /// <para>60</para>
                /// </summary>
                [NameInMap("Ttl")]
                [Validation(Required=false)]
                public int? Ttl { get; set; }

            }

            /// <summary>
            /// <para>The time when the instance was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-10-14T06:58Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The timestamp that indicates when the instance was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1602658709000</para>
            /// </summary>
            [NameInMap("CreateTimestamp")]
            [Validation(Required=false)]
            public long? CreateTimestamp { get; set; }

            /// <summary>
            /// <para>The time when the instance expires.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-10-14T06:58Z</para>
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }

            /// <summary>
            /// <para>The timestamp that indicates when the instance expires.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1602658709000</para>
            /// </summary>
            [NameInMap("ExpireTimestamp")]
            [Validation(Required=false)]
            public long? ExpireTimestamp { get; set; }

            /// <summary>
            /// <para>The ID of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>gtm-cn-wwo3a3hbz**</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The billing method. Valid value:</para>
            /// <list type="bullet">
            /// <item><description>Subscription</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Subscription</para>
            /// </summary>
            [NameInMap("PaymentType")]
            [Validation(Required=false)]
            public string PaymentType { get; set; }

            /// <summary>
            /// <para>The ID of the resource group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>resourceGroupid123</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The total quota of text message notifications.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SmsQuota")]
            [Validation(Required=false)]
            public int? SmsQuota { get; set; }

            /// <summary>
            /// <para>The total number of health check tasks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TaskQuota")]
            [Validation(Required=false)]
            public int? TaskQuota { get; set; }

            /// <summary>
            /// <para>The used quota.</para>
            /// </summary>
            [NameInMap("UsedQuota")]
            [Validation(Required=false)]
            public DescribeDnsGtmInstancesResponseBodyGtmInstancesUsedQuota UsedQuota { get; set; }
            public class DescribeDnsGtmInstancesResponseBodyGtmInstancesUsedQuota : TeaModel {
                /// <summary>
                /// <para>The total number of DingTalk messages that were sent.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("DingtalkUsedCount")]
                [Validation(Required=false)]
                public int? DingtalkUsedCount { get; set; }

                /// <summary>
                /// <para>The total number of emails that were sent.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("EmailUsedCount")]
                [Validation(Required=false)]
                public int? EmailUsedCount { get; set; }

                /// <summary>
                /// <para>The total number of text messages that were sent.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("SmsUsedCount")]
                [Validation(Required=false)]
                public int? SmsUsedCount { get; set; }

                /// <summary>
                /// <para>The number of health check tasks that were created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("TaskUsedCount")]
                [Validation(Required=false)]
                public int? TaskUsedCount { get; set; }

            }

            /// <summary>
            /// <para>The version of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>standard</para>
            /// </summary>
            [NameInMap("VersionCode")]
            [Validation(Required=false)]
            public string VersionCode { get; set; }

        }

        /// <summary>
        /// <para>The number of the page returned. The value starts from <b>1</b>. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Maximum value: 100. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The unique request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>84314904-D047-4176-A0EC-256D7F68C7F5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalItems")]
        [Validation(Required=false)]
        public int? TotalItems { get; set; }

        /// <summary>
        /// <para>The total number of pages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("TotalPages")]
        [Validation(Required=false)]
        public int? TotalPages { get; set; }

    }

}
