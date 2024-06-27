// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeDetailStartRequest : TeaModel {
        [NameInMap("appKey")]
        [Validation(Required=false)]
        public string AppKey { get; set; }

        [NameInMap("endDs")]
        [Validation(Required=false)]
        public string EndDs { get; set; }

        [NameInMap("regId")]
        [Validation(Required=false)]
        public string RegId { get; set; }

        [NameInMap("service")]
        [Validation(Required=false)]
        public string Service { get; set; }

        [NameInMap("startDs")]
        [Validation(Required=false)]
        public string StartDs { get; set; }

    }

}
