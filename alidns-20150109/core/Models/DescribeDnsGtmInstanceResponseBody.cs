// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDnsGtmInstanceResponseBody : TeaModel {
        /// <summary>
        /// The configurations of the instance.
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public DescribeDnsGtmInstanceResponseBodyConfig Config { get; set; }
        public class DescribeDnsGtmInstanceResponseBodyConfig : TeaModel {
            /// <summary>
            /// The alert notification method.
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
                    /// Indicates whether email notification is configured. Valid values:
                    /// 
                    /// *   true: Email notification is configured.
                    /// *   false: Email notification is not configured. null: Email notification is not configured.
                    /// </summary>
                    [NameInMap("EmailNotice")]
                    [Validation(Required=false)]
                    public bool? EmailNotice { get; set; }

                    /// <summary>
                    /// The type of the alert event. Valid values:
                    /// 
                    /// *   ADDR_ALERT: The address is unavailable.
                    /// *   ADDR_RESUME: The address is restored and becomes available.
                    /// *   ADDR_POOL_GROUP_UNAVAILABLE: The address pool group is unavailable.
                    /// *   ADDR_POOL_GROUP_AVAILABLE: The address pool group is restored and becomes available.
                    /// *   ACCESS_STRATEGY_POOL_GROUP_SWITCH: Switchover is triggered between the primary and secondary address pools.
                    /// *   MONITOR_NODE_IP_CHANGE: The IP address of the monitoring node has changed.
                    /// </summary>
                    [NameInMap("NoticeType")]
                    [Validation(Required=false)]
                    public string NoticeType { get; set; }

                    /// <summary>
                    /// Indicates whether SMS notification is configured. Valid values:
                    /// 
                    /// *   true: SMS notification is configured.
                    /// *   false: SMS notification is not configured. null: SMS notification is not configured.
                    /// </summary>
                    [NameInMap("SmsNotice")]
                    [Validation(Required=false)]
                    public bool? SmsNotice { get; set; }

                }

            }

            /// <summary>
            /// The name of the alert group.
            /// </summary>
            [NameInMap("AlertGroup")]
            [Validation(Required=false)]
            public string AlertGroup { get; set; }

            /// <summary>
            /// The type of the CNAME domain name that is used to access the instance. Valid value:
            /// 
            /// *   PUBLIC: The CNAME domain name is used to access the instance over the Internet.
            /// </summary>
            [NameInMap("CnameType")]
            [Validation(Required=false)]
            public string CnameType { get; set; }

            /// <summary>
            /// The name of the instance.
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// The domain name that is used to access the instance over the Internet.
            /// </summary>
            [NameInMap("PubicZoneName")]
            [Validation(Required=false)]
            public string PubicZoneName { get; set; }

            /// <summary>
            /// Indicates whether a custom CNAME domain name or a CNAME domain name assigned by the system is used to access the instance over the Internet. Valid values:
            /// 
            /// *   CUSTOM: A custom CNAME domain name is used.
            /// *   SYSTEM_ASSIGN: A CNAME domain name assigned by the system is used.
            /// </summary>
            [NameInMap("PublicCnameMode")]
            [Validation(Required=false)]
            public string PublicCnameMode { get; set; }

            /// <summary>
            /// The hostname corresponding to the CNAME domain name that is used to access the instance over the Internet.
            /// </summary>
            [NameInMap("PublicRr")]
            [Validation(Required=false)]
            public string PublicRr { get; set; }

            /// <summary>
            /// The service domain name that is used over the Internet.
            /// </summary>
            [NameInMap("PublicUserDomainName")]
            [Validation(Required=false)]
            public string PublicUserDomainName { get; set; }

            /// <summary>
            /// The type of the access policy. Valid values:
            /// 
            /// *   LATENCY: Latency-based
            /// *   GEO: Geographical location-based
            /// </summary>
            [NameInMap("StrategyMode")]
            [Validation(Required=false)]
            public string StrategyMode { get; set; }

            /// <summary>
            /// The global time to live (TTL).
            /// </summary>
            [NameInMap("Ttl")]
            [Validation(Required=false)]
            public int? Ttl { get; set; }

        }

        /// <summary>
        /// The time when the instance was created.
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// The UNIX timestamp that indicates when the instance was created.
        /// </summary>
        [NameInMap("CreateTimestamp")]
        [Validation(Required=false)]
        public long? CreateTimestamp { get; set; }

        /// <summary>
        /// The time when the instance expires.
        /// </summary>
        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public string ExpireTime { get; set; }

        /// <summary>
        /// The UNIX timestamp that indicates when the instance expires.
        /// </summary>
        [NameInMap("ExpireTimestamp")]
        [Validation(Required=false)]
        public long? ExpireTimestamp { get; set; }

        /// <summary>
        /// The ID of the instance.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The billing method. Valid value:
        /// 
        /// *   Subscription: You can pay in advance for the use of resources.
        /// </summary>
        [NameInMap("PaymentType")]
        [Validation(Required=false)]
        public string PaymentType { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The ID of the resource group to which the instance belongs.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The total number of SMS notifications.
        /// </summary>
        [NameInMap("SmsQuota")]
        [Validation(Required=false)]
        public int? SmsQuota { get; set; }

        /// <summary>
        /// The total number of detection tasks.
        /// </summary>
        [NameInMap("TaskQuota")]
        [Validation(Required=false)]
        public int? TaskQuota { get; set; }

        /// <summary>
        /// The used quota.
        /// </summary>
        [NameInMap("UsedQuota")]
        [Validation(Required=false)]
        public DescribeDnsGtmInstanceResponseBodyUsedQuota UsedQuota { get; set; }
        public class DescribeDnsGtmInstanceResponseBodyUsedQuota : TeaModel {
            [NameInMap("DingtalkUsedCount")]
            [Validation(Required=false)]
            public int? DingtalkUsedCount { get; set; }

            /// <summary>
            /// The total number of emails that were sent.
            /// </summary>
            [NameInMap("EmailUsedCount")]
            [Validation(Required=false)]
            public int? EmailUsedCount { get; set; }

            /// <summary>
            /// The total number of short messages that were sent.
            /// </summary>
            [NameInMap("SmsUsedCount")]
            [Validation(Required=false)]
            public int? SmsUsedCount { get; set; }

            /// <summary>
            /// The number of detection tasks that were created.
            /// </summary>
            [NameInMap("TaskUsedCount")]
            [Validation(Required=false)]
            public int? TaskUsedCount { get; set; }

        }

        /// <summary>
        /// The version of the instance.
        /// </summary>
        [NameInMap("VersionCode")]
        [Validation(Required=false)]
        public string VersionCode { get; set; }

    }

}
