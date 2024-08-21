// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class CreateSyntheticTaskResponseBody : TeaModel {
        /// <summary>
        /// The status code returned.
        /// 
        /// *   1001: The request was successful.
        /// *   1002: The request failed.
        /// *   1003: Parameter errors occurred.
        /// *   1004: Authentication failed.
        /// *   1006: The task does not exist.
        /// *   1099: Internal errors occurred.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The information about the synthetic monitoring task.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateSyntheticTaskResponseBodyData Data { get; set; }
        public class CreateSyntheticTaskResponseBodyData : TeaModel {
            /// <summary>
            /// The ID of the synthetic monitoring task.
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public long? TaskId { get; set; }

        }

        /// <summary>
        /// The message that is returned when the task failed to be created.
        /// </summary>
        [NameInMap("Msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
