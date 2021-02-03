// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDnsGtmInstanceResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=true)]
        public string InstanceId { get; set; }

        [NameInMap("VersionCode")]
        [Validation(Required=true)]
        public string VersionCode { get; set; }

        [NameInMap("SmsQuota")]
        [Validation(Required=true)]
        public int? SmsQuota { get; set; }

        [NameInMap("TaskQuota")]
        [Validation(Required=true)]
        public int? TaskQuota { get; set; }

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

        [NameInMap("ResourceGroupId")]
        [Validation(Required=true)]
        public string ResourceGroupId { get; set; }

        [NameInMap("PaymentType")]
        [Validation(Required=true)]
        public string PaymentType { get; set; }

        [NameInMap("Config")]
        [Validation(Required=true)]
        public DescribeDnsGtmInstanceResponseConfig Config { get; set; }
        public class DescribeDnsGtmInstanceResponseConfig : TeaModel {
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
            [NameInMap("PubicZoneName")]
            [Validation(Required=true)]
            public string PubicZoneName { get; set; }
            [NameInMap("Ttl")]
            [Validation(Required=true)]
            public int? Ttl { get; set; }
            [NameInMap("StrategyMode")]
            [Validation(Required=true)]
            public string StrategyMode { get; set; }
            [NameInMap("AlertGroup")]
            [Validation(Required=true)]
            public string AlertGroup { get; set; }
            [NameInMap("AlertConfig")]
            [Validation(Required=true)]
            public DescribeDnsGtmInstanceResponseConfigAlertConfig AlertConfig { get; set; }
            public class DescribeDnsGtmInstanceResponseConfigAlertConfig : TeaModel {
                [NameInMap("AlertConfig")]
                [Validation(Required=true)]
                public List<DescribeDnsGtmInstanceResponseConfigAlertConfigAlertConfig> AlertConfig { get; set; }
                public class DescribeDnsGtmInstanceResponseConfigAlertConfigAlertConfig : TeaModel {
                    [NameInMap("NoticeType")]
                    [Validation(Required=true)]
                    public string NoticeType { get; set; }

                    [NameInMap("SmsNotice")]
                    [Validation(Required=true)]
                    public bool? SmsNotice { get; set; }

                    [NameInMap("EmailNotice")]
                    [Validation(Required=true)]
                    public bool? EmailNotice { get; set; }

                }

            }
        };

        [NameInMap("UsedQuota")]
        [Validation(Required=true)]
        public DescribeDnsGtmInstanceResponseUsedQuota UsedQuota { get; set; }
        public class DescribeDnsGtmInstanceResponseUsedQuota : TeaModel {
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
