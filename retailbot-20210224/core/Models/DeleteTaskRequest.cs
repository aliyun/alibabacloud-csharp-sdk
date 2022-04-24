// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RetailBot20210224.Models
{
    public class DeleteTaskRequest : TeaModel {
        [NameInMap("DigDeleteParam")]
        [Validation(Required=false)]
        public DeleteTaskRequestDigDeleteParam DigDeleteParam { get; set; }
        public class DeleteTaskRequestDigDeleteParam : TeaModel {
            [NameInMap("DelMessage")]
            [Validation(Required=false)]
            public string DelMessage { get; set; }
            [NameInMap("OperatorId")]
            [Validation(Required=false)]
            public string OperatorId { get; set; }
            [NameInMap("OperatorName")]
            [Validation(Required=false)]
            public string OperatorName { get; set; }
            [NameInMap("RobotCode")]
            [Validation(Required=false)]
            public string RobotCode { get; set; }
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public long? TaskId { get; set; }
        };

    }

}
