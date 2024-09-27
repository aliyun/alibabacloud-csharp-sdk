// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDnsGtmInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>The Global Traffic Manager (GTM) instances.</para>
        /// </summary>
        [NameInMap("GtmInstances")]
        [Validation(Required=false)]
        public List<DescribeDnsGtmInstancesResponseBodyGtmInstances> GtmInstances { get; set; }
        public class DescribeDnsGtmInstancesResponseBodyGtmInstances : TeaModel {
            /// <summary>
            /// <para>The configurations of the instance.</para>
            /// </summary>
            [NameInMap("Config")]
            [Validation(Required=false)]
            public DescribeDnsGtmInstancesResponseBodyGtmInstancesConfig Config { get; set; }
            public class DescribeDnsGtmInstancesResponseBodyGtmInstancesConfig : TeaModel {
                /// <summary>
                /// <para>The alert notification method.</para>
                /// </summary>
                [NameInMap("AlertConfig")]
                [Validation(Required=false)]
                public List<DescribeDnsGtmInstancesResponseBodyGtmInstancesConfigAlertConfig> AlertConfig { get; set; }
                public class DescribeDnsGtmInstancesResponseBodyGtmInstancesConfigAlertConfig : TeaModel {
                    /// <summary>
                    /// <para>Indicates whether DingTalk alert notifications are configured. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>true</description></item>
                    /// <item><description>false | null</description></item>
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
                    /// <item><description>true</description></item>
                    /// <item><description>false | null</description></item>
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
                    /// <item><description>ADDR_ALERT: The address is unavailable.</description></item>
                    /// <item><description>ADDR_RESUME: The address becomes available.</description></item>
                    /// <item><description>ADDR_POOL_GROUP_UNAVAILABLE: The address pool set is unavailable.</description></item>
                    /// <item><description>ADDR_POOL_GROUP_AVAILABLE: The address pool set becomes available.</description></item>
                    /// <item><description>ACCESS_STRATEGY_POOL_GROUP_SWITCH: Switchover is triggered between the primary and secondary address pools.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ADDR_ALERT</para>
                    /// </summary>
                    [NameInMap("NoticeType")]
                    [Validation(Required=false)]
                    public string NoticeType { get; set; }

                    /// <summary>
                    /// <para>Indicates whether SMS notifications are configured. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>true</description></item>
                    /// <item><description>false | null</description></item>
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
                /// <para>The alert contact groups. The value is in the JSON format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testgroup</para>
                /// </summary>
                [NameInMap("AlertGroup")]
                [Validation(Required=false)]
                public string AlertGroup { get; set; }

                /// <summary>
                /// <para>The type of the CNAME. Valid value:</para>
                /// <list type="bullet">
                /// <item><description>PUBLIC</description></item>
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
                /// <para>instanceTest</para>
                /// </summary>
                [NameInMap("InstanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

                /// <summary>
                /// <para>Specifies whether to use a custom CNAME or a system-assigned CNAME to access GTM over the Internet. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>CUSTOM: a custom CNAME</description></item>
                /// <item><description>SYSTEM_ASSIGN: a system-assigned CNAME. You cannot set PublicCnameMode to this value.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>custom</para>
                /// </summary>
                [NameInMap("PublicCnameMode")]
                [Validation(Required=false)]
                public string PublicCnameMode { get; set; }

                /// <summary>
                /// <para>The hostname of the domain name that is used to access GTM over the Internet.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test.rr</para>
                /// </summary>
                [NameInMap("PublicRr")]
                [Validation(Required=false)]
                public string PublicRr { get; set; }

                /// <summary>
                /// <para>The domain name that is used to access GTM over the Internet.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example.com</para>
                /// </summary>
                [NameInMap("PublicUserDomainName")]
                [Validation(Required=false)]
                public string PublicUserDomainName { get; set; }

                /// <summary>
                /// <para>The canonical name (CNAME) that is used to access GTM over the Internet.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test.rr.gtm-003.com</para>
                /// </summary>
                [NameInMap("PublicZoneName")]
                [Validation(Required=false)]
                public string PublicZoneName { get; set; }

                /// <summary>
                /// <para>The type of the access policy. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>LATENCY: latency-based access policy</description></item>
                /// <item><description>GEO: geographical location-based access policy</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>geo</para>
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
            /// <para>The time when the instance was created. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-10-14T06:58Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The time when the instance was created. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1602658709000</para>
            /// </summary>
            [NameInMap("CreateTimestamp")]
            [Validation(Required=false)]
            public long? CreateTimestamp { get; set; }

            /// <summary>
            /// <para>The time when the instance expires. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-10-14T06:58Z</para>
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }

            /// <summary>
            /// <para>The time when the instance expires. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1602658709000</para>
            /// </summary>
            [NameInMap("ExpireTimestamp")]
            [Validation(Required=false)]
            public long? ExpireTimestamp { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>instance1</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The billing method of the GTM instance. Valid value:</para>
            /// <list type="bullet">
            /// <item><description>Subscription.</description></item>
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
            /// <para>The total number of Short Message Service (SMS) notifications.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SmsQuota")]
            [Validation(Required=false)]
            public int? SmsQuota { get; set; }

            /// <summary>
            /// <para>The total number of detection tasks.</para>
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
                /// <para>The total number of sent DingTalk notifications.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("DingtalkUsedCount")]
                [Validation(Required=false)]
                public int? DingtalkUsedCount { get; set; }

                /// <summary>
                /// <para>The total number of sent email notifications.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("EmailUsedCount")]
                [Validation(Required=false)]
                public int? EmailUsedCount { get; set; }

                /// <summary>
                /// <para>The total number of sent SMS notifications.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("SmsUsedCount")]
                [Validation(Required=false)]
                public int? SmsUsedCount { get; set; }

                /// <summary>
                /// <para>The number of created detection tasks.</para>
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
            /// <para>testVersion1</para>
            /// </summary>
            [NameInMap("VersionCode")]
            [Validation(Required=false)]
            public string VersionCode { get; set; }

        }

        /// <summary>
        /// <para>The page number. Pages start from page <b>1</b>. Default value: <b>1</b>.</para>
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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>84314904-D047-4176-A0EC-256D7F68C7F5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalItems")]
        [Validation(Required=false)]
        public int? TotalItems { get; set; }

        /// <summary>
        /// <para>The total number of pages returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("TotalPages")]
        [Validation(Required=false)]
        public int? TotalPages { get; set; }

    }

}
