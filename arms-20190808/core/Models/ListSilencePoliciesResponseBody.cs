// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class ListSilencePoliciesResponseBody : TeaModel {
        /// <summary>
        /// The value of the matching condition.
        /// </summary>
        [NameInMap("PageBean")]
        [Validation(Required=false)]
        public ListSilencePoliciesResponseBodyPageBean PageBean { get; set; }
        public class ListSilencePoliciesResponseBodyPageBean : TeaModel {
            /// <summary>
            /// The name of the silence policy.
            /// </summary>
            [NameInMap("Page")]
            [Validation(Required=false)]
            public long? Page { get; set; }

            /// <summary>
            /// The number of silence policies that were returned.
            /// </summary>
            [NameInMap("SilencePolicies")]
            [Validation(Required=false)]
            public List<ListSilencePoliciesResponseBodyPageBeanSilencePolicies> SilencePolicies { get; set; }
            public class ListSilencePoliciesResponseBodyPageBeanSilencePolicies : TeaModel {
                /// <summary>
                /// The name of the silence policy.
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// Specifies whether to query the details of a silence policy. Valid values:
                /// 
                /// *   `true`: Details of the silence policy are queried.
                /// *   `false`: Details of the silence policy are not queried.
                /// </summary>
                [NameInMap("MatchingRules")]
                [Validation(Required=false)]
                public List<ListSilencePoliciesResponseBodyPageBeanSilencePoliciesMatchingRules> MatchingRules { get; set; }
                public class ListSilencePoliciesResponseBodyPageBeanSilencePoliciesMatchingRules : TeaModel {
                    /// <summary>
                    /// The ID of the request.
                    /// </summary>
                    [NameInMap("MatchingConditions")]
                    [Validation(Required=false)]
                    public List<ListSilencePoliciesResponseBodyPageBeanSilencePoliciesMatchingRulesMatchingConditions> MatchingConditions { get; set; }
                    public class ListSilencePoliciesResponseBodyPageBeanSilencePoliciesMatchingRulesMatchingConditions : TeaModel {
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        [NameInMap("Operator")]
                        [Validation(Required=false)]
                        public string Operator { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                /// <summary>
                /// An array of returned objects.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// The number of entries that were returned on each page.
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            /// <summary>
            /// An array of matching rule objects.
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        /// <summary>
        /// The logical operator of the matching condition. Valid values:
        /// 
        /// *   `eq`: equal to.
        /// *   `neq`: not equal to.
        /// *   `in`: contains.
        /// *   `nin`: does not contain.
        /// *   `re`: regular expression match.
        /// *   `nre`: regular expression mismatch.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
