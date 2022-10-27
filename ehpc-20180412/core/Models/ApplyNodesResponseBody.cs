// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class ApplyNodesResponseBody : TeaModel {
        [NameInMap("Detail")]
        [Validation(Required=false)]
        public string Detail { get; set; }

        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public ApplyNodesResponseBodyInstanceIds InstanceIds { get; set; }
        public class ApplyNodesResponseBodyInstanceIds : TeaModel {
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public List<string> InstanceId { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SatisfiedAmount")]
        [Validation(Required=false)]
        public int? SatisfiedAmount { get; set; }

        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
