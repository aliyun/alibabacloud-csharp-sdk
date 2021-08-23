// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20170906.Models
{
    public class CreateSetResponseBody : TeaModel {
        [NameInMap("VideoCount")]
        [Validation(Required=false)]
        public int? VideoCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        [NameInMap("VideoLength")]
        [Validation(Required=false)]
        public int? VideoLength { get; set; }

        [NameInMap("SetId")]
        [Validation(Required=false)]
        public string SetId { get; set; }

        [NameInMap("ImageCount")]
        [Validation(Required=false)]
        public int? ImageCount { get; set; }

        [NameInMap("FaceCount")]
        [Validation(Required=false)]
        public int? FaceCount { get; set; }

        [NameInMap("SetName")]
        [Validation(Required=false)]
        public string SetName { get; set; }

        [NameInMap("ModifyTime")]
        [Validation(Required=false)]
        public string ModifyTime { get; set; }

    }

}
