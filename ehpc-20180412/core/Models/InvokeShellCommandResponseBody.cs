// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class InvokeShellCommandResponseBody : TeaModel {
        [NameInMap("CommandId")]
        [Validation(Required=false)]
        public string CommandId { get; set; }

        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public InvokeShellCommandResponseBodyInstanceIds InstanceIds { get; set; }
        public class InvokeShellCommandResponseBodyInstanceIds : TeaModel {
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public List<string> InstanceId { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
