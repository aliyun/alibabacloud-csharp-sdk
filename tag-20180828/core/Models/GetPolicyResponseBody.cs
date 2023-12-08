// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tag20180828.Models
{
    public class GetPolicyResponseBody : TeaModel {
        /// <summary>
        /// The details of the tag policy.
        /// </summary>
        [NameInMap("Policy")]
        [Validation(Required=false)]
        public GetPolicyResponseBodyPolicy Policy { get; set; }
        public class GetPolicyResponseBodyPolicy : TeaModel {
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
