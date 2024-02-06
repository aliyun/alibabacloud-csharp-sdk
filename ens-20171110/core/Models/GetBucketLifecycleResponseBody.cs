// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class GetBucketLifecycleResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The detailed information about the rule.
        /// </summary>
        [NameInMap("Rule")]
        [Validation(Required=false)]
        public List<GetBucketLifecycleResponseBodyRule> Rule { get; set; }
        public class GetBucketLifecycleResponseBodyRule : TeaModel {
            /// <summary>
            /// The expiration time.
            /// </summary>
            [NameInMap("Expiration")]
            [Validation(Required=false)]
            public GetBucketLifecycleResponseBodyRuleExpiration Expiration { get; set; }
            public class GetBucketLifecycleResponseBodyRuleExpiration : TeaModel {
                /// <summary>
                /// The expiration date.
                /// </summary>
                [NameInMap("CreatedBeforeDate")]
                [Validation(Required=false)]
                public string CreatedBeforeDate { get; set; }

                /// <summary>
                /// The validity period, in days.
                /// </summary>
                [NameInMap("Days")]
                [Validation(Required=false)]
                public string Days { get; set; }

            }

            /// <summary>
            /// The unique ID of the rule.
            /// </summary>
            [NameInMap("ID")]
            [Validation(Required=false)]
            public string ID { get; set; }

            /// <summary>
            /// The prefix that is applied to the rule.
            /// </summary>
            [NameInMap("Prefix")]
            [Validation(Required=false)]
            public string Prefix { get; set; }

            /// <summary>
            /// The status of the rule. Valid values:
            /// 
            /// *   **Enabled**: The rule is periodically executed.
            /// *   **Disabled**: The rule is ignored.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

    }

}
