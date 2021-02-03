// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDnsGtmInstancesResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=true)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=true)]
        public int? PageSize { get; set; }

        [NameInMap("TotalItems")]
        [Validation(Required=true)]
        public int? TotalItems { get; set; }

        [NameInMap("TotalPages")]
        [Validation(Required=true)]
        public int? TotalPages { get; set; }

        [NameInMap("GtmInstances")]
        [Validation(Required=true)]
        public List<DescribeDnsGtmInstancesResponseGtmInstances> GtmInstances { get; set; }
        public class DescribeDnsGtmInstancesResponseGtmInstances : TeaModel {
            [NameInMap("InstanceId")]
            [Validation(Required=true)]
            public string InstanceId { get; set; }

            [NameInMap("VersionCode")]
            [Validation(Required=true)]
            public string VersionCode { get; set; }

            [NameInMap("SmsQuota")]
            [Validation(Required=true)]
            public int? SmsQuota { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=true)]
            public string CreateTime { get; set; }

            [NameInMap("CreateTimestamp")]
            [Validation(Required=true)]
            public long? CreateTimestamp { get; set; }

            [NameInMap("ExpireTime")]
            [Validation(Required=true)]
            public string ExpireTime { get; set; }

            [NameInMap("ExpireTimestamp")]
            [Validation(Required=true)]
            public long? ExpireTimestamp { get; set; }

            [NameInMap("TaskQuota")]
            [Validation(Required=true)]
            public int? TaskQuota { get; set; }

            [NameInMap("ResourceGroupId")]
            [Validation(Required=true)]
            public string ResourceGroupId { get; set; }

            [NameInMap("PaymentType")]
            [Validation(Required=true)]
            public string PaymentType { get; set; }

            [NameInMap("Config")]
            [Validation(Required=true)]
            public DescribeDnsGtmInstancesResponseGtmInstancesConfig Config { get; set; }
            public class DescribeDnsGtmInstancesResponseGtmInstancesConfig : TeaModel {
                [NameInMap("InstanceName")]
                [Validation(Required=true)]
                public string InstanceName { get; set; }
                [NameInMap("CnameType")]
                [Validation(Required=true)]
                public string CnameType { get; set; }
                [NameInMap("PublicUserDomainName")]
                [Validation(Required=true)]
                public string PublicUserDomainName { get; set; }
                [NameInMap("PublicCnameMode")]
                [Validation(Required=true)]
                public string PublicCnameMode { get; set; }
                [NameInMap("PublicZoneName")]
                [Validation(Required=true)]
                public string PublicZoneName { get; set; }
                [NameInMap("Ttl")]
                [Validation(Required=true)]
                public int? Ttl { get; set; }
                [NameInMap("AlertGroup")]
                [Validation(Required=true)]
                public string AlertGroup { get; set; }
                [NameInMap("StrategyMode")]
                [Validation(Required=true)]
                public string StrategyMode { get; set; }
                [NameInMap("AlertConfig")]
                [Validation(Required=true)]
                public List<DescribeDnsGtmInstancesResponseGtmInstancesConfigAlertConfig> AlertConfig { get; set; }
                public class DescribeDnsGtmInstancesResponseGtmInstancesConfigAlertConfig : TeaModel {
                    public string NoticeType { get; set; }
                    public string SmsNotice { get; set; }
                    public string EmailNotice { get; set; }
                }
            };

            [NameInMap("UsedQuota")]
            [Validation(Required=true)]
            public DescribeDnsGtmInstancesResponseGtmInstancesUsedQuota UsedQuota { get; set; }
            public class DescribeDnsGtmInstancesResponseGtmInstancesUsedQuota : TeaModel {
                [NameInMap("TaskUsedCount")]
                [Validation(Required=true)]
                public int? TaskUsedCount { get; set; }
                [NameInMap("SmsUsedCount")]
                [Validation(Required=true)]
                public int? SmsUsedCount { get; set; }
                [NameInMap("EmailUsedCount")]
                [Validation(Required=true)]
                public int? EmailUsedCount { get; set; }
            };

        }

    }

}
