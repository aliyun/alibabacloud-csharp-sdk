// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class InsertTaskDetailRequest : TeaModel {
        [NameInMap("OutboundTaskId")]
        [Validation(Required=false)]
        public long? OutboundTaskId { get; set; }

        [NameInMap("CallInfos")]
        [Validation(Required=false)]
        public string CallInfos { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}
