// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class ReplaceLinkelinkflowLinkflowTaskRequest : TeaModel {
        [NameInMap("OperatorId")]
        [Validation(Required=false)]
        public string OperatorId { get; set; }

        [NameInMap("ReAssignUserIdsRepeatList")]
        [Validation(Required=false)]
        public List<string> ReAssignUserIdsRepeatList { get; set; }

        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
