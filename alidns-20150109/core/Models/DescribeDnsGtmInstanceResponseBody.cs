// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDnsGtmInstanceResponseBody : TeaModel {
        [NameInMap("ExpireTimestamp")]
        [Validation(Required=false)]
        public long? ExpireTimestamp { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("TaskQuota")]
        [Validation(Required=false)]
        public int? TaskQuota { get; set; }

        [NameInMap("Config")]
        [Validation(Required=false)]
        public DescribeDnsGtmInstanceResponseBodyConfig Config { get; set; }
        public class DescribeDnsGtmInstanceResponseBodyConfig : TeaModel {
            [NameInMap("Ttl")]
            [Validation(Required=false)]
            public int? Ttl { get; set; }
            [NameInMap("AlertGroup")]
            [Validation(Required=false)]
            public string AlertGroup { get; set; }
            [NameInMap("CnameType")]
            [Validation(Required=false)]
            public string CnameType { get; set; }
            [NameInMap("StrategyMode")]
            [Validation(Required=false)]
            public string StrategyMode { get; set; }
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }
            [NameInMap("PublicCnameMode")]
            [Validation(Required=false)]
            public string PublicCnameMode { get; set; }
            [NameInMap("AlertConfig")]
            [Validation(Required=false)]
            public DescribeDnsGtmInstanceResponseBodyConfigAlertConfig AlertConfig { get; set; }
            public class DescribeDnsGtmInstanceResponseBodyConfigAlertConfig : TeaModel {
                [NameInMap("AlertConfig")]
                [Validation(Required=false)]
                public List<DescribeDnsGtmInstanceResponseBodyConfigAlertConfigAlertConfig> AlertConfig { get; set; }
                public class DescribeDnsGtmInstanceResponseBodyConfigAlertConfigAlertConfig : TeaModel {
                    [NameInMap("SmsNotice")]
                    [Validation(Required=false)]
                    public bool? SmsNotice { get; set; }

                    [NameInMap("NoticeType")]
                    [Validation(Required=false)]
                    public string NoticeType { get; set; }

                    [NameInMap("EmailNotice")]
                    [Validation(Required=false)]
                    public bool? EmailNotice { get; set; }

                }

            }
            [NameInMap("PublicUserDomainName")]
            [Validation(Required=false)]
            public string PublicUserDomainName { get; set; }
            [NameInMap("PubicZoneName")]
            [Validation(Required=false)]
            public string PubicZoneName { get; set; }
        };

        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        [NameInMap("SmsQuota")]
        [Validation(Required=false)]
        public int? SmsQuota { get; set; }

        [NameInMap("VersionCode")]
        [Validation(Required=false)]
        public string VersionCode { get; set; }

        [NameInMap("PaymentType")]
        [Validation(Required=false)]
        public string PaymentType { get; set; }

        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public string ExpireTime { get; set; }

        [NameInMap("CreateTimestamp")]
        [Validation(Required=false)]
        public long? CreateTimestamp { get; set; }

        [NameInMap("UsedQuota")]
        [Validation(Required=false)]
        public DescribeDnsGtmInstanceResponseBodyUsedQuota UsedQuota { get; set; }
        public class DescribeDnsGtmInstanceResponseBodyUsedQuota : TeaModel {
            [NameInMap("EmailUsedCount")]
            [Validation(Required=false)]
            public int? EmailUsedCount { get; set; }
            [NameInMap("TaskUsedCount")]
            [Validation(Required=false)]
            public int? TaskUsedCount { get; set; }
            [NameInMap("SmsUsedCount")]
            [Validation(Required=false)]
            public int? SmsUsedCount { get; set; }
        };

    }

}
