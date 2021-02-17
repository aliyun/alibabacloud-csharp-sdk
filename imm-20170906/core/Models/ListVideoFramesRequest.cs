// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20170906.Models
{
    public class ListVideoFramesRequest : TeaModel {
        [NameInMap("Project")]
        [Validation(Required=false)]
        public string Project { get; set; }

        [NameInMap("SetId")]
        [Validation(Required=false)]
        public string SetId { get; set; }

        [NameInMap("VideoUri")]
        [Validation(Required=false)]
        public string VideoUri { get; set; }

        [NameInMap("Marker")]
        [Validation(Required=false)]
        public string Marker { get; set; }

    }

}
