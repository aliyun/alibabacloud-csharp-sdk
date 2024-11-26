// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yuqing20220301.Models
{
    public class YuqingFinanceEvent : TeaModel {
        [NameInMap("comprehensiveRisk")]
        [Validation(Required=false)]
        public double? ComprehensiveRisk { get; set; }

        [NameInMap("entityArea")]
        [Validation(Required=false)]
        public string EntityArea { get; set; }

        [NameInMap("entityCrn")]
        [Validation(Required=false)]
        public string EntityCrn { get; set; }

        [NameInMap("entityEmotionScore")]
        [Validation(Required=false)]
        public double? EntityEmotionScore { get; set; }

        [NameInMap("entityId")]
        [Validation(Required=false)]
        public long? EntityId { get; set; }

        [NameInMap("entityName")]
        [Validation(Required=false)]
        public string EntityName { get; set; }

        [NameInMap("entityRelevanceScore")]
        [Validation(Required=false)]
        public double? EntityRelevanceScore { get; set; }

        [NameInMap("entityShowName")]
        [Validation(Required=false)]
        public string EntityShowName { get; set; }

        [NameInMap("entitySummary")]
        [Validation(Required=false)]
        public string EntitySummary { get; set; }

        [NameInMap("entityType")]
        [Validation(Required=false)]
        public string EntityType { get; set; }

        [NameInMap("eventId")]
        [Validation(Required=false)]
        public string EventId { get; set; }

        [NameInMap("eventLevel3Code")]
        [Validation(Required=false)]
        public long? EventLevel3Code { get; set; }

        [NameInMap("eventLevel3Name")]
        [Validation(Required=false)]
        public string EventLevel3Name { get; set; }

        [NameInMap("eventTags")]
        [Validation(Required=false)]
        public string EventTags { get; set; }

        [NameInMap("eventTime")]
        [Validation(Required=false)]
        public long? EventTime { get; set; }

        [NameInMap("securityAbbreviation")]
        [Validation(Required=false)]
        public string SecurityAbbreviation { get; set; }

        [NameInMap("securityCategoryCodes")]
        [Validation(Required=false)]
        public List<string> SecurityCategoryCodes { get; set; }

        [NameInMap("securityCodes")]
        [Validation(Required=false)]
        public List<string> SecurityCodes { get; set; }

        [NameInMap("securityMarketsCodes")]
        [Validation(Required=false)]
        public List<string> SecurityMarketsCodes { get; set; }

        [NameInMap("spamScore")]
        [Validation(Required=false)]
        public double? SpamScore { get; set; }

        [NameInMap("userSubscribeEntityTags")]
        [Validation(Required=false)]
        public List<string> UserSubscribeEntityTags { get; set; }

        [NameInMap("userSubscribeEventTags")]
        [Validation(Required=false)]
        public List<long?> UserSubscribeEventTags { get; set; }

    }

}
