// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListTaskFlowTimeVariablesResponseBody : TeaModel {
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
        /// The ID of the request.
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

        /// <summary>
        /// The time variables for the task flow.
        /// </summary>
        [NameInMap("TimeVariables")]
        [Validation(Required=false)]
        public ListTaskFlowTimeVariablesResponseBodyTimeVariables TimeVariables { get; set; }
        public class ListTaskFlowTimeVariablesResponseBodyTimeVariables : TeaModel {
            [NameInMap("TimeVariable")]
            [Validation(Required=false)]
            public List<ListTaskFlowTimeVariablesResponseBodyTimeVariablesTimeVariable> TimeVariable { get; set; }
            public class ListTaskFlowTimeVariablesResponseBodyTimeVariablesTimeVariable : TeaModel {
                /// <summary>
                /// The name of the time variable.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The format of the time variable.
                /// </summary>
                [NameInMap("Pattern")]
                [Validation(Required=false)]
                public string Pattern { get; set; }

            }

        }

    }

}
