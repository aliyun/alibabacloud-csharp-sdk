// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class ListAppPoliciesForIdentityResponseBody : TeaModel {
        /// <summary>
        /// The details of each policy.
        /// 
        /// > A maximum of 100 entries can be returned.
        /// </summary>
        [NameInMap("AppPolicyList")]
        [Validation(Required=false)]
        public List<ListAppPoliciesForIdentityResponseBodyAppPolicyList> AppPolicyList { get; set; }
        public class ListAppPoliciesForIdentityResponseBodyAppPolicyList : TeaModel {
            /// <summary>
            /// The ID of the application.
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// The time when the application policy was created. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// The description of the policy.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The last time when the application policy was modified. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("ModificationTime")]
            [Validation(Required=false)]
            public string ModificationTime { get; set; }

            /// <summary>
            /// The name of the policy.
            /// </summary>
            [NameInMap("PolicyName")]
            [Validation(Required=false)]
            public string PolicyName { get; set; }

            /// <summary>
            /// The type of the policy. Valid values:
            /// 
            /// *   **System**
            /// *   **Custom**
            /// </summary>
            [NameInMap("PolicyType")]
            [Validation(Required=false)]
            public string PolicyType { get; set; }

            /// <summary>
            /// The content of the policy.
            /// </summary>
            [NameInMap("PolicyValue")]
            [Validation(Required=false)]
            public string PolicyValue { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
