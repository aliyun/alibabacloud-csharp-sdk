// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDnsGtmInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The configurations of the instance.</para>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public DescribeDnsGtmInstanceResponseBodyConfig Config { get; set; }
        public class DescribeDnsGtmInstanceResponseBodyConfig : TeaModel {
            /// <summary>
            /// <para>The alert notification method.</para>
            /// </summary>
            [NameInMap("AlertConfig")]
            [Validation(Required=false)]
            public DescribeDnsGtmInstanceResponseBodyConfigAlertConfig AlertConfig { get; set; }
            public class DescribeDnsGtmInstanceResponseBodyConfigAlertConfig : TeaModel {
                [NameInMap("AlertConfig")]
                [Validation(Required=false)]
                public List<DescribeDnsGtmInstanceResponseBodyConfigAlertConfigAlertConfig> AlertConfig { get; set; }
                public class DescribeDnsGtmInstanceResponseBodyConfigAlertConfigAlertConfig : TeaModel {
                    [NameInMap("DingtalkNotice")]
                    [Validation(Required=false)]
                    public bool? DingtalkNotice { get; set; }

                    /// <summary>
                    /// <para>Indicates whether email notification is configured. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>true: Email notification is configured.</description></item>
                    /// <item><description>false: Email notification is not configured. null: Email notification is not configured.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("EmailNotice")]
                    [Validation(Required=false)]
                    public bool? EmailNotice { get; set; }

                    /// <summary>
                    /// <para>The type of the alert event. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>ADDR_ALERT: The address is unavailable.</description></item>
                    /// <item><description>ADDR_RESUME: The address is restored and becomes available.</description></item>
                    /// <item><description>ADDR_POOL_GROUP_UNAVAILABLE: The address pool group is unavailable.</description></item>
                    /// <item><description>ADDR_POOL_GROUP_AVAILABLE: The address pool group is restored and becomes available.</description></item>
                    /// <item><description>ACCESS_STRATEGY_POOL_GROUP_SWITCH: Switchover is triggered between the primary and secondary address pools.</description></item>
                    /// <item><description>MONITOR_NODE_IP_CHANGE: The IP address of the monitoring node has changed.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ADDR_ALERT</para>
                    /// </summary>
                    [NameInMap("NoticeType")]
                    [Validation(Required=false)]
                    public string NoticeType { get; set; }

                    /// <summary>
                    /// <para>Indicates whether SMS notification is configured. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>true: SMS notification is configured.</description></item>
                    /// <item><description>false: SMS notification is not configured. null: SMS notification is not configured.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("SmsNotice")]
                    [Validation(Required=false)]
                    public bool? SmsNotice { get; set; }

                }

            }

            /// <summary>
            /// <para>The name of the alert group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>alertgroup1</para>
            /// </summary>
            [NameInMap("AlertGroup")]
            [Validation(Required=false)]
            public string AlertGroup { get; set; }

            /// <summary>
            /// <para>The type of the CNAME domain name that is used to access the instance. Valid value:</para>
            /// <list type="bullet">
            /// <item><description>PUBLIC: The CNAME domain name is used to access the instance over the Internet.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>public</para>
            /// </summary>
            [NameInMap("CnameType")]
            [Validation(Required=false)]
            public string CnameType { get; set; }

            /// <summary>
            /// <para>The name of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>instancetest1</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>The domain name that is used to access the instance over the Internet.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test.rr.gtm-003.com</para>
            /// </summary>
            [NameInMap("PubicZoneName")]
            [Validation(Required=false)]
            public string PubicZoneName { get; set; }

            /// <summary>
            /// <para>Indicates whether a custom CNAME domain name or a CNAME domain name assigned by the system is used to access the instance over the Internet. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>CUSTOM: A custom CNAME domain name is used.</description></item>
            /// <item><description>SYSTEM_ASSIGN: A CNAME domain name assigned by the system is used.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>custom</para>
            /// </summary>
            [NameInMap("PublicCnameMode")]
            [Validation(Required=false)]
            public string PublicCnameMode { get; set; }

            /// <summary>
            /// <para>The hostname corresponding to the CNAME domain name that is used to access the instance over the Internet.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test.rr</para>
            /// </summary>
            [NameInMap("PublicRr")]
            [Validation(Required=false)]
            public string PublicRr { get; set; }

            /// <summary>
            /// <para>The service domain name that is used over the Internet.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example.com</para>
            /// </summary>
            [NameInMap("PublicUserDomainName")]
            [Validation(Required=false)]
            public string PublicUserDomainName { get; set; }

            /// <summary>
            /// <para>The type of the access policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>LATENCY: Latency-based</description></item>
            /// <item><description>GEO: Geographical location-based</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>GEO</para>
            /// </summary>
            [NameInMap("StrategyMode")]
            [Validation(Required=false)]
            public string StrategyMode { get; set; }

            /// <summary>
            /// <para>The global time to live (TTL).</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
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
        /// <para>The UNIX timestamp that indicates when the instance was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1602656937000</para>
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
        /// <para>The UNIX timestamp that indicates when the instance expires.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1602656937000</para>
        /// </summary>
        [NameInMap("ExpireTimestamp")]
        [Validation(Required=false)]
        public long? ExpireTimestamp { get; set; }

        /// <summary>
        /// <para>The ID of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>instanceid1</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The billing method. Valid value:</para>
        /// <list type="bullet">
        /// <item><description>Subscription: You can pay in advance for the use of resources.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Subscription</para>
        /// </summary>
        [NameInMap("PaymentType")]
        [Validation(Required=false)]
        public string PaymentType { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>84314904-D047-4176-A0EC-256D7F68C7F5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the instance belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>resourcegroupid1</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The total number of SMS notifications.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("SmsQuota")]
        [Validation(Required=false)]
        public int? SmsQuota { get; set; }

        /// <summary>
        /// <para>The total number of detection tasks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TaskQuota")]
        [Validation(Required=false)]
        public int? TaskQuota { get; set; }

        /// <summary>
        /// <para>The used quota.</para>
        /// </summary>
        [NameInMap("UsedQuota")]
        [Validation(Required=false)]
        public DescribeDnsGtmInstanceResponseBodyUsedQuota UsedQuota { get; set; }
        public class DescribeDnsGtmInstanceResponseBodyUsedQuota : TeaModel {
            [NameInMap("DingtalkUsedCount")]
            [Validation(Required=false)]
            public int? DingtalkUsedCount { get; set; }

            /// <summary>
            /// <para>The total number of emails that were sent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("EmailUsedCount")]
            [Validation(Required=false)]
            public int? EmailUsedCount { get; set; }

            /// <summary>
            /// <para>The total number of short messages that were sent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("SmsUsedCount")]
            [Validation(Required=false)]
            public int? SmsUsedCount { get; set; }

            /// <summary>
            /// <para>The number of detection tasks that were created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("TaskUsedCount")]
            [Validation(Required=false)]
            public int? TaskUsedCount { get; set; }

        }

        /// <summary>
        /// <para>The version of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>versioncode1</para>
        /// </summary>
        [NameInMap("VersionCode")]
        [Validation(Required=false)]
        public string VersionCode { get; set; }

    }

}
