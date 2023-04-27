// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class UpdateTaskFlowConstantsRequest : TeaModel {
        /// <summary>
        /// The key value of a constant for the task flow.
        /// </summary>
        [NameInMap("DagConstants")]
        [Validation(Required=false)]
        public List<UpdateTaskFlowConstantsRequestDagConstants> DagConstants { get; set; }
        public class UpdateTaskFlowConstantsRequestDagConstants : TeaModel {
            /// <summary>
            /// The key name of a constant for the task flow.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The ID of the request. You can use the ID to locate logs and troubleshoot issues.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The error code returned if the request failed.
        /// </summary>
        [NameInMap("DagId")]
        [Validation(Required=false)]
        public long? DagId { get; set; }

        /// <summary>
        /// The constants for the task flow.
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
