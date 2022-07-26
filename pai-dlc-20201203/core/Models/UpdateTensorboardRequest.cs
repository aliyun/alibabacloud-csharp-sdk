// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class UpdateTensorboardRequest : TeaModel {
        [NameInMap("MaxRunningTimeMinutes")]
        [Validation(Required=false)]
        public long? MaxRunningTimeMinutes { get; set; }

        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
