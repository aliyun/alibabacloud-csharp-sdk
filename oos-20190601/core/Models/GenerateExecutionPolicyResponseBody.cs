// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class GenerateExecutionPolicyResponseBody : TeaModel {
        /// <summary>
        /// The policies that are missing.
        /// </summary>
        [NameInMap("MissingPolicy")]
        [Validation(Required=false)]
        public string MissingPolicy { get; set; }

        /// <summary>
        /// The RAM policy.
        /// </summary>
        [NameInMap("Policy")]
        [Validation(Required=false)]
        public string Policy { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
