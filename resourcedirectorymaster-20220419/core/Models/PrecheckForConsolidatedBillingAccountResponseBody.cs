// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceDirectoryMaster20220419.Models
{
    public class PrecheckForConsolidatedBillingAccountResponseBody : TeaModel {
        /// <summary>
        /// The cause of the check failure.
        /// </summary>
        [NameInMap("Reasons")]
        [Validation(Required=false)]
        public List<PrecheckForConsolidatedBillingAccountResponseBodyReasons> Reasons { get; set; }
        public class PrecheckForConsolidatedBillingAccountResponseBodyReasons : TeaModel {
            /// <summary>
            /// The error code.
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// The error message.
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the check was successful. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public bool? Result { get; set; }

    }

}
