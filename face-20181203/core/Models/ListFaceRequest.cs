// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Face20181203.Models
{
    public class ListFaceRequest : TeaModel {
        [NameInMap("Group")]
        [Validation(Required=false)]
        public string Group { get; set; }

        [NameInMap("Mark")]
        [Validation(Required=false)]
        public long? Mark { get; set; }

    }

}
