// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class AddLocalNodesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public AddLocalNodesResponseBodyInstanceIds InstanceIds { get; set; }
        public class AddLocalNodesResponseBodyInstanceIds : TeaModel {
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public List<string> InstanceId { get; set; }
        };

    }

}
