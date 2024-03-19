// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OnsMqtt20191211.Models
{
    public class BatchQuerySessionByClientIdsRequest : TeaModel {
        [NameInMap("ClientIdList")]
        [Validation(Required=false)]
        public List<string> ClientIdList { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}
