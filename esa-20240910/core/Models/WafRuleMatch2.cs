// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class WafRuleMatch2 : TeaModel {
        [NameInMap("ConvertToLower")]
        [Validation(Required=false)]
        public bool? ConvertToLower { get; set; }

        [NameInMap("Criteria")]
        [Validation(Required=false)]
        public List<WafRuleMatch2Criteria> Criteria { get; set; }
        public class WafRuleMatch2Criteria : TeaModel {
            [NameInMap("ConvertToLower")]
            [Validation(Required=false)]
            public bool? ConvertToLower { get; set; }

            [NameInMap("Criteria")]
            [Validation(Required=false)]
            public List<WafRuleMatch2CriteriaCriteria> Criteria { get; set; }
            public class WafRuleMatch2CriteriaCriteria : TeaModel {
                [NameInMap("ConvertToLower")]
                [Validation(Required=false)]
                public bool? ConvertToLower { get; set; }

                [NameInMap("Criteria")]
                [Validation(Required=false)]
                public List<WafRuleMatch2CriteriaCriteriaCriteria> Criteria { get; set; }
                public class WafRuleMatch2CriteriaCriteriaCriteria : TeaModel {
                    [NameInMap("ConvertToLower")]
                    [Validation(Required=false)]
                    public bool? ConvertToLower { get; set; }

                    [NameInMap("MatchOperator")]
                    [Validation(Required=false)]
                    public string MatchOperator { get; set; }

                    [NameInMap("MatchType")]
                    [Validation(Required=false)]
                    public string MatchType { get; set; }

                    [NameInMap("MatchValue")]
                    [Validation(Required=false)]
                    public object MatchValue { get; set; }

                    [NameInMap("Negate")]
                    [Validation(Required=false)]
                    public bool? Negate { get; set; }

                }

                [NameInMap("Logic")]
                [Validation(Required=false)]
                public string Logic { get; set; }

                [NameInMap("MatchOperator")]
                [Validation(Required=false)]
                public string MatchOperator { get; set; }

                [NameInMap("MatchType")]
                [Validation(Required=false)]
                public string MatchType { get; set; }

                [NameInMap("MatchValue")]
                [Validation(Required=false)]
                public object MatchValue { get; set; }

                [NameInMap("Negate")]
                [Validation(Required=false)]
                public bool? Negate { get; set; }

            }

            [NameInMap("Logic")]
            [Validation(Required=false)]
            public string Logic { get; set; }

            [NameInMap("MatchOperator")]
            [Validation(Required=false)]
            public string MatchOperator { get; set; }

            [NameInMap("MatchType")]
            [Validation(Required=false)]
            public string MatchType { get; set; }

            [NameInMap("MatchValue")]
            [Validation(Required=false)]
            public object MatchValue { get; set; }

            [NameInMap("Negate")]
            [Validation(Required=false)]
            public bool? Negate { get; set; }

        }

        [NameInMap("Logic")]
        [Validation(Required=false)]
        public string Logic { get; set; }

        [NameInMap("MatchOperator")]
        [Validation(Required=false)]
        public string MatchOperator { get; set; }

        [NameInMap("MatchType")]
        [Validation(Required=false)]
        public string MatchType { get; set; }

        [NameInMap("MatchValue")]
        [Validation(Required=false)]
        public object MatchValue { get; set; }

        [NameInMap("Negate")]
        [Validation(Required=false)]
        public bool? Negate { get; set; }

    }

}
