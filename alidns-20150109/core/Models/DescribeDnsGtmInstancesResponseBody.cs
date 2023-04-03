// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDnsGtmInstancesResponseBody : TeaModel {
        /// <summary>
        /// The returned instances.
        /// </summary>
        [NameInMap("GtmInstances")]
        [Validation(Required=false)]
        public List<DescribeDnsGtmInstancesResponseBodyGtmInstances> GtmInstances { get; set; }
        public class DescribeDnsGtmInstancesResponseBodyGtmInstances : TeaModel {
            /// <summary>
            /// The configurations of the instance.
            /// </summary>
            [NameInMap("Config")]
            [Validation(Required=false)]
            public DescribeDnsGtmInstancesResponseBodyGtmInstancesConfig Config { get; set; }
            public class DescribeDnsGtmInstancesResponseBodyGtmInstancesConfig : TeaModel {
                /// <summary>
                /// The alert notification methods.
                /// </summary>
                [NameInMap("AlertConfig")]
                [Validation(Required=false)]
                public List<DescribeDnsGtmInstancesResponseBodyGtmInstancesConfigAlertConfig> AlertConfig { get; set; }
                public class DescribeDnsGtmInstancesResponseBodyGtmInstancesConfigAlertConfig : TeaModel {
                    [NameInMap("DingtalkNotice")]
                    [Validation(Required=false)]
                    public string DingtalkNotice { get; set; }

                    /// <summary>
                    /// Indicates whether email notifications were configured. Valid values:
                    /// 
                    /// *   true: configured
                    /// *   false | null: not configured
                    /// </summary>
                    [NameInMap("EmailNotice")]
                    [Validation(Required=false)]
                    public string EmailNotice { get; set; }

                    /// <summary>
                    /// The type of the alert event. Valid values:
                    /// 
                    /// *   ADDR_ALERT: The address is unavailable.
                    /// *   ADDR_RESUME: The address is restored and becomes available.
                    /// *   ADDR_POOL_GROUP_UNAVAILABLE: The address pool group is unavailable.
                    /// *   ADDR_POOL_GROUP_AVAILABLE: The address pool group is restored and becomes available.
                    /// *   ACCESS_STRATEGY_POOL_GROUP_SWITCH: Switchover is triggered between the primary and secondary address pools.
                    /// </summary>
                    [NameInMap("NoticeType")]
                    [Validation(Required=false)]
                    public string NoticeType { get; set; }

                    /// <summary>
                    /// Indicates whether SMS notifications were configured. Valid values:
                    /// 
                    /// *   true: configured
                    /// *   false | null: not configured
                    /// </summary>
                    [NameInMap("SmsNotice")]
                    [Validation(Required=false)]
                    public string SmsNotice { get; set; }

                }

                /// <summary>
                /// The alert group.
                /// </summary>
                [NameInMap("AlertGroup")]
                [Validation(Required=false)]
                public string AlertGroup { get; set; }

                /// <summary>
                /// The access type of the CNAME domain name.
                /// 
                /// *   The value was set to PUBLIC, which indicates Internet access.
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
                /// Indicates whether a custom CNAME domain name or a CNAME domain name assigned by the system is used to access GTM over the Internet. Valid values:
                /// 
                /// *   CUSTOM: a custom CNAME domain name
                /// *   SYSTEM_ASSIGN: a CNAME domain name assigned by the system
                /// </summary>
                [NameInMap("PublicCnameMode")]
                [Validation(Required=false)]
                public string PublicCnameMode { get; set; }

                [NameInMap("PublicRr")]
                [Validation(Required=false)]
                public string PublicRr { get; set; }

                /// <summary>
                /// The website domain name that the user uses on the Internet.
                /// </summary>
                [NameInMap("PublicUserDomainName")]
                [Validation(Required=false)]
                public string PublicUserDomainName { get; set; }

                /// <summary>
                /// The domain name that is used to access GTM over the Internet.
                /// </summary>
                [NameInMap("PublicZoneName")]
                [Validation(Required=false)]
                public string PublicZoneName { get; set; }

                /// <summary>
                /// The type of the access policy. Valid values:
                /// 
                /// *   LATENCY: latency-based
                /// *   GEO: geographical location-based
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
            /// The timestamp that indicates when the instance was created.
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
            /// The timestamp that indicates when the instance expires.
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
            /// The billing method of the instance.
            /// 
            /// *   The value is set to Subscription.
            /// </summary>
            [NameInMap("PaymentType")]
            [Validation(Required=false)]
            public string PaymentType { get; set; }

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
            public DescribeDnsGtmInstancesResponseBodyGtmInstancesUsedQuota UsedQuota { get; set; }
            public class DescribeDnsGtmInstancesResponseBodyGtmInstancesUsedQuota : TeaModel {
                [NameInMap("DingtalkUsedCount")]
                [Validation(Required=false)]
                public int? DingtalkUsedCount { get; set; }

                /// <summary>
                /// The total number of email notifications that were sent.
                /// </summary>
                [NameInMap("EmailUsedCount")]
                [Validation(Required=false)]
                public int? EmailUsedCount { get; set; }

                /// <summary>
                /// The total number of SMS notifications that were sent.
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

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned on all pages.
        /// </summary>
        [NameInMap("TotalItems")]
        [Validation(Required=false)]
        public int? TotalItems { get; set; }

        /// <summary>
        /// The total number of returned pages.
        /// </summary>
        [NameInMap("TotalPages")]
        [Validation(Required=false)]
        public int? TotalPages { get; set; }

    }

}
