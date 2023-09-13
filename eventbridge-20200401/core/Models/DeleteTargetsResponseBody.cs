// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class DeleteTargetsResponseBody : TeaModel {
        /// <summary>
        /// The returned HTTP status code. The HTTP status code 200 indicates that the request is successful.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The returned data.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DeleteTargetsResponseBodyData Data { get; set; }
        public class DeleteTargetsResponseBodyData : TeaModel {
            /// <summary>
            /// The information about the event body that failed to be processed.
            /// </summary>
            [NameInMap("ErrorEntries")]
            [Validation(Required=false)]
            public List<DeleteTargetsResponseBodyDataErrorEntries> ErrorEntries { get; set; }
            public class DeleteTargetsResponseBodyDataErrorEntries : TeaModel {
                /// <summary>
                /// The ID of the event body that failed to be processed.
                /// </summary>
                [NameInMap("EntryId")]
                [Validation(Required=false)]
                public string EntryId { get; set; }

                /// <summary>
                /// The returned error code.
                /// </summary>
                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                /// <summary>
                /// The returned error message.
                /// </summary>
                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

            }

            /// <summary>
            /// The number of event bodies that failed to be processed. Valid values: 0: No event bodies failed to be processed. An integer other than 0: the number of event bodies that failed to be processed.
            /// </summary>
            [NameInMap("ErrorEntriesCount")]
            [Validation(Required=false)]
            public int? ErrorEntriesCount { get; set; }

        }

        /// <summary>
        /// The returned error message.
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
        /// Indicates whether the operation is successful. Valid values: true and false.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
