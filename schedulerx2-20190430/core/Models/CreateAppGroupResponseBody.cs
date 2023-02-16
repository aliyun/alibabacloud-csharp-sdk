// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Schedulerx220190430.Models
{
    public class CreateAppGroupResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code that is returned.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The information about the job group.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateAppGroupResponseBodyData Data { get; set; }
        public class CreateAppGroupResponseBodyData : TeaModel {
            /// <summary>
            /// The ID of the job group.
            /// </summary>
            [NameInMap("AppGroupId")]
            [Validation(Required=false)]
            public long? AppGroupId { get; set; }

            /// <summary>
            /// The AppKey for the application.
            /// </summary>
            [NameInMap("AppKey")]
            [Validation(Required=false)]
            public string AppKey { get; set; }

        }

        /// <summary>
        /// The error message that is returned only if an error occurs.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the application is created. Valid values:
        /// 
        /// *   **true**: The application is created.
        /// *   **false**: Failed to create the application.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
