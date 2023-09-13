// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class PutTargetsResponseBody : TeaModel {
        /// <summary>
        /// The response code. Valid values:
        /// 
        /// *   Success: The call succeeded.
        /// *   Other codes: The call failed. For more information about error codes, see Error codes.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The returned result.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public PutTargetsResponseBodyData Data { get; set; }
        public class PutTargetsResponseBodyData : TeaModel {
            /// <summary>
            /// The ID of the failed event target.
            /// </summary>
            [NameInMap("ErrorEntries")]
            [Validation(Required=false)]
            public List<PutTargetsResponseBodyDataErrorEntries> ErrorEntries { get; set; }
            public class PutTargetsResponseBodyDataErrorEntries : TeaModel {
                /// <summary>
                /// The ID of the failed event target.
                /// </summary>
                [NameInMap("EntryId")]
                [Validation(Required=false)]
                public string EntryId { get; set; }

                /// <summary>
                /// The error code returned.
                /// </summary>
                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                /// <summary>
                /// The error message returned.
                /// </summary>
                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

            }

            /// <summary>
            /// The number of failed event targets. Valid values:
            /// 
            /// *   0: All event targets succeeded.
            /// *   An integer other than 0: indicates the number of failed event targets.
            /// </summary>
            [NameInMap("ErrorEntriesCount")]
            [Validation(Required=false)]
            public int? ErrorEntriesCount { get; set; }

        }

        /// <summary>
        /// The error message that is returned if the request failed.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   **true**: The request is successful.
        /// *   **false**: The request failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
