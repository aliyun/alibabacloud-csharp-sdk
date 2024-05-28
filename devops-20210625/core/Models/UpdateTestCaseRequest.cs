// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class UpdateTestCaseRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("updateWorkitemPropertyRequest")]
        [Validation(Required=false)]
        public List<UpdateTestCaseRequestUpdateWorkitemPropertyRequest> UpdateWorkitemPropertyRequest { get; set; }
        public class UpdateTestCaseRequestUpdateWorkitemPropertyRequest : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("fieldIdentifier")]
            [Validation(Required=false)]
            public string FieldIdentifier { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("fieldValue")]
            [Validation(Required=false)]
            public string FieldValue { get; set; }

        }

    }

}
