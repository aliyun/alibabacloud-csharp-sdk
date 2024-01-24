// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribePreCheckResultResponseBody : TeaModel {
        /// <summary>
        /// Indicates the result of the precheck task.
        /// </summary>
        [NameInMap("PreCheckResult")]
        [Validation(Required=false)]
        public DescribePreCheckResultResponseBodyPreCheckResult PreCheckResult { get; set; }
        public class DescribePreCheckResultResponseBodyPreCheckResult : TeaModel {
            /// <summary>
            /// Indicates the name of the precheck task.
            /// </summary>
            [NameInMap("PreCheckName")]
            [Validation(Required=false)]
            public string PreCheckName { get; set; }

            /// <summary>
            /// Indicates the state of the precheck task.
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// Indicates the details about the subtasks of the precheck task.
            /// </summary>
            [NameInMap("SubCheckItems")]
            [Validation(Required=false)]
            public List<DescribePreCheckResultResponseBodyPreCheckResultSubCheckItems> SubCheckItems { get; set; }
            public class DescribePreCheckResultResponseBodyPreCheckResultSubCheckItems : TeaModel {
                /// <summary>
                /// Indicates the error code that is returned by a subtask.
                /// </summary>
                [NameInMap("ErrorMsgCode")]
                [Validation(Required=false)]
                public string ErrorMsgCode { get; set; }

                /// <summary>
                /// Indicates an error message.
                /// </summary>
                [NameInMap("ErrorMsgParams")]
                [Validation(Required=false)]
                public List<string> ErrorMsgParams { get; set; }

                /// <summary>
                /// Indicates the name of the subtask.
                /// </summary>
                [NameInMap("PreCheckItemName")]
                [Validation(Required=false)]
                public string PreCheckItemName { get; set; }

                /// <summary>
                /// Indicates the state of the subtask.
                /// </summary>
                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request is successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
