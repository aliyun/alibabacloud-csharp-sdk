// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebPlus20190320.Models
{
    public class DescribeChangeResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Change")]
        [Validation(Required=false)]
        public DescribeChangeResponseBodyChange Change { get; set; }
        public class DescribeChangeResponseBodyChange : TeaModel {
            [NameInMap("ChangePaused")]
            [Validation(Required=false)]
            public bool? ChangePaused { get; set; }
            [NameInMap("ChangeDescription")]
            [Validation(Required=false)]
            public string ChangeDescription { get; set; }
            [NameInMap("FinishTime")]
            [Validation(Required=false)]
            public long? FinishTime { get; set; }
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }
            [NameInMap("ChangeTimedout")]
            [Validation(Required=false)]
            public bool? ChangeTimedout { get; set; }
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }
            [NameInMap("ChangeMessage")]
            [Validation(Required=false)]
            public string ChangeMessage { get; set; }
            [NameInMap("ActionName")]
            [Validation(Required=false)]
            public string ActionName { get; set; }
            [NameInMap("ChangeFinished")]
            [Validation(Required=false)]
            public bool? ChangeFinished { get; set; }
            [NameInMap("CreateUsername")]
            [Validation(Required=false)]
            public string CreateUsername { get; set; }
            [NameInMap("ChangeId")]
            [Validation(Required=false)]
            public string ChangeId { get; set; }
            [NameInMap("ChangeAborted")]
            [Validation(Required=false)]
            public bool? ChangeAborted { get; set; }
            [NameInMap("ChangeSucceed")]
            [Validation(Required=false)]
            public bool? ChangeSucceed { get; set; }
            [NameInMap("EnvId")]
            [Validation(Required=false)]
            public string EnvId { get; set; }
            [NameInMap("ChangeName")]
            [Validation(Required=false)]
            public string ChangeName { get; set; }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

    }

}
