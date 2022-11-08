// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Viapi_regen20211119.Models
{
    public class StartTrainTaskRequest : TeaModel {
        [NameInMap("ForceStartFlag")]
        [Validation(Required=false)]
        public bool? ForceStartFlag { get; set; }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        [NameInMap("RelyOnTaskId")]
        [Validation(Required=false)]
        public long? RelyOnTaskId { get; set; }

    }

}
