// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNest20210601.Models
{
    public class GenerateServicePolicyResponseBody : TeaModel {
        /// <summary>
        /// The policies that are missing.
        /// </summary>
        [NameInMap("MissingPolicy")]
        [Validation(Required=false)]
        public List<GenerateServicePolicyResponseBodyMissingPolicy> MissingPolicy { get; set; }
        public class GenerateServicePolicyResponseBodyMissingPolicy : TeaModel {
            /// <summary>
            /// Operations on specific resources.
            /// </summary>
            [NameInMap("Action")]
            [Validation(Required=false)]
            public List<string> Action { get; set; }

            /// <summary>
            /// The specific objects authorized. An asterisk (*) denotes all resources.
            /// </summary>
            [NameInMap("Resource")]
            [Validation(Required=false)]
            public string Resource { get; set; }

            /// <summary>
            /// The name of the service.
            /// </summary>
            [NameInMap("ServiceName")]
            [Validation(Required=false)]
            public string ServiceName { get; set; }

        }

        /// <summary>
        /// The RAM policy.
        /// </summary>
        [NameInMap("Policy")]
        [Validation(Required=false)]
        public string Policy { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
