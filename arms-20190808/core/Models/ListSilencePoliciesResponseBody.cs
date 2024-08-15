// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class ListSilencePoliciesResponseBody : TeaModel {
        /// <summary>
        /// The returned pages.
        /// </summary>
        [NameInMap("PageBean")]
        [Validation(Required=false)]
        public ListSilencePoliciesResponseBodyPageBean PageBean { get; set; }
        public class ListSilencePoliciesResponseBodyPageBean : TeaModel {
            /// <summary>
            /// The number of the page returned.
            /// </summary>
            [NameInMap("Page")]
            [Validation(Required=false)]
            public long? Page { get; set; }

            /// <summary>
            /// The queried silence policies.
            /// </summary>
            [NameInMap("SilencePolicies")]
            [Validation(Required=false)]
            public List<ListSilencePoliciesResponseBodyPageBeanSilencePolicies> SilencePolicies { get; set; }
            public class ListSilencePoliciesResponseBodyPageBeanSilencePolicies : TeaModel {
                [NameInMap("EffectiveTimeType")]
                [Validation(Required=false)]
                public string EffectiveTimeType { get; set; }

                /// <summary>
                /// The ID of the silence policy.
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// The matching rules.
                /// </summary>
                [NameInMap("MatchingRules")]
                [Validation(Required=false)]
                public List<ListSilencePoliciesResponseBodyPageBeanSilencePoliciesMatchingRules> MatchingRules { get; set; }
                public class ListSilencePoliciesResponseBodyPageBeanSilencePoliciesMatchingRules : TeaModel {
                    /// <summary>
                    /// The matching conditions.
                    /// </summary>
                    [NameInMap("MatchingConditions")]
                    [Validation(Required=false)]
                    public List<ListSilencePoliciesResponseBodyPageBeanSilencePoliciesMatchingRulesMatchingConditions> MatchingConditions { get; set; }
                    public class ListSilencePoliciesResponseBodyPageBeanSilencePoliciesMatchingRulesMatchingConditions : TeaModel {
                        /// <summary>
                        /// The key of the matching condition.
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// The logical operator of the matching condition. Valid values:
                        /// 
                        /// *   `eq`: equal to
                        /// *   `neq`: not equal to
                        /// *   `in`: contains
                        /// *   `nin`: does not contain
                        /// *   `re`: regular expression match
                        /// *   `nre`: regular expression mismatch
                        /// </summary>
                        [NameInMap("Operator")]
                        [Validation(Required=false)]
                        public string Operator { get; set; }

                        /// <summary>
                        /// The value of the matching condition.
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                /// <summary>
                /// The name of the silence policy.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// Indicates whether the silence policy is enabled. Valid values: enable and disable.
                /// </summary>
                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

                [NameInMap("TimePeriod")]
                [Validation(Required=false)]
                public string TimePeriod { get; set; }

                [NameInMap("TimeSlots")]
                [Validation(Required=false)]
                public string TimeSlots { get; set; }

            }

            /// <summary>
            /// The number of entries returned per page.
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            /// <summary>
            /// The number of silence policies that were returned.
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
