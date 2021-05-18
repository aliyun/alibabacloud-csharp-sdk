// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class GetIndexCurrentValueRequest : TeaModel {
        [NameInMap("DepIds")]
        [Validation(Required=false)]
        public string DepIds { get; set; }

        [NameInMap("GroupIds")]
        [Validation(Required=false)]
        public string GroupIds { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}
