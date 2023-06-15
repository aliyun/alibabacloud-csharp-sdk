// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class CreateGADInstanceResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// An array that consists of the information returned.
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public CreateGADInstanceResponseBodyResult Result { get; set; }
        public class CreateGADInstanceResponseBodyResult : TeaModel {
            /// <summary>
            /// The number of unit nodes that are created by calling this operation.
            /// </summary>
            [NameInMap("CreateMemberCount")]
            [Validation(Required=false)]
            public string CreateMemberCount { get; set; }

            /// <summary>
            /// The ID of the global active database cluster.
            /// </summary>
            [NameInMap("GadInstanceName")]
            [Validation(Required=false)]
            public string GadInstanceName { get; set; }

            /// <summary>
            /// The ID of the task.
            /// </summary>
            [NameInMap("TaskID")]
            [Validation(Required=false)]
            public string TaskID { get; set; }

        }

    }

}
