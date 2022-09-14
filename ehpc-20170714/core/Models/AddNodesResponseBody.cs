// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20170714.Models
{
    public class AddNodesResponseBody : TeaModel {
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public AddNodesResponseBodyInstanceIds InstanceIds { get; set; }
        public class AddNodesResponseBodyInstanceIds : TeaModel {
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public List<string> InstanceId { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
