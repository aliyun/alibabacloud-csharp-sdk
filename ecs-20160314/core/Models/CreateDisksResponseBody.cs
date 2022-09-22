// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20160314.Models
{
    public class CreateDisksResponseBody : TeaModel {
        [NameInMap("DiskId")]
        [Validation(Required=false)]
        public CreateDisksResponseBodyDiskId DiskId { get; set; }
        public class CreateDisksResponseBodyDiskId : TeaModel {
            [NameInMap("DiskIds")]
            [Validation(Required=false)]
            public List<string> DiskIds { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
