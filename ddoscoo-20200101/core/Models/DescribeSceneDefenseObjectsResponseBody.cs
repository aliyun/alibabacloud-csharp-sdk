// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeSceneDefenseObjectsResponseBody : TeaModel {
        /// <summary>
        /// The information about the protected assets.
        /// </summary>
        [NameInMap("Objects")]
        [Validation(Required=false)]
        public List<DescribeSceneDefenseObjectsResponseBodyObjects> Objects { get; set; }
        public class DescribeSceneDefenseObjectsResponseBodyObjects : TeaModel {
            /// <summary>
            /// The domain name that is protected by the policy.
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// The ID of the policy.
            /// </summary>
            [NameInMap("PolicyId")]
            [Validation(Required=false)]
            public string PolicyId { get; set; }

            /// <summary>
            /// The IP address of the Anti-DDoS Pro or Anti-DDoS Premium instance that is protected by the policy.
            /// </summary>
            [NameInMap("Vip")]
            [Validation(Required=false)]
            public string Vip { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   **true**: yes
        /// *   **false**: no
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
