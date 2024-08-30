// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class CreateTimingSyntheticTaskResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code returned. The status code 200 indicates that the request was successful.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        /// <summary>
        /// The struct returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateTimingSyntheticTaskResponseBodyData Data { get; set; }
        public class CreateTimingSyntheticTaskResponseBodyData : TeaModel {
            /// <summary>
            /// The task status. Valid values:
            /// 
            /// - INIT: The task is in the initial state.
            /// - RELEASE: The task is being parsed.
            /// - RUNNING: The task is running.
            /// - STOP: The task is suspended.
            /// - SYSTEM_STOP: The task is suspended by the system.
            /// - CANCEL: The task is canceled.
            /// - SYSTEM_CANCEL: The task is canceled by the system.
            /// - DONE: The task is complete.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The ID of the synthetic monitoring task.
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

        /// <summary>
        /// The message returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values: true and false.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
