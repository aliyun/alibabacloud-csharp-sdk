// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tag20180828.Models
{
    public class ListPoliciesResponseBody : TeaModel {
        /// <summary>
        /// Indicates whether the next query is required.
        /// 
        /// *   If the value of this parameter is empty (`"NextToken": ""`), all results are returned, and the next query is not required.
        /// *   If the value of this parameter is not empty, the next query is required, and the value is the token used to start the next query.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The tag policies.
        /// </summary>
        [NameInMap("PolicyList")]
        [Validation(Required=false)]
        public List<ListPoliciesResponseBodyPolicyList> PolicyList { get; set; }
        public class ListPoliciesResponseBodyPolicyList : TeaModel {
            /// <summary>
            /// The document of the tag policy.
            /// </summary>
            [NameInMap("PolicyContent")]
            [Validation(Required=false)]
            public string PolicyContent { get; set; }

            /// <summary>
            /// The description of the tag policy.
            /// </summary>
            [NameInMap("PolicyDesc")]
            [Validation(Required=false)]
            public string PolicyDesc { get; set; }

            /// <summary>
            /// The ID of the tag policy.
            /// </summary>
            [NameInMap("PolicyId")]
            [Validation(Required=false)]
            public string PolicyId { get; set; }

            /// <summary>
            /// The name of the tag policy.
            /// </summary>
            [NameInMap("PolicyName")]
            [Validation(Required=false)]
            public string PolicyName { get; set; }

            /// <summary>
            /// The mode of the Tag Policy feature. Valid values:
            /// 
            /// *   USER: single-account mode
            /// *   RD: multi-account mode
            /// 
            /// For more information about the modes of the Tag Policy feature, see [Modes of the Tag Policy feature](~~417434~~).
            /// </summary>
            [NameInMap("UserType")]
            [Validation(Required=false)]
            public string UserType { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
