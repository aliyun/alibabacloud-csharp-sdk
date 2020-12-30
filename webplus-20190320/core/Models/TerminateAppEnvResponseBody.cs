// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebPlus20190320.Models
{
    public class TerminateAppEnvResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("EnvChangeDetail")]
        [Validation(Required=false)]
        public TerminateAppEnvResponseBodyEnvChangeDetail EnvChangeDetail { get; set; }
        public class TerminateAppEnvResponseBodyEnvChangeDetail : TeaModel {
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }
            [NameInMap("ChangeId")]
            [Validation(Required=false)]
            public string ChangeId { get; set; }
            [NameInMap("EnvId")]
            [Validation(Required=false)]
            public string EnvId { get; set; }
            [NameInMap("Operations")]
            [Validation(Required=false)]
            public TerminateAppEnvResponseBodyEnvChangeDetailOperations Operations { get; set; }
            public class TerminateAppEnvResponseBodyEnvChangeDetailOperations : TeaModel {
                [NameInMap("Operation")]
                [Validation(Required=false)]
                public List<TerminateAppEnvResponseBodyEnvChangeDetailOperationsOperation> Operation { get; set; }
                public class TerminateAppEnvResponseBodyEnvChangeDetailOperationsOperation : TeaModel {
                    [NameInMap("OperationDescription")]
                    [Validation(Required=false)]
                    public string OperationDescription { get; set; }

                    [NameInMap("OperationType")]
                    [Validation(Required=false)]
                    public string OperationType { get; set; }

                }

            }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

    }

}
