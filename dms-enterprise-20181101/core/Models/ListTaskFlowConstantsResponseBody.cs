// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListTaskFlowConstantsResponseBody : TeaModel {
        /// <summary>
        /// A list of constant key-value pairs for the task flow.
        /// </summary>
        [NameInMap("DagConstants")]
        [Validation(Required=false)]
        public ListTaskFlowConstantsResponseBodyDagConstants DagConstants { get; set; }
        public class ListTaskFlowConstantsResponseBodyDagConstants : TeaModel {
            [NameInMap("DagConstant")]
            [Validation(Required=false)]
            public List<ListTaskFlowConstantsResponseBodyDagConstantsDagConstant> DagConstant { get; set; }
            public class ListTaskFlowConstantsResponseBodyDagConstantsDagConstant : TeaModel {
                /// <summary>
                /// The constant key.
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// The constant value.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        /// <summary>
        /// The error code returned if the request failed.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The error message returned if the request failed.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The ID of the request. You can use the ID to locate logs and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   **true**: The request was successful.
        /// *   **false**: The request failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
