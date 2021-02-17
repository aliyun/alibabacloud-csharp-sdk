// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20170906.Models
{
    public class ListProjectsRequest : TeaModel {
        [NameInMap("Marker")]
        [Validation(Required=false)]
        public string Marker { get; set; }

        [NameInMap("MaxKeys")]
        [Validation(Required=false)]
        public int? MaxKeys { get; set; }

    }

}
