// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20190901.Models
{
    public class DeleteSynchronizationJobRequest : TeaModel {
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        [NameInMap("SynchronizationJobId")]
        [Validation(Required=false)]
        public string SynchronizationJobId { get; set; }

    }

}
