// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class CreateOrUpdateSilencePolicyResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The silence policy.
        /// </summary>
        [NameInMap("SilencePolicy")]
        [Validation(Required=false)]
        public CreateOrUpdateSilencePolicyResponseBodySilencePolicy SilencePolicy { get; set; }
        public class CreateOrUpdateSilencePolicyResponseBodySilencePolicy : TeaModel {
            /// <summary>
            /// The ID of the silence policy.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// A list of matching rules.
            /// </summary>
            [NameInMap("MatchingRules")]
            [Validation(Required=false)]
            public List<CreateOrUpdateSilencePolicyResponseBodySilencePolicyMatchingRules> MatchingRules { get; set; }
            public class CreateOrUpdateSilencePolicyResponseBodySilencePolicyMatchingRules : TeaModel {
                /// <summary>
                /// The matching conditions.
                /// </summary>
                [NameInMap("MatchingConditions")]
                [Validation(Required=false)]
                public List<CreateOrUpdateSilencePolicyResponseBodySilencePolicyMatchingRulesMatchingConditions> MatchingConditions { get; set; }
                public class CreateOrUpdateSilencePolicyResponseBodySilencePolicyMatchingRulesMatchingConditions : TeaModel {
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

        }

    }

}
