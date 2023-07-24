// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnWafScenesResponseBody : TeaModel {
        /// <summary>
        /// The types of the protection policies.
        /// </summary>
        [NameInMap("DefenseScenes")]
        [Validation(Required=false)]
        public List<DescribeDcdnWafScenesResponseBodyDefenseScenes> DefenseScenes { get; set; }
        public class DescribeDcdnWafScenesResponseBodyDefenseScenes : TeaModel {
            /// <summary>
            /// The type of the protection policy, which is the same as the DefenseScenes parameter in request parameters.
            /// </summary>
            [NameInMap("DefenseScene")]
            [Validation(Required=false)]
            public string DefenseScene { get; set; }

            /// <summary>
            /// The total number of policies of this type that were configured.
            /// </summary>
            [NameInMap("PolicyCount")]
            [Validation(Required=false)]
            public int? PolicyCount { get; set; }

            /// <summary>
            /// The total number of protection rules that were configured in this type of the policy.
            /// </summary>
            [NameInMap("RuleCount")]
            [Validation(Required=false)]
            public int? RuleCount { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
