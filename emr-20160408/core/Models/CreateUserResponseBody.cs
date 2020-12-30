// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20160408.Models
{
    public class CreateUserResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Paging")]
        [Validation(Required=false)]
        public bool? Paging { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public bool? Data { get; set; }

    }

}
