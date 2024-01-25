// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiops20200806.Models
{
    public class ListRootCauseRequest : TeaModel {
        [NameInMap("EventId")]
        [Validation(Required=false)]
        public string EventId { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("RootCauseId")]
        [Validation(Required=false)]
        public string RootCauseId { get; set; }

    }

}
