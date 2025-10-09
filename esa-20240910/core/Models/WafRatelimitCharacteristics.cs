// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class WafRatelimitCharacteristics : TeaModel {
        [NameInMap("Criteria")]
        [Validation(Required=false)]
        public List<WafRatelimitCharacteristicsCriteria> Criteria { get; set; }
        public class WafRatelimitCharacteristicsCriteria : TeaModel {
            [NameInMap("Criteria")]
            [Validation(Required=false)]
            public List<WafRatelimitCharacteristicsCriteriaCriteria> Criteria { get; set; }
            public class WafRatelimitCharacteristicsCriteriaCriteria : TeaModel {
                [NameInMap("Criteria")]
                [Validation(Required=false)]
                public List<WafRatelimitCharacteristicsCriteriaCriteriaCriteria> Criteria { get; set; }
                public class WafRatelimitCharacteristicsCriteriaCriteriaCriteria : TeaModel {
                    [NameInMap("MatchType")]
                    [Validation(Required=false)]
                    public string MatchType { get; set; }

                }

                [NameInMap("Logic")]
                [Validation(Required=false)]
                public string Logic { get; set; }

                [NameInMap("MatchType")]
                [Validation(Required=false)]
                public string MatchType { get; set; }

            }

            [NameInMap("Logic")]
            [Validation(Required=false)]
            public string Logic { get; set; }

            [NameInMap("MatchType")]
            [Validation(Required=false)]
            public string MatchType { get; set; }

        }

        [NameInMap("Logic")]
        [Validation(Required=false)]
        public string Logic { get; set; }

        [NameInMap("MatchType")]
        [Validation(Required=false)]
        public string MatchType { get; set; }

    }

}
