// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class UpdateTestCaseRequest : TeaModel {
        [NameInMap("updateWorkitemPropertyRequest")]
        [Validation(Required=false)]
        public List<UpdateTestCaseRequestUpdateWorkitemPropertyRequest> UpdateWorkitemPropertyRequest { get; set; }
        public class UpdateTestCaseRequestUpdateWorkitemPropertyRequest : TeaModel {
            [NameInMap("fieldIdentifier")]
            [Validation(Required=false)]
            public string FieldIdentifier { get; set; }

            [NameInMap("fieldValue")]
            [Validation(Required=false)]
            public string FieldValue { get; set; }

        }

    }

}
