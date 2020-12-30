// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebPlus20190320.Models
{
    public class DescribeChangesResponseBody : TeaModel {
        [NameInMap("Changes")]
        [Validation(Required=false)]
        public DescribeChangesResponseBodyChanges Changes { get; set; }
        public class DescribeChangesResponseBodyChanges : TeaModel {
            [NameInMap("Change")]
            [Validation(Required=false)]
            public List<DescribeChangesResponseBodyChangesChange> Change { get; set; }
            public class DescribeChangesResponseBodyChangesChange : TeaModel {
                public bool? ChangePaused { get; set; }
                public string ChangeDescription { get; set; }
                public long? FinishTime { get; set; }
                public long? UpdateTime { get; set; }
                public bool? ChangeTimedout { get; set; }
                public long? CreateTime { get; set; }
                public string ChangeMessage { get; set; }
                public string ActionName { get; set; }
                public bool? ChangeFinished { get; set; }
                public string CreateUsername { get; set; }
                public string ChangeId { get; set; }
                public bool? ChangeAborted { get; set; }
                public bool? ChangeSucceed { get; set; }
                public string EnvId { get; set; }
                public string ChangeName { get; set; }
            }
        };

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

    }

}
