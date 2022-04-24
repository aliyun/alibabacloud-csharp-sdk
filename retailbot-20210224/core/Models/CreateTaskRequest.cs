// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RetailBot20210224.Models
{
    public class CreateTaskRequest : TeaModel {
        [NameInMap("DigTaskInfoParam")]
        [Validation(Required=false)]
        public CreateTaskRequestDigTaskInfoParam DigTaskInfoParam { get; set; }
        public class CreateTaskRequestDigTaskInfoParam : TeaModel {
            [NameInMap("OperatorId")]
            [Validation(Required=false)]
            public string OperatorId { get; set; }
            [NameInMap("OperatorName")]
            [Validation(Required=false)]
            public string OperatorName { get; set; }
            [NameInMap("ParamConfig")]
            [Validation(Required=false)]
            public string ParamConfig { get; set; }
            [NameInMap("RobotCode")]
            [Validation(Required=false)]
            public string RobotCode { get; set; }
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }
        };

    }

}
